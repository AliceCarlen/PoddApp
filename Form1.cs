using PoddApp.BLL;
using PoddApp.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PoddApp
{
    public partial class Form1 : Form
    {
        private KategoriManager kategoriManager; //fält som refererar till BLL-lagret
        private PoddDAL poddDAL;
        private PoddBLL poddBLL;
        private string currentUrl;
        public Form1() //konstruktor som skapar en instans av BLL-lagret (KategoriManager)
        {
            InitializeComponent();
            kategoriManager = new KategoriManager();
            poddDAL = new PoddDAL();
            FyllKategoriComboBox(); //metod som fyller comboboxen med kategorier - se metodkropp längre ner
            FiltreraKategorierComboBox(); //metod som filterar kategorier
            listBoxRedigeraKategorierFyll();
            listViewPoddar.SelectedIndexChanged += listViewPoddar_SelectedIndexChanged;
            poddBLL = new PoddBLL();
            LasInPoddarOchFyllListView();
            this.FormClosing += Form1_FormClosing;

            //Konfigurera kolumner för listViewPoddar
            listViewPoddar.View = View.Details;
            listViewPoddar.FullRowSelect = true;
            listViewPoddar.Columns.Add("Tilldelat namn", -2, HorizontalAlignment.Left);
            listViewPoddar.Columns.Add("Poddtitel", -2, HorizontalAlignment.Left);
            listViewPoddar.Columns.Add("Antal avsnitt", -2, HorizontalAlignment.Left);
            listViewPoddar.Columns.Add("Kategori", -2, HorizontalAlignment.Left);
            listViewPoddar.Columns.Add("URL", -2, HorizontalAlignment.Left);

            listBoxAvsnitt.SelectedIndexChanged += listBoxAvsnitt_SelectedIndexChanged;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void buttonLaggTill_Click(object sender, EventArgs e)
        {

            string url = textBoxUrl.Text.Trim();  //hämta url från textrutan
            string egetNamn = textBoxEgetNamn.Text;
            string kategori = comboBoxKategori.SelectedItem?.ToString();

            //kontrollera att kategori har valts
            //if (string.IsNullOrEmpty(kategori))
            //{
            //    MessageBox.Show("Vänligen välj en kategori");
            //    return;
            //}
            try
            {
                Validering.ValideraUrl(url);
                Validering.ValideraValdKategori(kategori);

                await poddDAL.HamtaPoddarURL(url, egetNamn, kategori);

                listViewPoddar.Items.Clear();
                List<PoddInfo> poddar = poddDAL.HämtaAllaPoddar();

                foreach (var podd in poddar)
                {
                    var item = new ListViewItem(new[]
                    {
                        podd.EgetNamn,
                        podd.Titel,
                        podd.AntalAvsnitt.ToString(),
                        podd.Kategori,
                        podd.Url
                    }
                    );
                    item.Tag = podd;
                    listViewPoddar.Items.Add(item);
                }

                poddDAL.SparaPoddarTillXML(poddar);

                textBoxUrl.Clear();
                textBoxEgetNamn.Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FyllKategoriComboBox() //metod som fyller cb. Hämtar data från DAL-lagret med hjälp av mellanhanden BLL
        {
            List<string> kategorier = kategoriManager.HamtaKategorier();
            comboBoxKategori.Items.Clear();
            comboBoxKategori.Items.AddRange(kategorier.ToArray());
        }

        private void comboBoxFiltreraKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hämta den valda kategorin
            string valdKategori = comboBoxFiltreraKategori.SelectedItem?.ToString();

            // Hämta poddar baserat på vald kategori från DAL
            List<PoddInfo> poddar = poddDAL.HamtaAllaPoddar(valdKategori);

            // Uppdatera listViewPoddar
            listViewPoddar.Items.Clear();
            foreach (var podd in poddar)
            {
                var item = new ListViewItem(new[]
                {
            podd.EgetNamn,
            podd.Titel,
            podd.AntalAvsnitt.ToString(),
            podd.Kategori,
            podd.Url
        });
                item.Tag = podd;
                listViewPoddar.Items.Add(item);
            }
        }


        private void FiltreraKategorierComboBox() //metod som filtrerar kategoirer. Använder samma metoder i BLL som FyllKategoriComboBox gör.
        {
            List<string> kategorier = kategoriManager.HamtaKategorier();
            comboBoxFiltreraKategori.Items.Clear();
            comboBoxFiltreraKategori.Items.AddRange(kategorier.ToArray());
        }

        private void listBoxRedigerakategorier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxRedigeraKategorierFyll()
        {
            List<string> kategorier = kategoriManager.HamtaKategorier();
            listBoxRedigerakategorier.Items.Clear();
            listBoxRedigerakategorier.Items.AddRange(kategorier.ToArray());
        }

        private void textBoxAndraKategori_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLaggTillKategori_Click(object sender, EventArgs e)
        {
            string nyKategori = textBoxHanteraKategori.Text.Trim(); //trim tar bort oönskade mellanslag 
            //if (!string.IsNullOrEmpty(nyKategori))
            try
            {
                Validering.ValideraNyKategori(nyKategori);

                kategoriManager.LaggTillKategori(nyKategori); //anropa metod i BLL-lagret
                listBoxRedigeraKategorierFyll(); //fyller listboxen igen för att se den nya kategorin
                textBoxHanteraKategori.Clear(); //rensar textbox efter att vi lagt till kategorin
            }

            //else
            //{
            //    MessageBox.Show("Ange en kategori.");
            //}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAndra_Click(object sender, EventArgs e)
        {
            string gammalKategori = listBoxRedigerakategorier.SelectedItem.ToString();
            string nyKategori = textBoxHanteraKategori.Text; // Textbox där användaren skriver in det nya namnet

            //if (!string.IsNullOrEmpty(gammalKategori) && !string.IsNullOrEmpty(nyKategori))
            try
            {
                Validering.ValideraValdKategori(gammalKategori);
                Validering.ValideraNyKategori(nyKategori);
                
                kategoriManager.AndraKategori(gammalKategori, nyKategori); // Anropa metoden i BLL-lagret
                listBoxRedigeraKategorierFyll(); // Uppdatera listboxen
                textBoxHanteraKategori.Clear(); // Rensa textfältet
                FyllKategoriComboBox();
                //metod för att fylla filtrera cb
            }
            //else
            //{
            //    MessageBox.Show("Vänligen välj en kategori och ange ett nytt namn.");
            //}
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message); 
            }
        }
      

        private void buttonTaBort_Click(object sender, EventArgs e)
        {
            string kategoriAttTaBort = listBoxRedigerakategorier.SelectedItem?.ToString(); // Hämta den valda kategorin
            //if (!string.IsNullOrEmpty(kategoriAttTaBort))
            try

            {
                Validering.ValideraValdKategori(kategoriAttTaBort);

                DialogResult result = MessageBox.Show(
                    $"Är du säker på att du vill ta bort kategorin \"{kategoriAttTaBort}\"?",
                   "Bekräfta borttagning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                //om användaren väler ja ska kategorin tas bort
                if (result == DialogResult.Yes)
                {
                    kategoriManager.TaBortKategori(kategoriAttTaBort); //metod i BLL
                    listBoxRedigeraKategorierFyll(); //uppdatera listan efter borttag
                }
            }
            //else
            //{
            //    MessageBox.Show("Vänligen välj en kategori att ta bort.");
            //}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void listViewPoddar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPoddar.SelectedItems.Count > 0) // Kontrollera om det finns ett valt objekt
            {
                var selectedItem = listViewPoddar.SelectedItems[0]; // Hämta det valda objektet
                string poddTitel = selectedItem.SubItems[1].Text; // Hämta poddtitel från listView
                currentUrl = selectedItem.SubItems[4].Text;

                // Hämta avsnitt för den valda podden
                var avsnitt = await poddBLL.HamtaAvsnittForPoddAsync(poddTitel, currentUrl); // Skapa en metod i DAL som hämtar avsnitt

                // Rensa tidigare avsnitt i listbox
                listBoxAvsnitt.Items.Clear();

                // Lägg till avsnitt i listbox
                foreach (var avsnittItem in avsnitt)
                {
                    listBoxAvsnitt.Items.Add(avsnittItem); // Anta att avsnittItem är en sträng med avsnittsinformation
                }

               
            }
        }


        private void LasInPoddarOchFyllListView()
        {
            poddDAL.LasInPoddarFranXML();

            listViewPoddar.Items.Clear();
            List<PoddInfo> poddar = poddDAL.HämtaAllaPoddar();

            foreach (var podd in poddar)
            {
                listViewPoddar.Items.Add(new ListViewItem(new[]
                {
                podd.EgetNamn,
                podd.Titel,
                podd.AntalAvsnitt.ToString(),
                podd.Kategori,
                podd.Url
            }));
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Hämta alla poddar innan vi sparar dem
            List<PoddInfo> poddar = poddDAL.HämtaAllaPoddar();

            // Skicka listan med poddar till metoden för att spara
            poddDAL.SparaPoddarTillXML(poddar);
        }


        private void textBoxBeskrivning_TextChanged(object sender, EventArgs e)
        {

        }

        private async void richTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kontrollera om ett avsnitt är valt
            if (listBoxAvsnitt.SelectedItem != null)
            {
                // Hämta valt avsnittets titel
                string valdAvsnittTitel = listBoxAvsnitt.SelectedItem.ToString();

                // Hämta beskrivningen från BLL/DAL för valt avsnitt
                string beskrivning = await poddBLL.HamtaBeskrivningForAvsnittAsync(valdAvsnittTitel, currentUrl);

                // Visa beskrivningen i textBoxBeskrivning
                richTextBox.Text = beskrivning;
            }


        }

        private async void listBoxAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kontrollera om ett avsnitt är valt
            if (listBoxAvsnitt.SelectedItem != null)
            {
                // Hämta valt avsnittets titel
                string valdAvsnittTitel = listBoxAvsnitt.SelectedItem.ToString();

                // Kontrollera att currentUrl är korrekt
                //if (string.IsNullOrEmpty(currentUrl) || !Uri.IsWellFormedUriString(currentUrl, UriKind.Absolute))
                //{
                //    MessageBox.Show("Den angivna URL:n är ogiltig.");
                //    return;
                //}
                try
                {
                    Validering.ValideraUrl(currentUrl);



                    // Hämta beskrivningen från BLL/DAL för valt avsnitt
                    string beskrivning = await poddBLL.HamtaBeskrivningForAvsnittAsync(valdAvsnittTitel, currentUrl); // Se till att metoden är korrekt definierad

                    // Visa beskrivningen i textBoxBeskrivning
                    richTextBox.Text = beskrivning;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {

        }

      private void buttonTaBortPodd_Click(object sender, EventArgs e)
{
            if (listViewPoddar.SelectedItems.Count == 0) // Kontrollera om något objekt är valt
            {
                MessageBox.Show("Vänligen välj en podd att ta bort.");
                return;
            }

            var selectedItem = listViewPoddar.SelectedItems[0]; // Hämta det valda objektet
            var poddInfo = (PoddInfo)selectedItem.Tag; // Anta att du har sparat PoddInfo som Tag

            DialogResult result = MessageBox.Show(
                $"Är du säker på att du vill ta bort podden \"{poddInfo.Titel}\"?",
                "Bekräfta borttagning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Ta bort podden från XML
                poddDAL.TaBortPoddFrånXML(poddInfo.Url); // Du kan använda URL eller en annan identifierare

                // Ta bort den valda podden från ListView
                listViewPoddar.Items.Remove(selectedItem);
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }

}

    







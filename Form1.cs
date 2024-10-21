using PoddApp.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Form1() //konstruktor som skapar en instans av BLL-lagret (KategoriManager)
        {
            InitializeComponent();
            kategoriManager = new KategoriManager();
            FyllKategoriComboBox(); //metod som fyller comboboxen med kategorier - se metodkropp längre ner
            FiltreraKategorierComboBox(); //metod som filterar kategorier
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonLaggTill_Click(object sender, EventArgs e)
        {

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

        }

        private void FiltreraKategorierComboBox() //metod som filtrerar kategoirer. Använder samma metoder i BLL som FyllKategoriComboBox gör.
        {
            List<string> kategorier = kategoriManager.HamtaKategorier();
            comboBoxFiltreraKategori.Items.Clear();
            comboBoxFiltreraKategori.Items.AddRange(kategorier.ToArray());
        }
    }
}

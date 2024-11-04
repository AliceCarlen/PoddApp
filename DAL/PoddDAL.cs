using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.CodeDom;
using System.ServiceModel.Syndication;
using PoddApp.DAL;
using System.Net;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

namespace PoddApp
{
    public class PoddDAL
    {
        private List<PoddInfo> poddar;

        public PoddDAL() // Konstruktorn för PoddDAL
        {
            poddar = LasInPoddarFranXML(); // Ladda in poddar från XML när objektet skapas
        }

        /*private List<PoddInfo> poddar = new List<PoddInfo>();*/ //Lista för att lagra poddar

        public async Task<PoddInfo> HamtaPoddInfoAsync(string url)
        {

            try
            {
                using (XmlReader xmlReader = XmlReader.Create(url))
                {
                    var feed = await Task.Run(() => SyndicationFeed.Load(xmlReader));

                    return new PoddInfo
                    {
                        Titel = feed.Title.Text,
                        AntalAvsnitt = feed.Items.Count()
                    };

                    {
                    }
                     }}



            catch (WebException ex)
            {
                throw new Exception("Kunde inte nå Url: " + ex.Message);
            }

            catch (UriFormatException)
            {
                throw new Exception("Felaktig URL-format. Vänligen kontrollera URL:en.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Fel vid hämtning av poddar: {ex.Message}");
            }
        }

        public async Task<List<AvsnittInfo>> HamtaAvsnittRSSAsync(string url)
        {
            var avsnitt = new List<AvsnittInfo>();

            try
            {
                using (XmlReader xmlReader = XmlReader.Create(url))
                {
                    // Ladda syndikationsflödet asynkront
                    var feed = await Task.Run(() => SyndicationFeed.Load(xmlReader));

                    foreach (var item in feed.Items)
                    {
                        string beskrivning = item.Summary?.Text ?? "Ingen beskrivning tillgänglig"; // Hantera nul

                        // Om beskrivning är tom, försök hämta från andra fält som <description>
                        if (string.IsNullOrEmpty(beskrivning))
                        {
                            var description = item.ElementExtensions
                                .FirstOrDefault(ext => ext.OuterName == "description");

                            if (description != null)
                            {
                                beskrivning = description.GetObject<string>() ?? "Ingen beskrivning tillgänglig"; // Hantera null
                            }
                        }

                        avsnitt.Add(new AvsnittInfo
                        {
                            PoddTitel = feed.Title.Text,
                            AvsnittTitel = item.Title.Text,
                            Beskrivning = beskrivning
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Fel vid hämtning av avsnitt: {ex.Message}");
            }

            return avsnitt;
        }


        //synkron metod för att hämta PoddInfo från en URL
        //public PoddInfo HamtaPoddInfo(string url)
        //{
        //    try
        //    {
        //        using (XmlReader xmlReader = XmlReader.Create(url))
        //        {
        //            SyndicationFeed feed = SyndicationFeed.Load(xmlReader);
        //            return new PoddInfo
        //            {
        //                Titel = feed.Title.Text,
        //                AntalAvsnitt = feed.Items.Count()
        //            };
        //        }
        //    }

        //    catch (WebException ex)
        //    {
        //        throw new Exception("Kunde inte nå URL: " + ex.Message);
        //    }
        //    catch (UriFormatException)
        //    {
        //        throw new Exception("Felaktig URL-format. Vänligen kontrollera URL:en.");
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Fel vid hämtning av poddar: {ex.Message}");
        //    }
        //}




        // Metod för att hämta poddar från en URL
        public async Task<List<PoddInfo>> HamtaPoddarURL(string url, string egetNamn, string kategori)
        {

            try

            {
                using (XmlReader xmlReader = XmlReader.Create(url))
                {
                    SyndicationFeed feed = await Task.Run(() => SyndicationFeed.Load(xmlReader));

                    // Skapa ett enda PoddInfo-objekt för podden
                    PoddInfo nyPodd = new PoddInfo
                    {
                        EgetNamn = egetNamn,
                        Titel = feed.Title.Text,
                        AntalAvsnitt = feed.Items.Count(),
                        Kategori = kategori,
                        Url = url
                    };
                    poddar.Add(nyPodd);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Fel vid hämtning av poddar: {ex.Message}");
            }

            return poddar; // Returnera listan med poddar
        }

        // Metod för att hämta poddar från en URL
        

        public List<PoddInfo> HämtaAllaPoddar()
        {

            return poddar; // Metod för att hämta den aktuella listan av poddar
        }

        //Metodöverlagring för att hämta alla poddar, men baserat på kategori
        public List<PoddInfo> HamtaAllaPoddar(string kategori)
        {
            // Om kategori är null eller tom, returnera alla poddar
            if (string.IsNullOrEmpty(kategori))
            {
                return poddar;
            }

            // Annars, filtrera poddar baserat på den angivna kategorin
            return poddar.Where(p => p.Kategori.Equals(kategori, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public void SparaPoddarTillXML(List<PoddInfo> poddar)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string poddFilPath = Path.Combine(desktopPath, "poddar.xml");

            XmlSerializer serializer = new XmlSerializer(typeof(List<PoddInfo>));
            using (FileStream fs = new FileStream(poddFilPath, FileMode.Create))
            {
                serializer.Serialize(fs, poddar);
            }
        }

        public List <PoddInfo> LasInPoddarFranXML()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string poddFilPath = Path.Combine(desktopPath, "poddar.xml");

            if (!File.Exists(poddFilPath))
            {
                return new List<PoddInfo>(); // Om filen inte finns, returnera en tom lista
            }

            using (FileStream fs = new FileStream(poddFilPath, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<PoddInfo>));
                return (List<PoddInfo>)serializer.Deserialize(fs);
            }
        }

        public async Task<List<AvsnittInfo>> HamtaAvsnittRSS(string url)
        {
            var avsnitt = new List<AvsnittInfo>();

            try
            {
                using (XmlReader xmlReader = XmlReader.Create(url))
                {
                    var feed = await Task.Run(() => SyndicationFeed.Load(xmlReader));

                    // Kontrollera om feed är null
                    if (feed == null)
                    {
                        throw new Exception("Inga poddar hittades.");
                    }

                    foreach (var item in feed.Items)
                    {
                        // Kontrollera om item är null
                        if (item == null)
                        {
                            continue; // Hoppa över null-poster
                        }

                        // Använd null-kontroller för titel och beskrivning
                        string poddTitel = feed.Title?.Text ?? "Ingen titel tillgänglig"; // Hantera null
                        string avsnittTitel = item.Title?.Text ?? "Ingen avsnitttitel tillgänglig"; // Hantera null
                        string beskrivning = item.Summary?.Text ?? "Ingen beskrivning tillgänglig"; // Hantera null

                        avsnitt.Add(new AvsnittInfo
                        {
                            PoddTitel = poddTitel,
                            AvsnittTitel = avsnittTitel,
                            Beskrivning = beskrivning
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Fel vid hämtning av avsnitt: {ex.Message}");
            }

            return avsnitt;
        }

        public async Task<List<AvsnittInfo>> HamtaAvsnittForPoddAsync(string poddTitel, string url)
        {

            var avsnittList = await HamtaAvsnittRSS(url);
            return avsnittList
             .Where(a => a.PoddTitel.Equals(poddTitel, StringComparison.OrdinalIgnoreCase))
             .ToList();
        }

        public void TaBortPoddFrånXML(string url)
        {
            // Ladda in poddar från XML
            List<PoddInfo> poddar = HämtaAllaPoddar(); // Denna metod bör hämta poddar från XML

            // Hitta podden som ska tas bort
            var poddAttTaBort = poddar.FirstOrDefault(p => p.Url == url); // Använd URL eller annan identifierare

            if (poddAttTaBort != null)
            {
                poddar.Remove(poddAttTaBort); // Ta bort podden från listan

                // Spara tillbaka listan till XML
                SparaPoddarTillXML(poddar);
            }
            else
            {
                throw new Exception("Podden kunde inte hittas.");
            }
        }


    }

}










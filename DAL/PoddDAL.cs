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

namespace PoddApp
{
    public class PoddDAL
    {
        

        public PoddInfo HamtaPoddInfo(string url)
        {
            try
            {
                using (XmlReader xmlReader = XmlReader.Create(url))
                {
                    SyndicationFeed feed = SyndicationFeed.Load(xmlReader);


                    return new PoddInfo
                    {
                        PoddTitel = feed.Title.Text,
                        AntalAvsnitt = feed.Items.Count(),
                    };
                }
            }

            catch (WebException ex) //undantag för ev fel
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



  


        private List<PoddInfo> poddar = new List<PoddInfo>(); // Skapar en tom lista för att lagra poddar

        // Metod för att hämta poddar från en URL
        public List<PoddInfo> HamtaPoddarURL(string url, string egetNamn)
        {
            try
            {
                using (XmlReader xmlReader = XmlReader.Create(url))
                {
                    SyndicationFeed feed = SyndicationFeed.Load(xmlReader);

                    //string poddTitel = feed.Title.Text;
                    foreach (SyndicationItem item in feed.Items)
                    {
                        // Skapa ett nytt Podd-objekt
                        PoddInfo nyPodd = new PoddInfo


                        {
                            EgetNamn = egetNamn,
                            PoddTitel = item.Title.Text,
                            AntalAvsnitt = feed.Items.Count(), // Räkna avsnitt
                            /*Kategori = "Exempelkategori"*/ // Lägg till logik för att hämta kategori om möjligt
                        };
                        poddar.Add(nyPodd); // Lägg till podden i listan
                    }
                }
            }

            catch (Exception ex)
            {
                throw new Exception($"Fel vid hämtning av poddar: {ex.Message}");
            }

            return poddar; // Returnera listan med poddar
        }

        public List<PoddInfo> HämtaAllaPoddar()
        {
            return poddar; // Metod för att hämta den aktuella listan av poddar
        }

    }
}

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
                        Titel = feed.Title.Text,
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
        public List<PoddInfo> HamtaPoddarURL(string url, string egetNamn, string kategori)
        {
            try
            {
                using (XmlReader xmlReader = XmlReader.Create(url))
                {
                    SyndicationFeed feed = SyndicationFeed.Load(xmlReader);

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
        

        public List<PoddInfo> HämtaAllaPoddar()
        {

            return poddar; // Metod för att hämta den aktuella listan av poddar
        }

        public void SparaPoddarTillXML()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string poddFilPath = Path.Combine(desktopPath, "poddar.xml");

            XmlSerializer serializer = new XmlSerializer(typeof(List<PoddInfo>));
            using (FileStream fs = new FileStream(poddFilPath, FileMode.Create))
            {
                serializer.Serialize(fs, poddar);
            }
        }

        public void LasInPoddarFranXML()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string poddFilPath = Path.Combine(desktopPath, "poddar.xml");

            if (File.Exists(poddFilPath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<PoddInfo>));
                using (FileStream fs = new FileStream(poddFilPath, FileMode.Open))
                {
                    poddar = (List<PoddInfo>)serializer.Deserialize(fs);
                }
            }
        }


    public List<AvsnittInfo> HamtaAvsnittRSS(string url)
    {
        var avsnitt = new List<AvsnittInfo>();

       try
        {
            using (XmlReader xmlReader = XmlReader.Create(url))
            {
                SyndicationFeed feed = SyndicationFeed.Load(xmlReader);
                
                foreach (var item in feed.Items)
                {
                        string beskrivning = item.Summary?.Text;

                        // Om beskrivning är tom, kontrollera om det finns andra relevanta fält
                        if (string.IsNullOrEmpty(beskrivning))
                        {
                            // Alternativ 1: Hämta från <itunes:summary> om det finns
                            //var itunesSummary = item.ElementExtensions
                            //    .FirstOrDefault(ext => ext.OuterName == "summary" && ext.OuterNamespace == "http://www.itunes.com/dtds/podcast-1.0.dtd");

                            //if (itunesSummary != null)
                            //{
                            //    beskrivning = itunesSummary.GetObject<string>();
                            //}

                            // Alternativ 2: Hämta från <description> om den används istället
                            var description = item.ElementExtensions
                                .FirstOrDefault(ext => ext.OuterName == "description");

                            if (description != null && string.IsNullOrEmpty(beskrivning))
                            {
                                beskrivning = description.GetObject<string>();
                            }
                        }

                        avsnitt.Add(new AvsnittInfo
                    {
                        PoddTitel = feed.Title.Text,
                        AvsnittTitel = item.Title.Text,
                        Beskrivning = item.Summary.Text

                    });
                        
            }
            }
        }
        catch (Exception ex)
        { throw new Exception($"Fel vid hämtning av avsnitt: {ex.Message}");

        }

        return avsnitt;
    }


        public List<AvsnittInfo> HamtaAvsnittForPodd(string poddTitel, string url)
        {
         
            return HamtaAvsnittRSS(url)
                 .Where(a => a.PoddTitel.Equals(poddTitel, StringComparison.OrdinalIgnoreCase))
                 .ToList();
        }
    }
}








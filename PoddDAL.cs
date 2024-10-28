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

namespace PoddApp
{
    public class PoddDAL
    {
        public List<string> HamtaPoddarURL(string url) 
        {
            List<string> poddar = new List<string>(); //skapar lista för att lagra poddar
            try
            {
                using (XmlReader xmlReader = XmlReader.Create(url)) // skapar en xmlReader från url
                {
                    SyndicationFeed feed = SyndicationFeed.Load(xmlReader); //ladda ner RSS-flöder
                    foreach (SyndicationItem item in feed.Items) // Loopar igenom varje podd i flödet
                    {
                        poddar.Add(item.Title.Text); //lägger till poddens titel i listan
                    }
                }
            }
            catch (Exception ex) //undantag för ev fel
            {
                throw new Exception($"Fel vid hämtning av poddar: {ex.Message}");  // kastar undantag med felmeddelande
            }

            return poddar; //Returnera listan med poddar
        }


    }
}

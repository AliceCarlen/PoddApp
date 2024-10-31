﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using PoddApp.DAL;
using PoddApp.BLL;

namespace PoddApp
{
    public class PoddBLL : iFeedManager
    {
        private PoddDAL poddDAL;
        public PoddBLL() : base()//Skapar referens från poddDal-lagret. Fält
        {
            poddDAL = new PoddDAL();
        }

        public List<string> HamtaPoddar(String url, string egetNamn, string kategori) //metod för att hämta poddar från URL 
        {

            // Anropa DAL-metoden för att hämta poddar och returnera resultatet
            var poddar = poddDAL.HamtaPoddarURL(url, egetNamn, kategori);
            // Om du vill returnera titlarna som en lista av strängar, kan du skapa en lista
            return poddar.Select(p => p.Titel).ToList();

        }

        public List<string> HamtaAvsnittForPodd(string poddTitel, string url)
        {
            // Hämta avsnitt från DAL baserat på poddTitel
            var avsnitt = poddDAL.HamtaAvsnittForPodd(poddTitel, url);
            return avsnitt.Select(a => a.AvsnittTitel).ToList(); // Returnera en lista med avsnitttitlar
        }

        public FeedInfo HamtaPoddInfo(string url)
        {
            return poddDAL.HamtaPoddInfo(url);
        }

        public string HamtaBeskrivningForAvsnitt(string avsnittTitel, string url)
        {
            // Här antas att vi redan har hämtat poddavsnitten i listan
            var avsnitt = poddDAL.HamtaAvsnittRSS(url).FirstOrDefault(a => a.AvsnittTitel == avsnittTitel);

            // Om avsnittet hittas, returnera dess beskrivning
            return avsnitt?.Beskrivning ?? "Beskrivning ej tillgänglig.";
        }

    }

}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using PoddApp.DAL;
using PoddApp.BLL;
using System.Xml;
using System.ServiceModel.Syndication;

namespace PoddApp
{
    public class PoddBLL : iFeedManager
    {
        private PoddDAL poddDAL;

        public PoddBLL() : base()//Skapar referens från poddDal-lagret. Fält
        {
            poddDAL = new PoddDAL();
        }
        public async Task<List<PoddInfo>> HamtaPoddarAsync(string url, string egetNamn, string kategori)
        {
            // Anropa DAL-metoden för att hämta poddar och returnera resultatet
            var poddar = await poddDAL.HamtaPoddarURL(url, egetNamn, kategori);

            // Returnera hela listan av PoddInfo-objekt
            return poddar; // Se till att poddar är av typ List<PoddInfo>
        }

        

        public async Task<List<string>> HamtaAvsnittForPoddAsync(string poddTitel, string url)
        {
            // Hämta avsnitt från DAL baserat på poddTitel
            var avsnitt = await poddDAL.HamtaAvsnittForPoddAsync(poddTitel, url);
            return avsnitt.Select(a => a.AvsnittTitel).ToList(); // Returnera en lista med avsnitttitlar
        }

        public async Task<FeedInfo> HamtaPoddInfoAsync(string url)
        {
            return await poddDAL.HamtaPoddInfoAsync(url);
        }

        public async Task<string> HamtaBeskrivningForAvsnittAsync(string avsnittTitel, string url)
        {
            // Här antas att vi redan har hämtat poddavsnitten i listan
            var avsnittList = await poddDAL.HamtaAvsnittRSS(url); // Denna metod bör returnera Task<List<AvsnittInfo>>
            var avsnitt = avsnittList.FirstOrDefault(a => a.AvsnittTitel == avsnittTitel);
            // Om avsnittet hittas, returnera dess beskrivning
            return avsnitt?.Beskrivning ?? "Beskrivning ej tillgänglig.";
        }
    }

   

}

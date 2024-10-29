using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using PoddApp.DAL;

namespace PoddApp
{
    public class PoddBLL
    {
        private PoddDAL poddDAL; //Skapar referens från poddDal-lagret. Fält

        public PoddBLL() //konstruktor
        {
            poddDAL = new PoddDAL(); // skapar en ny instans av PoddDAL
        }

        public List<string> HamtaPoddar(String url, string egetNamn) //metod för att hämta poddar från URL 
        {

            // Anropa DAL-metoden för att hämta poddar och returnera resultatet
            var poddar = poddDAL.HamtaPoddarURL(url, egetNamn);
            // Om du vill returnera titlarna som en lista av strängar, kan du skapa en lista
            return poddar.Select(p => p.PoddTitel).ToList();
     
        }


        public PoddInfo HamtaPoddInfo(string url)
        {
            return poddDAL.HamtaPoddInfo(url);
        }
    }
}


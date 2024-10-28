using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoddApp
{
    public class PoddBLL
    {
        private PoddDAL poddDAL; //Skapar referens från poddDal-lagret. Fält

        public PoddBLL() //konstruktor
        {
            poddDAL = new PoddDAL(); // skapar en ny instans av PoddDAL
        }

        public List<string> HamtaPoddar(String url) //metod för att hämta poddar från URL 
        {
            return poddDAL.HamtaPoddarURL(url); //anropa DAL-metoden för att hämta poddar, och returnera reusltatet
        }
    }
}

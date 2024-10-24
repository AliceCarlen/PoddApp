using PoddApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoddApp.BLL
{
    public class KategoriManager //Fungerar som mellanhand mellan DAL och gränssnitt
    {
        private KategoriDataAccess kategoriDataAccess; //fält av typen KategoriDataAccess (DAL-lagret)

        public KategoriManager() //konstruktor som skapar en ny instans av KategoriDataAccess-klassen
        {
            kategoriDataAccess = new KategoriDataAccess();
        }

        public List<string> HamtaKategorier() //metodanrop från DAL
        {
            return kategoriDataAccess.HamtaKategorier();
        }

        public void LaggTillKategori(string nyKategori)
        {
            kategoriDataAccess.LaggTillKategori(nyKategori); //metod som lägger till nyKategori i Datalagret
        }

        public void AndraKategori(string gammalKategori, string nyKategori)
        {

            kategoriDataAccess.AndraKategori(gammalKategori, nyKategori);

        }

        public void TaBortKategori(string gammalKategori)
        {
            kategoriDataAccess.TaBortKategori(gammalKategori);
        }

    }
}


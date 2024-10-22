using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoddApp.DAL
{
    public class KategoriDataAccess //datalagret har här färdiga kategorier som ligger inom metoden HamtaKategorier.
    {

        private List<string> kategorier;

        public KategoriDataAccess() 
        {
            kategorier = new List<string> { "Humor", "Hälsa", "Utbildning", "True crime", "Historia" };
        }

        public List<string> HamtaKategorier() //returnerar en lista med kategorier
        {
            return kategorier;
        }

        public void LaggTillKategori(string nyKategori) //lägger till ny kategori i listan
        {
            if (!string.IsNullOrEmpty(nyKategori))
            {
                kategorier.Add(nyKategori);
            }
        }
    }
    
}

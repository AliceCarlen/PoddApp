using PoddApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoddApp.BLL
{
    public class KategoriManager
    {
        private KategoriDataAccess kategoriDataAccess;

        public KategoriManager()
        {
            kategoriDataAccess = new KategoriDataAccess();
        }

        public List<string> HamtaKategorier()
        {
            return kategoriDataAccess.HamtaKategorier();
        }
    }
}

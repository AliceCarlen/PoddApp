using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoddApp.DAL
{
    public class KategoriDataAccess
    {
        public List<string> HamtaKategorier()
        {
            return new List<string> { "Humor", "Hälsa", "Utbildning", "True crime", "Historia" };
        }
    }
    
}

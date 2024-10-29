using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoddApp.DAL
{
    public class PoddInfo
    {
        public string PoddTitel { get; set; } //titel ska bara läsas, inte kunna ändras
        public string EgetNamn {  get; set; }
        public int AntalAvsnitt { get; set; } //kan inte ändras av användaren
        //public string Kategori { get; set; }
    }

    

}

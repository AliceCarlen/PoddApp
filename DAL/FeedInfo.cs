using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoddApp.DAL
{
    public abstract class FeedInfo
    {
        public string Titel { get; set; }
        public string EgetNamn { get; set; }

        public string Url { get; set; }

        public string Kategori { get; set; }

        public abstract List<string> HamtaInnehall();
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoddApp.DAL
{
    public abstract class FeedInfo
    {
        public virtual string Titel { get; set; }
        public virtual string EgetNamn { get; set; }

        public virtual string Url { get; set; }

        public virtual string Kategori { get; set; }

        public abstract List<string> HamtaInnehall();
    }
}


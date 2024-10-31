using PoddApp;
using PoddApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoddApp
{
    public interface iFeedManager
    {
        List<string> HamtaPoddar(string url, string egetNamn, string kategori);
        List<string> HamtaAvsnittForPodd(string poddTitel, string url);
        FeedInfo HamtaPoddInfo(string url);
        string HamtaBeskrivningForAvsnitt(string avsnittTitel, string url);
    }
}



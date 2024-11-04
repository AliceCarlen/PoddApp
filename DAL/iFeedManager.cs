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
       
        Task<List<PoddInfo>> HamtaPoddarAsync(string url, string egetNamn, string kategori);
        Task<List<string>> HamtaAvsnittForPoddAsync(string poddTitel, string url);
        Task<FeedInfo> HamtaPoddInfoAsync(string url);
        Task<string> HamtaBeskrivningForAvsnittAsync(string avsnittTitel, string url);
    }

   
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoddApp.DAL
{ 
public class PoddInfo : FeedInfo
{
    public int AntalAvsnitt { get; set; }

    public List<AvsnittInfo> Avsnitt { get; set; } = new List<AvsnittInfo>();
    public override List<string> HamtaInnehall()
    {
        return Avsnitt.Select(a => a.AvsnittTitel).ToList();
    }

    }
}



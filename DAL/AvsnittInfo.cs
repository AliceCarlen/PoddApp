using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoddApp.DAL
{
    public class AvsnittInfo
    {
        public string PoddTitel { get; set; }
        public string AvsnittTitel { get; set; }

        public string Beskrivning { get; set; }

    // För att listBoxAvsnitt ska visa titel istället för klassnamnet
    public override string ToString()
    {
        return PoddTitel;
    }
}
}

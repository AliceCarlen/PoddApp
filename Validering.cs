using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoddApp
{
    public static class Validering
    {
        public static void ValideraUrl(string url) //validera URL
        {
            if (string.IsNullOrEmpty(url)  || !Uri.IsWellFormedUriString(url, UriKind.Absolute))
                    {
                throw new UriFormatException("Den angivna URL:n är ogiltig");
            }
        }

        public static string ValideraBeskrivning(string beskrivning)
        {
            if (string.IsNullOrEmpty(beskrivning))
            {
                return "Ingen beskrivning tillgänglig";
            }
            return beskrivning;
        }

        public static void ValideraValdKategori (string kategori) //funkar både för ta bort och ändra?
        {
            if (string.IsNullOrEmpty(kategori))
                    {
                throw new ArgumentException("Vänligen välj en kategori från listan.");
            }
        }

        public static void ValideraNyKategori (string kategori)
        {
            if (string.IsNullOrWhiteSpace(kategori))
            {
                throw new ArgumentException("Ange en kategori.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obesenec
{
    internal class ZapisPismena
    {
        public static void ZapisanePismena(List<char> UhadnutePismena, int IndexPismena, char HadanePismeno)
        {
            
            for (int i = 0; i < UhadnutePismena.Count; i++)
            {

            }
            
        }

        public static string UzHadanePismena(List<string> HadanePismena, string Hadanie)
        {

            HadanePismena.Add(Hadanie);

            string PismenavListe = string.Join(",", HadanePismena);

            return PismenavListe;
        }


    }


}

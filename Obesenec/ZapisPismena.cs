using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obesenec
{
    public static class ZapisPismena
    {
        /// <summary>
        /// nieco
        /// </summary>
        public static int ble =3;

        public static void ZapisanePismena(List<char> UhadnutePismena, int IndexPismena, char HadanePismeno)
        {
            
            for (int i = 0; i < UhadnutePismena.Count; i++)
            {

            }
            
        }

        /// <summary>
        /// tato metoda nieco robi
        /// </summary>
        /// <param name="HadanePismena"></param>
        /// <param name="Hadanie"></param>
        /// <returns></returns>
        public static string UzHadanePismena(List<string> HadanePismena, string Hadanie)
        {
            HadanePismena.Add(Hadanie);
            return string.Join(",", HadanePismena); ;
        }
    }


}

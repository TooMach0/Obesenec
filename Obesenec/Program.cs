using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Obesenec
{
    class Program
    {


        static void Main(string[] args)
        {
            //Vybera nahodne slovo
            List<string> HadaneSlova = new List<string> { "jana" };
            Random random = new Random();
            string HadaneSlovo = HadaneSlova[random.Next(0, HadaneSlova.Count)];


            //list pre hadane pismena
            List<string> HadanePismena = new List<string>();


            Console.WriteLine(HadaneSlovo);

            //Velkost hadaneho slova v chars
            List<char> UhadnuteSlovo = new List<char>(new char[HadaneSlovo.Count()]);




            int PocetNespravnychPokusov = 0;
            do
            {
                //Hadany char vo vybranom slove
                char Hadanie = Console.ReadLine()[0];

                //Miesto hadaneho pismena
                int IndexPismena = HadaneSlovo.IndexOf(Hadanie);



                //Data pre pouzite pismena
                string PismenavListe = ZapisPismena.UzHadanePismena(HadanePismena, Hadanie.ToString());

                
                


                if (HadaneSlovo.Contains(Hadanie))
                {

                    ZapisPismena.ZapisanePismena(UhadnuteSlovo,IndexPismena ,Hadanie);
                    Console.WriteLine("\n");
                    Console.WriteLine($"Zatial pouzite pismena: {PismenavListe}");

                }
                else
                {

                    PocetNespravnychPokusov++;
                    Console.WriteLine("Pocet nespravnych pokusov :" + StickFigure.Hangman(PocetNespravnychPokusov));
                    Console.WriteLine($"Zatial pouzite pismena: {PismenavListe}");
                }

            } while (PocetNespravnychPokusov != 3);


        }


    }
}



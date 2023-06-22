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
            List<char> HadanePismena = new List<char>();

            //Vybera nahodne slovo
            List<string> HadaneSlova = new List<string> { "jana" };
            Random random = new Random();

            string HadaneSlovo = HadaneSlova[random.Next(0, HadaneSlova.Count)];
            List<char> UhadnuteSlovo = Enumerable.Repeat('*', HadaneSlovo.Count()).ToList();

            Console.WriteLine(HadaneSlovo);

            int PocetNespravnychPokusov = 0;
            do
            {
                //Hadany char vo vybranom slove
                char userInputChar = Console.ReadLine()[0];

                HadanePismena.Add(userInputChar);
                var PismenavListe = string.Join(",", HadanePismena);


                if (HadaneSlovo.Contains(userInputChar))
                {
                    Console.WriteLine("SUCCES!");

                    for (int i = 0; i < HadaneSlovo.Length; i++)
                    {
                        if (HadaneSlovo[i] == userInputChar)
                        {
                            UhadnuteSlovo[i] = userInputChar;
                        }
                    }
                    
                    Console.WriteLine("\n");
                    Console.WriteLine($"Zatial pouzite pismena: {PismenavListe}");
                    Console.WriteLine(new string(UhadnuteSlovo.ToArray()));
                }
                else
                {
                    PocetNespravnychPokusov++;
                    Console.WriteLine("Pocet nespravnych pokusov :" + StickFigure.Hangman(PocetNespravnychPokusov));
                    Console.WriteLine($"Zatial pouzite pismena: {PismenavListe}");
                    Console.WriteLine(new string(UhadnuteSlovo.ToArray()));
                }

            } while (PocetNespravnychPokusov != 3);
        }
    }
}



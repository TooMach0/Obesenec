using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obesenec
{
    internal class StickFigure
    {

        public static int Hangman(int NespravnePismeno)
        {
            if (NespravnePismeno == 1)
            {
                Console.WriteLine("========");
                
            }
            else if (NespravnePismeno == 2)
            {
                Console.WriteLine("      || ");
                Console.WriteLine("      || ");
                Console.WriteLine("      || ");
                Console.WriteLine("      || ");
                Console.WriteLine("      || ");
                Console.WriteLine("      || ");
                Console.WriteLine("========");
            }
            else if (NespravnePismeno == 3)
            {
                Console.WriteLine("+=====+");
                Console.WriteLine("      || ");
                Console.WriteLine("      || ");
                Console.WriteLine("      || ");
                Console.WriteLine("      || ");
                Console.WriteLine("      || ");
                Console.WriteLine("      || ");
                Console.WriteLine("========");
            }
            return NespravnePismeno;
        }
        

        
    }
}

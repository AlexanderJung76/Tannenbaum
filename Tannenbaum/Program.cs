using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tannenbaum
{
    class Program
    {
        static void Main(string[] args)
        {
            int anzZeile, anzSternechen, anzLeerZeichen, stamm;


            Console.WriteLine("Wie hoch soll ihre Tanne werden? ");
            anzZeile = Int32.Parse(Console.ReadLine());
            stamm = anzZeile - 2;

            for (int z = 0; z < anzZeile; z++)
            {
                anzLeerZeichen = anzZeile - 1 - z;
                anzSternechen = (z + 1) * 2 - 1;

                for (int k = 0; k < anzLeerZeichen; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < anzSternechen; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            int stammv = stamm / 2;
            for (int s3 = 0; s3 < stammv; s3++)
            {
                for (int s = 0; s < stamm; s++)
                {
                    Console.Write(" ");
                }
                for (int s2 = 0; s2 < 3; s2++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nDruecken sie Enter zum Beenden.");
            Console.ReadLine();
        }
    }
}

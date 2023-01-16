using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b= 1, c=0;

            Console.Write("Quantos valores da sequencia você deseja que seja demostrado? ");
            int valores = int.Parse(Console.ReadLine());
            Console.WriteLine("Sequencia de Fibonacci com " + valores + " valores");

            for (int i = 0; i < valores; i++)
            {
                if (i < valores - 1)
                {
                    Console.Write(a + ", ");
                }
                else
                {
                    Console.Write(a);
                }
                c = a + b;
                a = b;
                b = c;
            }
            Console.ReadKey();
                        

        }
    }
}

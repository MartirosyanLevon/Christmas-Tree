using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elochka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If you want to draw Christmas tree");
            Console.WriteLine("write what height you want ?");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = x;
            int z = 1;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < z; k++)
                {
                    Console.Write("*");
                }
                y -= 1;
                z += 2;
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}

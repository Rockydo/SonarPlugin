using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Facto 5 :" + Facto(5));
            Console.WriteLine("Facto 12 :" + Facto(12));
            Console.WriteLine("Facto 10 :" + Facto(10));
            Console.WriteLine("Facto 8 : " + Facto(8));
        }
        private static int Facto(int nb)
        {
            if (nb < 0)
                return -1;
            else if (nb == 0 || nb == 1)
                return 1;
            else
                return nb * Facto(nb - 1);
        }
    }
}

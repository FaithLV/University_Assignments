using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Ievadi skaitli:");
            //int input = Int32.Parse(Console.ReadLine());
            //Console.WriteLine($"Summa: {Sum(input)}");
            Aritm(0, 3, 3);
            Console.ReadLine();
        }

        static int Sum(int n)
        {
            if(n != 0)
            {
                return (n % 10 + Sum(n / 10));
            }
            else
            {
                return 0;
            }
        }

        

    }
}

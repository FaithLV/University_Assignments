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
            Aritm(3, 3, 0);
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

        static int Aritm(int count, int step, int start)
        {
            int v = (count == 0) ? 0 : start + Aritm(count - 1, step, start) + step;
            if(v != 0)
            {
                Console.WriteLine(v);
            }
            return v;
        }

    }
}

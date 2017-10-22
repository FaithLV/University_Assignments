using System;
using static System.Console;

namespace Praktiskais_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pirmais();
            Otrais();

            ReadLine();
        }

        static void Pirmais()
        {
            WriteLine("Ievadiet pirmo skaitli");
            int x = Int32.Parse(ReadLine());

            WriteLine("Ievadiet otro skaitli");
            int y = Int32.Parse(ReadLine());

            WriteLine($"{x}+{y}={x+y}");
            WriteLine($"{x}-{y}={x - y}");
            WriteLine($"{x}*{y}={x * y}");
            WriteLine($"{x}/{y}={x / y}");
            WriteLine($"{x}%{y}={x % y}");
            WriteLine($"{x}^2 * {y}^2 = {(x * x) + (y*y)}");
        }

        static void Otrais()
        {
            WriteLine("{0,10}{1,10}{2,10}{3,10}{4,10}{5,10}{6,10}{7,10}{8,10}{9,10}{10,10}", String.Empty, "1", "2","3","4","5","6","7","8","9","10");
            WriteLine($"________________________________________________________________________________________________________________________");

            for(int i = 1; i <= 10; i++)
            {
                string foo = $"{i} |";
                WriteLine("{0,10}{1,10}{2,10}{3,10}{4,10}{5,10}{6,10}{7,10}{8,10}{9,10}{10,10}", foo ,i*1, i*2, i*3, i*4, i*5, i*6, i*7, i*8, i*9, i*10);

            }
        }
    }
}

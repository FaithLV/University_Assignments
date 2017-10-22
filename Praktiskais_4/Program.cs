using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiskais_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Izvēlies uzdevumu (1-2)");
            if(Console.ReadLine() == "1")
            {
                Pirmais();
            }
            else
            {
                Otrais();
            }

            Console.ReadLine();
        }

        static void Pirmais()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("            _ _                ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("           | | |               ");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("__   ____ _| | |_ ___ _ __ ___ ");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"\ \ / / _` | | __/ _ \ '__/ __|");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@" \ V / (_| | | ||  __/ |  \__ \");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(@"  \_/ \__,_|_|\__\___|_|  |___/");


            Console.WriteLine("                               ");
        }

        static void Otrais()
        {
            Console.WriteLine("Ievadi A");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ievadi B");
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ievadi C");
            int c = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"({a}-{b})^2 = {a}^2 + 2*{a*b} + {b}^2");
            Console.WriteLine($"({a}+{b}+{c})^2 = {a}^2 + {b}^2 + {c}^2 + 2*{a}*{b} + 2*{a}*{c} + 2*{b}*{c}");
        }
    }
}

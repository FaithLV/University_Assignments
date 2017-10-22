using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiskais_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Ceturtais();

            Console.ReadLine();
        }

        static void Pirmais()
        {
            Console.WriteLine("Ievadiet paroli:");
            if (Console.ReadLine() == "Valters")
            {
                Console.WriteLine("Parole pareiza");
            }
        }

        static void Otrais()
        {
            Console.WriteLine("Ievadiet X");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Ievadiet Y");
            double y = double.Parse(Console.ReadLine());

            if(y != 0)
            {
                Console.WriteLine(x/y);
            }
            else
            {
                Console.WriteLine("Nevar dalīt ar nulli.");
            }
        }

        static void Tresais()
        {
            Console.WriteLine("Ievadiet paroli");
            string _in = Console.ReadLine();

            if(_in.Length < 5)
            {
                Console.WriteLine("Parolē jābūt vismaz 5 simboliem");
            }
            else if(_in == "Valters")
            {
                Console.WriteLine("Parole pareiza!");
            }
            else
            {
                Console.WriteLine("Parole nepareiza");
            }

        }

        static void Ceturtais()
        {
            Console.WriteLine("Ievadi radiusu");
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine("Izvēlies uzdevumu: ");
            Console.WriteLine("1 - Riņķa līnijas garums");
            Console.WriteLine("2 - Riņķa laukums");
            Console.WriteLine("3 - Lodes laukums");
            Console.WriteLine("4 - Lodes tilpums");

            int s = Int32.Parse(Console.ReadLine());
            switch(s)
            {
                case 1:
                    Console.WriteLine($"RLG: {2*Math.PI*radius}");
                    break;
                case 2:
                    Console.WriteLine($"Rinka laukums: {Math.PI*radius*radius}");
                    break;
                case 3:
                    Console.WriteLine($"Lodes laukums: {4*Math.PI*radius*radius}");
                    break;
                case 4:
                    Console.WriteLine($"Lodes tilpums: {(4*Math.PI*radius*radius*radius)/3}");
                    break;
            }
        }
    }
}

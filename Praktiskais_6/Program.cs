using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiskais_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Blokshema();
            //Pirmais();
            Otrais();

            Console.ReadLine();
        }

        static void Blokshema()
        {
            double a;
            double b;
            double c;
            double x;
            double y;
            double t;

            Console.WriteLine("Ievadi A, B un C vērtības:");
            a = Double.Parse(Console.ReadLine());
            b = Double.Parse(Console.ReadLine());
            c = Double.Parse(Console.ReadLine());

            x = 2 * a * b;
            y = 5 * c;
            t = x + y;

            Console.WriteLine($"t = {t}");
        }

        static void Pirmais()
        {
            Console.Write("Ievadiet skaitli:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int y = 1;
            for(int i = 1; i <= x; i++)
            {
                Console.WriteLine($"{i}*{y} = {i*y}");
                y = i * y;
            }
        }

        static void Otrais()
        {
            Console.Write("Noguldījuma summa: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Noguldījuma ilgums (gados): ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Procentu likme gadā: ");
            double c = double.Parse(Console.ReadLine());

            double sum = a;
            for(int i = 0; i <= b; i++)
            {
                sum = sum + (a * c);
                Console.WriteLine($"{i}. gadā: {sum}");
            }


        }
    }
}

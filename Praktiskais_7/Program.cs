using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiskais_7
{
    class Program
    {
        static void Main(string[] args)
        {

            //Pirmais();
            //Otrais();
            Tresais();

            Console.ReadLine();
        }

        static void Pirmais()
        {
            string pw = "parole123";
            string foo = null;

            do
            {
                Console.Write("Ievadiet paroli: ");
                foo = Console.ReadLine();

                if(foo != pw)
                {
                    Console.WriteLine("Nepareizi!");
                }
            }
            while (foo != pw);

            Console.WriteLine("Parole pareiza!");

        }

        static void Otrais()
        {
            Console.WriteLine("Ievadiet A, B un C skaitļus...");
            int A = Int32.Parse(Console.ReadLine());
            double B = Int32.Parse(Console.ReadLine());
            double C = Int32.Parse(Console.ReadLine());

            int index = 0;
            double foo = B;

            do
            {
                Console.WriteLine($"E[{index}] = {B}");

                B += C;
                index++;
            }
            while (index <= A);
        }

        static void Tresais()
        {
            Console.Write("Ievadiet skaitli A: ");
            int A = Int32.Parse(Console.ReadLine());

            int index = 0;
            double step = 0;

            do
            {
                Console.Write($"Sum[{index}] = {step} + ");
                step += double.Parse(Console.ReadLine());
                index++;
            }
            while (index < A);

            Console.WriteLine($"Sum[{index}] = {step}");
        }
    }
}

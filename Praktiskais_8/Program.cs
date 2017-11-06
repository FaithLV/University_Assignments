using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiskais_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pirmais();
            Otrais();
            //Tresais();
        }

        static void Pirmais()
        {
            string[] skaitli = new string[] {"Viens", "Divi", "Trīs", "Četri", "Pieci" };
            bool run = true;

            do
            {
                Console.WriteLine("Ieraksti skaitli no 1 līdz 5. Ievadi jebko citu lai beigtu");

                try
                {
                    int input = Int32.Parse(Console.ReadLine());
                    Console.WriteLine($"{skaitli[input - 1]}");
                    Console.WriteLine("");
                }
                catch
                {
                    run = false;
                }
                
            }
            while (run);
        }

        static void Otrais()
        {
            Console.WriteLine("Cik reizes pārbaudīt skaitļus?");
            int input = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < input; i++)
            {
                Console.Write("Ievadiet Skaitli: ");
                int _in = Int32.Parse(Console.ReadLine());

                if(_in % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Skaitlis DALĀS ar 3 bez atlikuma.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Skaitlis NEDALĀS ar 3 bez atlikuma");
                }

                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        static void Tresais()
        {
            Console.WriteLine("Ievadiet trijstūra platumu: ");
            int size = Int32.Parse(Console.ReadLine());

            for(int i = size; i >= 1; i -= 2)
            {
                string _a = new string(' ', (size - i) /2);
                Console.WriteLine(_a + new string('*', i) + _a);
            }


            //for (int i = 1; i <= size; i += 2)
            //{
            //    string _a = new string(' ', (size - i) / 2);
            //    Console.WriteLine(_a + new string('*', i) + _a);
            //}

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_4
{
    class Program
    {
        static Random rand = new Random();
        static double[] garr1 = new double[10];
        static double[] garr2 = new double[10];

        static void Main(string[] args)
        {
            for (int i = 0; i < garr1.Length; i++)
            {
                garr1[i] = rand.Next(1, 11);
                garr2[i] = rand.Next(1, 11);
            }

            foreach (int i in garr1)
            {
                Console.Write($" {i} ");
            }
            Console.WriteLine();

            foreach (int i in garr2)
            {
                Console.Write($" {i} ");
            }
            Console.WriteLine();

            ShowOptions();
        }

        static void ShowOptions()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1 - Summet");
            Console.WriteLine("2 - Atnemt");
            Console.WriteLine("3 - Reizinat");
            Console.WriteLine("4 - Dalit");
            Console.WriteLine("5 - Videjais Aritmetiskais");
            Console.WriteLine("@ - iziet");
            Console.Write("Izvele: ");
            string input = Console.ReadLine();

            switch(input)
            {
                case ("1"):
                    Summet(garr1, garr2);
                    break;
                case ("2"):
                    Atnemt(garr1, garr2);
                    break;
                case ("3"):
                    Reizinat(garr1, garr2);
                    break;
                case ("4"):
                    Dalit(garr1, garr2);
                    break;
                case ("5"):
                    VidejaisAritmetiskais(garr1, garr2);
                    break;
                case ("@"):
                    Environment.Exit(0);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nepareiza izvele!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

            ShowOptions();
        }

        static void Summet(double[] a1, double[] a2)
        {
            double[] a3;

            if (a1.Length > a2.Length)
            {
                a3 = new double[a1.Length];
            }
            else
            {
                a3 = new double[a2.Length];
            }
            

            for (int i = 0; i < a3.Length; i++)
            {
                a3[i] = a1[i] + a2[i];
            }

            Console.WriteLine();
            Console.WriteLine("Rezultats: ");
            for (int i = 0; i < a3.Length; i++)
            {
                Console.Write(a3[i] + " ");
            }
        }

        static void Atnemt(double[] a1, double[] a2)
        {
            double[] a3;

            if (a1.Length > a2.Length)
            {
                a3 = new double[a1.Length];
            }
            else
            {
                a3 = new double[a2.Length];
            }

            for (int i = 0; i < a3.Length; i++)
            {
                a3[i] = a1[i] - a2[i];
            }

            Console.WriteLine();
            Console.WriteLine("Rezultats: ");
            for (int i = 0; i < a3.Length; i++)
            {
                Console.Write(a3[i] + " ");
            }
        }

        static void Reizinat(double[] a1, double[] a2)
        {
            double[] a3;

            if (a1.Length > a2.Length)
            {
                a3 = new double[a1.Length];
            }
            else
            {
                a3 = new double[a2.Length];
            }

            for (int i = 0; i < a3.Length; i++)
            {
                a3[i] = a1[i] * a2[i];
            }

            Console.WriteLine();
            Console.WriteLine("Rezultats: ");
            for (int i = 0; i < a3.Length; i++)
            {
                Console.Write(a3[i] + " ");
            }
        }

        static void Dalit(double[] a1, double[] a2)
        {
            double[] a3;

            if (a1.Length > a2.Length)
            {
                a3 = new double[a1.Length];
            }
            else
            {
                a3 = new double[a2.Length];
            }

            for (int i = 0; i < a3.Length; i++)
            {
                a3[i] = a1[i] / a2[i];
            }

            Console.WriteLine();
            Console.WriteLine("Rezultats: ");
            for (int i = 0; i < a3.Length; i++)
            {
                Console.Write(a3[i] + " ");
            }
        }

        static void VidejaisAritmetiskais(double[] a1, double[] a2)
        {
            double aritm1 = 0;
            double aritm2 = 0;

            for (int i = 0; i < a1.Length; i++)
            {
                aritm1 = aritm1 + a1[i];
            }

            for (int i = 0; i < a2.Length; i++)
            {
                aritm2 = aritm2 + a2[i];
            }

            aritm1 = aritm1 / a1.Length;
            aritm2 = aritm2 / a2.Length;

            Console.WriteLine();
            Console.WriteLine($"Pirma masiva videja ir {aritm1}, bet otra masiva videja vertiba ir {aritm2}");

            if(aritm1 > aritm2)
            {
                Console.WriteLine($"Pirma masiva videja ir lielaka par {aritm1 - aritm2}");
            }
            else if(aritm1 < aritm2)
            {
                Console.WriteLine($"Otra masiva videja ir lielaka par {aritm2 - aritm1}");
            }
            else
            {
                Console.WriteLine($"Abu masivu videjas vertibas ir vienadas!");
            }
        }

    }
}

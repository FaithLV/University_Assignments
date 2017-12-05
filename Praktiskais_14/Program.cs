using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiskais_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pirmais();
            //Otrais();
            //Tresais();
            Ceturtais();
        }

        static void Pirmais()
        {
            int[,] masivs = new int[10, 10];
            int[] sums = new int[10];
            Random rand = new Random();
            
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    masivs[i, j] = rand.Next(1, 10);
                    sums[i] = sums[i] + masivs[i, j];
                }
                Console.WriteLine("{0, 10} {1, 10} {2, 10} {3, 10} {4, 10} {5, 10} {6, 10} {7, 10} {8, 10} {9, 10}", 
                    masivs[i, 0], masivs[i, 1], masivs[i, 2], masivs[i, 3], masivs[i, 4], masivs[i, 5], masivs[i, 6], masivs[i, 7], masivs[i, 8], masivs[i, 9]);
            }

            for (int i = 0; i < sums.Length; i++)
            {
                Console.WriteLine($"{i + 1}. rindas skaitļu summa ir {sums[i]}");
            }

            Console.ReadLine();
        }

        static void Otrais()
        {
            int[,] masivs = new int[10, 10];
            Random rand = new Random();

            int[] max = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] min = new int[10] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    masivs[i, j] = rand.Next(1, 10);

                    if(max[i] < masivs[i, j])
                    {
                        max[i] = masivs[i,j];
                    }

                    if(min[i] > masivs[i, j])
                    {
                        min[i] = masivs[i,j];
                    }
                }

                Console.WriteLine("{0, 10} {1, 10} {2, 10} {3, 10} {4, 10} {5, 10} {6, 10} {7, 10} {8, 10} {9, 10}",
                    masivs[i, 0], masivs[i, 1], masivs[i, 2], masivs[i, 3], masivs[i, 4], masivs[i, 5], masivs[i, 6], masivs[i, 7], masivs[i, 8], masivs[i, 9]);
            }

            for (int i = 0; i < min.Length; i++)
            {
                Console.WriteLine($"{i + 1}. rindas Max: {max[i]} | Min : {min[i] }");
            }

            Console.ReadLine();
        }

        static void Tresais()
        {
            int[,] masivs = new int[10, 10];

            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    masivs[i, j] = rand.Next(1, 10);
                }

                Console.WriteLine("{0, 10} {1, 10} {2, 10} {3, 10} {4, 10} {5, 10} {6, 10} {7, 10} {8, 10} {9, 10}",
                    masivs[i, 0], masivs[i, 1], masivs[i, 2], masivs[i, 3], masivs[i, 4], masivs[i, 5], masivs[i, 6], masivs[i, 7], masivs[i, 8], masivs[i, 9]);
            }

            Console.WriteLine();
            Console.WriteLine("Apgriezts:");

            int[,] apgriezts = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    apgriezts[i, j] = masivs[j, i];
                }

                Console.WriteLine("{0, 10} {1, 10} {2, 10} {3, 10} {4, 10} {5, 10} {6, 10} {7, 10} {8, 10} {9, 10}",
                   apgriezts[i, 0], apgriezts[i, 1], apgriezts[i, 2], apgriezts[i, 3], apgriezts[i, 4], apgriezts[i, 5], apgriezts[i, 6], apgriezts[i, 7], apgriezts[i, 8], apgriezts[i, 9]);
            }

            Console.ReadLine();
        }

        static void Ceturtais()
        {
            int[,] masivs = new int[10, 10];
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    masivs[i, j] = rand.Next(1, 10);
                }

                Console.WriteLine("{0, 10} {1, 10} {2, 10} {3, 10} {4, 10} {5, 10} {6, 10} {7, 10} {8, 10} {9, 10}",
                    masivs[i, 0], masivs[i, 1], masivs[i, 2], masivs[i, 3], masivs[i, 4], masivs[i, 5], masivs[i, 6], masivs[i, 7], masivs[i, 8], masivs[i, 9]);
            }

            Console.WriteLine("");

            int[,] apgriezts = new int[10, 10];

            int limit = 1;
            int count = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                }

                count++;

                Console.WriteLine("{0, 10} {1, 10} {2, 10} {3, 10} {4, 10} {5, 10} {6, 10} {7, 10} {8, 10} {9, 10}",
                   apgriezts[i, 0], apgriezts[i, 1], apgriezts[i, 2], apgriezts[i, 3], apgriezts[i, 4], apgriezts[i, 5], apgriezts[i, 6], apgriezts[i, 7], apgriezts[i, 8], apgriezts[i, 9]);
            }

            Console.ReadLine();
        }
    }
}

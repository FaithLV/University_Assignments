using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiskais_15
{
    class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            //Pirmais();
            Otrais();
        }

        static void Pirmais()
        {
            Console.Write("Rindu skaits: ");
            int rows = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Kolonnu skaits: ");
            int columns = Int32.Parse(Console.ReadLine());

            int[,] array1 = new int[columns, rows];
            int even = 0;

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    array1[i, j] = rand.Next(1, 100);
                    Console.Write("{0, 10}", array1[i,j]);

                    if(array1[i, j] % 2 == 0)
                    {
                        even++;
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine($"{(100*even)/array1.Length}% masīvā ir pāra skaitļi");

            Console.ReadLine();

        }

        static void Otrais()
        {
            Console.Write("Rindu skaits: ");
            int rows = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Kolonnu skaits: ");
            int columns = Int32.Parse(Console.ReadLine());

            int[,] array1 = new int[columns, rows];
            int[,] array2 = new int[columns, rows];
            int counter = 0;

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    array1[i, j] = rand.Next(1, 100);
                    Console.Write("{0, 10}", array1[i, j]);

                    if(counter % 2 == 0)
                    {
                        array2[i, j] = 0;
                    }
                    else
                    {
                        array2[i, j] = array1[i, j];
                    }

                    counter++;
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write("{0, 10}", array2[i, j]);
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

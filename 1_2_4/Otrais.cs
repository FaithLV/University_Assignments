using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_4
{
    class Otrais
    {
        static int[,] array;
        static Random rand = new Random();
        public Otrais()
        {
            Console.WriteLine("Rindu skaits: ");
            int size1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Kolonnu skaits: ");
            int size2 = Int32.Parse(Console.ReadLine());
            array = new int[size1, size2];

            InitMas(array);
            PrintMas(array);
            MinMas(array);
            MaxMas(array);
            Meklet(array, 1);

            //ShowOptions();
        }

        static void InitMas(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(1, 11);
                }
            }
        }

        static void PrintMas(int[,] arr)
        {
            Console.WriteLine();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("prn");
        }

        static void MinMas(int[,] arr)
        {
            int min = Int32.MaxValue;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if(arr[i,j] < min)
                    {
                        min = arr[i, j];
                    }
                }
            }

            Console.WriteLine("Min: " + min);
        }

        static void MaxMas(int[,] arr)
        {
            int max = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
            }

            Console.WriteLine("Max: " + max);
        }

        static void Meklet(int[,] arr, int query)
        {
            int count = 0;

            foreach (int item in arr)
            {
                if(item == query)
                {
                    count++;
                }
            }

            Console.WriteLine("Atrasti: " + count);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiskais_10
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
            string[] array = new string[10];

            for(int i = 0; i < array.Length; i++)
            {
                Console.Write($"Ievadiet {i+1} vērtību: ");
                array[i] = Console.ReadLine();
            }

            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Masīva {i+1}. vērtība ir {array[i]}");
            }

            Console.Write("Apvienotais masīvs : ");
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }

        static void Otrais()
        {
            Console.WriteLine("Ievadiet 1. masīva lielumu ");
            int size1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ievadiet 2. masīva lielumu ");
            int size2 = Int32.Parse(Console.ReadLine());

            string[] array1 = new string[size1];
            string[] array2 = new string[size2];

            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($"Ievadiet 1. masīva - {i + 1} vērtību: ");
                array1[i] = Console.ReadLine();
            }

            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write($"Ievadiet 2. masīva - {i + 1} vērtību: ");
                array2[i] = Console.ReadLine();
            }

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"1. Masīva {i + 1}. vērtība ir {array1[i]}");
            }

            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine($"2. Masīva {i + 1}. vērtība ir {array2[i]}");
            }

            Console.Write("Apvienotais masīvs : ");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i]);
            }
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i]);
            }

        }

        static void Tresais()
        {
            Console.WriteLine("Ievadiet 1. masīva lielumu ");
            int size1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ievadiet 2. masīva lielumu ");
            int size2 = Int32.Parse(Console.ReadLine());

            string[] array1 = new string[size1];
            string[] array2 = new string[size2];

            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($"Ievadiet 1. masīva - {i + 1} vērtību: ");
                array1[i] = Console.ReadLine();
            }

            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write($"Ievadiet 2. masīva - {i + 1} vērtību: ");
                array2[i] = Console.ReadLine();
            }

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"1. Masīva {i + 1}. vērtība ir {array1[i]}");
            }

            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine($"2. Masīva {i + 1}. vērtība ir {array2[i]}");
            }

            Console.Write("Apvienotais masīvs : ");
            for (int i = 0; i < array1.Length; i++)
            {
                if(i == array1.Length / 2)
                {
                    for (int j = 0; j < array2.Length; j++)
                    {
                        Console.Write(array2[j]);
                    }
                }
                Console.Write(array1[i]);
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiskais_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadiet masīvu lielumu: ");
            int _in1 = Int32.Parse(Console.ReadLine());
            int _in2 = Int32.Parse(Console.ReadLine());

            int[] array1 = new int[_in1];
            int[] array2 = new int[_in2];

            Random rand = new Random();

            for(int i  = 0; array1.Length > i; i++)
            {
                array1[i] = rand.Next(10, 100);
            }
            for (int i = 0; array2.Length > i; i++)
            {
                array2[i] = rand.Next(10, 100);
            }

            object big_array = array1;
            if(array1.Length < array2.Length)
            {
                big_array = array2;
            }

            int min1 = 100;
            int min2 = 100;
            int max1 = 0;
            int max2 = 0;

            Console.WriteLine("{0, 10} {1, 10}", "Pirmais", "Otrais");
            for(int i = 0; i < ((int[])big_array).Length; i++)
            {
                int? i1 = null;
                int? i2 = null;

                if (i < array1.Length)
                {
                    i1 = array1[i];

                    if(max1 < array1[i])
                    {
                        max1 = array1[i];
                    }

                    if(min1 > array1[i])
                    {
                        min1 = array1[i];
                    }
                }

                if(i < array2.Length)
                {
                    i2 = array2[i];

                    if (max2 < array2[i])
                    {
                        max2 = array2[i];
                    }

                    if (min2 > array2[i])
                    {
                        min2 = array2[i];
                    }
                }

                Console.WriteLine("{0, 10} {1, 10}", i1, i2);
            }

            if(max1 == max2)
            {
                Console.WriteLine($"Abos masīvos lielākais skaitlis ir vienāds ar {max1}");
            }
            else if(max1 < max2)
            {
                Console.WriteLine($"Lielākais skaitlis ir no otrā masīva ar {max2}");
            }
            else if(max1 > max2)
            {
                Console.WriteLine($"Lielākais skaitlis ir no pirmā masīva ar {max1}");
            }

            if(min1 == min2)
            {
                Console.WriteLine($"Abos masīvos mazākais skaitlis ir vienāds ar {min1}");
            }
            else if(min1 > min2)
            {
                Console.WriteLine($"Mazākais skaitlis ir no otrā masīva ar {min2}");
            }
            else if(min1 < min2)
            {
                Console.WriteLine($"Mazākais skaitlis ir no pirmā masīva ar {min1}");
            }

            Console.ReadLine();
        }
    }
}

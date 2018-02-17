using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_3
{
    class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            Pirmais();

            Console.ReadLine();
        }

        static void Pirmais()
        {
            string[] array = new string[10];

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = randomString();
            }

            foreach (string str in array)
            {
                Console.WriteLine(str);
            }
        }

        static string randomString(int lenght = 6)
        {
            int minChar = 97;
            int maxChar = 122;
            string output = String.Empty;

            for(int i = 0; i < lenght; i++)
            {
                int randint = rand.Next(minChar, maxChar);
                output = output + (char)randint;
            }

            return output;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1_2_3
{
    class Program
    {
        static Random rand = new Random();

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

            for (int i = 0; i < array.Length; i++)
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

            for (int i = 0; i < lenght; i++)
            {
                int randint = rand.Next(minChar, maxChar);
                output = output + (char)randint;
            }

            return output;
        }

        static void Otrais()
        {
            int size = rand.Next(3, 8);

            int[][] myArray = new int[size][];

            for (int i = 0; i < size; i++)
            {
                myArray[i] = new int[size + i];
                string current = String.Empty;

                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = rand.Next(1, 11);
                    current = current + myArray[i][j] + " ";
                }

                Console.WriteLine($"{current}Rindas {i} garums ir {myArray[i].Length}");
            }

            Console.WriteLine();

            int index = 0;
            foreach (Array rr in myArray)
            {
                string current = String.Empty;

                foreach (int ii in rr)
                {
                    current = current + ii + " ";
                }

                Console.WriteLine($"{current} Rindas {index} garums ir {rr.Length}");

                index++;
            }
        }

        static void Tresais()
        {
            Console.WriteLine();
            Console.Write("Ievadi savu vārdu: ");
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char index = Char.ToUpper(input[i]);

                string result = String.Empty;
                try
                {
                    result = MorseDict[index];
                }
                catch
                {
                    Console.WriteLine($"Nezināms simbols: \"{index}\"");
                }

                for (int j = 0; j < result.Length; j++)
                {
                    if(result[j] == '.')
                    {
                        Console.Beep(1000, 100);
                    }
                    else if(result[j] == '-')
                    {
                        Console.Beep(1000, 800);
                    }
                }

                Thread.Sleep(100);
            }

            Console.WriteLine("Beigas");
        }

        static Dictionary<char, string> MorseDict = new Dictionary<char, string>()
        {
            { 'A', ".-" },
            { 'B', "-..." },
            { 'C', "-.-." },
            { 'D', "-.." },
            { 'E', "." },
            { 'F', "..-." },
            { 'G', "--." },
            { 'H', "...." },
            { 'I', ".." },
            { 'J', ".---" },
            { 'K', "-.-" },
            { 'L', ".-.." },
            { 'M', "--" },
            { 'N', "-." },
            { 'O', "---" },
            { 'P', ".--." },
            { 'Q', "--.-" },
            { 'R', ".-." },
            { 'S', "..." },
            { 'T', "-" },
            { 'U', "..-" },
            { 'V', "...-" },
            { 'W', ".--" },
            { 'X', "-..-" },
            { 'Y', "-.--" },
            { 'Z', "--.." },

            { '1', ".----" },
            { '2', "..---" },
            { '3', "...--" },
            { '4', "....-" },
            { '5', "....." },
            { '6', "-...." },
            { '7', "--..." },
            { '8', "---.." },
            { '9', "----." },
            { '0', "-----" },

            { '/', "-..-." },
            { '+', ".-.-." },
            { '=', "-...-" },
            { '.', ".-.-.-" },
            { ',', "--..--" },
            { '?', "..--.." },
            { '(', "-.--." },
            { ')', "-.--.-" },
            { '-', "-....-" },
            { '"', ".-..-." },
            { '_', "..--.-" },
            { '\'', ".----." },
            { ':', "---..." },
            { ';', "-.-.-." },
            { '$', "...-..-" }
        };
    }
}

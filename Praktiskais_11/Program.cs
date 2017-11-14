using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiskais_11
{
    class Program
    {

        static void Main(string[] args)
        {
            //Pirmais();
            //Otrais();
            //Tresais();
            Ceturtais();

            Console.ReadKey(true);
        }

        static void Pirmais()
        {
            int[] masivs = new int[10];

            for (int i = 0; i < masivs.Length; i++)
            {
                Console.Write($" Ievadiet masivs[{i}] vertibu: ");
                masivs[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < masivs.Length; i++)
            {
                Console.WriteLine($"masivs[{i}] = {masivs[i]}");
            }

            int reiz = masivs[0];
            for (int i = 0; i < masivs.Length; i++)
            {
                Console.WriteLine($"{i + 1}. reizinajums = {reiz}");
                if (i != masivs.Length - 1)
                {
                    reiz = reiz * masivs[i + 1];
                }

            }
        }

        static void Otrais()
        {
            char[] masivs = new char[20];

            char[] chars = @"abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890+-*/~!@#$%&*();:'""\|<>,./?".ToCharArray();
            Random rand = new Random();

            for(int i = 0; i < masivs.Length; i++)
            {
                int num = rand.Next(0, chars.Length - 1);
                masivs[i] = chars[num];
                Console.WriteLine($"masivs[{i}] = {chars[num]}");
            }

            char _in = (char)Console.Read();
            int count = 0;

            foreach(char ch in masivs)
            {
                if(ch == _in)
                {
                    count++;
                }
            }

            Console.WriteLine($"Masiivaa ir {count} {_in} simboli");

            for (int i = 0; i < masivs.Length; i++)
            {
                if(masivs[i] != _in)
                {
                    Console.WriteLine($"masivs[{i}] = {masivs[i]}");
                }
            }
        }

        static void Tresais()
        {
            int[] masivs = new int[10];
            Random rand = new Random();
            int max = 1;
            int low = 20;

            for(int i = 0; i < masivs.Length; i++)
            {
                int skaitlis = rand.Next(1, 20);
                masivs[i] = skaitlis;
                Console.WriteLine($"masivs[{i}] = {skaitlis}");
                if(skaitlis > max)
                {
                    max = skaitlis;
                }
                else if(skaitlis < low)
                {
                    low = skaitlis;
                }
            }

            Console.WriteLine($"max vertiba = {max}");
            Console.WriteLine($"min vertiba = {low}");


        }

        static void Ceturtais()
        {
            int[] masivs = new int[10];
            Random rand = new Random();

            for (int i = 0; i < masivs.Length; i++)
            {
                int skaitlis = rand.Next(1, 20);
                masivs[i] = skaitlis;
                Console.WriteLine($"[{i}] = {skaitlis}");
            }

            for(int i = 0; i < masivs.Length / 2; i++)
            {
                int temp;
                temp = masivs[masivs.Length - 1 - i];
                masivs[masivs.Length - 1 - i] = masivs[i];
                masivs[i] = temp;
            }

            Console.WriteLine("");

            for (int i = 0; i < masivs.Length; i++)
            {
                Console.WriteLine($"[{i}] = {masivs[i]}");
            }

        }
    }
}

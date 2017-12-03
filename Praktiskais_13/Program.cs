using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiskais_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pirmais();
            Otrais();
        }

        static void Pirmais()
        {
            Console.WriteLine("Ievadiet simbolu rindu:");

            string input = Console.ReadLine();
            char[] simb = input.ToArray();
            int sum = 0;

            foreach(char ch in simb)
            {
                Console.WriteLine($"{ch} = {(int)ch}");
                sum += ch;
            }

            Console.WriteLine($"Kodu summa: {sum}");

            Console.Write("Ievadiet simbolu: ");
            char input2 = Console.ReadLine().First();
            int count = 0;

            foreach(char ch in simb)
            {
                if(ch == input2)
                {
                    count++;
                }
            }

            Console.WriteLine($"Simbols {input2} ir sastopams {count} reizes.");

            Console.ReadLine();
        }

        static void Otrais()
        {
            char[] numbers = "1234567890".ToArray();
            char[] lowercase = "qwertyuiopasdfghjklzxcvbnm".ToArray();
            char[] uppercase = "QWERTYUIOPASDFGHJKLZXCVBNM".ToArray();

            Console.WriteLine("Ievadiet 1. simbolu rindu");
            char[] chars1 = Console.ReadLine().ToArray();

            Console.WriteLine("Ievadiet 2. simbolu rindu");
            char[] chars2 = Console.ReadLine().ToArray();

            for (int i = 0; i < chars1.Length; i++)
            {
                if(numbers.Contains(chars1[i]))
                {
                    chars1[i] = '*';
                }
            }

            for (int i = 0; i < chars2.Length; i++)
            {
                if(lowercase.Contains(chars2[i]))
                {
                    chars2[i] = uppercase[Array.IndexOf(lowercase, chars2[i])];
                }
            }

            Console.WriteLine($"Pirmā: {new string(chars1)}");
            Console.WriteLine($"Garums: {chars1.Length}");

            Console.WriteLine($"Otrā: {new string(chars2)}");
            Console.WriteLine($"Garums: {chars2.Length}");

            char[] apvienotaismasivs = new char[chars1.Length + chars2.Length];

            Console.Write("Apvienotais masīvs : ");
            for (int i = 0; i < chars1.Length; i++)
            {
                if (i == chars1.Length / 2)
                {
                    for (int j = 0; j < chars2.Length; j++)
                    {
                        apvienotaismasivs[i] = chars2[j];
                        Console.Write(chars2[j]);
                    }
                }
                apvienotaismasivs[i] = chars1[i];
                Console.Write(chars1[i]);
            }

            Console.WriteLine("Ievadiet 3. simbolu rindu");
            char[] chars3 = Console.ReadLine().ToArray();

            //for (int i = 0; i < apvienotaismasivs.Length; i++)
            //{
            //    if(apvienotaismasivs[i] == chars3[0])
            //    {

            //    }
            //}

            Console.WriteLine("3. simbolu rinda apvienotajā rindā atkārtojas !x reizes");

            Console.ReadLine();
        }
    }
}

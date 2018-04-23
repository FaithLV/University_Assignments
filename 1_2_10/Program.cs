using System;

namespace _1_2_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc cc = new Calc();
            int sk = 0;
            int x = 0;
            int y = 0;

            Console.WriteLine("sk: ");
            if(!int.TryParse(Console.ReadLine(), out sk))
            {
                Console.WriteLine("Nederīga izvēle.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("X: ");
            int.TryParse(Console.ReadLine(), out x);

            if (sk == 1)
            {
                cc.SkaitlisKubaa(ref x);
            }
            else if(sk == 2)
            {
                Console.WriteLine("Y: ");
                int.TryParse(Console.ReadLine(), out y);

                cc.Reizinasana(ref x, ref y);
            }

            Console.WriteLine($"X = {x}");
            if(y != 0)
            {
                Console.WriteLine($"Y = {y}");
            }
           
            Console.ReadLine();
        }
    }

    class Calc
    {
        public void SkaitlisKubaa(ref int x)
        {
            x = x * x * x;
        }

        public void Reizinasana(ref int x, ref int y)
        {
            x = x * y;
        }
    }

    class MathMans
    {
        public static int Min(params int[] arr)
        {
            int min = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < min)
                {
                    min = arr[i];
                }
            }

            return min;
        }

        public static int Max(params int[] arr)
        {
            int max = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }
    }
}

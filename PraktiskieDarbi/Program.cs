using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktiskieDarbi
{
    class Program
    {
        static void Main(string[] args)
        {
            Pirmais();
            //Otrais();

            Console.ReadLine();
        }

        static void Pirmais()
        {
            int a = 5;
            int b = 4;

            Console.WriteLine($"Skaitlis A = {a}");
            Console.WriteLine($"Skaitlis B = {b}");
            Console.WriteLine($"Operācijas reizināt darbība: {a}*{b}={a * b}");
            Console.WriteLine($"Operācijas atņemt darbība: {a}-{b}={a - b}");
            Console.WriteLine($"Operācijas summa darbība: {a}+{b}={a + b}");
            Console.WriteLine($"Operācijas dalīt darbība: {a}/{b}={a / b}");
        }

        static void Otrais()
        {
            double radius = 5.3;

            Console.WriteLine($"R = {radius}");
            Console.WriteLine($"Rinka linijas garums = {2 * Math.PI * radius}");
            Console.WriteLine($"Rinka laukums = {Math.PI * radius * radius}");
            Console.WriteLine($"Lodes laukums = {4 * Math.PI * radius * radius}");
            Console.WriteLine($"Lodes tilpums = {(4 * Math.PI * radius * radius * radius) / 3}");
        }

    }
}

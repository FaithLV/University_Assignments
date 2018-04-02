using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Cetrsturis uzd = new Cetrsturis();
            uzd.Register();

            uzd.Perimeter();
            uzd.Area();
            Console.WriteLine(uzd.IsRectangle());
            Console.WriteLine(uzd.IsSquare());


            Console.ReadLine();
        }
    }

    class Punkts
    {
        public int X;
        public int Y;
        public string Color;

        public void Register()
        {
            Console.WriteLine("Ievadiet X:");
            X = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ievadiet Y");
            Y = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("Ievadiet krāsu: ");
            //Color = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine($"X: {X}");
            Console.WriteLine($"Y: {Y}");
            Console.WriteLine($"Color: {Color}");
        }
    }

    class Linija
    {
        public Punkts A;
        public Punkts B;
        public string Color;

        public void Register()
        {
            Console.WriteLine("Punkts A: ");
            A = new Punkts();
            A.Register();

            Console.WriteLine("Punkts B:");
            B = new Punkts();
            B.Register();

            //Console.WriteLine("Ievadiet krāsu:");
            //Color = Console.ReadLine();
        }

        public double Length()
        {
            double a = Math.Pow(A.Y - A.X, 2);
            double b = Math.Pow(B.Y - B.X, 2);
            double c = Math.Sqrt(a + b);
            return c;
        }

        public void Display()
        {
            Console.WriteLine("A:");
            A.Display();

            Console.WriteLine("B:");
            B.Display();

            Console.WriteLine($"Krāsa: {Color}");
        }
    }

    class Cetrsturis
    {
        public Linija Linija1;
        public Linija Linija2;
        public Linija Linija3;
        public Linija Linija4;

        public void Register()
        {
            Console.WriteLine("Linija 1:");
            Linija1 = new Linija();
            Linija1.Register();

            Console.WriteLine("Linija 2:");
            Linija2 = new Linija();
            Linija2.Register();

            Console.WriteLine("Linija 3:");
            Linija3 = new Linija();
            Linija3.Register();

            Console.WriteLine("Linija 4:");
            Linija4 = new Linija();
            Linija4.Register();
        }

        public void Perimeter()
        {
            double per = Linija1.Length() + Linija2.Length() + Linija3.Length() + Linija4.Length();
            Console.WriteLine($"Perimetrs: {per}");
        }

        public bool IsRectangle()
        {
            bool _is = true;

            if(Linija1.Length() != Linija3.Length())
            {
                _is = false;
            }

            if (Linija2.Length() != Linija4.Length())
            {
                _is = false;
            }

            return _is;
        }

        public bool IsSquare()
        {
            bool _is = false;

            if(Linija1.Length() == Linija2.Length())
            {
                if(Linija3.Length() == Linija4.Length())
                {
                    _is = true;
                }
            }

            return _is;
        }

        public void Area()
        {
            Console.WriteLine($"Laukums: {Linija1.Length() * Linija2.Length()}");
        }

        
    }
}

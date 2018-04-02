using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_8
{
    class Program
    {
        static Klase[] Klases;

        static void Main(string[] args)
        {
            Console.WriteLine("Klašu skaits: ");
            Klases = new Klase[Int32.Parse(Console.ReadLine())];

            for (int i = 0; i < Klases.Length; i++)
            {
                Klases[i] = new Klase();
                Klases[i].Register();
            }

            Console.WriteLine("Meklēt klasi: ");
            Klase qk = Search(Console.ReadLine());

            if(qk != null)
            {
                qk.OldestStudent();
                Console.WriteLine("Meklēt studentu:");
                qk.Search(Console.ReadLine());
            }

            Console.ReadLine();
        }

        static Klase Search(string Query)
        {
            Klase fk = null;

            foreach (Klase kl in Klases)
            {
                if (kl.Nosaukums.Contains(Query))
                {
                    fk = kl;
                }
            }

            if (fk == null)
            {
                Console.WriteLine("Netika atrasts");
                return null;
            }

            Console.WriteLine("Atrasts:");
            Console.WriteLine($"{fk.Nosaukums} - {fk.Audzinatajs.Vards} {fk.Audzinatajs.Uzvards}");
            return fk;
        }
    }

    class Skolens
    {
        public string Vards;
        public string Uzvards;
        public string Pers_kods;

        public void Register()
        {
            Console.WriteLine("Vārds: ");
            Vards = Console.ReadLine();

            Console.WriteLine("Uzvārds: ");
            Uzvards = Console.ReadLine();

            Console.WriteLine("Personas Kods: ");
            Pers_kods = Console.ReadLine();
        }

        public int Age
        {
            get
            {
                DateTime zero = new DateTime(1,1,1);

                string s = Pers_kods.Remove(6,6);
                s = s.Insert(2, "-");
                s = s.Insert(5, "-");

                DateTime birth = DateTime.ParseExact(s, "dd-MM-yy", CultureInfo.InvariantCulture);
                TimeSpan span = DateTime.Now - birth;
                int years = (zero + span).Year - 1;

                return years;
            }
        }

        public void Display()
        {
            Console.WriteLine($"{Vards} {Uzvards} - {Age}");
        }
    }

    class Skolotajs
    {
        public string Vards;
        public string Uzvards;
        public double Alga;

        private int apgadajamie;

        public void Register()
        {
            Console.WriteLine("Vārds: ");
            Vards = Console.ReadLine();

            Console.WriteLine("Uzvārds: ");
            Uzvards = Console.ReadLine();

            Console.WriteLine("Alga: ");
            Alga = Double.Parse(Console.ReadLine());

            Console.WriteLine("Apgādājamo skaits:");
            apgadajamie = Int32.Parse(Console.ReadLine());
        }

        public double AlgaFinal
        {
            get
            {
                //nodoķlu aprēķins n shit
                return Alga;
            }
        }

        public void Display()
        {
            Console.WriteLine($"{Vards} {Uzvards} - {AlgaFinal}€");
        }
    }

    class Klase
    {
        public string Nosaukums;
        public Skolotajs Audzinatajs;
        public Skolens[] Skoleni;
        
        public int Skolenu_Skaits
        {
            get
            {
                return Skoleni.Count();
            }
        }

        public void Register()
        {
            Console.WriteLine("Nosaukums: ");
            Nosaukums = Console.ReadLine();

            Console.WriteLine("Skolēnu skaits: ");
            Skoleni = new Skolens[Int32.Parse(Console.ReadLine())];

            for (int i = 0; i < Skoleni.Length; i++)
            {
                Skoleni[i] = new Skolens();
                Console.WriteLine($"{i}. skolēns:");
                Skoleni[i].Register();
            }

            Console.WriteLine("Audzinātājs: ");
            Audzinatajs = new Skolotajs();
            Audzinatajs.Register();
        }

        public void Display()
        {
            Console.WriteLine($"{Nosaukums} ({Skolenu_Skaits} skolēni) - {Audzinatajs.Vards} {Audzinatajs.Uzvards}");
        }

        public void OldestStudent()
        {
            Skolens oldest = new Skolens { Pers_kods = "000000-00000" };

            foreach(Skolens st in Skoleni)
            {
                if(st.Age > oldest.Age)
                {
                    oldest = st;
                }
            }

            Console.WriteLine($"{oldest.Vards} {oldest.Uzvards} - {oldest.Age}");
        }

        public void Search(string query)
        {
            Skolens fs = null;

            foreach(Skolens st in Skoleni)
            {
                if(st.Vards == query || st.Uzvards == query)
                {
                    fs = st;
                }
            }

            if(fs == null)
            {
                Console.WriteLine("Netika atrasts");
                return;
            }

            Console.WriteLine("Atrasts:");
            Console.WriteLine($"{fs.Vards} {fs.Uzvards} - {fs.Age}");
        }
    }
}

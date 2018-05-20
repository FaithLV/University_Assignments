using System;
using System.Collections.Generic;
using System.Text;

namespace _1._2._13
{
    class Veikals
    {
        public string Nosaukums { get; set; }

        public int PartikasPrecuSkaits => PartikasPreces?.Length ?? 0;
        public int SaimniecibasPrecuSkaits => SaimniecibasPreces?.Length ?? 0;
        public Partika[] PartikasPreces { get; set; }
        public Samnieciba[] SaimniecibasPreces { get; set; }

        public void Registret()
        {
            Console.WriteLine();
            Console.WriteLine("Veikala reģistrācija.");
            Console.WriteLine("Nosaukums: ");
            Nosaukums = Console.ReadLine();
            
        }

        public void Izvadit()
        {
            Console.WriteLine();
            Console.WriteLine($"Nosaukums: {Nosaukums}");
            Console.WriteLine($"Pārtikas preču skaits: {PartikasPrecuSkaits}");
            Console.WriteLine($"Saimniecības preču skaits: {SaimniecibasPrecuSkaits}");
        }

        public void VeikalaTips()
        {
            Console.WriteLine();
            if (PartikasPrecuSkaits > 0 && SaimniecibasPrecuSkaits > 0)
            {
                Console.WriteLine("Lielveikals");
                return;
            }

            if (PartikasPrecuSkaits > 0)
            {
                Console.WriteLine("Pārtikas Veikals");
            }

            if (SaimniecibasPrecuSkaits > 0)
            {
                Console.WriteLine("Saimniecības Veikals");
            }
        }

        public void ArpusTermiņa()
        {
            Console.WriteLine();
            if (PartikasPreces.Length > 0)
            {
                Console.WriteLine("Preces ārpus termiņa: ");
            }
            else
            {
                return;
            }
            

            foreach (var p in PartikasPreces)
            {
                if (p.DerigumaTermins.Date <= DateTime.Today)
                {
                    Console.WriteLine($"{p.Nosaukums} : {p.DerigumaTermins.Date}");
                }
            }
        }

        public void AtlasitBistamus()
        {
            Console.WriteLine();
            if (SaimniecibasPreces.Length > 0)
            {
                Console.WriteLine("Bīstamas preces: ");
            }
            else
            {
                return;
            }

            foreach (var p in SaimniecibasPreces)
            {
                if (p.IrBistama)
                {
                    Console.WriteLine(p.Nosaukums);
                }
            }
        }
    }
}

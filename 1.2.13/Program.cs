using System;
using System.Collections.Generic;

namespace _1._2._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Veikals veik = new Veikals();
            veik.Registret();

            veik.PartikasPreces = PartikasPreces();
            veik.SaimniecibasPreces = SaimniecibasPreces();

            veik.Izvadit();
            veik.VeikalaTips();
            veik.ArpusTermiņa();
            veik.AtlasitBistamus();
            
            Console.ReadLine();
        }

        public static Partika[] PartikasPreces()
        {
            List<Partika> PartikasPreces = new List<Partika>();

            Partika p1 = new Partika();
            p1.Registret();
            PartikasPreces.Add(p1);
            p1.Izvadit();

            PartikasPreces.Add(new Partika
            {
                Nosaukums = "Makaroni",
                IrAlergisks = true,
                Mervieniba = "kg",
                IepirksanasCena = 0.9,
                DerigumaTermins = new DateTime(2020, 12, 22)
            });

            PartikasPreces.Add(new Partika
            {
                Nosaukums = "Sviests",
                IrAlergisks = true,
                Mervieniba = "kg",
                IepirksanasCena = 0.9,
                DerigumaTermins = new DateTime(2018, 05, 26)
            });

            PartikasPreces.Add(new Partika
            {
                Nosaukums = "Ūdens",
                IrAlergisks = false,
                Mervieniba = "L",
                IepirksanasCena = 0.13,
                DerigumaTermins = new DateTime(2018, 2, 4)
            });

            return PartikasPreces.ToArray();
        }

        public static Samnieciba[] SaimniecibasPreces()
        {
            List<Samnieciba> preces = new List<Samnieciba>
            {
                new Samnieciba
                {
                    Nosaukums = "Cianīds",
                    IepirksanasCena = 12.22,
                    IrBistama = true,
                    Materials = "Skābe"
                },

                new Samnieciba
                {
                    Nosaukums = "Skrūve",
                    IepirksanasCena = 0.03,
                    IrBistama = false,
                    Materials = "Alumīnijs"
                }
            };


            return preces.ToArray();
        }
    }
}

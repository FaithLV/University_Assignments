using System;

namespace _1._2._13
{
    class Prece
    {
        public string Nosaukums { get; set; }
        public double IepirksanasCena { get; set; }

        public void Izvadit()
        {
            Console.WriteLine();
            Console.WriteLine($"Nosaukums: {Nosaukums}");
            Console.WriteLine($"Iepirkšanas Cena: {IepirksanasCena}");
        }
    }

    class Partika : Prece
    {
        public DateTime DerigumaTermins { get; set; }
        public bool IrAlergisks { get; set; }
        public string Mervieniba { get; set; }
        public double PardosanasCena => IepirksanasCena * 1.3;

        public void Registret()
        {
            Console.WriteLine();
            Console.WriteLine("Pārtikas produkta reģistrācija: ");

            Console.WriteLine("Nosaukums: ");
            Nosaukums = Console.ReadLine();

            Console.WriteLine("Iepirkšanas cena: ");
            IepirksanasCena = Double.Parse(Console.ReadLine());

            Console.WriteLine("Derīguma termiņš: ");
            DerigumaTermins = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Ir Alerģisks: ");
            IrAlergisks = Boolean.Parse(Console.ReadLine());

            Console.WriteLine("Mērvienība: ");
            Mervieniba = Console.ReadLine();
        }

        public new void Izvadit()
        {
            base.Izvadit();

            Console.WriteLine($"Derīguma Termiņš: {DerigumaTermins.Date}");
            Console.WriteLine($"Ir alerģisks: {IrAlergisks}");
            Console.WriteLine($"Mervieniba: {Mervieniba}");
            Console.WriteLine($"Pārdošanas cena: {PardosanasCena}");
        }
    }

    class Samnieciba : Prece
    {
        public string Materials { get; set; }
        public bool IrBistama { get; set; }
        public double PardosansCena => IepirksanasCena * 1.5;

        public void Registret()
        {
            Console.WriteLine("Saimniecības produkta reģistrācija: ");

            Console.WriteLine("Nosaukums: ");
            Nosaukums = Console.ReadLine();

            Console.WriteLine("Iepirkšanas cena: ");
            IepirksanasCena = Double.Parse(Console.ReadLine());

            Console.WriteLine("Materiāls: ");
            Materials = Console.ReadLine();

            Console.WriteLine("Ir Bīstams: ");
            IrBistama = Boolean.Parse(Console.ReadLine());
        }

        public new void Izvadit()
        {
            base.Izvadit();

            Console.WriteLine($"Pārdošans Cena: {PardosansCena}");
            Console.WriteLine($"Materiāls: {Materials}");
            Console.WriteLine($"Ir bīstams: {IrBistama}");
        }
    }
}

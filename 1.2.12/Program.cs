using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using Console = System.Console;

namespace _1._2._12
{
    class Program
    {
        static void Main(string[] args)
        {
            myConsole.NomainitBurtuKrasu();
            myConsole.NomainitFonaKrasu();

            Console.WriteLine(myConsole.tagad);

            string word = myConsole.IzveidotParoli(12);
            string encrp = myConsole.SifretTekstu(word);
            string decrp = myConsole.AtsifretTekstu(encrp);
            myConsole.Izvadit($"{word} --> {encrp} --> {decrp}");

            myConsole.NolasitKaInt();

            myConsole.FormatetVardu("Valters Tomsons");

            Console.ReadLine();
        }
    }

    public class myConsole
    {
        private static readonly Random Random = new Random();

        public static string tagad => DateTime.Now.ToString();

        public static int NolasitKaInt()
        {
            Console.WriteLine("Ievadi veselu skaitli: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int res))
            {
                return res;
            }

            Console.WriteLine("Konvertācija neveiksmīga!");
            return 0;
        }

        public static void Izvadit(string text)
        {
            Console.WriteLine(text);
        }

        public static void NomainitFonaKrasu()
        {
            Array colors = Enum.GetValues(typeof(ConsoleColor));
            Console.BackgroundColor = (ConsoleColor) colors.GetValue(Random.Next(colors.Length));
        }

        public static void NomainitBurtuKrasu()
        {
            Array colors = Enum.GetValues(typeof(ConsoleColor));
            Console.ForegroundColor = (ConsoleColor)colors.GetValue(Random.Next(colors.Length));
        }

        public static void FormatetVardu(string vards_uzvards)
        {
            string[] _words = vards_uzvards.Split(' ');
            Console.WriteLine($"{_words[0].First()}. {_words[1]}");
        }

        public static string IzveidotParoli(int garums)
        {
            int minChar = 0x20;
            int maxChar = 0x59;

            char[] pw = new char[garums];

            for (int i = 0; i < garums; i++)
            {
                pw[i] += (char) Random.Next(minChar, maxChar);
            }

            return string.Join(String.Empty, pw);
        }

        public static string SifretTekstu(string teksts)
        {
            char[] e_st = new char[teksts.Length];
            int index = 0;

            for (int i = 0; i < teksts.Length; i++)
            {
                if (index == 0)
                {
                    e_st[i] = (char)(teksts[i] + teksts.Length);
                    index++;
                }
                else
                {
                    e_st[i] = (char)(teksts[i] - teksts.Length);
                    index = 0;
                }
            }

            return string.Join(String.Empty, e_st);
        }

        public static string AtsifretTekstu(string teksts)
        {
            char[] kk = new char[teksts.Length];
            int index = 0;

            for (int i = 0; i < teksts.Length; i++)
            {
                if (index == 0)
                {
                    kk[i] = (char)(teksts[i] - teksts.Length);
                    index++;
                }
                else
                {
                    kk[i] = (char)(teksts[i] + teksts.Length);
                    index = 0;
                }
            }

            return string.Join(String.Empty, kk);
        }
    }
}

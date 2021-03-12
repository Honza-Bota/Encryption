using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo pokracovani;
            Crypto cry = new Crypto();

            do
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("     Vítej v programu pro šifrování");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Vyber si typ šifry:");
                Console.WriteLine("------------------------");
                Console.WriteLine("1) Bloková šifra XOR");
                Console.WriteLine("2) Cesarova šifra");
                Console.WriteLine("------------------------");
                Console.WriteLine();
                Console.Write("Zadej číslo šifry <1, 2>: ");

                string sifra = Console.ReadLine();
                if (sifra == "1") cry.XOR();
                else if (sifra == "2") cry.Cesar();
                else Console.WriteLine("\n --- Neplatný vstup! --- ");

                Console.WriteLine();
                Console.WriteLine("-------------------------------------");
                Console.Write("Přejete si pokračovat? <Y:N>: ");
                pokracovani = Console.ReadKey();

            } while (pokracovani.Key == ConsoleKey.Y);



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("----------- Pro ukončení stiskni Enter -----------");
            Console.ReadLine();
        }

        class Crypto
        {
            public void XOR()
            {
                throw new NotImplementedException();
            }

            public void Cesar()
            {
                throw new NotImplementedException();
            }
        }
    }
}

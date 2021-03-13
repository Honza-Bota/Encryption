using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    partial class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo pokracovani;
            Crypto crypto = new Crypto();

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
                Console.WriteLine("3) Bloková šifra XOR - dešifrování");
                Console.WriteLine("4) Cesarova šifra - dešifrování");
                Console.WriteLine("------------------------");
                Console.WriteLine();
                Console.Write("Zadej číslo šifry <1, 4>: ");

                string sifra = Console.ReadLine();
                Console.WriteLine("------------------------");

                if (sifra == "1")
                {
                    Console.Write("Zadej zprávu pro zašifrování: ");
                    string zprava = Console.ReadLine();
                    Console.Write("Zadej klíč pro šifrování: ");
                    string klic = Console.ReadLine();

                    string zasifrovana = crypto.XOR(zprava, klic);

                    Console.WriteLine();
                    Console.WriteLine("------------------------");
                    Console.WriteLine($"Zašifrovaná zpráva:");
                    Console.WriteLine(zasifrovana);
                    Console.WriteLine("------------------------");
                    Console.Write("Chcete text uložit do souboru? Pokud ne, stiskňete Enter. Pokud ano, zadejte jméno souboru pro uložení: ");
                    string ulozeni = Console.ReadLine();
                    if (ulozeni != "") crypto.SaveText(zasifrovana, ulozeni);

                }
                else if (sifra == "2")
                {
                    Console.Write("Zadej zprávu pro zašifrování: ");
                    string zprava = Console.ReadLine();
                    Console.Write("Zadej posun <1, 25>: ");
                    string _posun = Console.ReadLine();
                    int posun;
                    if (int.TryParse(_posun, out posun) && posun <= 25 && posun > 0)
                    {
                        string zasifrovana = crypto.Cesar(zprava, posun);

                        Console.WriteLine();
                        Console.WriteLine("------------------------");
                        Console.WriteLine($"Zašifrovaná zpráva:");
                        Console.WriteLine(zasifrovana);
                        Console.WriteLine("------------------------");
                        Console.Write("Chcete text uložit do souboru? Pokud ne, stiskňete Enter. Pokud ano, zadejte jméno souboru pro uložení: ");
                        string ulozeni = Console.ReadLine();
                        if (ulozeni != "") crypto.SaveText(zasifrovana, ulozeni);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("---- Neplatný vstup pro posun!! ----");
                    }
                }
                else if (sifra == "3")
                {
                    Console.Write("Zadej zprávu pro dešifrování: ");
                    string zprava = Console.ReadLine();
                    Console.Write("Zadej klíč pro dešifrování: ");
                    string klic = Console.ReadLine();

                    string desfirovana = crypto.XOR(zprava, klic);

                    Console.WriteLine();
                    Console.WriteLine("------------------------");
                    Console.WriteLine($"Dešifrovaná zpráva:");
                    Console.WriteLine(desfirovana);
                    Console.WriteLine("------------------------");
                    Console.Write("Chcete text uložit do souboru? Pokud ne, stiskňete Enter. Pokud ano, zadejte jméno souboru pro uložení: ");
                    string ulozeni = Console.ReadLine();
                    if (ulozeni != "") crypto.SaveText(desfirovana, ulozeni);
                }
                else if (sifra == "4")
                {
                    Console.Write("Zadej zprávu pro dešifrování: ");
                    string zprava = Console.ReadLine();
                    Console.Write("Zadej posun <1, 25>: ");
                    string _posun = Console.ReadLine();
                    int posun;
                    if (int.TryParse(_posun, out posun) && posun <= 25 && posun > 0)
                    {
                        string desifrovana = crypto.Cesar(zprava, posun * (-1));

                        Console.WriteLine();
                        Console.WriteLine("------------------------");
                        Console.WriteLine($"Dešifrovaná zpráva:");
                        Console.WriteLine(desifrovana);
                        Console.WriteLine("------------------------");
                        Console.Write("Chcete text uložit do souboru? Pokud ne, stiskňete Enter. Pokud ano, zadejte jméno souboru pro uložení: ");
                        string ulozeni = Console.ReadLine();
                        if (ulozeni != "") crypto.SaveText(desifrovana, ulozeni);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("---- Neplatný vstup pro posun!! ----");
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(" --- Neplatný vstup! --- ");
                    Console.WriteLine();
                }

                Console.WriteLine("-------------------------------------");
                Console.Write("Pokud si přejete pokračovat stiskněte 'Y': ");
                pokracovani = Console.ReadKey();
                Console.WriteLine();

            } while (pokracovani.Key == ConsoleKey.Y);


            Console.WriteLine();
            Console.WriteLine("----------- Pro ukončení stiskni Enter -----------");
            Console.ReadLine();
        }
    }
}

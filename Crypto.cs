using System.IO;

namespace Encryption
{
    partial class Program
    {
        class Crypto
        {
            public string XOR(string zprava, string klic)
            {
                string zasifrovana = "";
                zprava = NormalizedString(zprava);
                klic = NormalizedString(klic);

                for (int i = 0, j = 0; i < zprava.Length; i++, j++)
                {
                    if (j >= klic.Length) j = 0;

                    zasifrovana += (char)(zprava[i] ^ klic[j]);
                }

                return zasifrovana;
            }

            public string Cesar(string zprava, int posun)
            {
                string zasifrovana = ""; 
                zprava = NormalizedString(zprava);

                for (int i = 0; i < zprava.Length; i++)
                {
                    zasifrovana += (char)((int)zprava[i] + posun);
                }

                return zasifrovana;
            }

            public string SaveText(string text, string soubor)
            {
                if (soubor.Contains(".txt"))
                {
                    File.WriteAllText(soubor, text);
                    return "Soubor úspěšně uložen.";
                }

                return "Nastala chyba při ukládání!";
            }

            private string NormalizedString(string zprava)
            {
                string edited;

                edited = zprava.Replace(" ", "");
                edited = edited.Replace('Á', 'a');
                edited = edited.Replace('á', 'a');
                edited = edited.Replace('Č', 'c');
                edited = edited.Replace('č', 'c');
                edited = edited.Replace('Ď', 'd');
                edited = edited.Replace('ď', 'd');
                edited = edited.Replace('É', 'e');
                edited = edited.Replace('é', 'e');
                edited = edited.Replace('Ě', 'e');
                edited = edited.Replace('ě', 'e');
                edited = edited.Replace('Í', 'i');
                edited = edited.Replace('í', 'i');
                edited = edited.Replace('Ň', 'n');
                edited = edited.Replace('ň', 'n');
                edited = edited.Replace('Ó', 'o');
                edited = edited.Replace('ó', 'o');
                edited = edited.Replace('Ř', 'r');
                edited = edited.Replace('ř', 'r');
                edited = edited.Replace('Š', 's');
                edited = edited.Replace('š', 's');
                edited = edited.Replace('Ť', 't');
                edited = edited.Replace('ť', 't');
                edited = edited.Replace('Ú', 'u');
                edited = edited.Replace('ú', 'u');
                edited = edited.Replace('Ů', 'u');
                edited = edited.Replace('ů', 'u');
                edited = edited.Replace('Ý', 'y');
                edited = edited.Replace('ý', 'y');
                edited = edited.Replace('Ž', 'z');
                edited = edited.Replace('ž', 'z');
                                             
                edited = edited.ToUpper();

                return edited;
            }
        }
    }
}

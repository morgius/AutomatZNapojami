using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatZNapojami
{
    public class Automat
    {
        public List<Napoj> Napoje { get; set; }
        public static double Balans { get; set; }
        public double DoZaplaty { get; set; }
        private string NazwaNapoju { get; set; }
        public Automat(List<Napoj> lista,double balans)
        {
            if (lista == null || lista.Count == 0)
            {
                throw new ArgumentNullException("Automat jest pusty.");
            }
            Napoje = lista;
            Balans = balans;
        }
        public bool CzyDostepny(string nazwaNapoju, Rozmiar rozmiar)
        {
            NazwaNapoju = $"{nazwaNapoju}, {rozmiar}";
            bool czyDostepny = false;
            foreach (var item in Napoje)
            {
                if (item.Rozmiar == rozmiar && item.Nazwa == nazwaNapoju)
                {
                    Napoje.Remove(item);
                    DoZaplaty = item.Cena;
                    czyDostepny = true;
                    break;
                }
            }
            return czyDostepny;
        }
        public void Zaplac(double cena)
        {
            do
            {
                Console.WriteLine($"Do zapłaty:{cena.ToString("c")}");
                bool wrzuconoMonete;
                do
                {
                    Console.WriteLine("Wrzuć monetę:\n1 - 5zł\n2 - 2xł\n3 - 1zł\n4 - 50gr\n5 - 20gr\n6 - 10gr");
                    var keyInput = Console.ReadKey();
                    wrzuconoMonete = (keyInput.Key == ConsoleKey.D1) || (keyInput.Key == ConsoleKey.D2) || (keyInput.Key == ConsoleKey.D3) ||
                                      (keyInput.Key == ConsoleKey.D4) || (keyInput.Key == ConsoleKey.D5) || (keyInput.Key == ConsoleKey.D6);
                    switch (keyInput.Key)
                    {
                        case ConsoleKey.D1:
                            cena -= 5;
                            break;
                        case ConsoleKey.D2:
                            cena -= 2;
                            break;
                        case ConsoleKey.D3:
                            cena -= 1;
                            break;
                        case ConsoleKey.D4:
                            cena -= 0.5;
                            break;
                        case ConsoleKey.D5:
                            cena -= 0.2;
                            break;
                        case ConsoleKey.D6:
                            cena -= 0.1;
                            break;
                    }
                    
                    Console.Clear();
                } while (!wrzuconoMonete);
            } while (cena > 0);
            if (cena == 0)
            {
                Console.WriteLine($"Wydano {NazwaNapoju}\nDziekujemy za zakupy");
                Balans += cena;
            }
            else if (cena < 0 && -cena<Balans)
            {
                Console.WriteLine($"Zwrot reszty {-cena}zł");
                Console.WriteLine($"Wydano {NazwaNapoju}.\nDziekujemy za zakupy");
                Balans += cena;
            }
            else
            {
                Console.WriteLine("Nie można wydać reszty");
            }
        }
        public  string WybierzNapoj()
        {
            bool wybranoNapoj;
            string wynik = "";
            do
            {
                Console.WriteLine("Wybierz produkt:\nS - Sok\nW - Woda\nC - Cola");
                var keyInput = Console.ReadKey();
                wybranoNapoj = (keyInput.Key == ConsoleKey.S) || (keyInput.Key == ConsoleKey.W) || (keyInput.Key == ConsoleKey.C);
                switch (keyInput.Key)
                {
                    case ConsoleKey.S:
                        wynik = "Sok";
                        break;
                    case ConsoleKey.W:
                        wynik = "Woda";
                        break;
                    case ConsoleKey.C:
                        wynik = "Cola";
                        break;
                }
                Console.Clear();
            } while (!wybranoNapoj);
            return wynik;
        }
        public Rozmiar WybierzRozmiar()
        {
            bool wybranoRozmiar;
            Rozmiar wynik = Rozmiar.duży;
            do
            {
                Console.WriteLine("Wybierz rozmiar:\n1 - Duży\n2 = Mały");
                var keyInput = Console.ReadKey();
                wybranoRozmiar = (keyInput.Key == ConsoleKey.D1) || (keyInput.Key == ConsoleKey.D2);
                switch (keyInput.Key)
                {
                    case ConsoleKey.D1:
                        wynik = Rozmiar.duży;
                        break;
                    case ConsoleKey.D2:
                        wynik = Rozmiar.mały;
                        break;
                }
                Console.Clear();
            } while (!wybranoRozmiar);
            return wynik;
        }
    }
}

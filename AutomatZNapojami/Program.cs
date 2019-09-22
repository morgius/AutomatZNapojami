using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatZNapojami
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Napoj> napoje = new List<Napoj>
            {
                new Sok(Rozmiar.duży),
                new Sok(Rozmiar.mały),
                new Sok(Rozmiar.duży),
                new Woda(Rozmiar.duży),
                new Woda(Rozmiar.mały),
                new Woda(Rozmiar.duży),
                new Woda(Rozmiar.duży),
                new Woda(Rozmiar.duży),
                new Cola(Rozmiar.mały),
            };
                    
            Automat automat = new Automat(napoje,2);
            
            do
            {
                if (automat.CzyDostepny(automat.WybierzNapoj(), automat.WybierzRozmiar()))
                {
                    automat.Zaplac(automat.DoZaplaty);
                }
                else
                {
                    Console.WriteLine("Brak wybranego napoju");
                }
                Console.WriteLine("Aby kontynuować zakupy, wciśnij dowolny klawisz.Aby zakończyć, wciśnij 'ESC'");
                var input = Console.ReadKey();
                if (input.Key == ConsoleKey.Escape)
                {
                    return;
                }
            } while (napoje.Count != 0);
            Console.WriteLine("Automat jest pusty.");



            Console.ReadLine();
        }
       
    }
}

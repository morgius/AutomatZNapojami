using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatZNapojami
{
    public class Sok:Napoj
    {
        public Sok(Rozmiar rozmiar)
        {
            Rozmiar = rozmiar;
            if (rozmiar == Rozmiar.duży)
                Cena = 1.5;
            else
                Cena = 1;
            Nazwa = "Sok";
        }
    }
}

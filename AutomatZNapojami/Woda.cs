using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatZNapojami
{
    class Woda:Napoj
    {
        public Woda(Rozmiar rozmiar)
        {
            Rozmiar = rozmiar;
            if (rozmiar == Rozmiar.duży)
                Cena = 0.7;
            else
                Cena = 0.5;
            Nazwa = "Woda";
        }
    }
}

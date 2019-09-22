using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatZNapojami
{
    public class Cola:Napoj
    {
        public Cola(Rozmiar rozmiar)
        {
            Rozmiar = rozmiar;
            if (rozmiar == Rozmiar.duży)
                Cena = 2.5;
            else
                Cena = 2;
            Nazwa = "Cola";
        }
    }
}

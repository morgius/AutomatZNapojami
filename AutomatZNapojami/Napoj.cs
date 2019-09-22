using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatZNapojami
{
    public enum Rozmiar
    {
        mały,
        duży
    }
    public abstract class Napoj
    {
        public Rozmiar Rozmiar;
        public string Nazwa { get; set; }
        public double Cena { get; set; }
    }
}

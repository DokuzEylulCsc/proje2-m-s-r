using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class Oda
    {
        bool TV = false;
        bool Minibar = false;
        bool Klima = false;
        bool DenizManzarasi = false;
        int fiyat;
        Odatipi type;
        Otel otel;

        public Oda(int fiya, Odatipi tip, Otel ote)
        {
            this.fiyat = fiya;
            this.type = tip;
            this.otel = ote;
        }


        public bool tv
        {
            get { return TV; }
            set { TV = value; }
        }
        public bool minibar
        {
            get { return Minibar; }
            set { Minibar = value; }
        }
        public bool klima
        {
            get { return Klima; }
            set { Klima = value; }
        }
        public bool denizmanzarasi
        {
            get { return DenizManzarasi; }
            set { DenizManzarasi = value; }
        }
    }
}

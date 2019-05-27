using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevTaslak
{
    class Rezarvasyon
    {
        static int RezarvasyonSayisi;
        private bool balkonuVar;
        private bool denizVar;
        private bool kralOdasi;
        private DateTime Baslangic;
        private DateTime Bitis;
        private int kisisayisi;

        public bool BalkonuVar { get => balkonuVar; set => balkonuVar = value; }
        public bool DenizVar { get => denizVar; set => denizVar = value; }
        public bool KralOdasi { get => kralOdasi; set => kralOdasi = value; }
    }
}

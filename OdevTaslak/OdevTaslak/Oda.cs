using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevTaslak
{
    abstract class Oda:RezarvasyonIslemleri
    {
        private int odano;
        private bool balkonuVar;
        private bool denizVar;
        private bool kralOdasi;
        private int yatakSayisi;
        private int kapasite;

        public int Odano { get => odano; set => odano = value; }
        public bool BalkonuVar { get => balkonuVar; set => balkonuVar = value; }
        public bool DenizVar { get => denizVar; set => denizVar = value; }
        public bool KralOdasi { get => kralOdasi; set => kralOdasi = value; }

        public bool RezarvasyonIptalEt()
        {
            throw new NotImplementedException();
        }

        public void RezarvasyonListele()
        {
            throw new NotImplementedException();
        }

        public int RezarvasyonYap()
        {
            throw new NotImplementedException();
        }

        protected abstract void KapasiteOlustur();
    }
}

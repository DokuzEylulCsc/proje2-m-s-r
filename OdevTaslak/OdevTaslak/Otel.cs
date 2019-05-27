using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevTaslak
{
    class Otel : RezarvasyonIslemleri
    {
        private string oteladi;
        private int odasayisi;
        private int otelyıldız;

        public string Oteladi { get => oteladi; set => oteladi = value; }
        public int Odasayisi { get => odasayisi; set => odasayisi = value; }
        public int Otelyıldız { get => otelyıldız; set => otelyıldız = value; }

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
    }
}

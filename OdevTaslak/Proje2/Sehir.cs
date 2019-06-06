using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class Sehir
    {
        string sehiradi;
       public List<Otel> otels = new List<Otel>();

        public Sehir(string adi)
        {
            this.sehiradi = adi;
        }
        public string sehirismi
        {
            get { return sehiradi; }

        }

    }
}

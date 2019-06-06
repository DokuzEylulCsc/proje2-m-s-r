using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class Otel
    {
        int yildiz;
        string oteladi;
        Sehir sehir;
        public Otel(int  star, string adi, Sehir il)
        {
            this.yildiz = star;
            this.oteladi = adi;
            this.sehir = il;
        }
        public int  yildizz
        {
            get { return yildiz; }
        }
        public string otelismi
        {
            get { return oteladi; }

        }
        

       
          
            
      


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class Otel
    {
        public List<Oda> odas = new List<Oda>();
        int yildiz;
        string oteladi;
        Sehir sehir;
        Oteltipi tip;
        public Otel(int  star, string adi, Sehir il, Oteltipi type)
        {
            this.yildiz = star;
            this.oteladi = adi;
            this.sehir = il;
            this.tip = type;
        }
        public int  yildizz
        {
            get { return yildiz; }
        }
        public string otelismi
        {
            get { return oteladi; }

        }
        public Oteltipi oteltipi
        {
            get { return oteltipi; }
        }
        

       
          
            
      


    }
}

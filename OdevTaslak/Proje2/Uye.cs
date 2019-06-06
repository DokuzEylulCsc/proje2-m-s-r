using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class Uye
    {
        int Id;
        string adsoyad;
        public int No
        {
            get { return Id; }
        }
        public string isim
        {
            get { return adsoyad; }
            set { adsoyad = value; }
        }

        public Uye(string ad, int id)
        {
            this.adsoyad = ad;
            this.Id = id;
        }
            
    }
}

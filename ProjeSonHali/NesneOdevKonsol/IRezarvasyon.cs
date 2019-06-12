using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdevKonsol
{
    interface IRezarvasyon
    {
        int rezervasyonYap(Rezervasyon rev);
        bool RezarvasyonIptalEt(int id);
        void RezarvasyonListele();
    }
}

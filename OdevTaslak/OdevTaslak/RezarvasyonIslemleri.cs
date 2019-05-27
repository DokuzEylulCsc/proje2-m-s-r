using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevTaslak
{
    interface RezarvasyonIslemleri
    {
        int RezarvasyonYap();
        void RezarvasyonListele();
        bool RezarvasyonIptalEt();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdevKonsol
{
    class IkiYatakli : Oda
    {
        public IkiYatakli(int no) : base(no)
        {
        }

        public IkiYatakli(int no, bool balkonuVar) : base(no, balkonuVar)
        {
        }

        public IkiYatakli(int no, bool balkonuVar, bool denizManzaraVar) : base(no, balkonuVar, denizManzaraVar)
        {
        }

        public IkiYatakli(int no, bool balkonuVar, bool denizManzaraVar, bool minibarVar) : base(no, balkonuVar, denizManzaraVar, minibarVar)
        {
            CreateCapacity();
        }

        protected override void CreateCapacity()
        {
            kapasite = 2;
            yatakSayi = 2;
            tekYatakSayi = 2;
            ciftYatakSayi = 0;
        }
    }
}

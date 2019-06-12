using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdevKonsol
{
    class IkiKisilik : Oda
    {
        public IkiKisilik(int no) : base(no)
        {
            CreateCapacity();
        }
        public IkiKisilik(int no, bool balkonuVar) : base(no, balkonuVar)
        {
            CreateCapacity();
        }
        public IkiKisilik(int no,bool balkonuVar,bool denizManzaraVar): base(no,balkonuVar,denizManzaraVar)
        {
            CreateCapacity();
        }

        public IkiKisilik(int no, bool balkonuVar, bool denizManzaraVar, bool minibarVar) : base(no, balkonuVar, denizManzaraVar, minibarVar)
        {
            CreateCapacity();
        }

        protected override void CreateCapacity()
        {
            kapasite = 2;
            yatakSayi = 1;
            tekYatakSayi = 0;
            ciftYatakSayi = 1;
        }
    }
}

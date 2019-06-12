using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdevKonsol
{
    class TekKisilik : Oda
    {
        public TekKisilik(int no) : base(no)
        {
            CreateCapacity();
        }

        public TekKisilik(int no, bool balkonuVar) : base(no, balkonuVar)
        {
            CreateCapacity();
        }

        public TekKisilik(int no, bool balkonuVar, bool denizManzaraVar) : base(no, balkonuVar, denizManzaraVar)
        {
            CreateCapacity();
        }

        public TekKisilik(int no, bool balkonuVar, bool denizManzaraVar, bool minibarVar) : base(no, balkonuVar, denizManzaraVar, minibarVar)
        {
            CreateCapacity();
        }

        protected override void CreateCapacity()
        {
            kapasite = 1;
            yatakSayi = 1;
            tekYatakSayi = 1;
            ciftYatakSayi = 0;
        }
    }
}

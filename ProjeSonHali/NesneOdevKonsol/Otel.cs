using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdevKonsol
{
    class Otel:IRezarvasyon
    {
        private string otelAdi; //Otel adi
        private int odaSayisi; //Otel oda sayisi
        Oda[] odalar;
        
        public Otel(string adi,int sayisi)
        {
            otelAdi = adi;
            odaSayisi = sayisi;
            odalar = new Oda[odaSayisi];
            odaYarat(odaSayisi);
        }

        public string OtelAdi { get => otelAdi;}
        public int OdaSayisi { get => odaSayisi;}

        public bool RezarvasyonIptalEt(int id)
        {
            bool ch = false;
            foreach (Oda a in odalar)
            {
                ch = a.RezarvasyonIptalEt(id); //İptal sağlanırsa true dönüyor.
                if (ch) break;
            }
            return ch;
        }

        public void RezarvasyonListele()
        {
            foreach (Oda a in odalar)
            {
                a.RezarvasyonListele();
            }
        }

        public int rezervasyonYap(Rezervasyon rev)
        {
            int ch = -1;
            foreach (Oda a in odalar) //Her odaya rezervasyon için başvuruluyor
            {
                ch = a.rezervasyonYap(rev); //Oda ilgili rezervasyon için musaitse oda nosunu değilse -1
                if (ch > -1) break;
            }
            return ch;
        }

        private void odaYarat(int n) //Otelin tüm odalarının oluşturulduğu fonksiyon
        {
            for (int i = 0; i <n; i++)
            {
                bool balkon;
                bool deniz;
                bool bar;
                string inp;
                Console.WriteLine("{0} nolu oda oluşuturuluyor.", i+1);
                Console.WriteLine("Balkon (1:evet,2:hayir)");
                inp = Console.ReadLine();
                balkon = (inp == "1") ? true : false;
                Console.WriteLine("Deniz Manzarası (1:evet,2:hayir)");
                inp = Console.ReadLine();
                deniz = (inp == "1") ? true : false;
                Console.WriteLine("Mini Bar (1:evet,2:hayir)");
                inp = Console.ReadLine();
                bar = (inp == "1") ? true : false;
                Console.WriteLine("Oda Tipi (1:TekKisilik ,2:IkiKisilik ,3:IkiYatakli)");
                inp = Console.ReadLine();
                switch (inp)
                {
                    case "1":
                        odalar[i] = new TekKisilik(i, balkon, deniz,bar);
                        break;
                    case "2":
                        odalar[i] = new IkiKisilik(i, balkon, deniz,bar);
                        break;
                    case "3":
                        odalar[i] = new IkiYatakli(i, balkon, deniz,bar);
                        break;
                }
            }
        }
    }
}

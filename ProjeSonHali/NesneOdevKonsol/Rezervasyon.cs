using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdevKonsol
{
    class Rezervasyon:IComparable<Rezervasyon>
    {
        private static int rezervasyonSayisi = 0;
        private int rezarve_sayi; //rezervasyon numaraıs
        private int kisiSayi; //kişi sayisi
        private Type odaTipi; //Oda tipi
        private bool balkonuVar; //Balkon varmı?
        private bool denizManzaraVar; //Deniz manzarılı mi?
        private bool minibarVar;//Minibar var mı?
        private DateTime baslangic; //Başlangıç tarihi
        private DateTime bitis; //Bitiş tarihi

        public Rezervasyon(int kisisayisi, Type odatipi, bool balkonlu, bool denizli,bool minibarli,DateTime bslngc,DateTime bits)
        {
            if ((bslngc - bitis).TotalHours > 0) //Başlangıç > Bitiş tarihi ise yeniden tarhileri soruyor.
            {
                baslangic = bslngc;
                bitis = bits;
            }
            else
            {
                askNewDate();
            }
            kisiSayi = kisisayisi;
            odaTipi = odatipi;
            balkonuVar = balkonlu;
            denizManzaraVar = denizli;
            minibarVar = minibarli;
            rezervasyonSayisi++;
            rezarve_sayi = rezervasyonSayisi;
        }
        private void askNewDate() //Yeniden tarihleri sorma
        {
            Console.WriteLine("Başlangıç tarihi giriniz (e.g. 12/06/2019): ");
            DateTime sDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Bitiş tarihi giriniz (e.g. 13/06/2019): ");
            DateTime eDate = DateTime.Parse(Console.ReadLine());
            if ((eDate - sDate).TotalHours > 0)
            {
                baslangic = sDate;
                bitis = eDate;
            }
            else
            {
                askNewDate();
            }

        }

        public int KisiSayi { get => kisiSayi; }
        public Type OdaTipi { get => odaTipi; }
        public bool BalkonuVar { get => balkonuVar; }
        public bool DenizManzaraVar { get => denizManzaraVar; }
        public DateTime Baslangic { get => baslangic; }
        public DateTime Bitis { get => bitis;}
        public int Rezarve_sayi { get => rezarve_sayi; }
        public bool MinibarVar { get => minibarVar; }

        public int CompareTo(Rezervasyon other)
        {
            return baslangic.CompareTo(other.baslangic);
        }
    }
}

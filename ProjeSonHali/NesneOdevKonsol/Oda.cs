using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdevKonsol
{
    internal abstract class Oda : IRezarvasyon
    {
        private int no; //Oda no
        private ArrayList rezervasyonlar; //Odaya ait rezervasyonlar
        private bool balkonuVar; //Balkonu var mi
        private bool denizManzaraVar; //Deniz manzaralımı
        private bool minibarVar;//minibar olması
        protected int kapasite; //kapasite
        protected int yatakSayi; //Yatak sayisi
        protected int tekYatakSayi; //Tek yatak sayisi
        protected int ciftYatakSayi; //Çift yatak sayisi

        public int No { get => no; }
        public ArrayList Rezervasyonlar { get => rezervasyonlar; set => rezervasyonlar = value; }
        public bool BalkonuVar { get => balkonuVar; set => balkonuVar = value; }
        public bool DenizManzaraVar { get => denizManzaraVar; set => denizManzaraVar = value; }
        public bool MinibarVar { get => minibarVar; set => minibarVar = value; }

        public Oda(int no) //olusturucu method
        {
            this.no = no;
            rezervasyonlar = new ArrayList();
            balkonuVar = false;
            denizManzaraVar = false;
        }

        public Oda(int no, bool balkonuVar) //Oluşturucu metod overload
        {
            this.no = no;
            rezervasyonlar = new ArrayList();
            this.balkonuVar = balkonuVar;
            denizManzaraVar = false;
        }
        public Oda(int no, bool balkonuVar, bool denizManzaraVar) //Oluşturucu metod overload
        {
            this.no = no;
            rezervasyonlar = new ArrayList();
            this.balkonuVar = balkonuVar;
            this.denizManzaraVar = denizManzaraVar;
        }
        public Oda(int no, bool balkonuVar, bool denizManzaraVar, bool minibarVar)
        {
            this.no = no;
            rezervasyonlar = new ArrayList();
            this.balkonuVar = balkonuVar;
            this.denizManzaraVar = denizManzaraVar;
            this.minibarVar = minibarVar;
        }

        protected abstract void CreateCapacity();

        public int rezervasyonYap(Rezervasyon rev) //odaya rezervasyon yapma
        {
            bool check = true;
            if (this.GetType() == rev.OdaTipi)
            {
                foreach (Rezervasyon a in rezervasyonlar)
                {
                    if (a.Baslangic < rev.Bitis && rev.Baslangic < a.Bitis) //Daha önce yapılan rezervasyonların tarihleri ile kıyaslanıyor.
                    {
                        check = false;
                        break;
                    }

                }
                if (check)
                {
                    if (this.kapasite < rev.KisiSayi || this.denizManzaraVar != rev.DenizManzaraVar || this.balkonuVar != rev.BalkonuVar || this.minibarVar != rev.MinibarVar) //oda rezervasyonda istenen özellikleri kontrol
                    {
                        check = false;
                    }
                }
            }
            else
                check = false;
            if (check)
            {
                rezervasyonlar.Add(rev); //Rezervasyonu ekle
                return this.No;
            }
            else
            {
                return -1;
            }

        }
        public bool RezarvasyonIptalEt(int id) //Verilenrezervasyon bu oda ise iptal eder değilse false döndürür.
        {
            bool ch = false;
            foreach (Rezervasyon a in rezervasyonlar)
            {
                if (id == a.Rezarve_sayi)
                {
                    rezervasyonlar.Remove(a);
                    ch = true;
                    break;
                }
            }
            return ch;
        }
        public void RezarvasyonListele() //Odaya ait tüm rezervasyonları döndürür.
        {

            Rezervasyon[] ress = (Rezervasyon[])Rezervasyonlar.ToArray(typeof(Rezervasyon));
            Array.Sort(ress); //Rezervasyonarın başlangıç tarihlerine göre sıralar
            foreach (Rezervasyon a in ress)
            {
                Console.WriteLine("Oda No:{0} Oda Tipi:{1} Rezervasyon No:{2} Rezervasyon Başlangıç Tarihi:{3} Rezervasyon Bitiş Tarihi:{4} ", this.No, this.GetType().Name, a.Rezarve_sayi, a.Baslangic.ToShortDateString(), a.Bitis.ToShortDateString());
            }

        }
    }
}

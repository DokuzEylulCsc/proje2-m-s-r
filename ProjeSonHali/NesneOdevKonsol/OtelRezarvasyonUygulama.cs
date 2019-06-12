using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdevKonsol
{
    class OtelRezarvasyonUygulama
    {
        private Otel otel;
        public OtelRezarvasyonUygulama()
        {
            int odasayisi = 3;
            otel = new Otel("Otel", odasayisi);
            YoneticiKontrol();
            //AnaFonksiyon();
        }
        //private void AnaFonksiyon() //Ana ekran
        //{
        //    string select;
        //    do
        //    {
        //        Console.WriteLine("Rezervasyon yapmak için(1) \nRezervasyon iptali için(2) \nTüm rezervasyonları listelemek için(3) \nÇıkmak için(4)");
        //        select = Console.ReadLine();
        //        switch (select)
        //        {
        //            case "1": RezarvasyonYap(); break;
        //            case "2": RezarvasyonIptalEt(); break;
        //            case "3": RezarvasyonListele(); break;
        //            case "4": Console.WriteLine("Otelimizi tercih ettiğiniz için teşşekür ederiz.Yine bekleriz."); break;
        //            default: Console.WriteLine("Yanlış giriş yaptınız.Lütfen tekrar giriniz."); break;

        //        }
        //    } while (select != "4");
        //}
        private void RezarvasyonYap() //Rezervasyon yaratıp otele gönderiyor
        {
            Console.WriteLine("Konuk sayini giriniz: ");
            int k_s = int.Parse(Console.ReadLine());
            Console.WriteLine("Balkon (1:evet,2:hayir)");
            string inp = Console.ReadLine();
            bool balkon = (inp == "1") ? true : false;
            Console.WriteLine("Deniz Manzarası (1:evet,1:hayir)");
            inp = Console.ReadLine();
            bool deniz = (inp == "1") ? true : false;
            Console.WriteLine("Mini Bar (1:evet,2:hayir)");
            inp = Console.ReadLine();
            bool bar = (inp == "1") ? true : false;
            Console.WriteLine("Oda Tipi (1:TekKisilik,2:IkiKisilik,3:IkiYatakli)");
            inp = Console.ReadLine();
            Type tip = null;
            switch (inp)
            {
                case "1":
                    tip = typeof(TekKisilik);
                    break;
                case "2":
                    tip = typeof(IkiKisilik);
                    break;
                case "3":
                    tip = typeof(IkiYatakli);
                    break;
            }

            Console.WriteLine("Başlangıç tarihi giriniz (e.g. 12/06/2019): ");
            DateTime sDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Bitiş tarihi giriniz (e.g. 13/06/2019): ");
            DateTime eDate = DateTime.Parse(Console.ReadLine());
            Rezervasyon rev = new Rezervasyon(k_s, tip, balkon, deniz, bar, sDate, eDate);
            int r_n = otel.rezervasyonYap(rev);
            if (r_n > -1) Console.WriteLine("Rezervasyonunuz {0}. nolu odaya yapıldı! Rezervasyon Numranız: {1} ", r_n, rev.Rezarve_sayi);
            else Console.WriteLine("Üzgünüz aradığınız kriterlere uygun odamız bulunmamaktadır.");
        }
        private void RezarvasyonIptalEt() //Otele rezervasyon iptal talebi gönderiyor
        {
            Console.WriteLine("İptel etmek istediğiniz rezervasyonun rezervasyon numarasını giriniz:");
            int id = int.Parse(Console.ReadLine());
            bool result = otel.RezarvasyonIptalEt(id);
            if (result)
                Console.WriteLine("Rezervasyonunuz iptal edildi.");
            else
                Console.WriteLine("Rezervasyon numarasına ait aktif bir rezarvasyon bulunamadı.");
        }
        private void RezarvasyonListele() //Otelin tüm rezervasonyoları listeliyor.
        {
            otel.RezarvasyonListele();
        }

        private void YoneticiKontrol()
        {
            Console.WriteLine("Musteri Girisi İcin Kullanici Adina(x) Sifresine(x) Yaziniz ");

            Console.WriteLine("Id Giriniz");
            string k_id = Console.ReadLine();
            Console.WriteLine("Sifre Giriniz");
            string s_sifre = Console.ReadLine();
            Yonetici y = new Yonetici(k_id, s_sifre);
            if (y.KontrolEt() == true)
            {
                Console.WriteLine("Yonetici Girisi Yaptiniz");
                string select;
                do
                {
                    Console.WriteLine("Tüm rezervasyonları listelemek için(1) \nRezervasyon iptali için(2) \nÇıkmak için(3)");
                    select = Console.ReadLine();
                    switch (select)
                    {
                        case "1": RezarvasyonListele(); break;
                        case "2": RezarvasyonIptalEt(); break;
                        case "3": Console.WriteLine("Otelimizi tercih ettiğiniz için teşşekür ederiz.Yine bekleriz."); break;
                        default: Console.WriteLine("Yanlış giriş yaptınız.Lütfen tekrar giriniz."); break;

                    }
                } while (select != "3");
            }
            else
            {
                Console.WriteLine("Musteri Girisi Yapliyor");
                string select;
                do
                {
                    Console.WriteLine("Rezervasyon yapmak için(1) \nRezervasyon iptali için(2) \nÇıkmak için(3)");
                    select = Console.ReadLine();
                    switch (select)
                    {
                        case "1": RezarvasyonYap(); break;
                        case "2": RezarvasyonIptalEt(); break;
                        case "3": Console.WriteLine("Otelimizi tercih ettiğiniz için teşşekür ederiz.Yine bekleriz."); break;
                        default: Console.WriteLine("Yanlış giriş yaptınız.Lütfen tekrar giriniz."); break;

                    }
                } while (select != "3");
            }
        }
    }
}

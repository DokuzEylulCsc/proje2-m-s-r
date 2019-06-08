using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class P
    {
        int uyeno = 0;
        public void basla()
        {
            List<Sehir> sehirs = new List<Sehir>(); // şehr listesi
            sehirs.Add(new Sehir("Istanbul"));
            sehirs.Add(new Sehir("Izmir"));
            sehirs.Add(new Sehir("Ankara"));
            sehirs.Add(new Sehir("Aydin"));
            List<Oteltipi> oteltipis = new List<Oteltipi>(); //otel tipi listesi oluşturulup dolduruldu.
            List<Odatipi> odatipis = new List<Odatipi>(); //oda tipi listesi oluşturulup dolduruldu.
            oteltipis.Add(new Oteltipi("Butik Otel"));
            oteltipis.Add(new Oteltipi("Apart Otel"));
            oteltipis.Add(new Oteltipi("Tatil Köyü"));
            odatipis.Add(new Odatipi("Tek Kişilik"));
            odatipis.Add(new Odatipi("Çift Kişilik"));
            odatipis.Add(new Odatipi("İkiz Yataklı Çift Kişilik"));
            odatipis.Add(new Odatipi("Üç Kişilik"));




            List<Uye> musteri = new List<Uye>();
            List<Uye> yonetici = new List<Uye>();
        UYE:
            Console.WriteLine("Uye ekle (1) \nUye girisi (2)"); //Uyelik işlemleri
            int sayi = int.Parse(Console.ReadLine());
            switch (sayi)
            {
                case 1:
                    {
                        Console.WriteLine("Yonetici ekle (1) \nUye ekle(2)"); //Eklenecek üyenin müşteri mi yoksa yönetici mi olduğu seçilir
                        sayi = int.Parse(Console.ReadLine());
                        switch (sayi)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Eklenecek yonetici adini girin"); //yöneticiyse isimm aldırılıp uniqe id ekrana yazdırılır.
                                    string isim = Console.ReadLine();
                                    yonetici.Add(new Uye(isim, uyeno));
                                    Console.WriteLine("Uye idniz: " + uyeno + ". Lütfen kaybetmeyiniz.");
                                    uyeno++;
                                    goto UYE;

                                }
                            case 2:
                                {
                                    Console.WriteLine("Eklenecek uye adini girin"); //müşteriyse isimm aldırılıp uniqe id ekrana yazdırılır.
                                    string isim = Console.ReadLine();
                                    musteri.Add(new Uye(isim, uyeno));
                                    Console.WriteLine("Uye idniz: " + uyeno + ". Lütfen kaybetmeyiniz.");
                                    uyeno++;
                                    goto UYE;
                                }
                            default:
                                {
                                    Console.WriteLine("Yanlis giris yaptiniz"); //yanlış giriş yapılırsa
                                    Console.ReadKey();
                                    goto UYE;
                                }
                        }
                    }
                case 2:
                    {
                        Console.WriteLine("Uye id girin"); //Giriş yapmak için üye id girilir.
                        sayi = int.Parse(Console.ReadLine());
                        bool buldum1 = false;
                        bool buldum2 = false;
                        int i = 0;
                        for (i = 0; i < yonetici.Count; i++) //üye id ye göre teker teker müşteri listesine ve yönetici listesine bakılır.
                        {
                            if (yonetici[i].No == sayi)
                            {
                                buldum1 = true;
                                Console.ReadKey();
                                break;
                            }
                        }
                        if (buldum1 == false)
                        {
                            for (i = 0; i < musteri.Count; i++)
                            {
                                if (musteri[i].No == sayi)
                                {
                                    buldum2 = true;
                                    break;
                                }
                            }
                        }
                        if (buldum2 == false && buldum1 == false) //eğer id bulunamazsa tekrar üyelik ekranına dönülür.
                        {
                            Console.WriteLine("Girilen id ye ait üye bulunamadı.");
                            Console.ReadKey();
                            goto UYE;
                        }
                        else
                        {
                            if (buldum1 == true) // eğer üye id yönetici listesinde bulunuşsa
                            {
                            YGIRIS:
                                Console.WriteLine("Hosgeldiniz " + yonetici[i].isim);
                                Console.WriteLine("Adinizi degistirmek icin (1) \nDevam icin (2)\nÇıkış (3)");
                                sayi = int.Parse(Console.ReadLine());
                                if (sayi == 1)
                                {
                                    Console.WriteLine("Yeni adi giriniz"); //isim değiştirme işlemleri
                                    string isim = Console.ReadLine();
                                    yonetici[i].isim = isim;
                                    goto YGIRIS;
                                }
                                else if (sayi == 2)
                                {
                                //ekleme işlemleri
                                //listeleme işlemleri
                                ekle:
                                    Console.WriteLine("Eklemek icin (1) \nListeleme icin(2)\nCikis (3)");
                                    sayi = int.Parse(Console.ReadLine());
                                    if (sayi == 1)
                                    {
                                        Console.WriteLine("Sehir icin (1)\nOtel icin (2) \nOda icin (3)\nAna Menü"); 
                                        int rakam = int.Parse(Console.ReadLine());
                                        if (rakam == 1)
                                        {
                                            Console.WriteLine("Eklenecek Şehir Adını Giriniz."); //şehir ekleme
                                            string s_adi = Console.ReadLine();
                                            sehirs.Add(new Sehir(s_adi));
                                        }
                                        if (rakam == 2)
                                        {
                                            if (sehirs.Count > 0) //otel ekleme
                                            {
                                                for (int j = 0; j < sehirs.Count; j++)// şehir listesi ekrana yazdırılıp şehir seçimi istenir.
                                                {
                                                    Console.WriteLine(j + " " + sehirs[j].sehirismi);
                                                }
                                                Console.WriteLine("Eklenecek sehri secin");
                                                int sehirno = int.Parse(Console.ReadLine());
                                                if (sehirno < 0 || sehirno > sehirs.Count - 1)
                                                {
                                                    Console.WriteLine("Hatali giris yaptiniz");
                                                    goto ekle;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Yildiz sayisini giriniz 1-5"); // şehir seçildikten sonra yıldız sayısı girilmesi istenir.
                                                    int yildizsayisi = int.Parse(Console.ReadLine());
                                                    if (yildizsayisi >0 && yildizsayisi<6)
                                                    {
                                                        OYG:
                                                        for(int j=0;j<oteltipis.Count;j++) //yıldız sayısından sonra otelin tipi seçilmesi istenir.
                                                        {
                                                            Console.WriteLine(j + ". " + oteltipis[j].tip);
                                                        }
                                                        Console.WriteLine("Otel tipini seçiniz.");
                                                        int oteltype = int.Parse(Console.ReadLine());
                                                        if(oteltype<0 || oteltype > oteltipis.Count-1)
                                                        {
                                                            Console.WriteLine("Yanlis giris yaptiniz.");
                                                            goto OYG;
                                                        }
                                                        Console.WriteLine("Eklenecek otel adini girin"); //otel adının girilmesi beklenir.
                                                        string oteladi = Console.ReadLine();
                                                        sehirs[sehirno].otels.Add(new Otel(yildizsayisi, oteladi, sehirs[sehirno], oteltipis[oteltype])); //her şey yolundaysa otel eklenir.
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Hatali giris yaptiniz");
                                                        goto ekle;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("hic sehir yok");
                                                goto ekle;
                                            }
                                        }
                                        if (rakam == 3) //oda ekleme
                                        {
                                            if (sehirs.Count > 0)
                                            {
                                                for (int j = 0; j < sehirs.Count; j++) //şehir listesi ekrana bastırılır.
                                                {
                                                    Console.WriteLine(j + " " + sehirs[j].sehirismi);

                                                }
                                                Console.WriteLine("Eklenecek sehri secin"); //şehir seçimi istenir.
                                                int sehirno = int.Parse(Console.ReadLine());
                                                if (sehirno < 0 || sehirno > sehirs.Count - 1)
                                                {
                                                    Console.WriteLine("Hatali giris yaptiniz");
                                                    goto ekle;
                                                }
                                                if (sehirs[sehirno].otels.Count > 0) //otel lstesi ekrana bastırılır.
                                                {
                                                    OOYG:
                                                    for (int t = 0; t < sehirs[sehirno].otels.Count; t++)
                                                    {
                                                        Console.WriteLine(sehirs[sehirno].otels[t].otelismi); //otel lstesi ekrana bastırılır.
                                                    }
                                                    Console.WriteLine("Otel numarasini secin"); //otel seçimi istenir.
                                                    int otelnumarasi = int.Parse(Console.ReadLine());
                                                    if(otelnumarasi<0 || otelnumarasi > sehirs[sehirno].otels.Count-1)
                                                    {
                                                        Console.WriteLine("Yanlış giriş yaptınız. Tekrar deneyin.");
                                                        goto OOYG;
                                                    }
                                                    odahg:
                                                    for(int j =0; j<odatipis.Count;j++) //oda tipleri ekrana bastılırılır.
                                                    {
                                                        Console.WriteLine(j + ". " + odatipis[j].tip);
                                                    }
                                                    int secim = int.Parse(Console.ReadLine());
                                                    if(secim<0 || secim >odatipis.Count-1)
                                                    {
                                                        Console.WriteLine("Yanlış giriş yaptınız. Tekrar deneyin.");
                                                        goto odahg;
                                                    }
                                                    Console.WriteLine("Oda fiyatını giriniz."); //eğer oda tipi seçilmişse oda fiyatı alınır.
                                                    int fiyat = int.Parse(Console.ReadLine());
                                                    sehirs[sehirno].otels[otelnumarasi].odas.Add(new Oda(fiyat, odatipis[secim], sehirs[sehirno].otels[otelnumarasi])); //her şey yolundaysa oda eklenir.
                                                    ozellikyg:
                                                    Console.WriteLine("Oda Eklendi. Odaya Özellik Eklemek İster Misiniz? e/h "); //odaya özellik eklenip eklenmeyeceği sorulur.
                                                    string ozellik = Console.ReadLine();
                                                    if(ozellik == "e" || ozellik == "E")
                                                    {
                                                    ozellikekle:
                                                        Console.WriteLine("TV(0), Minibar(1), Klima(2), Deniz Manzarası(3)\nLütfen seçim yapınız.");
                                                        int ozelliksecim = int.Parse(Console.ReadLine());
                                                        if(ozelliksecim==0)
                                                        {
                                                            sehirs[sehirno].otels[otelnumarasi].odas[sehirs[sehirno].otels[otelnumarasi].odas.Count - 1].tv = true;
                                                            
                                                            Console.WriteLine("Özellik Eklendi. Başka Ekle? e/h");
                                                            ozellik = Console.ReadLine();
                                                            if(ozellik == "e" || ozellik == "E")
                                                            {
                                                                goto ozellikekle;
                                                            }
                                                            else
                                                                goto ekle;
                                                            
                                                        }
                                                        else if (ozelliksecim == 1)
                                                        {
                                                            sehirs[sehirno].otels[otelnumarasi].odas[sehirs[sehirno].otels[otelnumarasi].odas.Count - 1].minibar = true;

                                                            Console.WriteLine("Özellik Eklendi. Başka Ekle? e/h");
                                                            ozellik = Console.ReadLine();
                                                            if (ozellik == "e" || ozellik == "E")
                                                            {
                                                                goto ozellikekle;
                                                            }
                                                            else
                                                                goto ekle;

                                                        }
                                                        else if (ozelliksecim == 0)
                                                        {
                                                            sehirs[sehirno].otels[otelnumarasi].odas[sehirs[sehirno].otels[otelnumarasi].odas.Count - 1].klima = true;

                                                            Console.WriteLine("Özellik Eklendi. Başka Ekle? e/h");
                                                            ozellik = Console.ReadLine();
                                                            if (ozellik == "e" || ozellik == "E")
                                                            {
                                                                goto ozellikekle;
                                                            }
                                                            else
                                                                goto ekle;

                                                        }
                                                        else if (ozelliksecim == 0)
                                                        {
                                                            sehirs[sehirno].otels[otelnumarasi].odas[sehirs[sehirno].otels[otelnumarasi].odas.Count - 1].denizmanzarasi = true;

                                                            Console.WriteLine("Özellik Eklendi. Başka Ekle? e/h");
                                                            ozellik = Console.ReadLine();
                                                            if (ozellik == "e" || ozellik == "E")
                                                            {
                                                                goto ozellikekle;
                                                            }
                                                            else
                                                                goto ekle;

                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Yanlış Giriş Yaptınız.");
                                                            goto ozellikekle;
                                                        }
                                                    }
                                                    else if(ozellik == "h" || ozellik == "H")
                                                    {
                                                        goto ekle;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Yanlış giriş yaptınız.");
                                                        goto ozellikyg;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Seçilen şehirde hiç otel yok.");
                                                    goto ekle;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Sehir yok");
                                                goto ekle;
                                            }
                                            

                                        }
                                        else
                                        {
                                            Console.WriteLine("YANLIS GIRIS!");
                                            Console.ReadKey();
                                            goto YGIRIS;
                                        }

                                        //YÖNETİCİ OLARAK GİRİŞ YAPILDIĞINDA DOLDURULACAK ALAN

                                    }
                                    else if(sayi==2)
                                    {
                                        Console.WriteLine("Yönetici Listeleme İşlemleri");
                                        Console.ReadKey();
                                    }
                                    else if(sayi == 3)
                                    {
                                        goto UYE;
                                    }
                                }
                                
                            }
                            else if (buldum2 == true)
                            {
                            UGIRIS:
                                Console.WriteLine("Hosgeldiniz " + musteri[i].isim);
                                Console.WriteLine("Adinizi degistirmek icin (1) \n devam icin (2)");
                                sayi = int.Parse(Console.ReadLine());
                                if (sayi == 1)
                                {
                                    Console.WriteLine("Yeni adi giriniz");
                                    string isim = Console.ReadLine();
                                    musteri[i].isim = isim;
                                }
                                else if (sayi == 2)
                                {
                                    //MÜŞTERİ OLARAK GİRİŞ YAPILDIĞINDA DOLDURULACAK ALAN
                                }
                                else
                                {
                                    Console.WriteLine("YANLIS GIRIS!");
                                    Console.ReadKey();
                                    goto UGIRIS;
                                }
                            }
                        }
                        break;
                    }
            }
        }
    }
}
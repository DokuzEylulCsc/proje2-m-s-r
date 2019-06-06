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
            List<Sehir> sehirs = new List<Sehir>();
            sehirs.Add(new Sehir("Istanbul"));
            sehirs.Add(new Sehir("Izmir"));
            sehirs.Add(new Sehir("Ankara"));
            sehirs.Add(new Sehir("Aydin"));





            List<Uye> musteri = new List<Uye>();
            List<Uye> yonetici = new List<Uye>();
        UYE:
            Console.WriteLine("Uye ekle (1) \nUye girisi (2)");
            int sayi = int.Parse(Console.ReadLine());
            switch (sayi)
            {
                case 1:
                    {
                        Console.WriteLine("Yonetici ekle (1) \nUye ekle(2)");
                        sayi = int.Parse(Console.ReadLine());
                        switch (sayi)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Eklenecek yonetici adini girin");
                                    string isim = Console.ReadLine();
                                    yonetici.Add(new Uye(isim, uyeno));
                                    Console.WriteLine("Uye idniz: " + uyeno + ". Lütfen kaybetmeyiniz.");
                                    uyeno++;
                                    goto UYE;

                                }
                            case 2:
                                {
                                    Console.WriteLine("Eklenecek uye adini girin");
                                    string isim = Console.ReadLine();
                                    musteri.Add(new Uye(isim, uyeno));
                                    Console.WriteLine("Uye idniz: " + uyeno + ". Lütfen kaybetmeyiniz.");
                                    uyeno++;
                                    goto UYE;
                                }
                            default:
                                {
                                    Console.WriteLine("Yanlis giris yaptiniz");
                                    Console.ReadKey();
                                    goto UYE;
                                }
                        }
                    }
                case 2:
                    {
                    YG:
                        Console.WriteLine("Uye id girin");
                        sayi = int.Parse(Console.ReadLine());
                        bool buldum1 = false;
                        bool buldum2 = false;
                        int i = 0;
                        for (i = 0; i < yonetici.Count; i++)
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
                        if (buldum2 == false && buldum1 == false)
                        {
                            Console.WriteLine("Atma Ziyaa");
                            Console.ReadKey();
                            goto YG;
                        }
                        else
                        {
                            if (buldum1 == true)
                            {
                            YGIRIS:
                                Console.WriteLine("Hosgeldiniz " + yonetici[i].isim);
                                Console.WriteLine("Adinizi degistirmek icin (1) \n devam icin (2)");
                                sayi = int.Parse(Console.ReadLine());
                                if (sayi == 1)
                                {
                                    Console.WriteLine("Yeni adi giriniz");
                                    string isim = Console.ReadLine();
                                    yonetici[i].isim = isim;
                                }
                                else if (sayi == 2)
                                {
                                //ekleme işlemleri
                                //listeleme işlemleri
                                ekle:
                                    Console.WriteLine("Eklemek icin (1) \n Listeleme icin(2)");
                                    sayi = int.Parse(Console.ReadLine());
                                    if (sayi == 1)
                                    {
                                        Console.WriteLine("Sehir icin (1)\nOtel icin (2) \nOda icin (3)");
                                        int rakam = int.Parse(Console.ReadLine());
                                        if (rakam == 1)
                                        {
                                            Console.WriteLine("Eklenecek Şehir Adını Giriniz.");
                                            string s_adi = Console.ReadLine();
                                            sehirs.Add(new Sehir(s_adi));
                                        }
                                        if (rakam == 2)
                                        {
                                            if (sehirs.Count > 0)
                                            {
                                                for (int j = 0; j < sehirs.Count; j++)
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
                                                    Console.WriteLine("Yildiz sayisini giriniz 1-5");
                                                    int yildizsayisi = int.Parse(Console.ReadLine());
                                                    if (yildizsayisi >0 && yildizsayisi<6)
                                                    {
                                                        Console.WriteLine("Eklenecek otel adini girin");
                                                        string oteladi = Console.ReadLine();
                                                        sehirs[sehirno].otels.Add(new Otel(yildizsayisi, oteladi, sehirs[sehirno]));
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

                                        if (rakam == 3)
                                        {
                                            if (sehirs.Count > 0)
                                            {

                                                for (int j = 0; j < sehirs.Count; j++)
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
                                                if (sehirs[sehirno].otels.Count > 0)
                                                {
                                                    for (int t = 0; t < sehirs[sehirno].otels.Count; t++)
                                                    {
                                                        Console.WriteLine(sehirs[sehirno].otels[t].otelismi);
                                                    }
                                                    Console.WriteLine("Otel numarasini secin");
                                                    int otelnumarasi = int.Parse(Console.ReadLine());

                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Sehir yok");
                                                goto ekle;
                                            }
                                            

                                        }


                                        //YÖNETİCİ OLARAK GİRİŞ YAPILDIĞINDA DOLDURULACAK ALAN

                                    }
                                    else
                                    {
                                        Console.WriteLine("YANLIS GIRIS!");
                                        Console.ReadKey();
                                        goto YGIRIS;
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
                        }
                        break;
                    }
            }
        }
    }
}
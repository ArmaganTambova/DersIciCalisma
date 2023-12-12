using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekOdevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Yemekler[] YemeklerDizisi = new Yemekler[40];

            Yemekler ymk1 = new Yemekler();
            ymk1.YemekIsmi = "Adana Kebap";
            ymk1.YemekTuru = "Kebap";
            ymk1.YemekSehiri = "Adana";
            YemeklerDizisi[0] = ymk1;


            Yemekler ymk2 = new Yemekler();
            ymk2.YemekIsmi = "Çiğ köfte";
            ymk2.YemekTuru = "Köfte";
            ymk2.YemekSehiri = "Adıyaman";
            YemeklerDizisi[1] = ymk2;

            Yemekler ymk3 = new Yemekler();
            ymk3.YemekIsmi = "Ankara Tava";
            ymk3.YemekTuru = "Pilav";
            ymk3.YemekSehiri = "Ankara";
            YemeklerDizisi[2] = ymk3;

            Yemekler ymk4 = new Yemekler();
            ymk4.YemekIsmi = "Antalya Piyazı";
            ymk4.YemekTuru = "salata";
            ymk4.YemekSehiri = "Antalya";
            YemeklerDizisi[3] = ymk4;

            Yemekler ymk5 = new Yemekler();
            ymk5.YemekIsmi = "Ayran Aşı";
            ymk5.YemekTuru = "Çorba";
            ymk5.YemekSehiri = "Ardahan";
            YemeklerDizisi[4] = ymk5;

            Yemekler ymk6 = new Yemekler();
            ymk6.YemekIsmi = "Kömbe";
            ymk6.YemekTuru = "Hamur işi";
            ymk6.YemekSehiri = "Bingöl";
            YemeklerDizisi[5] = ymk6;

            Yemekler ymk7 = new Yemekler();
            ymk7.YemekIsmi = "Oğmaç Çorbası";
            ymk7.YemekTuru = "Çorba";
            ymk7.YemekSehiri = "Bolu";
            YemeklerDizisi[6] = ymk7;

            Yemekler ymk8 = new Yemekler();
            ymk8.YemekIsmi = "İskender";
            ymk8.YemekTuru = "Kebap";
            ymk8.YemekSehiri = "Bursa";
            YemeklerDizisi[7] = ymk8;

            Yemekler ymk9 = new Yemekler();
            ymk9.YemekIsmi = "İskorpit Çorbası";
            ymk9.YemekTuru = "Çorba";
            ymk9.YemekSehiri = "Çanakkale";
            YemeklerDizisi[8] = ymk9;

            Yemekler ymk10 = new Yemekler();
            ymk10.YemekIsmi = "Tava Ciğer";
            ymk10.YemekTuru = "ciğer";
            ymk10.YemekSehiri = "Edirne";
            YemeklerDizisi[9] = ymk10;

            Yemekler ymk11 = new Yemekler();
            ymk11.YemekIsmi = "ÇiBörek";
            ymk11.YemekTuru = "Hamur işi";
            ymk11.YemekSehiri = "Eskişehir";
            YemeklerDizisi[10] = ymk11;

            Yemekler ymk12 = new Yemekler();
            ymk12.YemekIsmi = "Beyran Aşı";
            ymk12.YemekTuru = "Çorba";
            ymk12.YemekSehiri = "Gaziantep";
            YemeklerDizisi[11] = ymk12;

            Yemekler ymk13 = new Yemekler();
            ymk13.YemekIsmi = "Künefe";
            ymk13.YemekTuru = "Tatlı";
            ymk13.YemekSehiri = "Hatay";
            YemeklerDizisi[12] = ymk13;

            Yemekler ymk14 = new Yemekler();
            ymk14.YemekIsmi = "Kumru";
            ymk14.YemekTuru = "Tost";
            ymk14.YemekSehiri = "İzmir";
            YemeklerDizisi[13] = ymk14;

            Yemekler ymk15 = new Yemekler();
            ymk15.YemekIsmi = "Mantı";
            ymk15.YemekTuru = "Hamur işi";
            ymk15.YemekSehiri = "Kayseri";
            YemeklerDizisi[14] = ymk15;

            Yemekler ymk16 = new Yemekler();
            ymk16.YemekIsmi = "Etli Ekmek";
            ymk16.YemekTuru = "Pide";
            ymk16.YemekSehiri = "Konya";
            YemeklerDizisi[15] = ymk16;

            Yemekler ymk17 = new Yemekler();
            ymk17.YemekIsmi = "Tantuni";
            ymk17.YemekTuru = "Tantuni";
            ymk17.YemekSehiri = "Mersin";
            YemeklerDizisi[16] = ymk17;

            Yemekler ymk18 = new Yemekler();
            ymk18.YemekIsmi = "Sinop Mantısı";
            ymk18.YemekTuru = "Hamur işi";
            ymk18.YemekSehiri = "Sinop";
            YemeklerDizisi[17] = ymk18;

            Yemekler ymk19 = new Yemekler();
            ymk19.YemekIsmi = "Akçabaat Köfte";
            ymk19.YemekTuru = "Köfte";
            ymk19.YemekSehiri = "Trabzon";
            YemeklerDizisi[18] = ymk19;

            Yemekler ymk20 = new Yemekler();
            ymk20.YemekIsmi = "Tirit";
            ymk20.YemekTuru = "Et Yemeği";
            ymk20.YemekSehiri = "Balıkesir";
            YemeklerDizisi[19] = ymk20;

            Yemekler ymk21 = new Yemekler();
            ymk21.YemekIsmi = "Kayseri Yağlaması";
            ymk21.YemekTuru = "Yağlama";
            ymk21.YemekSehiri = "Kayseri";
            YemeklerDizisi[20] = ymk21;

            Yemekler ymk22 = new Yemekler();
            ymk22.YemekIsmi = "Urfa Kebap";
            ymk22.YemekTuru = "Kebap";
            ymk22.YemekSehiri = "Urfa";
            YemeklerDizisi[21] = ymk22;

            Yemekler ymk23 = new Yemekler();
            ymk23.YemekIsmi = "HöŞmerim";
            ymk23.YemekTuru = "Tatlı";
            ymk23.YemekSehiri = "Çankırı";
            YemeklerDizisi[22] = ymk23;

            Yemekler ymk24 = new Yemekler();
            ymk24.YemekIsmi = "Lebeniye Çorbası";
            ymk24.YemekTuru = "Çorba";
            ymk24.YemekSehiri = "Gaziantep";
            YemeklerDizisi[23] = ymk24;

            Yemekler ymk25 = new Yemekler();
            ymk25.YemekIsmi = "Sultanahmet Köftesi";
            ymk25.YemekTuru = "Köfte";
            ymk25.YemekSehiri = "İstanbul";
            YemeklerDizisi[24] = ymk25;

            Yemekler ymk26 = new Yemekler();
            ymk26.YemekIsmi = "Çökertme Kebabı";
            ymk26.YemekTuru = "Kebap";
            ymk26.YemekSehiri = "Muğla";
            YemeklerDizisi[25] = ymk26;

            Yemekler ymk27 = new Yemekler();
            ymk27.YemekIsmi = "Hamsi Dolması";
            ymk27.YemekTuru = "Dolma";
            ymk27.YemekSehiri = "Trabzon";
            YemeklerDizisi[26] = ymk27;

            Yemekler ymk28 = new Yemekler();
            ymk28.YemekIsmi = "Pişi";
            ymk28.YemekTuru = "Hamur İşi";
            ymk28.YemekSehiri = "Şanlıurfa";
            YemeklerDizisi[27] = ymk28;

            Yemekler ymk29 = new Yemekler();
            ymk29.YemekIsmi = "Karnıyarık";
            ymk29.YemekTuru = "Patlıcan yemeği";
            ymk29.YemekSehiri = "Sivas";
            YemeklerDizisi[28] = ymk29;

            Yemekler ymk30 = new Yemekler();
            ymk30.YemekIsmi = "Nohut";
            ymk30.YemekTuru = "Baklagil";
            ymk30.YemekSehiri = "Şanlıurfa";
            YemeklerDizisi[29] = ymk30;

            Yemekler ymk31 = new Yemekler();
            ymk31.YemekIsmi = "Kuru Fasulye";
            ymk31.YemekTuru = "Baklagil";
            ymk31.YemekSehiri = "Erzurum";
            YemeklerDizisi[30] = ymk31;

            Yemekler ymk32 = new Yemekler();
            ymk32.YemekIsmi = "Kars Katmeri";
            ymk32.YemekTuru = "Katmer";
            ymk32.YemekSehiri = "Kars";
            YemeklerDizisi[31] = ymk32;

            Yemekler ymk33 = new Yemekler();
            ymk33.YemekIsmi = "Karaçuval Helvası";
            ymk33.YemekTuru = "Helva";
            ymk33.YemekSehiri = "Çorum";
            YemeklerDizisi[32] = ymk33;

            Yemekler ymk34 = new Yemekler();
            ymk34.YemekIsmi = "Gelincik Böreği";
            ymk34.YemekTuru = "Börek";
            ymk34.YemekSehiri = "İzmir";
            YemeklerDizisi[33] = ymk34;

            Yemekler ymk35 = new Yemekler();
            ymk35.YemekIsmi = "Tava Ciğeri";
            ymk35.YemekTuru = "Ciğer";
            ymk35.YemekSehiri = "Edirne";
            YemeklerDizisi[34] = ymk35;

            Yemekler ymk36 = new Yemekler();
            ymk36.YemekIsmi = "Et Döner";
            ymk36.YemekTuru = "Döner";
            ymk36.YemekSehiri = "Bursa";
            YemeklerDizisi[35] = ymk36;

            Yemekler ymk37 = new Yemekler();
            ymk37.YemekIsmi = "Arabaşı Çorbası";
            ymk37.YemekTuru = "Çorba";
            ymk37.YemekSehiri = "Yozgat";
            YemeklerDizisi[36] = ymk37;

            Yemekler ymk38 = new Yemekler();
            ymk38.YemekIsmi = "Taze Fasulye";
            ymk38.YemekTuru = "Fasulye";
            ymk38.YemekSehiri = "Giresun";
            YemeklerDizisi[37] = ymk38;

            Yemekler ymk39 = new Yemekler();
            ymk39.YemekIsmi = "Zeytinyağlı Sarma";
            ymk39.YemekTuru = "Sarma";
            ymk39.YemekSehiri = "Malatya";
            YemeklerDizisi[38] = ymk39;

            Yemekler ymk40 = new Yemekler();
            ymk40.YemekIsmi = "Pastırmalı Yumurta";
            ymk40.YemekTuru = "pastırmalı Yemekler";
            ymk40.YemekSehiri = "Kayseri";
            YemeklerDizisi[39] = ymk40;

            //

            Console.WriteLine("Lütfen Yemekleri Nasıl Aratmak Listelemek İstediğinizi Seçiniz\n1) Yemekler Türüne Göre\n2) Şehirine Göre");
            int Secim = Convert.ToInt32(Console.ReadLine());

            if (Secim == 1 || Secim == 2)
            {
                if (Secim == 1)
                {
                    Console.WriteLine("Lütfen Aratmak İstediğiniz Türü Giriniz");
                    string YemekTuru = Console.ReadLine();

                    bool Kontrol = false;

                    for (int i = 0; i < YemeklerDizisi.Length; i++)
                    {
                        if (YemeklerDizisi[i].YemekTuru == YemekTuru)
                        {
                            Kontrol = true;
                            break;
                        }
                    }

                    if (Kontrol)
                    {
                        for (int i = 0; i < YemeklerDizisi.Length; i++)
                        {
                            if (YemeklerDizisi[i].YemekTuru == YemekTuru)
                            {
                                Console.WriteLine($"{YemeklerDizisi[i].YemekIsmi} - {YemeklerDizisi[i].YemekSehiri}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Geçerli Bir Değer Girmediniz");
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen Aratmak İstediğiniz Şehiri Giriniz");
                    string YemekSehiri = Console.ReadLine();

                    bool Kontrol = false;

                    for (int i = 0; i < YemeklerDizisi.Length; i++)
                    {
                        if (YemeklerDizisi[i].YemekSehiri == YemekSehiri)
                        {
                            Kontrol = true;
                            break;
                        }
                    }

                    if (Kontrol)
                    {
                        for (int i = 0; i < YemeklerDizisi.Length; i++)
                        {
                            if (YemeklerDizisi[i].YemekSehiri == YemekSehiri)
                            {
                                Console.WriteLine($"{YemeklerDizisi[i].YemekIsmi} - {YemeklerDizisi[i].YemekTuru}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Geçerli Bir Değer Girmediniz");
                    }
                }
            }
            else
            {
                Console.WriteLine("Geçerli Bir Değer Girmediniz");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraTatilOdevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Kitap Sistemi
            //string[] KitapAdi = { "Şeker Portakalı", "Otomatik Portakal", "Felsefeye Giriş", "Seninle Başlamadı", "Mesaj", "Aeden", "Suç ve Ceza", "Türlerin Kökeni", "İnsanın Türeyişi", "Fi", "Çi", "Pi", "Beyin", "Don Kişot", "Dijital Kaos", "Epigenetik", "Zamanın Kısa Tarihi", "Büyük Sorulara Kısa Yanıtlar", "Romeo ve Juliet", "Hayvanlardan Tanrılara: Sapiens" };
            //string[] KitabinYazari = { "Jose Mauro De Vasconcelos", "Anthony Burgess", "Ahmet Cevizci", "Mark Wolynn", "Carl Sagan", "Akilah Azra Kohen", "Fyodor Dostoyevski", "Charles Darwin", "Charles Darwin", "Akilah Azra Kohen", "Akilah Azra Kohen", "Akilah Azra Kohen", "David Eagleman", "Miguel de Cervantes", "Tanol Türkoğlu", "Bernhard Kegel", "Stephen W. Hawking", "Stephen W. Hawking", "William Shakespeare", "Yuval Noah Harari" };
            //string[] KitabinTuru = { "Roman", "Roman", "Araştırma-İnceleme", "Araştırma-İnceleme", "Bilim-Kurgu", "Roman", "Roman", "Bilim-Teknoloji-Mühendislik", "Bilim-Teknoloji-Mühendislik", "Roman", "Roman", "Roman", "Bilim-Teknoloji-Mühendislik", "Roman", "Bilim-Kurgu", "Bilim-Teknoloji-Mühendislik", "Bilim-Teknoloji-Mühendislik", "Bilim-Teknoloji-Mühendislik", "Dünya Klasikleri", "Bilim-Teknoloji-Mühendislik" };
            //string[] KitabinYayinEvi = { "Can Yayınları", "İş Bankası Kültür Yayınları", "Say Yayınları", "Sola Unitas Yayınları", "Say Yayınları", "Everest Yayınları", "İş Bankası Kültür Yayınları", "Yason Yayıncılık", "Alfa Yayınları", "Everest Yayınları", "Everest Yayınları", "Everest Yayınları", "Domingo Yayınevi", "Koridor Yayınları", "Epsilon Yayınevi", "Say Yayınları", "Alfa Bilim", "Alfa Yayıncılık", "İş Bankası Kültür Yayınları", "Kolektif Kitap" };
            //double[] KitabinFiyati = { 85.00, 28.60, 133.00, 102.95, 190.00, 146.25, 56.80, 105.60, 97.20, 136.50, 90.35, 136.50, 92.14, 68.87, 117.95, 152.00, 90.35, 74.75, 13.86, 166.85 };

            //string[] KitaplarinTurleri = { "Roman", "Araştırma-İnceleme", "Bilim-Kurgu", "Bilim-Teknoloji-Mühendislik", "Dünya Klasikleri" };
            //string[] KitaplarinYazarlari = { "Jose Mauro De Vasconcelos", "Anthony Burgess", "Ahmet Cevizci", "Mark Wolynn", "Carl Sagan", "Akilah Azra Kohen", "Fyodor Dostoyevski", "Charles Darwin", "David Eagleman", "Miguel de Cervantes", "Tanol Türkoğlu", "Bernhard Kegel", "Stephen W. Hawking", "William Shakespeare", "Yuval Noah Harari" };
            //List<string> ListelenenKitaplar = new List<string>();


            //bool Kontrol = true; bool KKontrol = true; int Secim = 0; bool KSKontrol = true; int sayac = 1; bool SSKontrol = true; string Secenek = ""; int KSecim = 0; int SSecim = 0;

            //Console.WriteLine("Hoşgeldiniz");

            //while (Kontrol)
            //{
            //    while (KKontrol)
            //    {
            //        Console.WriteLine("Lütfen Hangi Şekilde Listeleme Yapmak İstediğinizi Seçiniz\n1- Türe Göre\n2- Yazara Göre");
            //        Secim = Convert.ToInt32(Console.ReadLine());

            //        if (Secim == 1)
            //        {
            //            Console.Clear();
            //            for (int i = 0; i < KitaplarinTurleri.Length; i++)
            //            {
            //                Console.WriteLine($"{i + 1}) {KitaplarinTurleri[i]}");
            //            }
            //            KKontrol = false;
            //        }
            //        else if (Secim == 2)
            //        {
            //            Console.Clear();
            //            for (int i = 0; i < KitaplarinYazarlari.Length; i++)
            //            {
            //                Console.WriteLine($"{i + 1}) {KitaplarinYazarlari[i]}");
            //            }
            //            KKontrol = false;
            //        }
            //        else
            //        {
            //            Console.Clear();
            //            Console.WriteLine("Lütfen Geçerli Bir Seçenek Giriniz");
            //            KKontrol = true;
            //        }
            //    }

            //    if (Secim == 1)
            //    {
            //        while (KSKontrol)
            //        {
            //            Console.WriteLine("Kitap Türü Seçiniz");
            //            KSecim = Convert.ToInt32(Console.ReadLine());

            //            if (!(KSecim <= 0 || KSecim > KitaplarinTurleri.Length))
            //            {
            //                Console.Clear();
            //                sayac = 1;
            //                for (int i = 0; i < KitabinTuru.Length; i++)
            //                {
            //                    if (KitaplarinTurleri[KSecim - 1] == KitabinTuru[i])
            //                    {
            //                        Console.WriteLine($"{sayac}) {KitapAdi[i]} - {KitabinYazari[i]} / {KitabinYayinEvi[i]} / {KitabinFiyati[i]}");
            //                        ListelenenKitaplar.Add(KitapAdi[i]);
            //                        sayac++;
            //                    }
            //                }
            //                KSKontrol = false;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Lütfen Geçerli Bir Seçenek Giriniz");
            //            }
            //        }

            //        while (SSKontrol)
            //        {
            //            Console.WriteLine("Lütfen Hangi Kitabı Satın Almak İstediğinizi Seçiniz");
            //            SSecim = Convert.ToInt32(Console.ReadLine());

            //            if (!(SSecim <= 0 || SSecim > ListelenenKitaplar.Count))
            //            {
            //                int Index = Array.IndexOf(KitapAdi, ListelenenKitaplar[SSecim - 1]);
            //                Console.WriteLine($"{ListelenenKitaplar[SSecim - 1]} / {KitabinFiyati[Index]} TL\nSatın Alım İşlemi Gerçekleştirildi");
            //                SSKontrol = false;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Lütfen Geçerli Bir Seçenek Giriniz");
            //            }
            //        }
            //    }
            //    else
            //    {
            //        while (KSKontrol)
            //        {
            //            Console.WriteLine("Yazar Seçiniz");
            //            KSecim = Convert.ToInt32(Console.ReadLine());

            //            if (!(KSecim <= 0 || KSecim > KitabinYazari.Length))
            //            {
            //                Console.Clear();
            //                sayac = 1;
            //                for (int i = 0; i < KitabinYazari.Length; i++)
            //                {
            //                    if (KitaplarinYazarlari[KSecim - 1] == KitabinYazari[i])
            //                    {
            //                        Console.WriteLine($"{sayac}) {KitapAdi[i]} - {KitabinYazari[i]} / {KitabinYayinEvi[i]} / {KitabinFiyati[i]}");
            //                        ListelenenKitaplar.Add(KitapAdi[i]);
            //                        sayac++;
            //                    }
            //                }
            //                KSKontrol = false;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Lütfen Geçerli Bir Seçenek Giriniz");
            //            }
            //        }

            //        while (SSKontrol)
            //        {
            //            Console.WriteLine("Lütfen Hangi Kitabı Satın Almak İstediğinizi Seçiniz");
            //            SSecim = Convert.ToInt32(Console.ReadLine());

            //            if (!(SSecim <= 0 || SSecim > ListelenenKitaplar.Count))
            //            {
            //                int Index = Array.IndexOf(KitapAdi, ListelenenKitaplar[SSecim - 1]);
            //                Console.WriteLine($"{ListelenenKitaplar[SSecim - 1]} / {KitabinFiyati[Index]} TL\nSatın Alım İşlemi Gerçekleştirildi");
            //                SSKontrol = false;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Lütfen Geçerli Bir Seçenek Giriniz");
            //            }
            //        }
            //    }

            //    Console.WriteLine("Satın Alım İşlemine Devam Etmek İstiyor Musunuz? e/h");
            //    Secenek = Console.ReadLine();

            //    if (Secenek == "E" || Secenek == "e")
            //    {
            //        Console.Clear();
            //        Kontrol = true; KKontrol = true; Secim = 0; KSKontrol = true; sayac = 1; SSKontrol = true; Secenek = ""; KSecim = 0; SSecim = 0; ListelenenKitaplar.Clear();
            //    }
            //    else
            //    {
            //        Console.Clear();
            //        Kontrol = false;
            //    }
            //}

            //Console.WriteLine("Bizi Tercih Ettiğiniz İçin Teşekkürler");
            #endregion

            #region İlaç Sistemi
            string[] IlacKategorileri = { "A", "B", "C", "D", "X" };
            string[] Ilaclar = { "Folik Asit (Folic Acid)", "Metformin", "Levotiroksin", "İnsülin", "Amoksisilin", "İbuprofen", "Parasetamol", "Zofran (Ondansetron)", "Diphenhydramine (Benadryl)", "Pseudoephedrine (Sudafed)", "Fluconazole (Diflucan)", "Venlafaxine (Effexor)", "Lisinopril", "İsotretinoin", "Warfarin", "Methotrexate", "Thalidomide", "İsofosfamid", "Warfarin", "Misoprostol" };
            string[] IlaclarinKategorileri = { "A", "A", "A", "A", "B", "B", "B", "B", "C", "C", "C", "C", "D", "D", "D", "D", "X", "X", "X", "X"};
            string[] IlaclarBilgilendirme = { "Folik Asit, B grubu vitaminlerden biri olan folatın sentetik bir formudur. Vücut için önemli bir vitamindir ve özellikle hamilelik öncesi, hamilelik sırası ve emzirme dönemlerinde önemli bir rol oynar. İşte folik asit hakkında bilgi ve kullanımı ile dozu:\nFolik Asit Nedir?:\n* Folik Asit, B9 vitamini olarak da bilinir ve vücutta hücre bölünmesi, DNA sentezi, amino asit metabolizması ve nöral tüp gelişimi gibi bir dizi önemli işlevde kritik bir rol oynar.\n* Özellikle gebelik öncesi ve ilk trimesterde yetersiz folik asit alımı, nöral tüp defektleri gibi doğumsal anomalilere yol açabilir.\nFolik Asit Kullanımı:\n* Folik asit takviyeleri, folik asit eksikliğini önlemek veya tedavi etmek için önerilir. Ayrıca gebelik planlayan veya hamile kadınlar için özellikle önemlidir.\n* Doktor tavsiyesi olmadan yüksek dozlarda folik asit kullanımından kaçınılmalıdır.\nFolik Asit Dozu:\n* Hamilelik öncesi dönemde ve hamilelik sırasında folik asit ihtiyacı artar. Genellikle doktorlar, 400 ila 800 mikrogram (mcg) folik asit takviyesi almayı önerirler.\n* Emzirme döneminde de ekstra folik asit alımı gerekebilir, ve yine doktorunuzun tavsiyelerini takip etmelisiniz.\n* Hamilelik planlaması yaparken, folik asit takviyelerine başlamak ve hamilelik boyunca devam etmek önemlidir.", "Metformin, tip 2 diyabetin tedavisinde yaygın olarak kullanılan bir ilaçtır. Ayrıca prediyabet (şeker hastalığı riski taşıyan durum) ve polikistik over sendromu (PCOS) gibi diğer sağlık sorunlarının tedavisinde de kullanılabilir. İşte Metformin hakkında daha fazla bilgi ve kullanımı ile dozu:\nMetformin Nedir?:\n* Metformin, oral olarak alınabilen bir antidiyabetik ilaçtır.\n* Tip 2 diyabetin yönetiminde etkilidir ve vücuttaki kan şekeri seviyelerini düşürmeye yardımcı olur.\n* İlaç, insülin direnci, karaciğerin glikoz üretimini azaltma ve kas hücrelerinin glikozu daha iyi kullanmasına yardımcı olarak çalışır.\nMetformin Kullanımı:\n* Metformin, tip 2 diyabetin tedavisinde, kilo kontrolünde ve kan şekeri düzeylerinin yönetiminde kullanılır.\n* Ayrıca, prediyabet veya insülin direnci durumlarında ve polikistik over sendromu (PCOS) tedavisinde de etkilidir.\nMetformin Dozu:\n* Metformin dozu, kişinin özel ihtiyaçlarına ve doktorun tavsiyelerine bağlı olarak değişebilir.\n* Genellikle, tedaviye düşük bir dozla başlanır ve doz zamanla artırılabilir.\n* İlaç genellikle yemekle birlikte alınır ve doktorunuzun önerdiği şekilde alınmalıdır.\nMetformin kullanırken dikkat etmeniz gereken bazı önemli konular şunlar olabilir:\n* Metformin, bazı insanlarda mide rahatsızlığına yol açabilir. Bu nedenle, ilacı yemekle birlikte almak mide problemlerini azaltabilir.\n* Metformin kullanırken düzenli olarak kan şekeri seviyelerinizi takip etmek önemlidir.\n* İlaç kullanırken, yan etkiler veya diğer sağlık endişeleri hakkında doktorunuzla iletişimde kalmalısınız." };

            Console.WriteLine("Hoşgeldiniz");
            Console.WriteLine("Kategorilendirme FDA Standartlarına Göre Yapılmıştır");
            Console.WriteLine(IlaclarBilgilendirme[1]);
            #endregion
        }
    }
}

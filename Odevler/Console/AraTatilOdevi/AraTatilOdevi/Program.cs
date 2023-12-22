using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
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
            string[] IlaclarinKategorileri = { "A", "A", "A", "A", "B", "B", "B", "B", "C", "C", "C", "C", "D", "D", "D", "D", "X", "X", "X", "X" };
            string[] IlaclarBilgilendirme = { "Folik Asit, B grubu vitaminlerden biri olan folatın sentetik bir formudur. Vücut için önemli bir vitamindir ve özellikle hamilelik öncesi, hamilelik sırası ve emzirme dönemlerinde önemli bir rol oynar. İşte folik asit hakkında bilgi ve kullanımı ile dozu:\n\nFolik Asit Nedir?:\n* Folik Asit, B9 vitamini olarak da bilinir ve vücutta hücre bölünmesi, DNA sentezi, amino asit metabolizması ve nöral tüp gelişimi gibi bir dizi önemli işlevde kritik bir rol oynar.\n* Özellikle gebelik öncesi ve ilk trimesterde yetersiz folik asit alımı, nöral tüp defektleri gibi doğumsal anomalilere yol açabilir.\n\nFolik Asit Kullanımı:\n* Folik asit takviyeleri, folik asit eksikliğini önlemek veya tedavi etmek için önerilir. Ayrıca gebelik planlayan veya hamile kadınlar için özellikle önemlidir.\n* Doktor tavsiyesi olmadan yüksek dozlarda folik asit kullanımından kaçınılmalıdır.\n\nFolik Asit Dozu:\n* Hamilelik öncesi dönemde ve hamilelik sırasında folik asit ihtiyacı artar. Genellikle doktorlar, 400 ila 800 mikrogram (mcg) folik asit takviyesi almayı önerirler.\n* Emzirme döneminde de ekstra folik asit alımı gerekebilir, ve yine doktorunuzun tavsiyelerini takip etmelisiniz.\n* Hamilelik planlaması yaparken, folik asit takviyelerine başlamak ve hamilelik boyunca devam etmek önemlidir.", "Metformin, tip 2 diyabetin tedavisinde yaygın olarak kullanılan bir ilaçtır. Ayrıca prediyabet (şeker hastalığı riski taşıyan durum) ve polikistik over sendromu (PCOS) gibi diğer sağlık sorunlarının tedavisinde de kullanılabilir. İşte Metformin hakkında daha fazla bilgi ve kullanımı ile dozu:\n\nMetformin Nedir?:\n* Metformin, oral olarak alınabilen bir antidiyabetik ilaçtır.\n* Tip 2 diyabetin yönetiminde etkilidir ve vücuttaki kan şekeri seviyelerini düşürmeye yardımcı olur.\n* İlaç, insülin direnci, karaciğerin glikoz üretimini azaltma ve kas hücrelerinin glikozu daha iyi kullanmasına yardımcı olarak çalışır.\n\nMetformin Kullanımı:\n* Metformin, tip 2 diyabetin tedavisinde, kilo kontrolünde ve kan şekeri düzeylerinin yönetiminde kullanılır.\n* Ayrıca, prediyabet veya insülin direnci durumlarında ve polikistik over sendromu (PCOS) tedavisinde de etkilidir.\n\nMetformin Dozu:\n* Metformin dozu, kişinin özel ihtiyaçlarına ve doktorun tavsiyelerine bağlı olarak değişebilir.\n* Genellikle, tedaviye düşük bir dozla başlanır ve doz zamanla artırılabilir.\n* İlaç genellikle yemekle birlikte alınır ve doktorunuzun önerdiği şekilde alınmalıdır.\n\nMetformin kullanırken dikkat etmeniz gereken bazı önemli konular şunlar olabilir:\n* Metformin, bazı insanlarda mide rahatsızlığına yol açabilir. Bu nedenle, ilacı yemekle birlikte almak mide problemlerini azaltabilir.\n* Metformin kullanırken düzenli olarak kan şekeri seviyelerinizi takip etmek önemlidir.\n* İlaç kullanırken, yan etkiler veya diğer sağlık endişeleri hakkında doktorunuzla iletişimde kalmalısınız.", "Levotiroksin, tiroid hormonu olan tiroksin (T4) yapısında sentetik bir ilaçtır. Genellikle tiroid bezinin yeterli miktarda tiroksin üretemediği durumlarda, özellikle hipotiroidizm (tiroid bezinin yetersiz çalışması) tedavisinde kullanılır. İşte Levotiroksin hakkında daha fazla bilgi ve kullanımı ile dozu:\n\nLevotiroksin Nedir?:\n* Levotiroksin, tiroid hormonu eksikliği durumunda vücuda dışarıdan tiroksin sağlamak amacıyla kullanılır.\n* Tiroid hormonları, vücudun enerji düzeyini ve metabolizmayı düzenler. Levotiroksin, tiroid hormonu eksikliğini düzelterek bu işlevleri yerine getirir.\n\nLevotiroksin Kullanımı:\n* Levotiroksin, genellikle hipotiroidizm tedavisinde kullanılır. Hipotiroidizm, tiroid bezinin yeterince hormon üretemediği bir durumdur.\n* Ayrıca, tiroid bezinin cerrahi olarak çıkarılması veya radyoaktif iyot tedavisi sonrasında oluşan hipotiroidizm durumlarında da kullanılabilir.\n\nLevotiroksin Dozu:\n* Levotiroksin dozu, bireyin tiroid fonksiyon test sonuçlarına ve ihtiyaçlarına bağlı olarak belirlenir.\n* Doz, genellikle düşük bir seviyede başlar ve ardından tiroid fonksiyon testleri sonuçlarına göre ayarlanabilir.\n* Levotiroksin genellikle aç karnına sabahları alınır, çünkü yemekler ilacın emilimini etkileyebilir.\n\nLevotiroksin kullanırken dikkate almanız gereken bazı önemli konular şunlar olabilir:\n* İlacın düzenli olarak alınması önemlidir. İlaç alımını düzenli olarak atlamamak önemlidir.\n* Diğer ilaçlar veya besin takviyeleri ile etkileşimleri olabileceği için, diğer ilaçlarınızı veya takviyelerinizi doktorunuza danışarak kullanmalısınız.\n* Levotiroksin dozunun ayarlanması ve değiştirilmesi sadece doktorunuz tarafından yapılmalıdır.", "İnsülin, pankreasta üretilen bir hormondur ve vücuttaki hücrelere glikozun alınmasını sağlayarak kan şekerini düzenler. İnsülin tedavisi, genellikle tip 1 diyabet veya tip 2 diyabetin şiddetli formları gibi durumlarda kullanılır, özellikle kan şekerini düzenlemek için vücuda yeterince insülin üretilemediği veya kullanılamadığı durumlarda. İşte insülin hakkında daha fazla bilgi ve kullanımı:\n\nİnsülin Nedir?:\n* İnsülin, karbonhidratların vücut tarafından kullanılabilir enerjiye dönüştürülmesini sağlayan bir hormondur.\n* Pankreas, yeterli miktarda insülin üretemediğinde veya üretilen insülinin etkili bir şekilde kullanılamadığı durumlarda, dışarıdan alınan insülin takviyeleri kullanılır.\n\nİnsülin Kullanımı:\nİnsülin, genellikle diyabetli bireylerde kullanılır. Tip 1 diyabet, vücut insülin üretmez, bu nedenle insülin dışarıdan verilir. Tip 2 diyabet, genellikle vücut insülinini etkili bir şekilde kullanamaz, bu nedenle insülin tedavisi tip 2 diyabetin yönetiminde kullanılabilir.\n\nİnsülin Dozu:\n* İnsülin dozu, bireyin kan şekeri seviyelerine, yaşına, kilosuna, yaşam tarzına ve diğer faktörlere bağlı olarak belirlenir.\n* İnsülin, genellikle enjeksiyon veya şırınga ile deri altına veya insülin pompası aracılığıyla sürekli olarak verilebilir.\n\nİnsülin tedavisi konusunda önemli konular şunlardır:\n* İnsülin dozları, kan şekerini kontrol altında tutmak için düzenli olarak ayarlanmalıdır.\n* İnsülinin doğru şekilde saklanması ve uygulanması önemlidir.\n* İnsülin kullanımı sırasında kan şekerini izlemek, dozajları düzenlemek ve olası sorunları tanımak önemlidir.", "Amoksisilin, bir antibiyotiktir ve çeşitli bakteriyel enfeksiyonların tedavisinde kullanılır. Amoksisilin, penisilin sınıfına ait bir ilaçtır ve geniş bir bakteri yelpazesine karşı etkilidir. İşte Amoksisilin hakkında daha fazla bilgi ve kullanımı ile dozu:\n\nAmoksisilin Nedir?:\n* Amoksisilin, penisilin sınıfında bir antibiyotiktir ve birçok bakteri tarafından üretilen bir enzim olan beta-laktamazlara karşı direnç gösteren bir formüle sahiptir.\n* Üst solunum yolu enfeksiyonları, orta kulak enfeksiyonları, sinüzit, idrar yolu enfeksiyonları ve diğer bazı bakteriyel enfeksiyonların tedavisinde kullanılır.\n\nAmoksisilin Kullanımı:\n* Amoksisilin, bir doktor tarafından reçete edildiği şekilde ve belirli bir süre boyunca kullanılmalıdır.\n* Reçete edilen doz ve tedavi süresi, enfeksiyonun tipine, şiddetine ve bireyin sağlık durumuna bağlı olarak değişebilir.\n\nAmoksisilin Dozu:\n* Amoksisilin dozu, enfeksiyonun türüne, şiddetine ve bireyin yaşına, kilosuna gibi faktörlere bağlı olarak belirlenir.\n* Genellikle günde 2-3 kez alınır ve dozaj, genellikle 250 mg, 500 mg veya 875 mg tabletler veya 125 mg/5 ml, 200 mg/5 ml veya 400 mg/5 ml şurup formunda olabilir.\n\nAmoksisilin kullanımı ile ilgili önemli hususlar şunlardır:\n* Amoksisilin, belirli bir bakteri türüne karşı etkili olabilir, ancak tüm bakterilere karşı etkili değildir. Bu nedenle, bir doktor tarafından belirtilen durumlar dışında kullanılmamalıdır.\n* İlacın tamamı, doktorun önerdiği süre boyunca düzenli olarak kullanılmalıdır. İlacın erken bırakılması, enfeksiyonun tekrarlamasına ve direnç gelişmesine neden olabilir.\n* Amoksisilin kullanımı sırasında olası yan etkiler veya alerjik reaksiyonlar için dikkatli olunmalı ve doktora bildirilmelidir.", "İbuprofen, bir nonsteroidal anti-inflamatuar ilaç (NSAID) olarak bilinen bir ilaçtır. İbuprofen, ağrı, iltihap ve ateşi azaltma yeteneği nedeniyle genellikle ağrı kesici, ateş düşürücü ve anti-inflamatuar amaçlarla kullanılır. Ancak, kullanımıyla ilgili bazı önemli faktörler vardır. İşte İbuprofen hakkında daha fazla bilgi ve kullanımı:\n\nİbuprofen Nedir?:\n* İbuprofen, ağrı ve iltihaplanmayı azaltan bir NSAID'dir.\n* Ayrıca, ateş düşürme özelliği sayesinde ateşli durumların yönetiminde de kullanılır.\n* Kas ağrıları, baş ağrısı, diş ağrısı, adet ağrıları, romatoid artrit ve osteoartrit gibi durumların semptomlarına karşı etkilidir.\n\nİbuprofen Kullanımı:\n* İbuprofen, ağrı veya inflamasyonu hafifletmek veya ateşi düşürmek amacıyla kullanılır.\n* Doktor tarafından belirlenen doz ve süre boyunca kullanılmalıdır.\n* Yiyeceklerle birlikte alınabilir veya aç karnına alınabilir, ancak mide problemleri yaşamamak için yiyeceklerle birlikte alınması önerilir.\n\nİbuprofen Dozu:\n* İbuprofen dozu, yaşa, kiloya, sağlık durumuna ve kullanım amacına bağlı olarak değişebilir.\n* Genellikle günde 2-4 kez alınır ve doz, genellikle 200 mg ile 800 mg arasında değişebilir.\n\nİbuprofen kullanımı konusunda dikkat edilmesi gereken bazı önemli noktalar şunlar olabilir:\n* İbuprofen mide problemlerine neden olabilir, bu nedenle mide rahatsızlığı, mide ülseri veya mide kanaması öyküsü olan kişilerin kullanımından önce doktorlarına danışmaları önemlidir.\n* İbuprofen, uzun süreli ve yüksek doz kullanımı durumunda böbrek sorunlarına ve kardiyovasküler sorunlara yol açabilir.\n* Diğer ilaçlarla etkileşime girebilir, bu nedenle diğer ilaçlarla birlikte kullanılmadan önce doktorunuza danışmalısınız.", "Parasetamol (ayrıca asetaminofen olarak da adlandırılır), ağrı kesici ve ateş düşürücü bir ilaçtır. Parasetamol, genellikle hafif ila orta şiddetteki ağrıların ve hafif ateşin yönetimi için kullanılır. İşte Parasetamol hakkında daha fazla bilgi ve kullanımı:\n\nParasetamol Nedir?:\n* Parasetamol, ağrı ve ateşi yönetmek için kullanılan bir analjezik (ağrı kesici) ve antipiretik (ateş düşürücü) ilaçtır.\n* İnflamasyonu azaltma özelliğine sahip değildir, bu nedenle NSAID (nonsteroidal anti-inflamatuar ilaçlar) grubuna dahil değildir.\n* Baş ağrısı, diş ağrısı, kas ağrıları, adet ağrıları ve hafif ateşin yönetimi için yaygın olarak kullanılır.\n\nParasetamol Kullanımı:\n* Parasetamol, genellikle ağrı veya ateşi hafifletmek amacıyla kullanılır.\n* Uygun dozaj ve kullanım süresi, bir doktor veya sağlık profesyoneli tarafından belirlenmelidir.\n* Genellikle yiyeceklerle birlikte alınabilir veya aç karnına alınabilir.\n\nParasetamol Dozu:\n* Parasetamol dozu, yaşa, kiloya ve sağlık durumuna bağlı olarak değişebilir.\n* Genellikle günde belirli aralıklarla alınır ve doz, genellikle 500 mg ile 1000 mg arasında değişebilir.\n\nParasetamol kullanımıyla ilgili dikkat edilmesi gereken bazı önemli hususlar şunlar olabilir:\n* Dozaj talimatlarına dikkat edilmelidir ve belirtilen doz aşılmamalıdır.\n* Alkol tüketimiyle birlikte kullanılmamalıdır, çünkü karaciğer toksisitesine neden olabilir.\n* Aşırı doz alımı ciddi karaciğer hasarına neden olabilir, bu nedenle belirtilen dozlara dikkat edilmelidir.", "Zofran, ondansetron adlı bir ilaçtır ve genellikle mide bulantısı ve kusmayı kontrol altına almak amacıyla kullanılır. Ondansetron, özellikle kemoterapi veya radyoterapi sonrasında veya cerrahi müdahale sonrasında ortaya çıkan mide bulantısı ve kusmayı önleme amacıyla yaygın olarak reçete edilir. İşte Zofran hakkında daha fazla bilgi ve kullanımı:\n\nZofran (Ondansetron) Nedir?:\n* Ondansetron, serotonin reseptör antagonistleri sınıfına aittir. Bu, mide bulantısı ve kusma ile ilişkilendirilen serotonin etkileşimlerini engelleyerek çalışır.\n* Kemoterapi, radyoterapi, cerrahi işlemler veya diğer nedenlerle oluşan mide bulantısı ve kusmayı kontrol altına almak için kullanılır.\n* Hamilelikte ortaya çıkan mide bulantısı ve kusma durumlarında da kullanılabilir, ancak hamilelikte kullanımıyla ilgili doktorla görüşmek önemlidir.\n\nZofran (Ondansetron) Kullanımı:\n* Zofran, doktor tarafından belirlenen doz ve süre boyunca alınmalıdır.\n* Genellikle ağızdan alınabilir tablet, çözünür tablet, şurup veya enjeksiyon formunda bulunur.\n* Kemoterapi veya radyoterapi öncesinde alınan bir doz, ameliyat sonrasında alınan bir doz veya ihtiyaca bağlı olarak kullanılabilir.\n\nZofran (Ondansetron) Dozu:\n* Doz, hastanın durumuna, kullanım amacına ve genel sağlık durumuna bağlı olarak değişebilir.\n* Genellikle, mide bulantısı ve kusma kontrolü için bir doz alındıktan sonra belirli bir süre boyunca devam eden tedavi planı uygulanabilir.\n\nZofran kullanımıyla ilgili dikkat edilmesi gereken bazı önemli noktalar şunlar olabilir:\n* İlacın dozaj talimatlarına ve doktorun önerilerine dikkat edilmelidir.\n* Ondansetron, belirli koşullarda kullanılabilir, ancak her durumda kullanımı öncesinde doktorla görüşmek önemlidir.\n* Gebelik döneminde kullanımıyla ilgili olarak, hamilelik durumunu doktorla paylaşmalı ve ilacın risk ve faydalarını değerlendirmelisiniz.", "Diphenhydramine, genellikle alerjik reaksiyonların ve sakinleştirici olarak kullanılan bir antihistaminiktir. Birçok marka adı altında satılan benadryl, bu etken maddeyi içeren yaygın bir ilaçtır. İşte Diphenhydramine (Benadryl) hakkında daha fazla bilgi ve kullanımı:\n\nDiphenhydramine (Benadryl) Nedir?:\n* Diphenhydramine, birinci nesil antihistaminik olarak bilinir ve alerjik reaksiyonları engellemek veya hafifletmek amacıyla kullanılır.\n* Alerjik nezle, kurdeşen, kaşıntı, göz sulanması gibi alerjik belirtileri kontrol altına alabilir.\n* Ayrıca, uykusuzluk veya huzursuzluk durumlarında sakinleştirici etkileri nedeniyle kullanılabilir.\n\nDiphenhydramine (Benadryl) Kullanımı:\n* Alerjik reaksiyonların kontrolü veya hafifletilmesi amacıyla kullanılır.\n* Uykusuzluk veya huzursuzluk durumlarında sakinleştirici olarak kullanılabilir.\n* Doktor tarafından önerilen doz ve süre boyunca alınmalıdır.\n\nDiphenhydramine (Benadryl) Dozu:\n* Doz, kişinin yaşına, kilosuna, sağlık durumuna ve kullanım amacına bağlı olarak değişebilir.\n* Genellikle alerjik belirtileri kontrol etmek için günde birkaç kez alınabilir.\n* Sakinleştirici olarak kullanılacaksa, uykusuzluk durumunda genellikle yatmadan önce alınır.\n\nDiphenhydramine (Benadryl) kullanımı ile ilgili dikkat edilmesi gereken bazı önemli noktalar şunlar olabilir:\n* Dozaj talimatlarına dikkat edilmelidir ve belirtilen dozlar aşılmamalıdır.\n* Uykusuzluk veya sakinleştirici etkileri nedeniyle araç kullanma veya tehlikeli makinelerle çalışma yeteneğinizi etkileyebilir, bu nedenle dikkatli olunmalıdır.\n* Baş dönmesi, uykusuzluk, kabızlık gibi yan etkiler görülebilir ve bu durumlar devam ederse doktora başvurulmalıdır.", "Pseudoephedrine, genellikle soğuk algınlığı, grip ve alerjik rinit gibi durumların belirtilerini hafifletmek amacıyla kullanılan bir dekonjestan maddedir. Sudafed gibi marka adları altında satılabilmektedir. Pseudoephedrine, burun tıkanıklığını azaltarak ve hava yollarını genişleterek etki eder. Ancak, bazı ülkelerde bu madde, methamphetamine gibi uyuşturucu üretiminde kullanılma riski nedeniyle reçetesiz olarak satılmamaktadır ve alımında sınırlamalar bulunabilir. İşte Pseudoephedrine (Sudafed) hakkında daha fazla bilgi ve kullanımı:\n\nPseudoephedrine (Sudafed) Nedir?:\n* Pseudoephedrine, dekonjestan bir ajan olup, burun tıkanıklığını hafifletmek için kullanılır.\n* Genellikle soğuk algınlığı, grip ve alerjik rinit gibi durumların belirtilerini azaltmak amacıyla kullanılır.\n* Lokal kan damarlarını daraltarak ve burun içindeki mukus üretimini azaltarak etki eder.\n\nPseudoephedrine (Sudafed) Kullanımı:\n* Pseudoephedrine, genellikle ağızdan alınan tablet veya kapsül formunda bulunur.\n* Doktor tarafından önerilen doz ve süre boyunca kullanılmalıdır.\n* Günde belirli aralıklarla veya ihtiyaç durumuna göre kullanılabilir.\n\nPseudoephedrine (Sudafed) Dozu:\n* Dozaj, kişinin yaşına, kilosuna, sağlık durumuna ve kullanım amacına bağlı olarak değişebilir.\n* Genellikle belirli bir süre için kullanılır ve uzun süreli kullanım önerilmez.\n\nPseudoephedrine (Sudafed) kullanımıyla ilgili dikkat edilmesi gereken bazı önemli noktalar şunlar olabilir:\n* Pseudoephedrine, uyarıcı bir etkiye sahip olabilir ve bu nedenle uykusuzluk, sinirlilik gibi yan etkilere neden olabilir. Bu tür etkiler devam ederse doktora danışılmalıdır.\n* Bazı sağlık koşulları, özellikle yüksek tansiyon gibi durumlar, Pseudoephedrine kullanımına karşı kontrendike olabilir. Bu nedenle, başlamadan önce bir sağlık profesyoneli ile görüşmek önemlidir.\n* Pseudoephedrine'in uyuşturucu üretiminde kullanılabilecek bir madde olması nedeniyle, bazı ülkelerde sınırlı miktarlarda satılabilir ve satın almak için reçeteye ihtiyaç duyabilir.", "Fluconazole, mantar enfeksiyonlarına karşı etkili bir antifungal ilaçtır ve Diflucan adıyla bilinir. Genellikle mantar enfeksiyonlarının tedavisi için kullanılır. Fluconazole, vajinal mantar enfeksiyonları, oral mantar enfeksiyonları, sistemik mantar enfeksiyonları ve diğer mantar türleri tarafından oluşturulan enfeksiyonları tedavi etmek amacıyla reçete edilebilir. İşte Fluconazole (Diflucan) hakkında daha fazla bilgi ve kullanımı:\n\nFluconazole (Diflucan) Nedir?:\n* Fluconazole, azol antifungal bir ilaçtır ve birçok mantar türüne karşı etkilidir.\n* Vajinal mantar enfeksiyonları, oral mantar enfeksiyonları, sistemik mantar enfeksiyonları ve diğer mantar türleri tarafından oluşturulan enfeksiyonları tedavi etmek için kullanılabilir.\n* Tablet, kapsül, şurup veya damla formunda bulunabilir.\n\nFluconazole (Diflucan) Kullanımı:\n* Fluconazole, doktor tarafından belirlenen doz ve süre boyunca alınmalıdır.\n* Enfeksiyonun türüne ve şiddetine bağlı olarak, tek doz veya birkaç gün süreyle alınabilir.\n\nFluconazole (Diflucan) Dozu:\n* Doz, hastanın durumuna, enfeksiyonun tipine ve ciddiyetine bağlı olarak değişebilir.\n* Genellikle, vajinal mantar enfeksiyonları için tek bir doz yeterli olabilir, ancak diğer enfeksiyonlar için tedavi süresi uzun olabilir.\n\nFluconazole (Diflucan) kullanımıyla ilgili dikkat edilmesi gereken bazı önemli noktalar şunlar olabilir:\n* Dozaj talimatlarına dikkat edilmelidir ve belirtilen dozlar aşılmamalıdır.\n* Diğer ilaçlarla etkileşimlere neden olabileceği için, kullanılan diğer ilaçlar doktorla paylaşılmalıdır.\n* Gebelik veya emzirme döneminde kullanımı konusunda doktorla konuşulmalıdır.", "Venlafaxine, bir serotonin ve norepinefrin geri alım inhibitörü (SNRI) olarak adlandırılan bir antidepresan ilaçtır ve Effexor markası altında satılmaktadır. Genellikle majör depresyon, panik bozukluk, sosyal anksiyete bozukluğu ve yaygın anksiyete bozukluğu gibi durumların tedavisinde kullanılır. Venlafaxine, serotonin ve norepinefrin adı verilen beyin kimyasallarının seviyelerini düzenleyerek etki eder. İşte Venlafaxine (Effexor) hakkında daha fazla bilgi ve kullanımı:\n\nVenlafaxine (Effexor) Nedir?:\n* Venlafaxine, serotonin ve norepinefrin adı verilen iki nörotransmitterin beyindeki geri alımını engelleyerek depresyon ve anksiyete bozukluklarına karşı etkili olabilir.\n* SNRI sınıfına aittir, bu da hem serotonin hem de norepinefrin üzerinde etki gösterdiği anlamına gelir.\n* Tablet veya kapsül formunda bulunabilir.\n\nVenlafaxine (Effexor) Kullanımı:\n* Venlafaxine, doktor tarafından belirlenen doz ve süre boyunca düzenli olarak alınmalıdır.\n* Tedavi süresi genellikle bireysel duruma bağlıdır ve dozaj yavaşça artırılarak veya azaltılarak ayarlanabilir.\n\nVenlafaxine (Effexor) Dozu:\n* Dozaj, bireyin sağlık durumuna, tedaviye yanıtına ve yan etkilerine bağlı olarak değişebilir.\n* Dozun ani olarak kesilmesi bazen çekilme belirtilerine neden olabilir, bu nedenle doz değişiklikleri doktor gözetiminde yapılmalıdır.\n\nVenlafaxine (Effexor) kullanımıyla ilgili dikkat edilmesi gereken bazı önemli noktalar şunlar olabilir:\n* Bu tür antidepresan ilaçları alkol ile birlikte kullanılmamalıdır.\n* Venlafaxine kullanımı sırasında düzenli doktor kontrolleri önemlidir.\n* Gebelik veya emzirme durumunda kullanımı konusunda doktorla konuşulmalıdır.", "ACE inhibitörleri (Anjiyotensin Dönüştürücü Enzim İnhibitörleri), hipertansiyon (yüksek kan basıncı) ve bazı kalp hastalıklarının tedavisinde kullanılan bir ilaç sınıfıdır. ACE inhibitörleri, anjiyotensin dönüştürücü enziminin (ACE) aktivitesini engelleyerek, kan damarlarının genişlemesine ve kan basıncının düşmesine katkıda bulunur. Ayrıca, kalp yetmezliği gibi durumların tedavisinde de kullanılabilirler. İşte ACE inhibitörleri hakkında daha fazla bilgi:\n\nACE İnhibitörleri Nedir ve Nasıl Çalışır?:\n* ACE inhibitörleri, anjiyotensin dönüştürücü enzimi engelleyerek anjiyotensin I'in anjiyotensin II'ye dönüşümünü önlerler. Anjiyotensin II, kan damarlarının daralmasına ve kan basıncının yükselmesine neden olabilir.\n* Anjiyotensin II'nin etkisinin azaltılması, kan damarlarının genişlemesine ve kan basıncının düşmesine yol açar.\n* Bu mekanizma, kalp yetmezliği durumlarında da kalp iş yükünü azaltabilir.\n\nACE İnhibitörleri Hangi Durumlarda Kullanılır?:\n* Hipertansiyon (yüksek kan basıncı) tedavisinde.\n* Kalp yetmezliği tedavisinde.\n* Koroner arter hastalığı olan bireylerde kalp krizi riskini azaltmak amacıyla kullanılabilir.\n* Böbrek hastalıklarında, özellikle diyabetik nefropati durumlarında kullanılabilir.\n\nBazı ACE İnhibitörleri Örnekleri:\n* Enalapril (Vasotec)\n* Lisinopril (Prinivil, Zestril)\n* Ramipril (Altace)\n* Captopril (Capoten)\n* Fosinopril (Monopril)\n* Benazepril (Lotensin)\n\nACE İnhibitörleri Kullanımı ile İlgili Önemli Hususlar:\n* ACE inhibitörleri genellikle düşük tansiyon, böbrek sorunları veya yüksek potasyum seviyeleri olan bireylerde dikkatle kullanılmalıdır.\n* Gebelik durumunda kullanımı, özellikle ikinci ve üçüncü trimesterlerde, önerildiği durumlar dışında genellikle önerilmez.", "Retinoidler, A vitamini türevleri olan ve cilt hücrelerinin büyümesini ve gelişmesini düzenleyen bir grup kimyasal bileşiktir. Retinoidler, özellikle cilt bakımında ve dermatolojik tedavilerde kullanılan etkili maddelerdir. Bu bileşikler, akne, cilt lekeleri, ince çizgiler ve kırışıklıkların tedavisi için yaygın olarak kullanılır. İşte retinoidler hakkında daha fazla bilgi:\n\nRetinoidlerin Çeşitleri:\n* Retinol:\nRetinol, A vitamini (retinoid) türevidir ve cildin gençleşmesine yardımcı olan bir kozmetik bileşendir. Cilt bakım ürünlerinde yaygın olarak bulunabilir.\n* Retinaldehyde: Retinaldehyde, retinolün bir öncüsüdür ve cilt bakım ürünlerinde kullanılır. Cildin gençleşmesini destekleyen bir madde olarak bilinir.\n* Retinoik Asit (Tretinoin):\nRetinoik asit, cilt hücrelerinin yeniden büyümesini ve cilt yüzeyinin yeniden şekillenmesini uyararak akne ve kırışıklıkların tedavisinde etkili olan bir retinoiddir.\n* Adapalene:\nAdapalene, özellikle akne tedavisi için kullanılan bir retinoiddir. Ayrıca cilt hücrelerinin oluşumunu kontrol ederek akne oluşumunu azaltabilir.\n\nRetinoidlerin Kullanım Alanları:\n* Akne Tedavisi:\nRetinoidler, aknenin tedavisinde yaygın olarak kullanılır. Özellikle tretinoin ve adapalen, akne lekelerini azaltmaya ve yeni lekelerin oluşumunu önlemeye yardımcı olabilir.\n* Anti-Aging (Yaşlanma Karşıtı):\nRetinoidler, cildin gençleşmesini destekleyerek ince çizgileri, kırışıklıkları ve pigmentasyon problemlerini azaltabilir.\n* Cilt Leke Tedavisi:\nRetinoidler, güneş lekeleri veya hiperpigmentasyon gibi cilt lekelerinin tedavisinde etkili olabilir.\n* Cilt Yenileme:\nRetinoidler, cildin hücresel yenilenmesini artırarak cildin daha pürüzsüz ve taze görünmesine yardımcı olabilir.\n\nRetinoidlerin Kullanımı ile İlgili Önemli Hususlar:\n* Retinoidler, ciltte kızarıklık, soyulma ve hassasiyet gibi yan etkilere neden olabilir. Bu nedenle, kullanılmaya başlandığında dikkatli bir şekilde kullanılmalıdır.\n* Retinoidlerin güneşe karşı hassasiyeti artırabileceği unutulmamalıdır. Bu nedenle, retinoid kullanımı sırasında güneş koruyucu ürünlerin düzenli olarak kullanılması önerilir.\n* Hamilelik döneminde retinoid kullanımından kaçınılmalıdır, çünkü bazı retinoidler fetal gelişimi etkileyebilir.", "Warfarin, bir antikoagülan veya kan sulandırıcı olarak adlandırılan bir ilaçtır. Kan pıhtılarını önleyerek veya mevcut pıhtıların büyümesini engelleyerek çalışır. Warfarin, genellikle kalp krizi, inme ve diğer damar tıkanıklıklarını önlemek veya tedavi etmek amacıyla kullanılır. İşte Warfarin hakkında daha fazla bilgi:\n\nWarfarin Kullanımı ve Çalışma Mekanizması:\n* Warfarin, vitamin K'ya bağlı olarak çalışan bir antikoagülandır. Vitamin K, pıhtı oluşumunda önemli bir rol oynar.\n* Warfarin, karaciğerdeki vitamin K epoksid reductase enzimini inhibe ederek vitamin K'nın aktif formunu oluşturmasını engeller. Aktif vitamin K, pıhtı oluşumunda rol alan faktörlerin sentezinde önemli bir rol oynar.\n* Bu mekanizma, pıhtı oluşumunu engelleyerek veya mevcut pıhtıların büyümesini durdurarak kanın daha az pıhtılaşmasını sağlar.\n\nWarfarin Kullanım Alanları:\n* Atriyal Fibrilasyon:\nKalbin üst odacıklarının düzensiz atışları durumunda, pıhtı oluşumunu önlemek amacıyla kullanılabilir.\n* Derin Ven Trombozu (DVT) ve Pulmoner Emboli (PE):\nBacak damarlarında veya akciğerlerde pıhtı oluşumu durumunda kullanılabilir.\n* Kalp Kapak Protezleri:\nKalp kapak ameliyatı geçiren kişilerde, protez kapakların etrafında pıhtı oluşumunu önlemek için kullanılabilir.\n* Damar Tıkanıklıkları:\nKalp krizi veya inme riskini azaltmak amacıyla kullanılabilir.\n\nWarfarin Kullanımı ile İlgili Önemli Hususlar:\n* Warfarin, dikkatlice izlenen bir ilaçtır ve dozaj, kan pıhtılaşma zamanını ölçen bir test olan INR (International Normalized Ratio) ile sıkça kontrol edilir.\n* Warfarin kullanımı sırasında düzenli olarak kan testleri yapılması önemlidir.\n* İlacın yan etkileri arasında kanamalar ve morarmalar bulunabilir. Eğer beklenmeyen kanama belirtileri ortaya çıkarsa, hemen sağlık profesyoneli ile iletişime geçilmelidir.\n* Warfarin, bazı ilaçlar ve besinlerle etkileşime girebilir, bu nedenle kullanılan diğer ilaçlar ve diyet de dikkatle takip edilmelidir.", "Methotrexate, bir kemoterapi ilacı olup, romatoid artrit, psoriasis (sedef hastalığı), jüvenil idiopatik artrit, ülseratif kolit ve bazı kanser türlerinin tedavisinde kullanılan bir ilaçtır. Methotrexate, bağışıklık sistemini baskılayarak ve hücre çoğalmasını engelleyerek etki gösterir. İşte Methotrexate hakkında daha fazla bilgi:\n\nMethotrexate Kullanım Alanları:\n* Romatoid Artrit:\nRomatoid artrit gibi otoimmün hastalıklarda, iltihaplı eklemleri rahatlatmak ve hastalığın ilerlemesini yavaşlatmak için kullanılabilir.\n* Psoriasis (Sedef Hastalığı):\nCiltteki hücre büyümesini kontrol etmek ve inflamasyonu azaltmak amacıyla psoriasis tedavisinde kullanılabilir.\nJüvenil İdiopatik Artrit: Çocuklarda görülen bu tip artrit tedavisinde kullanılabilir.\n* Ülseratif Kolit:\nBağırsak iltihabını kontrol etmek amacıyla kullanılabilir.\n* Kanser Tedavisi:\nMethotrexate, lösemi, lenfoma, meme kanseri ve akciğer kanseri gibi çeşitli kanser türlerinin tedavisinde kullanılabilir.\n\nMethotrexate Kullanımı ile İlgili Önemli Hususlar:\n* Methotrexate, dikkatlice izlenen bir ilaçtır ve genellikle düşük dozlarda kullanılarak tedaviye başlanır. Dozaj, bireysel duruma ve tedavi amaçlarına bağlı olarak değişebilir.\n* Methotrexate, bağışıklık sistemini baskılayarak çalıştığından, enfeksiyon riskini artırabilir. Bu nedenle, kullanıldığı süre boyunca düzenli kan testleri yapılması önemlidir.\n* Methotrexate kullanırken alkol tüketimi genellikle önerilmez, çünkü alkol ve Methotrexate birlikte karaciğer üzerinde ekstra baskı oluşturabilir.\n* Gebelik sırasında veya gebelik planı içerisinde olan kişilerde kullanımı konusunda dikkatli olunmalıdır, çünkü Methotrexate doğmamış bir bebeğe zarar verebilir.\n* Methotrexate kullanımı sırasında düzenli hekim kontrolleri ve laboratuvar testleri gereklidir.", "Thalidomide, 1950'ler ve 1960'lar boyunca gebelikte kullanılan bir ilaç olarak tanıtıldı, ancak fetüs gelişiminde ciddi anormalliklere neden olduğu ortaya çıktı. Bu durum, thalidomide'nin dünya çapında gebelikte kullanımının yasaklanmasına ve ilacın diğer tedavi amaçları için dikkatlice kullanılmasına yol açtı.\n\nThalidomide Kullanımı ve Öyküsü:\n* Geçmişteki Kullanımı:\nThalidomide, başlangıçta gebelikte kusmaları önlemek ve uykusuzluğu tedavi etmek amacıyla pazarlanmıştı. Ancak, bu ilacın kullanımı, özellikle gebeliğin ilk trimesterinde kullanıldığında, doğuştan gelen anomalilere, özellikle de bebeklerin kollarında ve bacaklarında kısalıklara neden oldu.\n* Gebelik Kategorisi X:\nThalidomide, FDA tarafından Gebelik Kategorisi X'ye (fetal hasar riski yüksek) dahil edilmiştir, bu nedenle gebeler veya hamilelik planlayan kadınlar tarafından kullanılması kesinlikle önerilmez.\n* Günümüzdeki Kullanımı:\nThalidomide, immün sistemi baskılayarak ve anti-angiogenesis özellikleri göstererek etki eder. Bu nedenle günümüzde, özellikle multipl miyelom ve lepra (cüzzam) gibi belirli durumların tedavisinde dikkatlice kullanılmaktadır.\n\nThalidomide Kullanımı ile İlgili Önemli Hususlar:\n* Gebelikten Kaçınma:\nThalidomide'nin kullanımı sırasında, özellikle de üreme potansiyeli olan bireylerde, etkili doğum kontrol yöntemleri kullanılmalıdır.\n* Kan Testleri ve İzleme:\nThalidomide tedavisi sırasında düzenli kan testleri ve hekim gözetimi gereklidir. Bu, ilacın olası yan etkilerinin ve komplikasyonlarının izlenmesine yardımcı olur.", "İfosfamid, bir alkilasyon ajani olarak bilinen bir kemoterapi ilacıdır. İfosfamid, hücrelerin DNA'sına zarar vererek ve hücre çoğalmasını engelleyerek çalışır. Bu, özellikle kanser hücrelerini etkiler ve çeşitli kanser türlerinin tedavisinde kullanılır. İfosfamid, bir dizi kanser türüne karşı etkili olabilir, ancak kullanımı dikkatlice izlenmelidir. İşte İfosfamid hakkında daha fazla bilgi:\n\n* İfosfamid Kullanımı ve Kanser Tedavisi:\nİfosfamid, genellikle lenfoma, yumurtalık kanseri, akciğer kanseri, meme kanseri, sarkom (bağ dokusu kanseri), nöroblastoma (sinir hücreleri kökenli kanser) gibi çeşitli kanser türlerinin tedavisinde kullanılır.\nKanser hücrelerini hedefleyen bir alkilasyon ajani olarak, İfosfamid, hücrelerin genetik materyali olan DNA'nın yapısına zarar vererek hücre çoğalmasını engeller.\n\nİfosfamid Kullanımı ile İlgili Önemli Hususlar:\n* Anti-Üreme Etkisi:\nİfosfamid, sperm üretimini ve yumurta hücresi olgunlaşmasını etkileyebilir. Tedavi sırasında ve sonrasında doğum kontrolü kullanılması önemlidir.\n* Böbrek Fonksiyonları:\nİfosfamid, böbrekleri etkileyebilir. Tedavi sırasında ve sonrasında böbrek fonksiyonları düzenli olarak izlenmelidir.\n* İnfüzyon Yoluyla Uygulama:\nGenellikle damar içi yolla bir sağlık profesyoneli tarafından uygulanır. İfosfamid tedavisi sırasında sıklıkla diğer ilaçlar ve sıvılar da aynı zamanda verilir.\n\nYan Etkiler ve Komplikasyonlar:\n* İfosfamid tedavisinin yan etkileri arasında mide bulantısı, kusma, saç dökülmesi, bağışıklık sisteminin zayıflaması ve böbrek sorunları bulunabilir.", "Warfarin, bir antikoagülan veya kan sulandırıcı olarak adlandırılan bir ilaçtır. Kan pıhtılarını önleyerek veya mevcut pıhtıların büyümesini engelleyerek çalışır. Warfarin, genellikle kalp krizi, inme ve diğer damar tıkanıklıklarını önlemek veya tedavi etmek amacıyla kullanılır. İşte Warfarin hakkında daha fazla bilgi:\n\nWarfarin Kullanımı ve Çalışma Mekanizması:\n* Warfarin, vitamin K'ya bağlı olarak çalışan bir antikoagülandır. Vitamin K, pıhtı oluşumunda önemli bir rol oynar.\n* Warfarin, karaciğerdeki vitamin K epoksid reductase enzimini inhibe ederek vitamin K'nın aktif formunu oluşturmasını engeller. Aktif vitamin K, pıhtı oluşumunda rol alan faktörlerin sentezinde önemli bir rol oynar.\n* Bu mekanizma, pıhtı oluşumunu engelleyerek veya mevcut pıhtıların büyümesini durdurarak kanın daha az pıhtılaşmasını sağlar.\n\nWarfarin Kullanım Alanları:\n* Atriyal Fibrilasyon:\nKalbin üst odacıklarının düzensiz atışları durumunda, pıhtı oluşumunu önlemek amacıyla kullanılabilir.\n* Derin Ven Trombozu (DVT) ve Pulmoner Emboli (PE):\nBacak damarlarında veya akciğerlerde pıhtı oluşumu durumunda kullanılabilir.\n* Kalp Kapak Protezleri:\nKalp kapak ameliyatı geçiren kişilerde, protez kapakların etrafında pıhtı oluşumunu önlemek için kullanılabilir.\n* Damar Tıkanıklıkları:\nKalp krizi veya inme riskini azaltmak amacıyla kullanılabilir.\n\nWarfarin Kullanımı ile İlgili Önemli Hususlar:\n* Warfarin, dikkatlice izlenen bir ilaçtır ve dozaj, kan pıhtılaşma zamanını ölçen bir test olan INR (International Normalized Ratio) ile sıkça kontrol edilir.\n* Warfarin kullanımı sırasında düzenli olarak kan testleri yapılması önemlidir.\n* İlacın yan etkileri arasında kanamalar ve morarmalar bulunabilir. Eğer beklenmeyen kanama belirtileri ortaya çıkarsa, hemen sağlık profesyoneli ile iletişime geçilmelidir.\n* Warfarin, bazı ilaçlar ve besinlerle etkileşime girebilir, bu nedenle kullanılan diğer ilaçlar ve diyet de dikkatle takip edilmelidir.", "Misoprostol, prostaglandin adı verilen maddeleri taklit eden bir sentetik prostaglandin analogu olarak sınıflandırılan bir ilaçtır. Genellikle mide ülseri tedavisi ve gebelik sonlandırma (düşük) amacıyla kullanılır. İşte Misoprostol hakkında daha fazla bilgi:\n\nMisoprostol Kullanımı:\n* Mide Ülseri Tedavisi:\nNonsteroidal anti-inflamatuar ilaçlara (NSAID'ler) bağlı mide ülserlerinin tedavisinde kullanılabilir. Misoprostol, mide mukozasının korunmasına yardımcı olabilir.\n* Gebelik Sonlandırma (Düşük):\nMisoprostol, gebeliği sonlandırmak için kullanılabilecek etkili bir ilaçtır. Bu kullanım genellikle başka bir ilaç olan mifepristone (RU-486) ile birleştirilir.\n\nMisoprostol Kullanımı ile İlgili Önemli Hususlar:\n* Misoprostol, hamilelik sonlandırma (düşük) amacıyla kullanıldığında, genellikle bir sağlık profesyoneli tarafından yönlendirilir ve izlenir.\n* Misoprostol kullanımı sırasında, özellikle gebelikle ilgili kullanımlarda, yan etkiler ve riskler dikkate alınmalıdır.\n* Hamilelik sonlandırma amacıyla kullanılan dozajlar, bireyin sağlık durumuna, gebelik süresine ve diğer faktörlere bağlı olarak değişebilir.\n\nMisoprostol'ün Yan Etkileri:\n* Misoprostol kullanımı bazı yan etkilere neden olabilir. Bu yan etkiler arasında mide bulantısı, kusma, ishal, karın ağrısı ve vajinal kanama bulunabilir.\n\nMisoprostol Kullanımı ve Gebelik:\n* Misoprostol, gebeliği sonlandırmak amacıyla kullanıldığında, genellikle doktor gözetiminde ve talimatlarına uygun olarak kullanılmalıdır.\n* Hamilelikle ilgili bir kullanım durumunda, bireyin durumuna ve hamileliğin özelliklerine bağlı olarak farklı protokoller izlenebilir." };
            List<string> ListelenenIlaclar = new List<string>();

            Console.WriteLine("Hoşgeldiniz");
            Console.WriteLine("Kategorilendirme FDA Standartlarına Göre Yapılmıştır");
            Console.WriteLine("!!İlaç Bilgileri ChatGPT'den Alınmıştır!!");

            bool Kontrol = true; bool SKontrol = true; bool IKontrol = true; int Secim = 0; int ISecim = 0; int Index = 0; string SSecim = "";

            while (Kontrol)
            {
                while (SKontrol)
                {
                    Console.WriteLine("Lütfen Kategori Seçiniz");
                    for (int i = 0; i < IlacKategorileri.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}) {IlacKategorileri[i]}");
                    }
                    Secim = Convert.ToInt32(Console.ReadLine());

                    if (!(Secim > IlacKategorileri.Length || Secim <= 0))
                    {
                        Console.Clear();
                        SKontrol = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Lütfen Geçerli Bir Değer Giriniz");
                    }
                }

                for (int i = 0; i < Ilaclar.Length; i++)
                {
                    if (IlacKategorileri[Secim - 1] == IlaclarinKategorileri[i])
                    {
                        ListelenenIlaclar.Add(Ilaclar[i]);
                    }
                }

                for (int i = 0; i < ListelenenIlaclar.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {ListelenenIlaclar[i]}");
                }

                while (IKontrol)
                {
                    Console.WriteLine("Lütfen Hangi İlacı İncelemek İstediğinizi Seçiniz");
                    ISecim = Convert.ToInt32(Console.ReadLine());

                    if (!(ISecim > ListelenenIlaclar.Count || ISecim <= 0))
                    {
                        Console.Clear();
                        IKontrol = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Lütfen Geçerli Bir Değer Giriniz");
                        for (int i = 0; i < ListelenenIlaclar.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}) {ListelenenIlaclar[i]}");
                        }
                    }
                }

                for (int i = 0; i < Ilaclar.Length; i++)
                {
                    if (ListelenenIlaclar[ISecim - 1] == Ilaclar[i])
                    {
                        Index = Array.IndexOf(Ilaclar, ListelenenIlaclar[ISecim - 1]);
                        break;
                    }
                }

                Console.WriteLine(IlaclarBilgilendirme[Index]);

                Console.WriteLine("İlaç Sorgulamaya Devam Etmek İster Misiniz? e/h");
                SSecim = Console.ReadLine();

                if (SSecim == "e" || SSecim == "E")
                {
                    Kontrol = true; SKontrol = true; IKontrol = true; Secim = 0; ISecim = 0; SSecim = ""; ListelenenIlaclar.Clear(); Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Kontrol = false;
                }
            }

            Console.WriteLine("Görüşmek Üzere");
            #endregion
        }
    }
}

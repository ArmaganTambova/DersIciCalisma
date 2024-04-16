using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DosyaVeKlasorIslemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama
            /*
             Bilgisayar İçerisinde Dosya Ve Klasörlerle Erişim Ve Oluşturma İşlemleri İçin Kullanılır
             using System.IO Kütüphanesi İçerisinde Bulunana Sınıflar İle İşlem Yapılır
            */
            #endregion

            #region FileInfo Sınıfı
            //string TxtYolu = "C://Armagan/Nikola.txt";
            //string DocYolu = "C://Armagan/Nikola.docx";

            //FileInfo TXT = new FileInfo(TxtYolu);
            //FileInfo DOCX = new FileInfo(DocYolu);

            //Console.WriteLine("Dosya Adı = " + TXT.Name);
            //Console.WriteLine("Dosya Yolu = " + TXT.FullName);

            //Console.WriteLine("Dosya Uzantısı = " + TXT.Extension);
            //Console.WriteLine("Dosya Var Mı? = " + TXT.Exists);

            //Console.WriteLine("Dosya Boyutu = " + TXT.Length + " byte");

            //Console.WriteLine("Dosya Klasör Yolu = " + TXT.DirectoryName);
            //Console.WriteLine("Dosya Klasör Adı = " + TXT.Directory);

            //Console.WriteLine("Oluşturma Zamanı = " + TXT.CreationTime);
            //Console.WriteLine("Son Erişim Zamanı = " + TXT.LastAccessTime);

            //Console.WriteLine("Salt Okunur Dosya Mı? = " + TXT.IsReadOnly);

            //Console.WriteLine("<<**>>");

            //Console.WriteLine("Dosya Adı = " + DOCX.Name);
            //Console.WriteLine("Dosya Yolu = " + DOCX.FullName);

            //Console.WriteLine("Dosya Uzantısı = " + DOCX.Extension);
            //Console.WriteLine("Dosya Var Mı? = " + DOCX.Exists);

            //Console.WriteLine("Dosya Boyutu = " + DOCX.Length + " byte");

            //Console.WriteLine("Dosya Klasör Yolu = " + DOCX.DirectoryName);
            //Console.WriteLine("Dosya Klasör Adı = " + DOCX.Directory);

            //Console.WriteLine("Oluşturma Zamanı = " + DOCX.CreationTime);
            //Console.WriteLine("Son Erişim Zamanı = " + DOCX.LastAccessTime);

            //Console.WriteLine("Salt Okunur Dosya Mı? = " + DOCX.IsReadOnly);
            #endregion

            #region Dosya Oluşturma
            //FileInfo Fi = new FileInfo("C://Armagan/BenYaptim.txt");

            //Fi.Create(); // İçinin Dolu Olup Olmadığına Bakmaksızın Yeniden Oluşturur

            //if (!Fi.Exists)
            //{
            //    Fi.Create();
            //}

            //Fi.Delete();
            #endregion

            #region DirectoryInfo Sınıfı
            //string KlasorYolu = "C://Armagan/";

            //DirectoryInfo Di = new DirectoryInfo(KlasorYolu);

            //Console.WriteLine("Klasör Adı = " + Di.Name);
            //Console.WriteLine("Klasör Tam Adı = " + Di.FullName);

            //Console.WriteLine("Klasör Var Mı? = " + Di.Exists);

            //Console.WriteLine("Oluşturma Zamanı = " + Di.CreationTime);
            //Console.WriteLine("Son Erişim Zamanı = " + Di.LastAccessTime);
            #endregion

            #region Alt Klasörleri Listelemek
            //DirectoryInfo Di2 = new DirectoryInfo("C://");

            //DirectoryInfo[] Klasorler = Di2.GetDirectories();

            //foreach (DirectoryInfo Item in Klasorler)
            //{
            //    Console.WriteLine(Item.Name);
            //}
            #endregion

            #region Dosyaları Listemek
            //DirectoryInfo Di3 = new DirectoryInfo("C://");
            //FileInfo[] Dosyalar = Di3.GetFiles();

            //foreach (FileInfo Item in Dosyalar)
            //{
            //    Console.WriteLine(Item.Name);
            //}
            #endregion

            #region Dosya Yazma
            //StreamWriter Sw = new StreamWriter("C://Armagan/Deneme.txt", true); // true Burada Üst Üste Eklemeyi Aktifleştiriyor
            //Sw.WriteLine("Nörüyonuz?");
            //Sw.Close();
            #endregion

            #region Dosya Okuma
            //StreamReader Sr = new StreamReader("C://Armagan/Nikola.txt");
            //Console.WriteLine(Sr.Read());

            //Console.WriteLine(Sr.ReadLine()); // İlk Satırı Okur
            //Console.WriteLine(Sr.ReadLine()); // Okunmamış Sıradaki Satırı Okur

            //Console.WriteLine(Sr.ReadToEnd()); // Başından Sonuna Kadar Oku
            //Sr.Close();
            #endregion
        }
    }
}

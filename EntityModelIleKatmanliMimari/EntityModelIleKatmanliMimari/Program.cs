using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriErisimKatmani;

namespace EntityModelIleKatmanliMimari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama
            /*
             Solution İçerisinde İhtiyaç Duyduğumuz Projeleri Tutan Yapıdır
             Her Proje Farklı Bir Amaca Hizmet Edebilir
             Biz Şimdiye Kadar Her Solution İçerisinde Bir Proje Tipini Kullandık
             Yani Her Proje Açışımızda Proje Console Uygulaması İse Sadece Console, Proje Masaüstü Uygulaması İse SWinForm Proje Tipini Kullandık
             Şimdi İse Veritabanı İşlemleri İçin Ayrı Bir Proje Oluşturacağız
             Oluşturduğumuz Proje Tek Başına Çalışma Özelliği Olmayan, Amacı .dll Oluşturmak Olan classLibrary Projesi Olacaktır
             Oluşturulan Her .dll Aslında Şimdiye Kadar Projelerimizde Kullandığımız using.System.Collections Gibi Birer .dll Olacaktır
             Yani Kendi Kütüphanemizi Oluşturacağız
             Veritabanı İşlemlerini .dll İçerisinde Yazmak CleanCode Yaklaşımına Uygun Kod Yazmamızı Sağlar
             Ayrıca Oluşan .dll Kodlarımızı Şifrelediği İçin ADO.NET Kodlarımız Ve Veritabanımızın Güvenliğini Arttırmış Olacağız
            */
            #endregion

            #region ClassLibrary Ekleme Ve Kullanımı

            // 1) Öncelikle Solution'a Sağ Tıklayıp "Add => New Project => ClassLibrary(.Net Framework)" Yolunu İzleyerek Sınıf Kütüphanemizi Solution'a Ekliyoruz

            #endregion

            #region Tür Ekleme
            //VeriIslem vi = new VeriIslem();

            //Console.WriteLine("Tür Adını Yazınız");
            //string TurIsim = Console.ReadLine();

            //if (vi.TurEkle(TurIsim))
            //{
            //    Console.WriteLine("Başarılı İşlem");
            //}
            //else
            //{
            //     Console.WriteLine("Başarısız İşlem");
            //}
            #endregion

            #region Tür Ekleme - Entity Model
            //VeriIslem vi = new VeriIslem();
            //Tur t = new Tur();

            //Console.WriteLine("Tür Adını Yazınız");
            //t.Isim = Console.ReadLine();

            //if (vi.TurEkleEntity(t))
            //{
            //    Console.WriteLine("Ekleme Başarılı");
            //}
            //else
            //{
            //    Console.WriteLine("Ekleme Başarısız");
            //}
            #endregion
        }
    }
}

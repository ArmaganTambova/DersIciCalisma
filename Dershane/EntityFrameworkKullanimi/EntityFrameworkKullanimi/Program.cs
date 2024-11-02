using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkKullanimi
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama

            //CRUD işlemlerini ve daha fazlasını (tüm veritabanı işlemlerini) yönetmek için kullanılan .NET Framework kütüphanesidir.

            #endregion

            NORTHWNDEntities1 ne = new NORTHWNDEntities1();

            #region Kullanım - Kategorileri Listeleyelim

            //1.öğreneceğimiz basamak Database First

            List<Categories> kategoriler = ne.Categories.ToList();

            foreach (Categories item in kategoriler)
            {
                Console.WriteLine($"{item.CategoryID} {item.CategoryName} {item.Description}");
            }

            #endregion

            #region Kullanım - Kategori Ekleyelim

            //Console.WriteLine("Kategori Adı = ");
            //string kategoriAdi = Console.ReadLine();

            //Console.WriteLine("Açıklama = ");
            //string aciklama = Console.ReadLine();

            //Categories c = new Categories();
            //c.CategoryName = kategoriAdi;
            //c.Description = aciklama;

            //ne.Categories.Add(c);
            //try
            //{
            //    ne.SaveChanges();
            //    Console.WriteLine("Kategori Eklendi");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Başarısız");
            //}

            #endregion

            #region Kullanım - Ürün Listeleyelim

            //List<Products> urunler = ne.Products.ToList();

            //foreach (Products item in urunler)
            //{
            //    Console.WriteLine($"{item.ProductID}) {item.ProductName} {item.Categories.CategoryName} {item.Suppliers.CompanyName} {item.Suppliers.Address}");
            //}

            #endregion

            #region Kullanım - Deniz Ürünleri Kategorisindeki Ürünleri Listeleyelim

            //List<Products> denizurunleri = ne.Products.Where(p => p.CategoryID == 8).ToList();
            //denizurunleri.ForEach(x => Console.WriteLine(x.ProductID + ") " + x.ProductName + x.Categories.CategoryName));

            #endregion

            #region Kullanım - Kategori Silme

            //Categories cat = ne.Categories.Find(15);
            //if (cat !=null)
            //{
            //    ne.Categories.Remove(cat);
            //    ne.SaveChanges();
            //}
            //else
            //{
            //    Console.WriteLine("Kategori Bulunamadı");
            //}

            #endregion

            #region Kullanım - Kategori Güncelleme

            //Güncellenecek olan kategori MUTLAKA find ile çekilmiş olması gerekir
            //Find ile çekilmiş olan veri değiştirildiğinde nesnenin içinde bulunan "EntityState" durumunu "Modified" yapar.
            //Save changes ise her çalıştığında önce modified olan nesnem var mı diye kontrol eder ve modified olanları günceller.

            //Categories cat = ne.Categories.Find(13);
            //cat.CategoryName = "Şarküteri";
            //cat.Description = "Et, Süt, Peynir";

            //ne.SaveChanges();

            #endregion
        }
    }
}

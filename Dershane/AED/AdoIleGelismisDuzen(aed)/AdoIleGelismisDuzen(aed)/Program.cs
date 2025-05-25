using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoİleGelismisDüzen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataModel dm = new DataModel();
            string devam = "E";
            while (devam.ToLower() == "e")
            {
                List<Kategori> kategoriler = dm.KategoriListele();
                dm.KategoriYazdır(kategoriler);
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi iseçiniz");
                Console.WriteLine("1-kategori ekle , 2-Kategori düzenle");
                int islem = Convert.ToInt32(Console.ReadLine());
                if (islem == 1)
                {
                    Kategori k = new Kategori();
                    Console.WriteLine("Lütfen kategori adını giriniz");
                    k.Isim = Console.ReadLine();
                    Console.WriteLine("Lütfen kategori açıklamasını giriniz");
                    k.Aciklama = Console.ReadLine();
                    if (dm.KategoriEkle(k))
                    {
                        kategoriler = dm.KategoriListele();
                        dm.KategoriYazdır(kategoriler);
                    }
                    else
                    {
                        Console.WriteLine("başarısız olmuştur");
                    }
                }
                else if (islem == 2)
                {
                    Console.WriteLine("Lütfen güncellemek istediğiniz kategorinin numarasını giriniz");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Kategori k = dm.KategoriGetir(id);
                    Console.WriteLine("Lütfen kategori adını giriniz");
                    k.Isim = Console.ReadLine();
                    Console.WriteLine("Lütfen kategori açıklamasını giriniz");
                    k.Aciklama = Console.ReadLine();
                    if (dm.KategoriGuncelle(k))
                    {
                        kategoriler = dm.KategoriListele();
                        dm.KategoriYazdır(kategoriler);
                    }
                    else
                    {
                        Console.WriteLine("başarısız olmuştur");
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen Doğru seçenek girdiğinize emin olunuz");
                }
                Console.WriteLine("İşleme devam etmek için E çıkmak için H'ye basınız");
                devam = Console.ReadLine();
            }
        }
    }
}

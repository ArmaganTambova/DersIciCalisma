using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericKavrami
{
    // Jenerik Kavramı 
    // Özellikle Metotlarda Kullanılacak Field Türünün Kod Yazım Esnasında Belirlenip Nesnenin İstenilen Türlerde Fieldlara Sahip Olması Sağlanır
    // Generic Türü Nesne Oluştururken Sınıf İle Beraber Tanımlanmalıdır

    internal class Program
    {
        static void Main(string[] args)
        {
            // "Ins1" İsimli Nesnenin Generic Türü "int" Olarak Gönderildi
            // Bu Sebeple Generic Tür Belirleyicisine Sahip "Yas" Field'ı "int" Türüne Tanımlandı 
            Insan<int> Ins1 = new Insan<int>();
            Ins1.Isim = "Armağan";
            Ins1.Soyisim = "Tambova";
            Ins1.Yas = 15;
            Ins1.Yazdir();

            // "Ins2" İsimli Nesnenin Generic Türü "string" Olarak Gönderildi
            // Bu Sebeple Generic Tür Belirleyicisine Sahip "Yas" Field'ı "string" Türüne Tanımlandı 
            Insan<string> Ins2 = new Insan<string>();
            Ins2.Isim = "Murtaza";
            Ins2.Soyisim = "Şuayipoğlu";
            Ins2.Yas = "55";
            Ins2.Yazdir();
        }
    }

    // Generic Class
    class Insan<T> // "T" Generic Tür Belirleyicisi, T Yerine Herhangi Bir Karakter Yazılabilir
    {
        public string Isim;
        public string Soyisim;
        public T Yas;

        public void Yazdir()
        {
            Console.WriteLine($"{Isim} {Soyisim} {Yas}");
        }
    }
}

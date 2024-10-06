using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JsonSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urn1 = new Urun();
            urn1.ID = 1;
            urn1.Isim = "Bardak";
            urn1.AlisFiyat = 60;
            urn1.SatisFiyat = 360;

            Urun urn2 = new Urun();
            urn2.ID = 2;
            urn2.Isim = "Tabak";
            urn2.AlisFiyat = 120;
            urn2.SatisFiyat = 400;

            Urun urn3 = new Urun();
            urn3.ID = 3;
            urn3.Isim = "Çatal";
            urn3.AlisFiyat = 10;
            urn3.SatisFiyat = 50;

            Urun urn4 = new Urun();
            urn4.ID = 4;
            urn4.Isim = "Kaşık";
            urn4.AlisFiyat = 15;
            urn4.SatisFiyat = 55;

            Urun urn5 = new Urun();
            urn5.ID = 5;
            urn5.Isim = "Bıçak";
            urn5.AlisFiyat = 30;
            urn5.SatisFiyat = 70;

            Urun urn6 = new Urun();
            urn6.ID = 6;
            urn6.Isim = "Fincan";
            urn6.AlisFiyat = 450.50;
            urn6.SatisFiyat = 850.99;

            Urun urn7 = new Urun();
            urn7.ID = 7;
            urn7.Isim = "Kesme Tahtası";
            urn7.AlisFiyat = 125;
            urn7.SatisFiyat = 368;

            Urun urn8 = new Urun();
            urn8.ID = 8;
            urn8.Isim = "Masa Örtüsü";
            urn8.AlisFiyat = 5;
            urn8.SatisFiyat = 250;
            
            Urun urn9 = new Urun();
            urn9.ID = 9;
            urn9.Isim = "Kadeh";
            urn9.AlisFiyat = 550;
            urn9.SatisFiyat = 1249.99;

            Urun urn10 = new Urun();
            urn10.ID = 10;
            urn10.Isim = "Sebil";
            urn10.AlisFiyat = 95;
            urn10.SatisFiyat = 399.99;

            List<Urun> UrunlerListe = new List<Urun>();

            UrunlerListe.Add(urn1);
            UrunlerListe.Add(urn2);
            UrunlerListe.Add(urn3);
            UrunlerListe.Add(urn4);
            UrunlerListe.Add(urn5);
            UrunlerListe.Add(urn6);
            UrunlerListe.Add(urn7);
            UrunlerListe.Add(urn8);
            UrunlerListe.Add(urn9);
            UrunlerListe.Add(urn10);

            string Serilestirilmis = JsonSerialize(UrunlerListe);
            Console.WriteLine(Serilestirilmis);

            Console.WriteLine("*/*/*/*/*/*/*/*/*/*");

            List<Urun> Deserilestirilmis = JsonConvert.DeserializeObject<List<Urun>>(Serilestirilmis);
            foreach (var item in Deserilestirilmis)
            {
                Console.WriteLine($"ID: {item.ID}, Isim: {item.Isim}, AlisFiyat: {item.AlisFiyat}, SatisFiyat: {item.SatisFiyat}");
            }
        }

        public static string JsonSerialize(object data)
        {
            return JsonConvert.SerializeObject(data, Formatting.None, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Objects
            });
        }
    }

    [Serializable]
    public class Urun
    {
        public int ID { get; set; }
        public string Isim { get; set; }
        [NonSerialized]
        public double AlisFiyat;
        public double SatisFiyat { get; set; }
    }
}

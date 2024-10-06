using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace SerializationNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama
            /*
             Bir Nesnedeki Verilerin Bir Yerde Depolanması Veya Ağ Ortamında Bir Yerden Bir Yere Gönderilmesi Gerektiği Durumlarda Uygun Formata Dönüştürülmesi İşlemine Denir
             
             Serileştirme İşlemini Ve Serileştirilmiş Nesneleri Dönüştürme İşlemini (İşlem 2 Yönlü Olarak ELe Alınabilir) Gercekleştirecek Olan Nesneler System.Net.Runime.Serialization namespace'inde Bulunmaktadır.
             Serialization İşlemi 
            */
            #endregion

            Urun urn = new Urun() { ID = 1, Isim = "Bardak", AlisFiyat = 60, SatisFiyat = 360 };

            #region Binary Serialization
            //byte[] serilestirilmis = BinarySerialize(urn);

            //foreach (byte item in serilestirilmis)
            //{
            //    Console.Write(item.ToString());
            //}

            //object deserilestirilmis = BinaryDeserialize(serilestirilmis);
            //Urun urnGelen = (Urun)deserilestirilmis;
            //Console.WriteLine($"\nID = {urnGelen.ID}, İsim = {urnGelen.Isim}, Alış Fiyat = {urnGelen.AlisFiyat}, Satış Fiyat = {urnGelen.SatisFiyat}");
            #endregion

            #region JSON Serialization
            //string serilestirilmis = JsonSerialize(urn);
            //Console.WriteLine(serilestirilmis);

            //object deserilestirilmis = JsonDeserialize(serilestirilmis);
            //Urun urunGelen = (Urun)deserilestirilmis;
            //Console.WriteLine($"ID = {urunGelen.ID}, İsim = {urunGelen.Isim}, Alış Fiyat = {urunGelen.AlisFiyat}, Satış Fiyat = {urunGelen.SatisFiyat}");
            #endregion

            #region XML Serialization
            string serilestirilmis = XmlSerialize(urn);
            Console.WriteLine(serilestirilmis);

            Urun urunGelen = XmlDeserialize(serilestirilmis);
            Console.WriteLine($"ID = {urunGelen.ID}, İsim = {urunGelen.Isim}, Alış Fiyat = {urunGelen.AlisFiyat}, Satış Fiyat = {urunGelen.SatisFiyat}");
            #endregion
        }

        public static byte[] BinarySerialize(object data)
        {
            MemoryStream stream = new MemoryStream();

            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, data);

            return stream.ToArray();
        }

        public static object BinaryDeserialize(byte[] data)
        {
            MemoryStream strean = new MemoryStream(data);

            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(strean);
        }

        public static string JsonSerialize(object data)
        {
            return JsonConvert.SerializeObject(data, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Objects
            }); // Formatting.None
        }

        public static object JsonDeserialize(string data)
        {
            return JsonConvert.DeserializeObject(data, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Objects
            });
        }

        public static string XmlSerialize(Urun data)
        {
            XmlSerializer serilestirici = new XmlSerializer(typeof(Urun));

            TextWriter writer = new StringWriter();

            serilestirici.Serialize(writer, data);

            return writer.ToString();
        }

        public static Urun XmlDeserialize(string XmlData)
        {
            XmlSerializer deserilestirici = new XmlSerializer(typeof(Urun));

            StringReader reader = new StringReader(XmlData);

            XmlReader xmlReader = new XmlTextReader(reader);

            if (deserilestirici.CanDeserialize(xmlReader))
            {
                Urun urunGiden = (Urun)deserilestirici.Deserialize(xmlReader);
                return urunGiden;
            }
            return null;
        }
    }

    [Serializable]
    public class Urun
    {
        [XmlAttribute]
        public int ID {  get; set; }
        public string Isim { get; set; }
        [NonSerialized]
        [XmlIgnore]
        public double AlisFiyat;
        public double SatisFiyat { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneYonelimliProgramlamaIlac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ilaclar FolikAsit = new Ilaclar();
            FolikAsit.IlacAdi = "Folik Asit (Folic Acid)";
            FolikAsit.IlacKategori = "A";

            Ilaclar Metformin = new Ilaclar();
            Metformin.IlacAdi = "Metformin";
            Metformin.IlacKategori = "A";

            Ilaclar Levotiroksin = new Ilaclar();
            Levotiroksin.IlacAdi = "Levotiroksin";
            Levotiroksin.IlacKategori= "A";

            Ilaclar Insulin = new Ilaclar();
            Insulin.IlacAdi = "İnsülin";
            Insulin.IlacKategori = "A";

            Ilaclar Amoksisilin = new Ilaclar();
            Amoksisilin.IlacAdi = "Amoksisilin";
            Amoksisilin.IlacKategori = "B";

            Ilaclar Ibuprofen = new Ilaclar();
            Ibuprofen.IlacAdi = "İbuprofen";
            Ibuprofen.IlacKategori = "B";

            Ilaclar Parasetamol = new Ilaclar();
            Parasetamol.IlacAdi = "Parasetamol";
            Parasetamol.IlacKategori = "B";

            Ilaclar Zofran = new Ilaclar();
            Zofran.IlacAdi = "Zofran (Ondansetron)";
            Zofran.IlacKategori = "B";

            Ilaclar Diphenhydramine = new Ilaclar();
            Diphenhydramine.IlacAdi = "Diphenhydramine (Benadryl)";
            Diphenhydramine.IlacKategori = "C";

            Ilaclar Pseudoephedrine = new Ilaclar();
            Pseudoephedrine.IlacAdi = "Pseudoephedrine (Sudafed)";
            Pseudoephedrine.IlacKategori = "C";

            Ilaclar Fluconazole = new Ilaclar();
            Fluconazole.IlacAdi = "Fluconazole (Diflucan)";
            Fluconazole.IlacKategori = "C";

            Ilaclar Venlafaxine = new Ilaclar();
            Venlafaxine.IlacAdi = "Venlafaxine (Effexor)";
            Venlafaxine.IlacKategori = "C";

            Ilaclar Lisinopril = new Ilaclar();
            Lisinopril.IlacAdi = "Lisinopril";
            Lisinopril.IlacKategori = "D";

            Ilaclar Isotretinoin = new Ilaclar();
            Isotretinoin.IlacAdi = "İsotretinoin";
            Isotretinoin.IlacKategori= "D";

            Ilaclar Warfarin = new Ilaclar();
            Warfarin.IlacAdi = "Warfarin";
            Warfarin.IlacKategori = "D";

            Ilaclar Methotrexate = new Ilaclar();
            Methotrexate.IlacAdi = "Methotrexate";
            Methotrexate.IlacKategori = "D";

            Ilaclar Thalidomide = new Ilaclar();
            Thalidomide.IlacAdi = "Thalidomide";
            Thalidomide.IlacKategori = "X";

            Ilaclar Isofosfamid = new Ilaclar();
            Isofosfamid.IlacAdi = "İsofosfamid";
            Isofosfamid.IlacKategori = "X";

            Ilaclar Warfarin1 = new Ilaclar();
            Warfarin1.IlacAdi = "Warfarin";
            Warfarin1.IlacKategori = "X";

            Ilaclar Misoprostol = new Ilaclar();
            Misoprostol.IlacAdi = "Misoprostol";
            Misoprostol.IlacKategori = "X";

            Console.WriteLine($"{FolikAsit.IlacAdi} İsimli İlaç FDA Tarafından {FolikAsit.IlacKategori} Kategorisinde Sınıflandırılmaktadır");
            Console.WriteLine($"{Metformin.IlacAdi} İsimli İlaç FDA Tarafından {Metformin.IlacKategori} Kategorisinde Sınıflandırılmaktadır");
            Console.WriteLine($"{Levotiroksin.IlacAdi} İsimli İlaç FDA Tarafından {Levotiroksin.IlacKategori} Kategorisinde Sınıflandırılmaktadır");
            Console.WriteLine($"{Insulin.IlacAdi} İsimli İlaç FDA Tarafından {Insulin.IlacKategori} Kategorisinde Sınıflandırılmaktadır");
            Console.WriteLine($"{Amoksisilin.IlacAdi} İsimli İlaç FDA Tarafından {Amoksisilin.IlacKategori} Kategorisinde Sınıflandırılmaktadır");
            Console.WriteLine($"{Ibuprofen.IlacAdi} İsimli İlaç FDA Tarafından {Ibuprofen.IlacKategori} Kategorisinde Sınıflandırılmaktadır");
            Console.WriteLine($"{Parasetamol.IlacAdi} İsimli İlaç FDA Tarafından {Parasetamol.IlacKategori} Kategorisinde Sınıflandırılmaktadır");
            Console.WriteLine($"{Zofran.IlacAdi} İsimli İlaç FDA Tarafından {Zofran.IlacKategori} Kategorisinde Sınıflandırılmaktadır");
            Console.WriteLine($"{Diphenhydramine.IlacAdi} İsimli İlaç FDA Tarafından {Diphenhydramine.IlacKategori} Kategorisinde Sınıflandırılmaktadır");
            Console.WriteLine($"{Pseudoephedrine.IlacAdi} İsimli İlaç FDA Tarafından {Pseudoephedrine.IlacKategori} Kategorisinde Sınıflandırılmaktadır");
            Console.WriteLine($"{Fluconazole.IlacAdi} İsimli İlaç FDA Tarafından {Fluconazole.IlacKategori} Kategorisinde Sınıflandırılmaktadır");
            Console.WriteLine($"{Venlafaxine.IlacAdi} İsimli İlaç FDA Tarafından {Venlafaxine.IlacKategori} Kategorisinde Sınıflandırılmaktadır");
            Console.WriteLine($"{Lisinopril.IlacAdi} İsimli İlaç FDA Tarafından {Lisinopril.IlacKategori} Kategorisinde Sınıflandırılmaktadır");
            Console.WriteLine($"{Isotretinoin.IlacAdi} İsimli İlaç FDA Tarafından {Isotretinoin.IlacKategori} Kategorisinde Sınıflandırılmaktadır");
            Console.WriteLine($"{Warfarin.IlacAdi} İsimli İlaç FDA Tarafından {Warfarin.IlacKategori} Kategorisinde Sınıflandırılmaktadır");
            Console.WriteLine($"{Methotrexate.IlacAdi} İsimli İlaç FDA Tarafından {Methotrexate.IlacKategori} Kategorisinde Sınıflandırılmaktadır");
            Console.WriteLine($"{Thalidomide.IlacAdi} İsimli İlaç FDA Tarafından {Thalidomide.IlacKategori} Kategorisinde Sınıflandırılmaktadır");
            Console.WriteLine($"{Isofosfamid.IlacAdi} İsimli İlaç FDA Tarafından {Isofosfamid.IlacKategori} Kategorisinde Sınıflandırılmaktadır");
            Console.WriteLine($"{Warfarin1.IlacAdi} İsimli İlaç FDA Tarafından {Warfarin1.IlacKategori} Kategorisinde Sınıflandırılmaktadır");
            Console.WriteLine($"{Misoprostol.IlacAdi} İsimli İlaç FDA Tarafından {Misoprostol.IlacKategori} Kategorisinde Sınıflandırılmaktadır");
        }
    }
    class Ilaclar
    {
        public string IlacAdi;
        public string IlacKategori;
    }
}

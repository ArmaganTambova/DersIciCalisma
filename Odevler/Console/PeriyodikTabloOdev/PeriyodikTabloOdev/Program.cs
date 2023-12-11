using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriyodikTabloOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PeriyodikTablo[] Elementler = new PeriyodikTablo[118];

            PeriyodikTablo Hidrojen = new PeriyodikTablo();
            Hidrojen.AtomNumarasi = 1;
            Hidrojen.AtomAdi = "Hidrojen";
            Hidrojen.AtomSembolu = "H";
            Hidrojen.KutleNumarasi = 1.0078;
            Hidrojen.Kategorisi = "Ametal";
            Elementler[0] = Hidrojen;

            PeriyodikTablo Helyum = new PeriyodikTablo();
            Helyum.AtomNumarasi = 2;
            Helyum.AtomAdi = "Helyum";
            Helyum.AtomSembolu = "He";
            Helyum.KutleNumarasi = 4.0026;
            Helyum.Kategorisi = "Soy Gazlar";
            Elementler[1] = Helyum;

            PeriyodikTablo Lityum = new PeriyodikTablo();
            Lityum.AtomNumarasi = 3;
            Lityum.AtomAdi = "Lityum";
            Lityum.AtomSembolu = "Li";
            Lityum.KutleNumarasi = 6.9410;
            Lityum.Kategorisi = "Alkali Metaller";
            Elementler[2] = Lityum;

            PeriyodikTablo Berilyum = new PeriyodikTablo();
            Berilyum.AtomNumarasi = 4;
            Berilyum.AtomAdi = "Berilyum";
            Berilyum.AtomSembolu = "Be";
            Berilyum.KutleNumarasi = 9.0122;
            Berilyum.Kategorisi = "Alkali Toprak Metaller";
            Elementler[3] = Berilyum;

            PeriyodikTablo Bor = new PeriyodikTablo();
            Bor.AtomNumarasi = 5;
            Bor.AtomAdi = "Bor";
            Bor.AtomSembolu = "B";
            Bor.KutleNumarasi = 10.81;
            Bor.Kategorisi = "Yarı Metal";
            Elementler[4] = Bor;

            PeriyodikTablo Karbon = new PeriyodikTablo();
            Karbon.AtomNumarasi = 6;
            Karbon.AtomAdi = "Karbon";
            Karbon.AtomSembolu = "C";
            Karbon.KutleNumarasi = 12.011;
            Karbon.Kategorisi = "Ametal";
            Elementler[5] = Karbon;

            PeriyodikTablo Azot = new PeriyodikTablo();
            Azot.AtomNumarasi = 7;
            Azot.AtomAdi = "Azot";
            Azot.AtomSembolu = "N";
            Azot.KutleNumarasi = 14.007;
            Azot.Kategorisi = "Ametal";
            Elementler[6] = Azot;

            PeriyodikTablo Oksijen = new PeriyodikTablo();
            Oksijen.AtomNumarasi = 8;
            Oksijen.AtomAdi = "Oksijen";
            Oksijen.AtomSembolu = "O";
            Oksijen.KutleNumarasi = 15.999;
            Oksijen.Kategorisi = "Ametal";
            Elementler[7] = Oksijen;

            PeriyodikTablo Flor = new PeriyodikTablo();
            Flor.AtomNumarasi = 9;
            Flor.AtomAdi = "Flor";
            Flor.AtomSembolu = "F";
            Flor.KutleNumarasi = 18.998;
            Flor.Kategorisi = "Halojen";
            Elementler[8] = Flor;

            PeriyodikTablo Neon = new PeriyodikTablo();
            Neon.AtomNumarasi = 10;
            Neon.AtomAdi = "Neon";
            Neon.AtomSembolu = "Ne";
            Neon.KutleNumarasi = 20.180;
            Neon.Kategorisi = "Soy Gazlar";
            Elementler[9] = Neon;

            PeriyodikTablo Sodyum = new PeriyodikTablo();
            Sodyum.AtomNumarasi = 11;
            Sodyum.AtomAdi = "Sodyum";
            Sodyum.AtomSembolu = "Na";
            Sodyum.KutleNumarasi = 22.990;
            Sodyum.Kategorisi = "Alkali Metaller";
            Elementler[10] = Sodyum;

            PeriyodikTablo Magnezyum = new PeriyodikTablo();
            Magnezyum.AtomNumarasi = 12;
            Magnezyum.AtomAdi = "Magnezyum";
            Magnezyum.AtomSembolu = "Mg";
            Magnezyum.KutleNumarasi = 24.305;
            Magnezyum.Kategorisi = "Alkali Toprak Metaller";
            Elementler[11] = Magnezyum;

            PeriyodikTablo Aluminyum = new PeriyodikTablo();
            Aluminyum.AtomNumarasi = 13;
            Aluminyum.AtomAdi = "Alüminyum";
            Aluminyum.AtomSembolu = "Al";
            Aluminyum.KutleNumarasi = 26.982;
            Aluminyum.Kategorisi = "Ametal";
            Elementler[12] = Aluminyum;

            PeriyodikTablo Silisyum = new PeriyodikTablo();
            Silisyum.AtomNumarasi = 14;
            Silisyum.AtomAdi = "Silisyum";
            Silisyum.AtomSembolu = "Si";
            Silisyum.KutleNumarasi = 28.085;
            Silisyum.Kategorisi = "Yarı Metal";
            Elementler[13] = Silisyum;

            PeriyodikTablo Fosfor = new PeriyodikTablo();
            Fosfor.AtomNumarasi = 15;
            Fosfor.AtomAdi = "Fosfor";
            Fosfor.AtomSembolu = "P";
            Fosfor.KutleNumarasi = 30.974;
            Fosfor.Kategorisi = "Ametal";
            Elementler[14] = Fosfor;

            PeriyodikTablo Kukurt = new PeriyodikTablo();
            Kukurt.AtomNumarasi = 16;
            Kukurt.AtomAdi = "Kükürt";
            Kukurt.AtomSembolu = "S";
            Kukurt.KutleNumarasi = 32.07;
            Kukurt.Kategorisi = "Ametal";
            Elementler[15] = Kukurt;

            PeriyodikTablo Klor = new PeriyodikTablo();
            Klor.AtomNumarasi = 17;
            Klor.AtomAdi = "Klor";
            Klor.AtomSembolu = "Cl";
            Klor.KutleNumarasi = 35.453;
            Klor.Kategorisi = "Halojen";
            Elementler[16] = Klor;

            PeriyodikTablo Argon = new PeriyodikTablo();
            Argon.AtomNumarasi = 18;
            Argon.AtomAdi = "Argon";
            Argon.AtomSembolu = "Ar";
            Argon.KutleNumarasi = 39.948;
            Argon.Kategorisi = "Soy Gazlar";
            Elementler[17] = Argon;

            PeriyodikTablo Potasyum = new PeriyodikTablo();
            Potasyum.AtomNumarasi = 19;
            Potasyum.AtomAdi = "Potasyum";
            Potasyum.AtomSembolu = "K";
            Potasyum.KutleNumarasi = 39.098;
            Potasyum.Kategorisi = "Alkali Metaller";
            Elementler[18] = Potasyum;

            PeriyodikTablo Kalsiyum = new PeriyodikTablo();
            Kalsiyum.AtomNumarasi = 20;
            Kalsiyum.AtomAdi = "Kalsiyum";
            Kalsiyum.AtomSembolu = "Ca";
            Kalsiyum.KutleNumarasi = 40.078;
            Kalsiyum.Kategorisi = "Alkali Toprak Metaller";
            Elementler[19] = Kalsiyum;

            PeriyodikTablo Skandiyum = new PeriyodikTablo();
            Skandiyum.AtomNumarasi = 21;
            Skandiyum.AtomAdi = "Skandiyum";
            Skandiyum.AtomSembolu = "Sc";
            Skandiyum.KutleNumarasi = 44.956;
            Skandiyum.Kategorisi = "Geçiş Metalleri";
            Elementler[20] = Skandiyum;

            PeriyodikTablo Titanyum = new PeriyodikTablo();
            Titanyum.AtomNumarasi = 22;
            Titanyum.AtomAdi = "Titanyum";
            Titanyum.AtomSembolu = "Ti";
            Titanyum.KutleNumarasi = 47.867;
            Titanyum.Kategorisi = "Geçiş Metalleri";
            Elementler[21] = Titanyum;

            PeriyodikTablo Vanadyum = new PeriyodikTablo();
            Vanadyum.AtomNumarasi = 23;
            Vanadyum.AtomAdi = "Vanadyum";
            Vanadyum.AtomSembolu = "V";
            Vanadyum.KutleNumarasi = 50.942;
            Vanadyum.Kategorisi = "Geçiş Metalleri";
            Elementler[22] = Vanadyum;

            PeriyodikTablo Krom = new PeriyodikTablo();
            Krom.AtomNumarasi = 24;
            Krom.AtomAdi = "Krom";
            Krom.AtomSembolu = "Cr";
            Krom.KutleNumarasi = 51.996;
            Krom.Kategorisi = "Geçiş Metalleri";
            Elementler[23] = Krom;

            PeriyodikTablo Mangan = new PeriyodikTablo();
            Mangan.AtomNumarasi = 25;
            Mangan.AtomAdi = "Manganez";
            Mangan.AtomSembolu = "Mn";
            Mangan.KutleNumarasi = 54.938;
            Mangan.Kategorisi = "Geçiş Metalleri";
            Elementler[24] = Mangan;

            PeriyodikTablo Demir = new PeriyodikTablo();
            Demir.AtomNumarasi = 26;
            Demir.AtomAdi = "Demir";
            Demir.AtomSembolu = "Fe";
            Demir.KutleNumarasi = 55.845;
            Demir.Kategorisi = "Geçiş Metalleri";
            Elementler[25] = Demir;

            PeriyodikTablo Kobalt = new PeriyodikTablo();
            Kobalt.AtomNumarasi = 27;
            Kobalt.AtomAdi = "Kobalt";
            Kobalt.AtomSembolu = "Co";
            Kobalt.KutleNumarasi = 58.933;
            Kobalt.Kategorisi = "Geçiş Metalleri";
            Elementler[26] = Kobalt;

            PeriyodikTablo Nikel = new PeriyodikTablo();
            Nikel.AtomNumarasi = 28;
            Nikel.AtomAdi = "Nikel";
            Nikel.AtomSembolu = "Ni";
            Nikel.KutleNumarasi = 58.693;
            Nikel.Kategorisi = "Geçiş Metalleri";
            Elementler[27] = Nikel;

            PeriyodikTablo Bakir = new PeriyodikTablo();
            Bakir.AtomNumarasi = 29;
            Bakir.AtomAdi = "Bakır";
            Bakir.AtomSembolu = "Cu";
            Bakir.KutleNumarasi = 63.546;
            Bakir.Kategorisi = "Geçiş Metalleri";
            Elementler[28] = Bakir;

            PeriyodikTablo Cinko = new PeriyodikTablo();
            Cinko.AtomNumarasi = 30;
            Cinko.AtomAdi = "Çinko";
            Cinko.AtomSembolu = "Zn";
            Cinko.KutleNumarasi = 65.38;
            Cinko.Kategorisi = "Geçiş Metalleri";
            Elementler[29] = Cinko;

            PeriyodikTablo Galyum = new PeriyodikTablo();
            Galyum.AtomNumarasi = 31;
            Galyum.AtomAdi = "Galyum";
            Galyum.AtomSembolu = "Ga";
            Galyum.KutleNumarasi = 69.723;
            Galyum.Kategorisi = "Yarı Metal";
            Elementler[30] = Galyum;

            PeriyodikTablo Germanyum = new PeriyodikTablo();
            Germanyum.AtomNumarasi = 32;
            Germanyum.AtomAdi = "Germanyum";
            Germanyum.AtomSembolu = "Ge";
            Germanyum.KutleNumarasi = 72.630;
            Germanyum.Kategorisi = "Yarı Metal";
            Elementler[31] = Germanyum;

            PeriyodikTablo Arsenik = new PeriyodikTablo();
            Arsenik.AtomNumarasi = 33;
            Arsenik.AtomAdi = "Arsenik";
            Arsenik.AtomSembolu = "As";
            Arsenik.KutleNumarasi = 74.922;
            Arsenik.Kategorisi = "Yarı Metal";
            Elementler[32] = Arsenik;

            PeriyodikTablo Selanyum = new PeriyodikTablo();
            Selanyum.AtomNumarasi = 34;
            Selanyum.AtomAdi = "Selenyum";
            Selanyum.AtomSembolu = "Se";
            Selanyum.KutleNumarasi = 78.971;
            Selanyum.Kategorisi = "Ametal";
            Elementler[33] = Selanyum;

            PeriyodikTablo Brom = new PeriyodikTablo();
            Brom.AtomNumarasi = 35;
            Brom.AtomAdi = "Brom";
            Brom.AtomSembolu = "Br";
            Brom.KutleNumarasi = 79.904;
            Brom.Kategorisi = "Halojen";
            Elementler[34] = Brom;

            PeriyodikTablo Kripton = new PeriyodikTablo();
            Kripton.AtomNumarasi = 36;
            Kripton.AtomAdi = "Kripton";
            Kripton.AtomSembolu = "Kr";
            Kripton.KutleNumarasi = 83.798;
            Kripton.Kategorisi = "Soy Gazlar";
            Elementler[35] = Kripton;

            PeriyodikTablo Rubidyum = new PeriyodikTablo();
            Rubidyum.AtomNumarasi = 37;
            Rubidyum.AtomAdi = "Rubidyum";
            Rubidyum.AtomSembolu = "Rb";
            Rubidyum.KutleNumarasi = 85.468;
            Rubidyum.Kategorisi = "Alkali Metaller";
            Elementler[36] = Rubidyum;

            PeriyodikTablo Stronsiyum = new PeriyodikTablo();
            Stronsiyum.AtomNumarasi = 38;
            Stronsiyum.AtomAdi = "Stronsiyum";
            Stronsiyum.AtomSembolu = "Sr";
            Stronsiyum.KutleNumarasi = 87.62;
            Stronsiyum.Kategorisi = "Alkali Toprak Metaller";
            Elementler[37] = Stronsiyum;

            PeriyodikTablo Itiriyum = new PeriyodikTablo();
            Itiriyum.AtomNumarasi = 39;
            Itiriyum.AtomAdi = "İtriyum";
            Itiriyum.AtomSembolu = "Y";
            Itiriyum.KutleNumarasi = 88.906;
            Itiriyum.Kategorisi = "Geçiş Metalleri";
            Elementler[38] = Itiriyum;

            PeriyodikTablo Zirkonyum = new PeriyodikTablo();
            Zirkonyum.AtomNumarasi = 40;
            Zirkonyum.AtomAdi = "Zirkonyum";
            Zirkonyum.AtomSembolu = "Zr";
            Zirkonyum.KutleNumarasi = 91.224;
            Zirkonyum.Kategorisi = "Geçiş Metalleri";
            Elementler[39] = Zirkonyum;

            PeriyodikTablo Niyobyum = new PeriyodikTablo();
            Niyobyum.AtomNumarasi = 41;
            Niyobyum.AtomAdi = "Niyobyum";
            Niyobyum.AtomSembolu = "Nb";
            Niyobyum.KutleNumarasi = 92.906;
            Niyobyum.Kategorisi = "Geçiş Metalleri";
            Elementler[40] = Niyobyum;

            PeriyodikTablo Molibden = new PeriyodikTablo();
            Molibden.AtomNumarasi = 42;
            Molibden.AtomAdi = "Molibden";
            Molibden.AtomSembolu = "Mo";
            Molibden.KutleNumarasi = 95.95;
            Molibden.Kategorisi = "Geçiş Metalleri";
            Elementler[41] = Molibden;

            PeriyodikTablo Teknesyum = new PeriyodikTablo();
            Teknesyum.AtomNumarasi = 43;
            Teknesyum.AtomAdi = "Teknesyum";
            Teknesyum.AtomSembolu = "Tc";
            Teknesyum.KutleNumarasi = 98.0;
            Teknesyum.Kategorisi = "Geçiş Metalleri";
            Elementler[42] = Teknesyum;

            PeriyodikTablo Rutenyum = new PeriyodikTablo();
            Rutenyum.AtomNumarasi = 44;
            Rutenyum.AtomAdi = "Rutenyum";
            Rutenyum.AtomSembolu = "Ru";
            Rutenyum.KutleNumarasi = 101.1;
            Rutenyum.Kategorisi = "Geçiş Metalleri";
            Elementler[43] = Rutenyum;

            PeriyodikTablo Rodyum = new PeriyodikTablo();
            Rodyum.AtomNumarasi = 45;
            Rodyum.AtomAdi = "Rodyum";
            Rodyum.AtomSembolu = "Rh";
            Rodyum.KutleNumarasi = 102.9;
            Rodyum.Kategorisi = "Geçiş Metalleri";
            Elementler[44] = Rodyum;

            PeriyodikTablo Paladyum = new PeriyodikTablo();
            Paladyum.AtomNumarasi = 46;
            Paladyum.AtomAdi = "Paladyum";
            Paladyum.AtomSembolu = "Pd";
            Paladyum.KutleNumarasi = 106.4;
            Paladyum.Kategorisi = "Geçiş Metalleri";
            Elementler[45] = Paladyum;

            PeriyodikTablo Gumus = new PeriyodikTablo();
            Gumus.AtomNumarasi = 47;
            Gumus.AtomAdi = "Gümüş";
            Gumus.AtomSembolu = "Ag";
            Gumus.KutleNumarasi = 107.9;
            Gumus.Kategorisi = "Geçiş Metalleri";
            Elementler[46] = Gumus;

            PeriyodikTablo Kadmiyum = new PeriyodikTablo();
            Kadmiyum.AtomNumarasi = 48;
            Kadmiyum.AtomAdi = "Kadmiyum";
            Kadmiyum.AtomSembolu = "Cd";
            Kadmiyum.KutleNumarasi = 112.4;
            Kadmiyum.Kategorisi = "Geçiş Metalleri";
            Elementler[47] = Kadmiyum;

            PeriyodikTablo Indiyum = new PeriyodikTablo();
            Indiyum.AtomNumarasi = 49;
            Indiyum.AtomAdi = "İndiyum";
            Indiyum.AtomSembolu = "In";
            Indiyum.KutleNumarasi = 114.8;
            Indiyum.Kategorisi = "Yarı Metal";
            Elementler[48] = Indiyum;

            PeriyodikTablo Kalay = new PeriyodikTablo();
            Kalay.AtomNumarasi = 50;
            Kalay.AtomAdi = "Kalay";
            Kalay.AtomSembolu = "Sn";
            Kalay.KutleNumarasi = 118.7;
            Kalay.Kategorisi = "Yarı Metal";
            Elementler[49] = Kalay;

            PeriyodikTablo Antimon = new PeriyodikTablo();
            Antimon.AtomNumarasi = 51;
            Antimon.AtomAdi = "Antimon";
            Antimon.AtomSembolu = "Sb";
            Antimon.KutleNumarasi = 121.8;
            Antimon.Kategorisi = "Yarı Metal";
            Elementler[50] = Antimon;

            PeriyodikTablo Tellur = new PeriyodikTablo();
            Tellur.AtomNumarasi = 52;
            Tellur.AtomAdi = "Tellür";
            Tellur.AtomSembolu = "Te";
            Tellur.KutleNumarasi = 127.6;
            Tellur.Kategorisi = "Yarı Metal";
            Elementler[51] = Tellur;

            PeriyodikTablo Iyot = new PeriyodikTablo();
            Iyot.AtomNumarasi = 53;
            Iyot.AtomAdi = "İyot";
            Iyot.AtomSembolu = "I";
            Iyot.KutleNumarasi = 126.9;
            Iyot.Kategorisi = "Halojen";
            Elementler[52] = Iyot;

            PeriyodikTablo Ksenon = new PeriyodikTablo();
            Ksenon.AtomNumarasi = 54;
            Ksenon.AtomAdi = "Ksenon";
            Ksenon.AtomSembolu = "Xe";
            Ksenon.KutleNumarasi = 131.3;
            Ksenon.Kategorisi = "Soy Gazlar";
            Elementler[53] = Ksenon;

            PeriyodikTablo Sezyum = new PeriyodikTablo();
            Sezyum.AtomNumarasi = 55;
            Sezyum.AtomAdi = "Sezyum";
            Sezyum.AtomSembolu = "Cs";
            Sezyum.KutleNumarasi = 132.9;
            Sezyum.Kategorisi = "Alkali Metaller";
            Elementler[54] = Sezyum;

            PeriyodikTablo Baryum = new PeriyodikTablo();
            Baryum.AtomNumarasi = 56;
            Baryum.AtomAdi = "Baryum";
            Baryum.AtomSembolu = "Ba";
            Baryum.KutleNumarasi = 137.3;
            Baryum.Kategorisi = "Alkali Toprak Metaller";
            Elementler[55] = Baryum;

            PeriyodikTablo Lantan = new PeriyodikTablo();
            Lantan.AtomNumarasi = 57;
            Lantan.AtomAdi = "Lantan";
            Lantan.AtomSembolu = "La";
            Lantan.KutleNumarasi = 138.9;
            Lantan.Kategorisi = "Lantanitler";
            Elementler[56] = Lantan;

            PeriyodikTablo Seryum = new PeriyodikTablo();
            Seryum.AtomNumarasi = 58;
            Seryum.AtomAdi = "Seryum";
            Seryum.AtomSembolu = "Ce";
            Seryum.KutleNumarasi = 140.1;
            Seryum.Kategorisi = "Lantanitler";
            Elementler[57] = Seryum;

            PeriyodikTablo Praseodim = new PeriyodikTablo();
            Praseodim.AtomNumarasi = 59;
            Praseodim.AtomAdi = "Praseodim";
            Praseodim.AtomSembolu = "Pr";
            Praseodim.KutleNumarasi = 140.9;
            Praseodim.Kategorisi = "Lantanitler";
            Elementler[58] = Praseodim;

            PeriyodikTablo Neodimyum = new PeriyodikTablo();
            Neodimyum.AtomNumarasi = 60;
            Neodimyum.AtomAdi = "Neodimyum";
            Neodimyum.AtomSembolu = "Nd";
            Neodimyum.KutleNumarasi = 144.2;
            Neodimyum.Kategorisi = "Lantanitler";
            Elementler[59] = Neodimyum;

            PeriyodikTablo Prometyum = new PeriyodikTablo();
            Prometyum.AtomNumarasi = 61;
            Prometyum.AtomAdi = "Prometyum";
            Prometyum.AtomSembolu = "Pm";
            Prometyum.KutleNumarasi = 145.0;
            Prometyum.Kategorisi = "Lantanitler";
            Elementler[60] = Prometyum;

            PeriyodikTablo Samaryum = new PeriyodikTablo();
            Samaryum.AtomNumarasi = 62;
            Samaryum.AtomAdi = "Samaryum";
            Samaryum.AtomSembolu = "Sm";
            Samaryum.KutleNumarasi = 150.4;
            Samaryum.Kategorisi = "Lantanitler";
            Elementler[61] = Samaryum;

            PeriyodikTablo Evropiyum = new PeriyodikTablo();
            Evropiyum.AtomNumarasi = 63;
            Evropiyum.AtomAdi = "Evropiyum";
            Evropiyum.AtomSembolu = "Eu";
            Evropiyum.KutleNumarasi = 151.9;
            Evropiyum.Kategorisi = "Lantanitler";
            Elementler[62] = Evropiyum;

            PeriyodikTablo Gadolinyum = new PeriyodikTablo();
            Gadolinyum.AtomNumarasi = 64;
            Gadolinyum.AtomAdi = "Gadolinyum";
            Gadolinyum.AtomSembolu = "Gd";
            Gadolinyum.KutleNumarasi = 157.3;
            Gadolinyum.Kategorisi = "Lantanitler";
            Elementler[63] = Gadolinyum;

            PeriyodikTablo Terbiyum = new PeriyodikTablo();
            Terbiyum.AtomNumarasi = 65;
            Terbiyum.AtomAdi = "Terbiyum";
            Terbiyum.AtomSembolu = "Tb";
            Terbiyum.KutleNumarasi = 158.9;
            Terbiyum.Kategorisi = "Lantanitler";
            Elementler[64] = Terbiyum;

            PeriyodikTablo Disprozyum = new PeriyodikTablo();
            Disprozyum.AtomNumarasi = 66;
            Disprozyum.AtomAdi = "Disprozyum";
            Disprozyum.AtomSembolu = "Dy";
            Disprozyum.KutleNumarasi = 162.5;
            Disprozyum.Kategorisi = "Lantanitler";
            Elementler[65] = Disprozyum;

            PeriyodikTablo Holmiyum = new PeriyodikTablo();
            Holmiyum.AtomNumarasi = 67;
            Holmiyum.AtomAdi = "Holmiyum";
            Holmiyum.AtomSembolu = "Ho";
            Holmiyum.KutleNumarasi = 164.9;
            Holmiyum.Kategorisi = "Lantanitler";
            Elementler[66] = Holmiyum;

            PeriyodikTablo Erbiyum = new PeriyodikTablo();
            Erbiyum.AtomNumarasi = 68;
            Erbiyum.AtomAdi = "Erbiyum";
            Erbiyum.AtomSembolu = "Er";
            Erbiyum.KutleNumarasi = 167.3;
            Erbiyum.Kategorisi = "Lantanitler";
            Elementler[67] = Erbiyum;

            PeriyodikTablo Tulyum = new PeriyodikTablo();
            Tulyum.AtomNumarasi = 69;
            Tulyum.AtomAdi = "Tulyum";
            Tulyum.AtomSembolu = "Tm";
            Tulyum.KutleNumarasi = 168.9;
            Tulyum.Kategorisi = "Lantanitler";
            Elementler[68] = Tulyum;

            PeriyodikTablo Iterbiyum = new PeriyodikTablo();
            Iterbiyum.AtomNumarasi = 70;
            Iterbiyum.AtomAdi = "İterbiyum";
            Iterbiyum.AtomSembolu = "Yb";
            Iterbiyum.KutleNumarasi = 173.0;
            Iterbiyum.Kategorisi = "Lantanitler";
            Elementler[69] = Iterbiyum;

            PeriyodikTablo Lutesyum = new PeriyodikTablo();
            Lutesyum.AtomNumarasi = 71;
            Lutesyum.AtomAdi = "Lutesyum";
            Lutesyum.AtomSembolu = "Lu";
            Lutesyum.KutleNumarasi = 174.9;
            Lutesyum.Kategorisi = "Lantanitler";
            Elementler[70] = Lutesyum;

            PeriyodikTablo Hafniyum = new PeriyodikTablo();
            Hafniyum.AtomNumarasi = 72;
            Hafniyum.AtomAdi = "Hafniyum";
            Hafniyum.AtomSembolu = "Hf";
            Hafniyum.KutleNumarasi = 178.5;
            Hafniyum.Kategorisi = "Geçiş Metalleri";
            Elementler[71] = Hafniyum;

            PeriyodikTablo Tantal = new PeriyodikTablo();
            Tantal.AtomNumarasi = 73;
            Tantal.AtomAdi = "Tantal";
            Tantal.AtomSembolu = "Ta";
            Tantal.KutleNumarasi = 180.9;
            Tantal.Kategorisi = "Geçiş Metalleri";
            Elementler[72] = Tantal;

            PeriyodikTablo Tungsten = new PeriyodikTablo();
            Tungsten.AtomNumarasi = 74;
            Tungsten.AtomAdi = "Tungsten";
            Tungsten.AtomSembolu = "W";
            Tungsten.KutleNumarasi = 183.8;
            Tungsten.Kategorisi = "Geçiş Metalleri";
            Elementler[73] = Tungsten;

            PeriyodikTablo Renyum = new PeriyodikTablo();
            Renyum.AtomNumarasi = 75;
            Renyum.AtomAdi = "Renyum";
            Renyum.AtomSembolu = "Re";
            Renyum.KutleNumarasi = 186.2;
            Renyum.Kategorisi = "Geçiş Metalleri";
            Elementler[74] = Renyum;

            PeriyodikTablo Osmiyum = new PeriyodikTablo();
            Osmiyum.AtomNumarasi = 76;
            Osmiyum.AtomAdi = "Osmiyum";
            Osmiyum.AtomSembolu = "Os";
            Osmiyum.KutleNumarasi = 190.2;
            Osmiyum.Kategorisi = "Geçiş Metalleri";
            Elementler[75] = Osmiyum;

            PeriyodikTablo Iridyum = new PeriyodikTablo();
            Iridyum.AtomNumarasi = 77;
            Iridyum.AtomAdi = "İridyum";
            Iridyum.AtomSembolu = "Ir";
            Iridyum.KutleNumarasi = 192.2;
            Iridyum.Kategorisi = "Geçiş Metalleri";
            Elementler[76] = Iridyum;

            PeriyodikTablo Platin = new PeriyodikTablo();
            Platin.AtomNumarasi = 78;
            Platin.AtomAdi = "Platin";
            Platin.AtomSembolu = "Pt";
            Platin.KutleNumarasi = 195.1;
            Platin.Kategorisi = "Geçiş Metalleri";
            Elementler[77] = Platin;

            PeriyodikTablo Altin = new PeriyodikTablo();
            Altin.AtomNumarasi = 79;
            Altin.AtomAdi = "Altın";
            Altin.AtomSembolu = "Au";
            Altin.KutleNumarasi = 197.0;
            Altin.Kategorisi = "Geçiş Metalleri";
            Elementler[78] = Altin;

            PeriyodikTablo Civa = new PeriyodikTablo();
            Civa.AtomNumarasi = 80;
            Civa.AtomAdi = "Cıva";
            Civa.AtomSembolu = "Hg";
            Civa.KutleNumarasi = 200.6;
            Civa.Kategorisi = "Geçiş Metalleri";
            Elementler[79] = Civa;

            PeriyodikTablo Talyum = new PeriyodikTablo();
            Talyum.AtomNumarasi = 81;
            Talyum.AtomAdi = "Talyum";
            Talyum.AtomSembolu = "Tl";
            Talyum.KutleNumarasi = 204.4;
            Talyum.Kategorisi = "Yarı Metal";
            Elementler[80] = Talyum;

            PeriyodikTablo Kursun = new PeriyodikTablo();
            Kursun.AtomNumarasi = 82;
            Kursun.AtomAdi = "Kurşun";
            Kursun.AtomSembolu = "Pb";
            Kursun.KutleNumarasi = 207.2;
            Kursun.Kategorisi = "Yarı Metal";
            Elementler[81] = Kursun;

            PeriyodikTablo Bizmut = new PeriyodikTablo();
            Bizmut.AtomNumarasi = 83;
            Bizmut.AtomAdi = "Bizmut";
            Bizmut.AtomSembolu = "Bi";
            Bizmut.KutleNumarasi = 208.9;
            Bizmut.Kategorisi = "Yarı Metal";
            Elementler[82] = Bizmut;

            PeriyodikTablo Polonyum = new PeriyodikTablo();
            Polonyum.AtomNumarasi = 84;
            Polonyum.AtomAdi = "Polonyum";
            Polonyum.AtomSembolu = "Po";
            Polonyum.KutleNumarasi = 209.0;
            Polonyum.Kategorisi = "Yarı Metal";
            Elementler[83] = Polonyum;

            PeriyodikTablo Astatin = new PeriyodikTablo();
            Astatin.AtomNumarasi = 85;
            Astatin.AtomAdi = "Astatin";
            Astatin.AtomSembolu = "At";
            Astatin.KutleNumarasi = 210.0;
            Astatin.Kategorisi = "Halojen";
            Elementler[84] = Astatin;

            PeriyodikTablo Radon = new PeriyodikTablo();
            Radon.AtomNumarasi = 86;
            Radon.AtomAdi = "Radon";
            Radon.AtomSembolu = "Rn";
            Radon.KutleNumarasi = 222.0;
            Radon.Kategorisi = "Soy Gazlar";
            Elementler[85] = Radon;

            PeriyodikTablo Fransiyum = new PeriyodikTablo();
            Fransiyum.AtomNumarasi = 87;
            Fransiyum.AtomAdi = "Fransiyum";
            Fransiyum.AtomSembolu = "Fr";
            Fransiyum.KutleNumarasi = 223.0;
            Fransiyum.Kategorisi = "Alkali Metaller";
            Elementler[86] = Fransiyum;

            PeriyodikTablo Radyum = new PeriyodikTablo();
            Radyum.AtomNumarasi = 88;
            Radyum.AtomAdi = "Radyum";
            Radyum.AtomSembolu = "Ra";
            Radyum.KutleNumarasi = 226.0;
            Radyum.Kategorisi = "Alkali Toprak Metaller";
            Elementler[87] = Radyum;

            PeriyodikTablo Aktinyum = new PeriyodikTablo();
            Aktinyum.AtomNumarasi = 89;
            Aktinyum.AtomAdi = "Aktinyum";
            Aktinyum.AtomSembolu = "Ac";
            Aktinyum.KutleNumarasi = 227.0;
            Aktinyum.Kategorisi = "Aktinitler";
            Elementler[88] = Aktinyum;

            PeriyodikTablo Toryum = new PeriyodikTablo();
            Toryum.AtomNumarasi = 90;
            Toryum.AtomAdi = "Toryum";
            Toryum.AtomSembolu = "Th";
            Toryum.KutleNumarasi = 232.0;
            Toryum.Kategorisi = "Aktinitler";
            Elementler[89] = Toryum;

            PeriyodikTablo Protaktinyum = new PeriyodikTablo();
            Protaktinyum.AtomNumarasi = 91;
            Protaktinyum.AtomAdi = "Protaktinyum";
            Protaktinyum.AtomSembolu = "Pa";
            Protaktinyum.KutleNumarasi = 231.04;
            Protaktinyum.Kategorisi = "Aktinit";
            Elementler[90] = Protaktinyum;

            PeriyodikTablo Uranyum = new PeriyodikTablo();
            Uranyum.AtomNumarasi = 92;
            Uranyum.AtomAdi = "Uranyum";
            Uranyum.AtomSembolu = "U";
            Uranyum.KutleNumarasi = 238.03;
            Uranyum.Kategorisi = "Aktinit";
            Elementler[91] = Uranyum;

            PeriyodikTablo Neptunyum = new PeriyodikTablo();
            Neptunyum.AtomNumarasi = 93;
            Neptunyum.AtomAdi = "Neptünyum";
            Neptunyum.AtomSembolu = "Np";
            Neptunyum.KutleNumarasi = 237.0;
            Neptunyum.Kategorisi = "Aktinit";
            Elementler[92] = Neptunyum;

            PeriyodikTablo Plutonyum = new PeriyodikTablo();
            Plutonyum.AtomNumarasi = 94;
            Plutonyum.AtomAdi = "Plütonyum";
            Plutonyum.AtomSembolu = "Pu";
            Plutonyum.KutleNumarasi = 244.0;
            Plutonyum.Kategorisi = "Aktinit";
            Elementler[93] = Plutonyum;

            PeriyodikTablo Amerikyum = new PeriyodikTablo();
            Amerikyum.AtomNumarasi = 95;
            Amerikyum.AtomAdi = "Amerikyum";
            Amerikyum.AtomSembolu = "Am";
            Amerikyum.KutleNumarasi = 243.0;
            Amerikyum.Kategorisi = "Aktinit";
            Elementler[94] = Amerikyum;

            PeriyodikTablo Kuriyum = new PeriyodikTablo();
            Kuriyum.AtomNumarasi = 96;
            Kuriyum.AtomAdi = "Küriyum";
            Kuriyum.AtomSembolu = "Cm";
            Kuriyum.KutleNumarasi = 247.0;
            Kuriyum.Kategorisi = "Aktinit";
            Elementler[95] = Kuriyum;

            PeriyodikTablo Berkelyum = new PeriyodikTablo();
            Berkelyum.AtomNumarasi = 97;
            Berkelyum.AtomAdi = "Berkelyum";
            Berkelyum.AtomSembolu = "Bk";
            Berkelyum.KutleNumarasi = 247.0;
            Berkelyum.Kategorisi = "Aktinit";
            Elementler[96] = Berkelyum;

            PeriyodikTablo Kaliforniyum = new PeriyodikTablo();
            Kaliforniyum.AtomNumarasi = 98;
            Kaliforniyum.AtomAdi = "Kaliforniyum";
            Kaliforniyum.AtomSembolu = "Cf";
            Kaliforniyum.KutleNumarasi = 251.0;
            Kaliforniyum.Kategorisi = "Aktinit";
            Elementler[97] = Kaliforniyum;

            PeriyodikTablo Aynstaynyum = new PeriyodikTablo();
            Aynstaynyum.AtomNumarasi = 99;
            Aynstaynyum.AtomAdi = "Aynştaynyum";
            Aynstaynyum.AtomSembolu = "Es";
            Aynstaynyum.KutleNumarasi = 252.0;
            Aynstaynyum.Kategorisi = "Aktinit";
            Elementler[98] = Aynstaynyum;

            PeriyodikTablo Fermiyum = new PeriyodikTablo();
            Fermiyum.AtomNumarasi = 100;
            Fermiyum.AtomAdi = "Fermiyum";
            Fermiyum.AtomSembolu = "Fm";
            Fermiyum.KutleNumarasi = 257.0;
            Fermiyum.Kategorisi = "Aktinit";
            Elementler[99] = Fermiyum;

            PeriyodikTablo Mendelevyum = new PeriyodikTablo();
            Mendelevyum.AtomNumarasi = 101;
            Mendelevyum.AtomAdi = "Mendelevyum";
            Mendelevyum.AtomSembolu = "Md";
            Mendelevyum.KutleNumarasi = 258.0;
            Mendelevyum.Kategorisi = "Aktinit";
            Elementler[100] = Mendelevyum;

            PeriyodikTablo Nobelyum = new PeriyodikTablo();
            Nobelyum.AtomNumarasi = 102;
            Nobelyum.AtomAdi = "Nobelyum";
            Nobelyum.AtomSembolu = "No";
            Nobelyum.KutleNumarasi = 259.0;
            Nobelyum.Kategorisi = "Aktinit";
            Elementler[101] = Nobelyum;

            PeriyodikTablo Lavrensiyum = new PeriyodikTablo();
            Lavrensiyum.AtomNumarasi = 103;
            Lavrensiyum.AtomAdi = "Lavrensiyum";
            Lavrensiyum.AtomSembolu = "Lr";
            Lavrensiyum.KutleNumarasi = 262.0;
            Lavrensiyum.Kategorisi = "Aktinit";
            Elementler[102] = Lavrensiyum;

            PeriyodikTablo Rutherfordıyum = new PeriyodikTablo();
            Rutherfordıyum.AtomNumarasi = 104;
            Rutherfordıyum.AtomAdi = "Rutherfordiyum";
            Rutherfordıyum.AtomSembolu = "Rf";
            Rutherfordıyum.KutleNumarasi = 267.0;
            Rutherfordıyum.Kategorisi = "Geçiş Metalleri";
            Elementler[103] = Rutherfordıyum;

            PeriyodikTablo Dunniyum = new PeriyodikTablo();
            Dunniyum.AtomNumarasi = 105;
            Dunniyum.AtomAdi = "Dubniyum";
            Dunniyum.AtomSembolu = "Db";
            Dunniyum.KutleNumarasi = 270.0;
            Dunniyum.Kategorisi = "Geçiş Metalleri";
            Elementler[104] = Dunniyum;

            PeriyodikTablo Seaborgiyum = new PeriyodikTablo();
            Seaborgiyum.AtomNumarasi = 106;
            Seaborgiyum.AtomAdi = "Seaborgiyum";
            Seaborgiyum.AtomSembolu = "Sg";
            Seaborgiyum.KutleNumarasi = 271.0;
            Seaborgiyum.Kategorisi = "Geçiş Metalleri";
            Elementler[105] = Seaborgiyum;

            PeriyodikTablo Bohriyum = new PeriyodikTablo();
            Bohriyum.AtomNumarasi = 107;
            Bohriyum.AtomAdi = "Bohriyum";
            Bohriyum.AtomSembolu = "Bh";
            Bohriyum.KutleNumarasi = 270.0;
            Bohriyum.Kategorisi = "Geçiş Metalleri";
            Elementler[106] = Bohriyum;

            PeriyodikTablo Hassiyum = new PeriyodikTablo();
            Hassiyum.AtomNumarasi = 108;
            Hassiyum.AtomAdi = "Hassiyum";
            Hassiyum.AtomSembolu = "Hs";
            Hassiyum.KutleNumarasi = 277.0;
            Hassiyum.Kategorisi = "Geçiş Metalleri";
            Elementler[107] = Hassiyum;

            PeriyodikTablo Meitreniyum = new PeriyodikTablo();
            Meitreniyum.AtomNumarasi = 109;
            Meitreniyum.AtomAdi = "Meitneriyum";
            Meitreniyum.AtomSembolu = "Mt";
            Meitreniyum.KutleNumarasi = 276.0;
            Meitreniyum.Kategorisi = "Geçiş Metalleri";
            Elementler[108] = Meitreniyum;

            PeriyodikTablo Darmstadtiyum = new PeriyodikTablo();
            Darmstadtiyum.AtomNumarasi = 110;
            Darmstadtiyum.AtomAdi = "Darmstadtiyum";
            Darmstadtiyum.AtomSembolu = "Ds";
            Darmstadtiyum.KutleNumarasi = 281.0;
            Darmstadtiyum.Kategorisi = "Geçiş Metalleri";
            Elementler[109] = Darmstadtiyum;

            PeriyodikTablo Rontgenyum = new PeriyodikTablo();
            Rontgenyum.AtomNumarasi = 111;
            Rontgenyum.AtomAdi = "Röntgenyum";
            Rontgenyum.AtomSembolu = "Rg";
            Rontgenyum.KutleNumarasi = 280.0;
            Rontgenyum.Kategorisi = "Geçiş Metalleri";
            Elementler[110] = Rontgenyum;

            PeriyodikTablo Kopernikyum = new PeriyodikTablo();
            Kopernikyum.AtomNumarasi = 112;
            Kopernikyum.AtomAdi = "Kopernikyum";
            Kopernikyum.AtomSembolu = "Cn";
            Kopernikyum.KutleNumarasi = 285.0;
            Kopernikyum.Kategorisi = "Geçiş Metalleri";
            Elementler[111] = Kopernikyum;

            PeriyodikTablo Nihoniyum = new PeriyodikTablo();
            Nihoniyum.AtomNumarasi = 113;
            Nihoniyum.AtomAdi = "Nihoniyum";
            Nihoniyum.AtomSembolu = "Nh";
            Nihoniyum.KutleNumarasi = 284.0;
            Nihoniyum.Kategorisi = "Geçiş Metalleri";
            Elementler[112] = Nihoniyum;

            PeriyodikTablo Flerovyum = new PeriyodikTablo();
            Flerovyum.AtomNumarasi = 114;
            Flerovyum.AtomAdi = "Flerovyum";
            Flerovyum.AtomSembolu = "Fl";
            Flerovyum.KutleNumarasi = 289.0;
            Flerovyum.Kategorisi = "Geçiş Metalleri";
            Elementler[113] = Flerovyum;

            PeriyodikTablo Moskoviyum = new PeriyodikTablo();
            Moskoviyum.AtomNumarasi = 115;
            Moskoviyum.AtomAdi = "Moskoviyum";
            Moskoviyum.AtomSembolu = "Mc";
            Moskoviyum.KutleNumarasi = 290.0;
            Moskoviyum.Kategorisi = "Geçiş Metalleri";
            Elementler[114] = Moskoviyum;

            PeriyodikTablo Livermoryum = new PeriyodikTablo();
            Livermoryum.AtomNumarasi = 116;
            Livermoryum.AtomAdi = "Livermoryum";
            Livermoryum.AtomSembolu = "Lv";
            Livermoryum.KutleNumarasi = 293.0;
            Livermoryum.Kategorisi = "Geçiş Metalleri";
            Elementler[115] = Livermoryum;

            PeriyodikTablo Tennesin = new PeriyodikTablo();
            Tennesin.AtomNumarasi = 117;
            Tennesin.AtomAdi = "Tennesin";
            Tennesin.AtomSembolu = "Ts";
            Tennesin.KutleNumarasi = 294.0;
            Tennesin.Kategorisi = "Geçiş Metalleri";
            Elementler[116] = Tennesin;

            PeriyodikTablo Oganesson = new PeriyodikTablo();
            Oganesson.AtomNumarasi = 118;
            Oganesson.AtomAdi = "Oganesson";
            Oganesson.AtomSembolu = "Og";
            Oganesson.KutleNumarasi = 294.0;
            Oganesson.Kategorisi = "Geçiş Metalleri";
            Elementler[117] = Oganesson;

            //

            Console.WriteLine("Lütfen Aratmak İstediğiniz Elementin Atom Numarasını Giriniz");
            int Secim = Convert.ToInt32(Console.ReadLine());

            if (Secim <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Elementler 'Atom Adı - Atom Sembolü - Kütle Numarası / Atom Kategorisi' Şeklinde Sıralanmıştır\n");
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < Elementler.Length; i++)
                {
                    Console.WriteLine($"{Elementler[i].AtomNumarasi}) {Elementler[i].AtomAdi} - {Elementler[i].AtomSembolu} - {Elementler[i].KutleNumarasi} / {Elementler[i].Kategorisi}");
                }
            }
            else
            {
                if (Elementler.Any(element => element.AtomNumarasi == Secim))
                {
                    Console.WriteLine($"{Elementler[Secim - 1].AtomAdi} - {Elementler[Secim - 1].AtomSembolu} - {Elementler[Secim - 1].KutleNumarasi} / {Elementler[Secim - 1].Kategorisi}");
                }
                else
                {
                    Console.WriteLine("Elementler Şu Anlık 118 İle Sınırlıdır");
                }
            }
        }
    }
}

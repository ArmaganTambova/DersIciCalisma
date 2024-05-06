using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Net.NetworkInformation;
using System.Drawing.Imaging;

namespace OgrenciKayıtSistemi
{
    public partial class Main : Form
    {
        private List<string> Ogrenciler = new List<string>();
        private string OgrenciResmiDosyaUzantisi = "";

        public Main()
        {
            InitializeComponent();

            LB_KayitliOgrenciler.Items.Clear();
            LB_KayitliOgrenciler.SelectedItem = null;
            Ogrenciler.Clear();

            DirectoryInfo DosyaIsimleri = new DirectoryInfo("../../Kayitlar/");
            FileInfo[] Dosya = DosyaIsimleri.GetFiles();

            if (Dosya.Length > 0 )
            {
                foreach (FileInfo Item in Dosya)
                {
                    Ogrenciler.Add(Item.Name);
                }
            }

            ListeYenile();

            StreamReader Sinif = new StreamReader("../../Siniflar/Sinif.txt");
            List<string> SinifListesi = new List<string>();

            while (true)
            {
                string Deger = Sinif.ReadLine();
                if (Deger != null)
                {
                    SinifListesi.Add(Deger);
                }
                else
                {
                    break;
                }
            }

            Sinif.Close();

            foreach (string Item in SinifListesi)
            {
                CB_Sinif.Items.Add(Item);
            }

            StreamReader Sube = new StreamReader("../../Siniflar/Sube.txt");
            List<string> SubeListesi = new List<string>();

            while (true)
            {
                string Deger = Sube.ReadLine();
                if (Deger != null)
                {
                    SubeListesi.Add(Deger);
                }
                else
                {
                    break;
                }
            }

            Sube.Close();

            foreach(string Item in SubeListesi)
            {
                CB_Sube.Items.Add(Item);
            }

            TB_Isim.TabIndex = 0;
            TB_SoyIsim.TabIndex = 1;
            TB_TC.TabIndex = 2;
            TB_Telefon.TabIndex = 3;
            TB_Adres.TabIndex = 4;
            TB_Okul.TabIndex = 5;
            CB_Sinif.TabIndex = 6;
            CB_Sube.TabIndex = 7;
            BTN_Temizle.TabIndex = 8;
            BTN_Kaydet.TabIndex = 9;
            BTN_Getir.TabIndex = 10;
            BTN_Sil.TabIndex = 11;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            OgrenciResmiOpenFileDialog.Filter = "Resim |*.jpg";
        }

        private void ListeYenile()
        {
            LB_KayitliOgrenciler.Items.Clear();

            string DosyaYolu = "../../Kayitlar/";

            foreach (string Item in Ogrenciler)
            {
                DosyaYolu += Item;

                StreamReader AdSoyad = new StreamReader(DosyaYolu);
                string Isim = AdSoyad.ReadLine();
                string Soyad = AdSoyad.ReadLine();
                LB_KayitliOgrenciler.Items.Add(Isim + " " + Soyad);
                AdSoyad.Close();

                DosyaYolu = "../../Kayitlar/";
            }
        }

        private void BTN_Temizle_Click(object sender, EventArgs e)
        {
            TB_Isim.Clear();
            TB_SoyIsim.Clear();
            TB_TC.Clear();
            TB_Telefon.Clear();
            TB_Adres.Clear();
            TB_Okul.Clear();
            CB_Sinif.Text = null; CB_Sube.Text= null;
            PB_OgrenciResmi.Image = null;

            LB_KayitliOgrenciler.SelectedItem = null;

            OgrenciResmiDosyaUzantisi = "";
        }

        private void BTN_Kaydet_Click(object sender, EventArgs e)
        {
            string TelefonNumarasi = TB_Telefon.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").Trim();

            if (TB_Isim.Text != "" && TB_Isim.Text != null)
            {
                if (TB_SoyIsim.Text != "" && TB_SoyIsim.Text != null)
                {
                    if (TelefonNumarasi.Length == 10)
                    {
                        if (TB_Adres.Text != "" && TB_Adres.Text != null)
                        {
                            if (TB_Okul.Text != "" && TB_Okul.Text != null)
                            {
                                if (CB_Sube.Text != "" && CB_Sube.Text != null || CB_Sinif.Text != "" && CB_Sinif.Text != null || PB_OgrenciResmi.Image != null)
                                {
                                    string DosyaYolu = "../../Kayitlar/" + TB_TC.Text + ".txt";

                                    if (File.Exists(DosyaYolu))
                                    {
                                        MessageBox.Show("Bu Öğrenci Zaten Kayıt Edilmiş", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else
                                    {
                                        if (TB_TC.Text.Replace("_", "").Trim().Length == 11)
                                        {
                                            string Isim = TB_Isim.Text;
                                            string[] Isimler = Isim.Split(' ');

                                            if (Isimler.Length > 1)
                                            {
                                                string DIsim = "";

                                                for (int i = 0; i < Isimler.Length; i++)
                                                {
                                                    string GIsim = Isimler[i];

                                                    if (i != Isimler.Length - 1)
                                                    {
                                                        GIsim = GIsim[0].ToString().ToUpper() + GIsim.Substring(1).ToLower() + " ";
                                                    }
                                                    else
                                                    {
                                                        // Eğer İkinci İsmin Sonunda Boşluk Varsa Hata Veriyor
                                                        GIsim = GIsim[0].ToString().ToUpper() + GIsim.Substring(1).ToLower();
                                                    }
                                                    
                                                    DIsim += GIsim;
                                                }

                                                TB_Isim.Text = DIsim;
                                            }
                                            else
                                            {
                                                TB_Isim.Text = TB_Isim.Text[0].ToString().ToUpper() + TB_Isim.Text.Substring(1).ToLower();
                                            }

                                            string SoyIsim = TB_SoyIsim.Text;
                                            string[] SoyIsimler = SoyIsim.Split(' ');

                                            if (Isimler.Length > 1)
                                            {
                                                string DSoyIsim = "";

                                                for (int i = 0; i < SoyIsimler.Length; i++)
                                                {
                                                    string GSoyIsim = SoyIsimler[i];

                                                    if (i != SoyIsimler.Length - 1)
                                                    {
                                                        GSoyIsim = GSoyIsim[0].ToString().ToUpper() + GSoyIsim.Substring(1).ToLower() + " ";
                                                    }
                                                    else
                                                    {
                                                        GSoyIsim = GSoyIsim[0].ToString().ToUpper() + GSoyIsim.Substring(1).ToLower();
                                                    }

                                                    DSoyIsim += GSoyIsim;
                                                }

                                                TB_SoyIsim.Text = DSoyIsim;
                                            }
                                            else
                                            {
                                                TB_SoyIsim.Text = TB_SoyIsim.Text[0].ToString().ToUpper() + TB_SoyIsim.Text.Substring(1).ToLower();
                                            }

                                            StreamWriter OgrenciKayit = new StreamWriter(DosyaYolu);
                                            string KayitMetni = "";
                                            KayitMetni += TB_Isim.Text + "\n" + TB_SoyIsim.Text + "\n";
                                            KayitMetni += TB_TC.Text + "\n";
                                            KayitMetni += TelefonNumarasi + "\n";
                                            KayitMetni += TB_Adres.Text + "\n";
                                            KayitMetni += TB_Okul.Text + "\n";
                                            KayitMetni += CB_Sinif.Text + "/" + CB_Sube.Text;
                                            OgrenciKayit.Write(KayitMetni);
                                            OgrenciKayit.Close();

                                            File.Copy(OgrenciResmiDosyaUzantisi, "../../OgrenciResimleri/" + TB_TC.Text + ".jpg");

                                            Ogrenciler.Add(TB_TC.Text + ".txt");
                                            ListeYenile();
                                            BTN_Temizle.PerformClick();
                                            LB_KayitliOgrenciler.SelectedItem = null;
                                        }
                                        else
                                        {
                                            MessageBox.Show("TC Kimlik Numarası Alanına 11 Haneli TC Kimlik Numarası Girilmelidir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            LB_KayitliOgrenciler.SelectedItem = null;
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Lütfen Tüm Boşlukları Doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    LB_KayitliOgrenciler.SelectedItem = null;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Lütfen Tüm Boşlukları Doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                LB_KayitliOgrenciler.SelectedItem = null;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Tüm Boşlukları Doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            LB_KayitliOgrenciler.SelectedItem = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Tüm Boşlukları Doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LB_KayitliOgrenciler.SelectedItem = null;
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Tüm Boşlukları Doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LB_KayitliOgrenciler.SelectedItem = null;
                }
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Boşlukları Doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LB_KayitliOgrenciler.SelectedItem = null;
            }
        }

        private void BTN_Getir_Click(object sender, EventArgs e)
        {
            if (LB_KayitliOgrenciler.SelectedItem != null)
            {
                bool Kontrol = true;

                List<string> KontrolListesi = new List<string>();
                KontrolListesi.Add(TB_Isim.Text);
                KontrolListesi.Add(TB_SoyIsim.Text);
                KontrolListesi.Add(TB_TC.Text);
                KontrolListesi.Add(TB_Telefon.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").Trim());
                KontrolListesi.Add(TB_Adres.Text);
                KontrolListesi.Add(TB_Okul.Text);
                KontrolListesi.Add(CB_Sube.Text);
                KontrolListesi.Add(CB_Sinif.Text);

                foreach (string Item in KontrolListesi)
                {
                    if (Item != null && Item != "")
                    {
                        Kontrol = false;
                        break;
                    }
                }

                if (Kontrol)
                {
                    string DosyaYolu = "../../Kayitlar/";

                    DosyaYolu += Ogrenciler[LB_KayitliOgrenciler.SelectedIndex];

                    StreamReader Ogrenci = new StreamReader(DosyaYolu);
                    TB_Isim.Text = Ogrenci.ReadLine();
                    TB_SoyIsim.Text = Ogrenci.ReadLine();
                    TB_TC.Text = Ogrenci.ReadLine();
                    TB_Telefon.Text = Ogrenci.ReadLine();
                    TB_Adres.Text = Ogrenci.ReadLine();
                    TB_Okul.Text = Ogrenci.ReadLine();
                    string Sinif = Ogrenci.ReadLine(); string SinifD = ""; string SubeD = "";

                    for (int i = 0; i < Sinif.Length; i++)
                    {
                        if (Sinif[i].ToString() == "/")
                        {
                            SinifD = Sinif.Substring(0, i);
                            SubeD = Sinif.Substring(Sinif.Length - 1);
                        }
                    }

                    CB_Sinif.Text = SinifD;
                    CB_Sube.Text = SubeD;
                    Ogrenci.Close();

                    string DosyaYoluResim = "../../OgrenciResimleri/";
                    DosyaYoluResim += Ogrenciler[LB_KayitliOgrenciler.SelectedIndex].Substring(0, 11) + ".jpg";

                    PB_OgrenciResmi.Load(DosyaYoluResim);

                    LB_KayitliOgrenciler.SelectedItem = null;
                }
                else
                {
                    DialogResult Getir = MessageBox.Show("Eğer Öğrenci Bilgileri Getirilirse Kayıt Edilen Öğrencinin Bilgileri Silinecektir, Devam Etmek İster Misiniz?", "Soru", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (Getir == DialogResult.OK)
                    {
                        string DosyaYolu = "../../Kayitlar/";

                        DosyaYolu = DosyaYolu + Ogrenciler[LB_KayitliOgrenciler.SelectedIndex];

                        StreamReader Ogrenci = new StreamReader(DosyaYolu);
                        TB_Isim.Text = Ogrenci.ReadLine();
                        TB_SoyIsim.Text = Ogrenci.ReadLine();
                        TB_TC.Text = Ogrenci.ReadLine();
                        TB_Telefon.Text = Ogrenci.ReadLine();
                        TB_Adres.Text = Ogrenci.ReadLine();
                        TB_Okul.Text = Ogrenci.ReadLine();
                        string Sinif = Ogrenci.ReadLine(); string SinifD = ""; string SubeD = "";

                        for (int i = 0; i < Sinif.Length; i++)
                        {
                            if (Sinif[i].ToString() == "/")
                            {
                                SinifD = Sinif.Substring(0, i);
                                SubeD = Sinif.Substring(Sinif.Length - 1);
                            }
                        }

                        CB_Sinif.Text = SinifD;
                        CB_Sube.Text = SubeD;
                        Ogrenci.Close();

                        string DosyaYoluResim = "../../OgrenciResimleri/";
                        DosyaYoluResim += Ogrenciler[LB_KayitliOgrenciler.SelectedIndex].Substring(0, 11) + ".jpg";

                        PB_OgrenciResmi.Load(DosyaYoluResim);

                        LB_KayitliOgrenciler.SelectedItem = null;
                    }
                    else
                    {
                        LB_KayitliOgrenciler.SelectedItem = null;
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Listeden Öğrenci Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTN_Sil_Click(object sender, EventArgs e)
        {
            if (LB_KayitliOgrenciler.SelectedItem != null)
            {
                string DosyaYolu = "../../Kayitlar/";
                DosyaYolu += Ogrenciler[LB_KayitliOgrenciler.SelectedIndex];

                File.Delete(DosyaYolu);

                string DosyaYoluResim = "../../OgrenciResimleri/";
                DosyaYoluResim += Ogrenciler[LB_KayitliOgrenciler.SelectedIndex].Substring(0, 11) + ".jpg";

                File.Delete(DosyaYoluResim);

                Ogrenciler.RemoveAt(LB_KayitliOgrenciler.SelectedIndex);

                ListeYenile();

                BTN_Temizle.PerformClick();
                LB_KayitliOgrenciler.SelectedItem = null;
            }
            else
            {
                MessageBox.Show("Lütfen Listeden Öğrenci Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PB_OgrenciResmi_Click(object sender, EventArgs e)
        {
            if (OgrenciResmiOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                PB_OgrenciResmi.Load(OgrenciResmiOpenFileDialog.FileName);
                OgrenciResmiDosyaUzantisi = OgrenciResmiOpenFileDialog.FileName;
            }
        }
    }
}

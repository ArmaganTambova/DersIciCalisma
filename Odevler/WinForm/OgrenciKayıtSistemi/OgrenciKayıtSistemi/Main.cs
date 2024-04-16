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

namespace OgrenciKayıtSistemi
{
    public partial class Main : Form
    {
        private List<string> Ogrenciler = new List<string>();

        public Main()
        {
            InitializeComponent();

            LB_KayitliOgrenciler.Items.Clear();
            LB_KayitliOgrenciler.SelectedItem = null;
            Ogrenciler.Clear();

            DirectoryInfo DosyaIsimleri = new DirectoryInfo("C://Users/armif/OneDrive/Belgeler/GitHub/DersIciCalisma/Odevler/WinForm/OgrenciKayıtSistemi/OgrenciKayıtSistemi/Kayitlar/");
            FileInfo[] Dosya = DosyaIsimleri.GetFiles();

            if (Dosya.Length > 0 )
            {
                foreach (FileInfo Item in Dosya)
                {
                    Ogrenciler.Add(Item.Name);
                }
            }

            ListeYenile();
        }

        private void ListeYenile()
        {
            LB_KayitliOgrenciler.Items.Clear();

            string DosyaYolu = "C://Users/armif/OneDrive/Belgeler/GitHub/DersIciCalisma/Odevler/WinForm/OgrenciKayıtSistemi/OgrenciKayıtSistemi/Kayitlar/";

            foreach (string Item in Ogrenciler)
            {
                DosyaYolu += Item;

                StreamReader AdSoyad = new StreamReader(DosyaYolu);
                string Isim = AdSoyad.ReadLine();
                string Soyad = AdSoyad.ReadLine();
                LB_KayitliOgrenciler.Items.Add(Isim + " " + Soyad);
                AdSoyad.Close();

                DosyaYolu = "C://Users/armif/OneDrive/Belgeler/GitHub/DersIciCalisma/Odevler/WinForm/OgrenciKayıtSistemi/OgrenciKayıtSistemi/Kayitlar/";
            }
        }

        private void BTN_Temizle_Click(object sender, EventArgs e)
        {
            TB_Isim.Clear();
            TB_SoyIsim.Clear();
            TB_TC.Clear();
            TB_Adres.Clear();
            TB_Okul.Clear();
            TB_Sinif.Clear();

            LB_KayitliOgrenciler.SelectedItem = null;
        }

        private void BTN_Kaydet_Click(object sender, EventArgs e)
        {
            if (TB_Isim.Text != "" && TB_Isim.Text != null)
            {
                if (TB_SoyIsim.Text != "" && TB_SoyIsim.Text != null)
                {
                    if (TB_TC.Text != "" && TB_TC.Text != null)
                    {
                        if (TB_Adres.Text != "" && TB_Adres.Text != null)
                        {
                            if (TB_Okul.Text != "" && TB_Okul.Text != null)
                            {
                                if (TB_Sinif.Text != "" && TB_Sinif.Text != null)
                                {
                                    string DosyaYolu = "C://Users/armif/OneDrive/Belgeler/GitHub/DersIciCalisma/Odevler/WinForm/OgrenciKayıtSistemi/OgrenciKayıtSistemi/Kayitlar/" + TB_TC.Text + ".txt";

                                    if (File.Exists(DosyaYolu))
                                    {
                                        MessageBox.Show("Bu Öğrenci Zaten Kayıt Edilmiş", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else
                                    {
                                        if (TB_TC.Text.Length == 11)
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
                                            KayitMetni += TB_Adres.Text + "\n";
                                            KayitMetni += TB_Okul.Text + "\n";
                                            KayitMetni += TB_Sinif.Text;
                                            OgrenciKayit.Write(KayitMetni);
                                            OgrenciKayit.Close();

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
                KontrolListesi.Add(TB_Adres.Text);
                KontrolListesi.Add(TB_Okul.Text);
                KontrolListesi.Add(TB_Sinif.Text);

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
                    string DosyaYolu = "C://Users/armif/OneDrive/Belgeler/GitHub/DersIciCalisma/Odevler/WinForm/OgrenciKayıtSistemi/OgrenciKayıtSistemi/Kayitlar/";

                    DosyaYolu = DosyaYolu + Ogrenciler[LB_KayitliOgrenciler.SelectedIndex];

                    StreamReader Ogrenci = new StreamReader(DosyaYolu);
                    TB_Isim.Text = Ogrenci.ReadLine();
                    TB_SoyIsim.Text = Ogrenci.ReadLine();
                    TB_TC.Text = Ogrenci.ReadLine();
                    TB_Adres.Text = Ogrenci.ReadLine();
                    TB_Okul.Text = Ogrenci.ReadLine();
                    TB_Sinif.Text = Ogrenci.ReadLine();
                    Ogrenci.Close();

                    LB_KayitliOgrenciler.SelectedItem = null;
                }
                else
                {
                    DialogResult Getir = MessageBox.Show("Eğer Öğrenci Bilgileri Getirilirse Kayıt Edilen Öğrencinin Bilgileri Silinecektir, Devam Etmek İster Misiniz?", "Soru", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (Getir == DialogResult.OK)
                    {
                        string DosyaYolu = "C://Users/armif/OneDrive/Belgeler/GitHub/DersIciCalisma/Odevler/WinForm/OgrenciKayıtSistemi/OgrenciKayıtSistemi/Kayitlar/";

                        DosyaYolu = DosyaYolu + Ogrenciler[LB_KayitliOgrenciler.SelectedIndex];

                        StreamReader Ogrenci = new StreamReader(DosyaYolu);
                        TB_Isim.Text = Ogrenci.ReadLine();
                        TB_SoyIsim.Text = Ogrenci.ReadLine();
                        TB_TC.Text = Ogrenci.ReadLine();
                        TB_Adres.Text = Ogrenci.ReadLine();
                        TB_Okul.Text = Ogrenci.ReadLine();
                        TB_Sinif.Text = Ogrenci.ReadLine();
                        Ogrenci.Close();

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
                string DosyaYolu = "C://Users/armif/OneDrive/Belgeler/GitHub/DersIciCalisma/Odevler/WinForm/OgrenciKayıtSistemi/OgrenciKayıtSistemi/Kayitlar/";

                DosyaYolu = DosyaYolu + Ogrenciler[LB_KayitliOgrenciler.SelectedIndex];

                FileInfo OgrenciSil = new FileInfo(DosyaYolu);
                OgrenciSil.Delete();

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

        private void TB_TC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || TB_TC.Text.Length >= 11 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

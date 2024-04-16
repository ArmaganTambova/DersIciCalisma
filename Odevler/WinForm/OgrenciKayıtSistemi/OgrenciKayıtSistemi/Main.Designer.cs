namespace OgrenciKayıtSistemi
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBL_Isim = new System.Windows.Forms.Label();
            this.TB_Isim = new System.Windows.Forms.TextBox();
            this.TB_SoyIsim = new System.Windows.Forms.TextBox();
            this.LBL_SoyIsim = new System.Windows.Forms.Label();
            this.TB_TC = new System.Windows.Forms.TextBox();
            this.LBL_TC = new System.Windows.Forms.Label();
            this.TB_Adres = new System.Windows.Forms.TextBox();
            this.LBL_Adres = new System.Windows.Forms.Label();
            this.TB_Okul = new System.Windows.Forms.TextBox();
            this.LBL_Okul = new System.Windows.Forms.Label();
            this.TB_Sinif = new System.Windows.Forms.TextBox();
            this.LBL_Sinif = new System.Windows.Forms.Label();
            this.LBL_OgrenciKayıtSistemi = new System.Windows.Forms.Label();
            this.BTN_Temizle = new System.Windows.Forms.Button();
            this.BTN_Kaydet = new System.Windows.Forms.Button();
            this.LBL_KayitliOgrenciler = new System.Windows.Forms.Label();
            this.LB_KayitliOgrenciler = new System.Windows.Forms.ListBox();
            this.BTN_Sil = new System.Windows.Forms.Button();
            this.BTN_Getir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_Isim
            // 
            this.LBL_Isim.AutoSize = true;
            this.LBL_Isim.Location = new System.Drawing.Point(13, 76);
            this.LBL_Isim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Isim.Name = "LBL_Isim";
            this.LBL_Isim.Size = new System.Drawing.Size(42, 20);
            this.LBL_Isim.TabIndex = 0;
            this.LBL_Isim.Text = "İsim:";
            // 
            // TB_Isim
            // 
            this.TB_Isim.Location = new System.Drawing.Point(87, 73);
            this.TB_Isim.Name = "TB_Isim";
            this.TB_Isim.Size = new System.Drawing.Size(200, 26);
            this.TB_Isim.TabIndex = 1;
            // 
            // TB_SoyIsim
            // 
            this.TB_SoyIsim.Location = new System.Drawing.Point(87, 105);
            this.TB_SoyIsim.Name = "TB_SoyIsim";
            this.TB_SoyIsim.Size = new System.Drawing.Size(200, 26);
            this.TB_SoyIsim.TabIndex = 3;
            // 
            // LBL_SoyIsim
            // 
            this.LBL_SoyIsim.AutoSize = true;
            this.LBL_SoyIsim.Location = new System.Drawing.Point(13, 108);
            this.LBL_SoyIsim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_SoyIsim.Name = "LBL_SoyIsim";
            this.LBL_SoyIsim.Size = new System.Drawing.Size(67, 20);
            this.LBL_SoyIsim.TabIndex = 2;
            this.LBL_SoyIsim.Text = "Soyisim:";
            // 
            // TB_TC
            // 
            this.TB_TC.Location = new System.Drawing.Point(87, 137);
            this.TB_TC.Name = "TB_TC";
            this.TB_TC.Size = new System.Drawing.Size(200, 26);
            this.TB_TC.TabIndex = 5;
            this.TB_TC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_TC_KeyPress);
            // 
            // LBL_TC
            // 
            this.LBL_TC.AutoSize = true;
            this.LBL_TC.Location = new System.Drawing.Point(13, 140);
            this.LBL_TC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_TC.Name = "LBL_TC";
            this.LBL_TC.Size = new System.Drawing.Size(57, 20);
            this.LBL_TC.TabIndex = 4;
            this.LBL_TC.Text = "TC No:";
            // 
            // TB_Adres
            // 
            this.TB_Adres.Location = new System.Drawing.Point(87, 169);
            this.TB_Adres.Name = "TB_Adres";
            this.TB_Adres.Size = new System.Drawing.Size(200, 26);
            this.TB_Adres.TabIndex = 7;
            // 
            // LBL_Adres
            // 
            this.LBL_Adres.AutoSize = true;
            this.LBL_Adres.Location = new System.Drawing.Point(13, 172);
            this.LBL_Adres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Adres.Name = "LBL_Adres";
            this.LBL_Adres.Size = new System.Drawing.Size(55, 20);
            this.LBL_Adres.TabIndex = 6;
            this.LBL_Adres.Text = "Adres:";
            // 
            // TB_Okul
            // 
            this.TB_Okul.Location = new System.Drawing.Point(87, 201);
            this.TB_Okul.Name = "TB_Okul";
            this.TB_Okul.Size = new System.Drawing.Size(200, 26);
            this.TB_Okul.TabIndex = 9;
            // 
            // LBL_Okul
            // 
            this.LBL_Okul.AutoSize = true;
            this.LBL_Okul.Location = new System.Drawing.Point(13, 204);
            this.LBL_Okul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Okul.Name = "LBL_Okul";
            this.LBL_Okul.Size = new System.Drawing.Size(45, 20);
            this.LBL_Okul.TabIndex = 8;
            this.LBL_Okul.Text = "Okul:";
            // 
            // TB_Sinif
            // 
            this.TB_Sinif.Location = new System.Drawing.Point(87, 233);
            this.TB_Sinif.Name = "TB_Sinif";
            this.TB_Sinif.Size = new System.Drawing.Size(200, 26);
            this.TB_Sinif.TabIndex = 11;
            // 
            // LBL_Sinif
            // 
            this.LBL_Sinif.AutoSize = true;
            this.LBL_Sinif.Location = new System.Drawing.Point(13, 236);
            this.LBL_Sinif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Sinif.Name = "LBL_Sinif";
            this.LBL_Sinif.Size = new System.Drawing.Size(44, 20);
            this.LBL_Sinif.TabIndex = 10;
            this.LBL_Sinif.Text = "Sınıf:";
            // 
            // LBL_OgrenciKayıtSistemi
            // 
            this.LBL_OgrenciKayıtSistemi.AutoSize = true;
            this.LBL_OgrenciKayıtSistemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_OgrenciKayıtSistemi.Location = new System.Drawing.Point(13, 9);
            this.LBL_OgrenciKayıtSistemi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_OgrenciKayıtSistemi.Name = "LBL_OgrenciKayıtSistemi";
            this.LBL_OgrenciKayıtSistemi.Size = new System.Drawing.Size(217, 25);
            this.LBL_OgrenciKayıtSistemi.TabIndex = 12;
            this.LBL_OgrenciKayıtSistemi.Text = "Öğrenci Kayıt Sistemi";
            // 
            // BTN_Temizle
            // 
            this.BTN_Temizle.Location = new System.Drawing.Point(87, 265);
            this.BTN_Temizle.Name = "BTN_Temizle";
            this.BTN_Temizle.Size = new System.Drawing.Size(90, 30);
            this.BTN_Temizle.TabIndex = 13;
            this.BTN_Temizle.Text = "Temizle";
            this.BTN_Temizle.UseVisualStyleBackColor = true;
            this.BTN_Temizle.Click += new System.EventHandler(this.BTN_Temizle_Click);
            // 
            // BTN_Kaydet
            // 
            this.BTN_Kaydet.Location = new System.Drawing.Point(195, 265);
            this.BTN_Kaydet.Name = "BTN_Kaydet";
            this.BTN_Kaydet.Size = new System.Drawing.Size(90, 30);
            this.BTN_Kaydet.TabIndex = 14;
            this.BTN_Kaydet.Text = "Kaydet";
            this.BTN_Kaydet.UseVisualStyleBackColor = true;
            this.BTN_Kaydet.Click += new System.EventHandler(this.BTN_Kaydet_Click);
            // 
            // LBL_KayitliOgrenciler
            // 
            this.LBL_KayitliOgrenciler.AutoSize = true;
            this.LBL_KayitliOgrenciler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_KayitliOgrenciler.Location = new System.Drawing.Point(346, 76);
            this.LBL_KayitliOgrenciler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_KayitliOgrenciler.Name = "LBL_KayitliOgrenciler";
            this.LBL_KayitliOgrenciler.Size = new System.Drawing.Size(151, 24);
            this.LBL_KayitliOgrenciler.TabIndex = 15;
            this.LBL_KayitliOgrenciler.Text = "Kayıtlı Öğrenciler";
            // 
            // LB_KayitliOgrenciler
            // 
            this.LB_KayitliOgrenciler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LB_KayitliOgrenciler.FormattingEnabled = true;
            this.LB_KayitliOgrenciler.ItemHeight = 20;
            this.LB_KayitliOgrenciler.Location = new System.Drawing.Point(350, 117);
            this.LB_KayitliOgrenciler.Name = "LB_KayitliOgrenciler";
            this.LB_KayitliOgrenciler.Size = new System.Drawing.Size(289, 142);
            this.LB_KayitliOgrenciler.TabIndex = 16;
            // 
            // BTN_Sil
            // 
            this.BTN_Sil.Location = new System.Drawing.Point(549, 265);
            this.BTN_Sil.Name = "BTN_Sil";
            this.BTN_Sil.Size = new System.Drawing.Size(90, 30);
            this.BTN_Sil.TabIndex = 18;
            this.BTN_Sil.Text = "Sil";
            this.BTN_Sil.UseVisualStyleBackColor = true;
            this.BTN_Sil.Click += new System.EventHandler(this.BTN_Sil_Click);
            // 
            // BTN_Getir
            // 
            this.BTN_Getir.Location = new System.Drawing.Point(350, 265);
            this.BTN_Getir.Name = "BTN_Getir";
            this.BTN_Getir.Size = new System.Drawing.Size(90, 30);
            this.BTN_Getir.TabIndex = 17;
            this.BTN_Getir.Text = "Getir";
            this.BTN_Getir.UseVisualStyleBackColor = true;
            this.BTN_Getir.Click += new System.EventHandler(this.BTN_Getir_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 304);
            this.Controls.Add(this.BTN_Sil);
            this.Controls.Add(this.BTN_Getir);
            this.Controls.Add(this.LB_KayitliOgrenciler);
            this.Controls.Add(this.LBL_KayitliOgrenciler);
            this.Controls.Add(this.BTN_Kaydet);
            this.Controls.Add(this.BTN_Temizle);
            this.Controls.Add(this.LBL_OgrenciKayıtSistemi);
            this.Controls.Add(this.TB_Sinif);
            this.Controls.Add(this.LBL_Sinif);
            this.Controls.Add(this.TB_Okul);
            this.Controls.Add(this.LBL_Okul);
            this.Controls.Add(this.TB_Adres);
            this.Controls.Add(this.LBL_Adres);
            this.Controls.Add(this.TB_TC);
            this.Controls.Add(this.LBL_TC);
            this.Controls.Add(this.TB_SoyIsim);
            this.Controls.Add(this.LBL_SoyIsim);
            this.Controls.Add(this.TB_Isim);
            this.Controls.Add(this.LBL_Isim);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Kayıt Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Isim;
        private System.Windows.Forms.TextBox TB_Isim;
        private System.Windows.Forms.TextBox TB_SoyIsim;
        private System.Windows.Forms.Label LBL_SoyIsim;
        private System.Windows.Forms.TextBox TB_TC;
        private System.Windows.Forms.Label LBL_TC;
        private System.Windows.Forms.TextBox TB_Adres;
        private System.Windows.Forms.Label LBL_Adres;
        private System.Windows.Forms.TextBox TB_Okul;
        private System.Windows.Forms.Label LBL_Okul;
        private System.Windows.Forms.TextBox TB_Sinif;
        private System.Windows.Forms.Label LBL_Sinif;
        private System.Windows.Forms.Label LBL_OgrenciKayıtSistemi;
        private System.Windows.Forms.Button BTN_Temizle;
        private System.Windows.Forms.Button BTN_Kaydet;
        private System.Windows.Forms.Label LBL_KayitliOgrenciler;
        private System.Windows.Forms.ListBox LB_KayitliOgrenciler;
        private System.Windows.Forms.Button BTN_Sil;
        private System.Windows.Forms.Button BTN_Getir;
    }
}


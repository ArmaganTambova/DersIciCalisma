namespace WinFormsKontrolleri
{
    partial class TextBoxKontroluOdev
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
            this.TB_Okul = new System.Windows.Forms.TextBox();
            this.LBL_Okul = new System.Windows.Forms.Label();
            this.TB_Adres = new System.Windows.Forms.TextBox();
            this.LBL_Adres = new System.Windows.Forms.Label();
            this.BTN_Gonder = new System.Windows.Forms.Button();
            this.GB_Bilgi = new System.Windows.Forms.GroupBox();
            this.LBL_Bilgi = new System.Windows.Forms.Label();
            this.MTB_Iban = new System.Windows.Forms.MaskedTextBox();
            this.LBL_Iban = new System.Windows.Forms.Label();
            this.MTB_Telefon = new System.Windows.Forms.MaskedTextBox();
            this.LBL_Telefon = new System.Windows.Forms.Label();
            this.TB_Soyisim = new System.Windows.Forms.TextBox();
            this.LBL_Soyisim = new System.Windows.Forms.Label();
            this.TB_Isim = new System.Windows.Forms.TextBox();
            this.LBL_Isim = new System.Windows.Forms.Label();
            this.LBL_Bolum = new System.Windows.Forms.Label();
            this.TB_Bolum = new System.Windows.Forms.TextBox();
            this.LBL_Sinif = new System.Windows.Forms.Label();
            this.CB_Sinif = new System.Windows.Forms.ComboBox();
            this.CB_Sube = new System.Windows.Forms.ComboBox();
            this.GB_Bilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_Okul
            // 
            this.TB_Okul.Location = new System.Drawing.Point(93, 222);
            this.TB_Okul.Name = "TB_Okul";
            this.TB_Okul.Size = new System.Drawing.Size(261, 20);
            this.TB_Okul.TabIndex = 28;
            // 
            // LBL_Okul
            // 
            this.LBL_Okul.AutoSize = true;
            this.LBL_Okul.Font = new System.Drawing.Font("SoDo Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Okul.Location = new System.Drawing.Point(12, 222);
            this.LBL_Okul.Name = "LBL_Okul";
            this.LBL_Okul.Size = new System.Drawing.Size(50, 20);
            this.LBL_Okul.TabIndex = 26;
            this.LBL_Okul.Text = "Okul:";
            // 
            // TB_Adres
            // 
            this.TB_Adres.Location = new System.Drawing.Point(93, 116);
            this.TB_Adres.Multiline = true;
            this.TB_Adres.Name = "TB_Adres";
            this.TB_Adres.Size = new System.Drawing.Size(261, 100);
            this.TB_Adres.TabIndex = 25;
            // 
            // LBL_Adres
            // 
            this.LBL_Adres.AutoSize = true;
            this.LBL_Adres.Font = new System.Drawing.Font("SoDo Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Adres.Location = new System.Drawing.Point(12, 116);
            this.LBL_Adres.Name = "LBL_Adres";
            this.LBL_Adres.Size = new System.Drawing.Size(58, 20);
            this.LBL_Adres.TabIndex = 24;
            this.LBL_Adres.Text = "Adres:";
            // 
            // BTN_Gonder
            // 
            this.BTN_Gonder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BTN_Gonder.Location = new System.Drawing.Point(369, 222);
            this.BTN_Gonder.Name = "BTN_Gonder";
            this.BTN_Gonder.Size = new System.Drawing.Size(218, 20);
            this.BTN_Gonder.TabIndex = 23;
            this.BTN_Gonder.Text = "Gönder";
            this.BTN_Gonder.UseVisualStyleBackColor = false;
            this.BTN_Gonder.Click += new System.EventHandler(this.BTN_Gonder_Click);
            // 
            // GB_Bilgi
            // 
            this.GB_Bilgi.Controls.Add(this.LBL_Bilgi);
            this.GB_Bilgi.Location = new System.Drawing.Point(369, 12);
            this.GB_Bilgi.Name = "GB_Bilgi";
            this.GB_Bilgi.Size = new System.Drawing.Size(218, 204);
            this.GB_Bilgi.TabIndex = 22;
            this.GB_Bilgi.TabStop = false;
            this.GB_Bilgi.Text = "Öğrenci Bilgileri:";
            // 
            // LBL_Bilgi
            // 
            this.LBL_Bilgi.AutoSize = true;
            this.LBL_Bilgi.Location = new System.Drawing.Point(6, 16);
            this.LBL_Bilgi.Name = "LBL_Bilgi";
            this.LBL_Bilgi.Size = new System.Drawing.Size(0, 13);
            this.LBL_Bilgi.TabIndex = 0;
            // 
            // MTB_Iban
            // 
            this.MTB_Iban.Location = new System.Drawing.Point(168, 90);
            this.MTB_Iban.Mask = "TR99-99999-999999-999999-9999-99";
            this.MTB_Iban.Name = "MTB_Iban";
            this.MTB_Iban.Size = new System.Drawing.Size(186, 20);
            this.MTB_Iban.TabIndex = 21;
            // 
            // LBL_Iban
            // 
            this.LBL_Iban.AutoSize = true;
            this.LBL_Iban.Font = new System.Drawing.Font("SoDo Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Iban.Location = new System.Drawing.Point(12, 90);
            this.LBL_Iban.Name = "LBL_Iban";
            this.LBL_Iban.Size = new System.Drawing.Size(47, 20);
            this.LBL_Iban.TabIndex = 20;
            this.LBL_Iban.Text = "İban:";
            // 
            // MTB_Telefon
            // 
            this.MTB_Telefon.Location = new System.Drawing.Point(168, 64);
            this.MTB_Telefon.Mask = "(999) 000-0000";
            this.MTB_Telefon.Name = "MTB_Telefon";
            this.MTB_Telefon.Size = new System.Drawing.Size(186, 20);
            this.MTB_Telefon.TabIndex = 19;
            // 
            // LBL_Telefon
            // 
            this.LBL_Telefon.AutoSize = true;
            this.LBL_Telefon.Font = new System.Drawing.Font("SoDo Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Telefon.Location = new System.Drawing.Point(12, 64);
            this.LBL_Telefon.Name = "LBL_Telefon";
            this.LBL_Telefon.Size = new System.Drawing.Size(150, 20);
            this.LBL_Telefon.TabIndex = 18;
            this.LBL_Telefon.Text = "Telefon Numarası:";
            // 
            // TB_Soyisim
            // 
            this.TB_Soyisim.Location = new System.Drawing.Point(93, 38);
            this.TB_Soyisim.Name = "TB_Soyisim";
            this.TB_Soyisim.Size = new System.Drawing.Size(261, 20);
            this.TB_Soyisim.TabIndex = 17;
            // 
            // LBL_Soyisim
            // 
            this.LBL_Soyisim.AutoSize = true;
            this.LBL_Soyisim.Font = new System.Drawing.Font("SoDo Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Soyisim.Location = new System.Drawing.Point(12, 38);
            this.LBL_Soyisim.Name = "LBL_Soyisim";
            this.LBL_Soyisim.Size = new System.Drawing.Size(75, 20);
            this.LBL_Soyisim.TabIndex = 16;
            this.LBL_Soyisim.Text = "Soyisim:";
            // 
            // TB_Isim
            // 
            this.TB_Isim.Location = new System.Drawing.Point(93, 12);
            this.TB_Isim.Name = "TB_Isim";
            this.TB_Isim.Size = new System.Drawing.Size(261, 20);
            this.TB_Isim.TabIndex = 15;
            // 
            // LBL_Isim
            // 
            this.LBL_Isim.AutoSize = true;
            this.LBL_Isim.Font = new System.Drawing.Font("SoDo Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Isim.Location = new System.Drawing.Point(12, 12);
            this.LBL_Isim.Name = "LBL_Isim";
            this.LBL_Isim.Size = new System.Drawing.Size(47, 20);
            this.LBL_Isim.TabIndex = 14;
            this.LBL_Isim.Text = "İsim:";
            // 
            // LBL_Bolum
            // 
            this.LBL_Bolum.AutoSize = true;
            this.LBL_Bolum.Font = new System.Drawing.Font("SoDo Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Bolum.Location = new System.Drawing.Point(12, 248);
            this.LBL_Bolum.Name = "LBL_Bolum";
            this.LBL_Bolum.Size = new System.Drawing.Size(64, 20);
            this.LBL_Bolum.TabIndex = 26;
            this.LBL_Bolum.Text = "Bölüm:";
            // 
            // TB_Bolum
            // 
            this.TB_Bolum.Location = new System.Drawing.Point(93, 248);
            this.TB_Bolum.Name = "TB_Bolum";
            this.TB_Bolum.Size = new System.Drawing.Size(261, 20);
            this.TB_Bolum.TabIndex = 28;
            // 
            // LBL_Sinif
            // 
            this.LBL_Sinif.AutoSize = true;
            this.LBL_Sinif.Font = new System.Drawing.Font("SoDo Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Sinif.Location = new System.Drawing.Point(12, 275);
            this.LBL_Sinif.Name = "LBL_Sinif";
            this.LBL_Sinif.Size = new System.Drawing.Size(48, 20);
            this.LBL_Sinif.TabIndex = 29;
            this.LBL_Sinif.Text = "Sınıf:";
            // 
            // CB_Sinif
            // 
            this.CB_Sinif.FormattingEnabled = true;
            this.CB_Sinif.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.CB_Sinif.Location = new System.Drawing.Point(93, 275);
            this.CB_Sinif.Name = "CB_Sinif";
            this.CB_Sinif.Size = new System.Drawing.Size(120, 21);
            this.CB_Sinif.TabIndex = 30;
            // 
            // CB_Sube
            // 
            this.CB_Sube.FormattingEnabled = true;
            this.CB_Sube.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "Ç",
            "D",
            "E",
            "F",
            "G",
            "Ğ",
            "H",
            "İ",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "Ö",
            "P",
            "R",
            "S",
            "Ş",
            "T",
            "U",
            "Ü",
            "V",
            "Y",
            "Z"});
            this.CB_Sube.Location = new System.Drawing.Point(234, 274);
            this.CB_Sube.Name = "CB_Sube";
            this.CB_Sube.Size = new System.Drawing.Size(120, 21);
            this.CB_Sube.TabIndex = 31;
            // 
            // TextBoxKontroluOdev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CB_Sube);
            this.Controls.Add(this.CB_Sinif);
            this.Controls.Add(this.LBL_Sinif);
            this.Controls.Add(this.TB_Bolum);
            this.Controls.Add(this.LBL_Bolum);
            this.Controls.Add(this.TB_Okul);
            this.Controls.Add(this.LBL_Okul);
            this.Controls.Add(this.TB_Adres);
            this.Controls.Add(this.LBL_Adres);
            this.Controls.Add(this.BTN_Gonder);
            this.Controls.Add(this.GB_Bilgi);
            this.Controls.Add(this.MTB_Iban);
            this.Controls.Add(this.LBL_Iban);
            this.Controls.Add(this.MTB_Telefon);
            this.Controls.Add(this.LBL_Telefon);
            this.Controls.Add(this.TB_Soyisim);
            this.Controls.Add(this.LBL_Soyisim);
            this.Controls.Add(this.TB_Isim);
            this.Controls.Add(this.LBL_Isim);
            this.Name = "TextBoxKontroluOdev";
            this.Text = "TextBox Kontrolü Ödev";
            this.GB_Bilgi.ResumeLayout(false);
            this.GB_Bilgi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TB_Okul;
        private System.Windows.Forms.Label LBL_Okul;
        private System.Windows.Forms.TextBox TB_Adres;
        private System.Windows.Forms.Label LBL_Adres;
        private System.Windows.Forms.Button BTN_Gonder;
        private System.Windows.Forms.GroupBox GB_Bilgi;
        private System.Windows.Forms.Label LBL_Bilgi;
        private System.Windows.Forms.MaskedTextBox MTB_Iban;
        private System.Windows.Forms.Label LBL_Iban;
        private System.Windows.Forms.MaskedTextBox MTB_Telefon;
        private System.Windows.Forms.Label LBL_Telefon;
        private System.Windows.Forms.TextBox TB_Soyisim;
        private System.Windows.Forms.Label LBL_Soyisim;
        private System.Windows.Forms.TextBox TB_Isim;
        private System.Windows.Forms.Label LBL_Isim;
        private System.Windows.Forms.Label LBL_Bolum;
        private System.Windows.Forms.TextBox TB_Bolum;
        private System.Windows.Forms.Label LBL_Sinif;
        private System.Windows.Forms.ComboBox CB_Sinif;
        private System.Windows.Forms.ComboBox CB_Sube;
    }
}


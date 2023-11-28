namespace WinFormsKontrolleri
{
    partial class TextBoxKontrolu
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
            this.LBL_Soyisim = new System.Windows.Forms.Label();
            this.TB_Soyisim = new System.Windows.Forms.TextBox();
            this.LBL_Telefon = new System.Windows.Forms.Label();
            this.MTB_Telefon = new System.Windows.Forms.MaskedTextBox();
            this.MTB_Iban = new System.Windows.Forms.MaskedTextBox();
            this.LBL_Iban = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBL_Bilgi = new System.Windows.Forms.Label();
            this.BTN_Gonder = new System.Windows.Forms.Button();
            this.LBL_Adres = new System.Windows.Forms.Label();
            this.TB_Adres = new System.Windows.Forms.TextBox();
            this.LBL_Okul = new System.Windows.Forms.Label();
            this.TB_Okul = new System.Windows.Forms.TextBox();
            this.TB_Okul1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_Isim
            // 
            this.LBL_Isim.AutoSize = true;
            this.LBL_Isim.Font = new System.Drawing.Font("SoDo Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Isim.Location = new System.Drawing.Point(12, 70);
            this.LBL_Isim.Name = "LBL_Isim";
            this.LBL_Isim.Size = new System.Drawing.Size(47, 20);
            this.LBL_Isim.TabIndex = 0;
            this.LBL_Isim.Text = "İsim:";
            // 
            // TB_Isim
            // 
            this.TB_Isim.Location = new System.Drawing.Point(93, 70);
            this.TB_Isim.Name = "TB_Isim";
            this.TB_Isim.Size = new System.Drawing.Size(261, 20);
            this.TB_Isim.TabIndex = 1;
            // 
            // LBL_Soyisim
            // 
            this.LBL_Soyisim.AutoSize = true;
            this.LBL_Soyisim.Font = new System.Drawing.Font("SoDo Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Soyisim.Location = new System.Drawing.Point(12, 96);
            this.LBL_Soyisim.Name = "LBL_Soyisim";
            this.LBL_Soyisim.Size = new System.Drawing.Size(75, 20);
            this.LBL_Soyisim.TabIndex = 2;
            this.LBL_Soyisim.Text = "Soyisim:";
            // 
            // TB_Soyisim
            // 
            this.TB_Soyisim.Location = new System.Drawing.Point(93, 96);
            this.TB_Soyisim.Name = "TB_Soyisim";
            this.TB_Soyisim.Size = new System.Drawing.Size(261, 20);
            this.TB_Soyisim.TabIndex = 3;
            // 
            // LBL_Telefon
            // 
            this.LBL_Telefon.AutoSize = true;
            this.LBL_Telefon.Font = new System.Drawing.Font("SoDo Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Telefon.Location = new System.Drawing.Point(12, 122);
            this.LBL_Telefon.Name = "LBL_Telefon";
            this.LBL_Telefon.Size = new System.Drawing.Size(150, 20);
            this.LBL_Telefon.TabIndex = 4;
            this.LBL_Telefon.Text = "Telefon Numarası:";
            // 
            // MTB_Telefon
            // 
            this.MTB_Telefon.Location = new System.Drawing.Point(168, 122);
            this.MTB_Telefon.Mask = "(999) 000-0000";
            this.MTB_Telefon.Name = "MTB_Telefon";
            this.MTB_Telefon.Size = new System.Drawing.Size(186, 20);
            this.MTB_Telefon.TabIndex = 5;
            // 
            // MTB_Iban
            // 
            this.MTB_Iban.Location = new System.Drawing.Point(168, 148);
            this.MTB_Iban.Mask = "TR99-99999-999999-999999-9999-99";
            this.MTB_Iban.Name = "MTB_Iban";
            this.MTB_Iban.Size = new System.Drawing.Size(186, 20);
            this.MTB_Iban.TabIndex = 7;
            // 
            // LBL_Iban
            // 
            this.LBL_Iban.AutoSize = true;
            this.LBL_Iban.Font = new System.Drawing.Font("SoDo Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Iban.Location = new System.Drawing.Point(12, 148);
            this.LBL_Iban.Name = "LBL_Iban";
            this.LBL_Iban.Size = new System.Drawing.Size(47, 20);
            this.LBL_Iban.TabIndex = 6;
            this.LBL_Iban.Text = "İban:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LBL_Bilgi);
            this.groupBox1.Location = new System.Drawing.Point(360, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 150);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri:";
            // 
            // LBL_Bilgi
            // 
            this.LBL_Bilgi.AutoSize = true;
            this.LBL_Bilgi.Location = new System.Drawing.Point(6, 16);
            this.LBL_Bilgi.Name = "LBL_Bilgi";
            this.LBL_Bilgi.Size = new System.Drawing.Size(0, 13);
            this.LBL_Bilgi.TabIndex = 0;
            // 
            // BTN_Gonder
            // 
            this.BTN_Gonder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BTN_Gonder.Location = new System.Drawing.Point(360, 174);
            this.BTN_Gonder.Name = "BTN_Gonder";
            this.BTN_Gonder.Size = new System.Drawing.Size(218, 20);
            this.BTN_Gonder.TabIndex = 9;
            this.BTN_Gonder.Text = "Gönder";
            this.BTN_Gonder.UseVisualStyleBackColor = false;
            this.BTN_Gonder.Click += new System.EventHandler(this.BTN_Gonder_Click);
            // 
            // LBL_Adres
            // 
            this.LBL_Adres.AutoSize = true;
            this.LBL_Adres.Font = new System.Drawing.Font("SoDo Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Adres.Location = new System.Drawing.Point(12, 174);
            this.LBL_Adres.Name = "LBL_Adres";
            this.LBL_Adres.Size = new System.Drawing.Size(58, 20);
            this.LBL_Adres.TabIndex = 10;
            this.LBL_Adres.Text = "Adres:";
            // 
            // TB_Adres
            // 
            this.TB_Adres.Location = new System.Drawing.Point(93, 174);
            this.TB_Adres.Multiline = true;
            this.TB_Adres.Name = "TB_Adres";
            this.TB_Adres.Size = new System.Drawing.Size(261, 100);
            this.TB_Adres.TabIndex = 11;
            // 
            // LBL_Okul
            // 
            this.LBL_Okul.AutoSize = true;
            this.LBL_Okul.Font = new System.Drawing.Font("SoDo Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Okul.Location = new System.Drawing.Point(12, 280);
            this.LBL_Okul.Name = "LBL_Okul";
            this.LBL_Okul.Size = new System.Drawing.Size(50, 20);
            this.LBL_Okul.TabIndex = 12;
            this.LBL_Okul.Text = "Okul:";
            // 
            // TB_Okul
            // 
            this.TB_Okul.Location = new System.Drawing.Point(93, 280);
            this.TB_Okul.Name = "TB_Okul";
            this.TB_Okul.ReadOnly = true;
            this.TB_Okul.Size = new System.Drawing.Size(261, 20);
            this.TB_Okul.TabIndex = 13;
            this.TB_Okul.Text = "Matrix Yazılım Anadolu Lisesi";
            // 
            // TB_Okul1
            // 
            this.TB_Okul1.Enabled = false;
            this.TB_Okul1.Location = new System.Drawing.Point(93, 306);
            this.TB_Okul1.Name = "TB_Okul1";
            this.TB_Okul1.Size = new System.Drawing.Size(261, 20);
            this.TB_Okul1.TabIndex = 13;
            this.TB_Okul1.Text = "Matrix Yazılım Anadolu Lisesi";
            // 
            // TextBoxKontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(590, 344);
            this.Controls.Add(this.TB_Okul1);
            this.Controls.Add(this.TB_Okul);
            this.Controls.Add(this.LBL_Okul);
            this.Controls.Add(this.TB_Adres);
            this.Controls.Add(this.LBL_Adres);
            this.Controls.Add(this.BTN_Gonder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MTB_Iban);
            this.Controls.Add(this.LBL_Iban);
            this.Controls.Add(this.MTB_Telefon);
            this.Controls.Add(this.LBL_Telefon);
            this.Controls.Add(this.TB_Soyisim);
            this.Controls.Add(this.LBL_Soyisim);
            this.Controls.Add(this.TB_Isim);
            this.Controls.Add(this.LBL_Isim);
            this.Name = "TextBoxKontrolu";
            this.Text = "TextBox Kontrolü";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Isim;
        private System.Windows.Forms.TextBox TB_Isim;
        private System.Windows.Forms.Label LBL_Soyisim;
        private System.Windows.Forms.TextBox TB_Soyisim;
        private System.Windows.Forms.Label LBL_Telefon;
        private System.Windows.Forms.MaskedTextBox MTB_Telefon;
        private System.Windows.Forms.MaskedTextBox MTB_Iban;
        private System.Windows.Forms.Label LBL_Iban;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LBL_Bilgi;
        private System.Windows.Forms.Button BTN_Gonder;
        private System.Windows.Forms.Label LBL_Adres;
        private System.Windows.Forms.TextBox TB_Adres;
        private System.Windows.Forms.Label LBL_Okul;
        private System.Windows.Forms.TextBox TB_Okul;
        private System.Windows.Forms.TextBox TB_Okul1;
    }
}
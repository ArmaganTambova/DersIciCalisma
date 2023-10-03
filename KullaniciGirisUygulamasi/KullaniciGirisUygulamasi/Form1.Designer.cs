namespace KullaniciGirisUygulamasi
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.TB_Sifre = new System.Windows.Forms.TextBox();
            this.BT_Giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // TB_KullaniciAdi
            // 
            this.TB_KullaniciAdi.Location = new System.Drawing.Point(82, 4);
            this.TB_KullaniciAdi.Name = "TB_KullaniciAdi";
            this.TB_KullaniciAdi.Size = new System.Drawing.Size(160, 20);
            this.TB_KullaniciAdi.TabIndex = 3;
            // 
            // TB_Sifre
            // 
            this.TB_Sifre.Location = new System.Drawing.Point(82, 32);
            this.TB_Sifre.Name = "TB_Sifre";
            this.TB_Sifre.Size = new System.Drawing.Size(160, 20);
            this.TB_Sifre.TabIndex = 4;
            this.TB_Sifre.UseSystemPasswordChar = true;
            // 
            // BT_Giris
            // 
            this.BT_Giris.Location = new System.Drawing.Point(250, 32);
            this.BT_Giris.Name = "BT_Giris";
            this.BT_Giris.Size = new System.Drawing.Size(75, 20);
            this.BT_Giris.TabIndex = 5;
            this.BT_Giris.Text = "Giriş";
            this.BT_Giris.UseVisualStyleBackColor = true;
            this.BT_Giris.Click += new System.EventHandler(this.BT_Giris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(369, 85);
            this.Controls.Add(this.BT_Giris);
            this.Controls.Add(this.TB_Sifre);
            this.Controls.Add(this.TB_KullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kullanıcı Giriş Uygulaması";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_KullaniciAdi;
        private System.Windows.Forms.TextBox TB_Sifre;
        private System.Windows.Forms.Button BT_Giris;
    }
}


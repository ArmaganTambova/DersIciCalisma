namespace KullaniciGirisi
{
    partial class Giris
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
            this.LBL_KullaniciAdi = new System.Windows.Forms.Label();
            this.TB_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.TB_Sifre = new System.Windows.Forms.TextBox();
            this.LBL_Sifre = new System.Windows.Forms.Label();
            this.BTN_Giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_KullaniciAdi
            // 
            this.LBL_KullaniciAdi.AutoSize = true;
            this.LBL_KullaniciAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_KullaniciAdi.Location = new System.Drawing.Point(15, 17);
            this.LBL_KullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_KullaniciAdi.Name = "LBL_KullaniciAdi";
            this.LBL_KullaniciAdi.Size = new System.Drawing.Size(84, 17);
            this.LBL_KullaniciAdi.TabIndex = 0;
            this.LBL_KullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // TB_KullaniciAdi
            // 
            this.TB_KullaniciAdi.Location = new System.Drawing.Point(18, 38);
            this.TB_KullaniciAdi.Name = "TB_KullaniciAdi";
            this.TB_KullaniciAdi.Size = new System.Drawing.Size(258, 25);
            this.TB_KullaniciAdi.TabIndex = 1;
            // 
            // TB_Sifre
            // 
            this.TB_Sifre.Location = new System.Drawing.Point(18, 87);
            this.TB_Sifre.Name = "TB_Sifre";
            this.TB_Sifre.Size = new System.Drawing.Size(258, 25);
            this.TB_Sifre.TabIndex = 3;
            // 
            // LBL_Sifre
            // 
            this.LBL_Sifre.AutoSize = true;
            this.LBL_Sifre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_Sifre.Location = new System.Drawing.Point(15, 66);
            this.LBL_Sifre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Sifre.Name = "LBL_Sifre";
            this.LBL_Sifre.Size = new System.Drawing.Size(37, 17);
            this.LBL_Sifre.TabIndex = 2;
            this.LBL_Sifre.Text = "Şifre:";
            // 
            // BTN_Giris
            // 
            this.BTN_Giris.Location = new System.Drawing.Point(200, 119);
            this.BTN_Giris.Name = "BTN_Giris";
            this.BTN_Giris.Size = new System.Drawing.Size(75, 23);
            this.BTN_Giris.TabIndex = 4;
            this.BTN_Giris.Text = "Giriş";
            this.BTN_Giris.UseVisualStyleBackColor = true;
            this.BTN_Giris.Click += new System.EventHandler(this.Login_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 152);
            this.Controls.Add(this.BTN_Giris);
            this.Controls.Add(this.TB_Sifre);
            this.Controls.Add(this.LBL_Sifre);
            this.Controls.Add(this.TB_KullaniciAdi);
            this.Controls.Add(this.LBL_KullaniciAdi);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Giris";
            this.Text = "Giriş";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Giris_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Giris_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_KullaniciAdi;
        private System.Windows.Forms.TextBox TB_KullaniciAdi;
        private System.Windows.Forms.TextBox TB_Sifre;
        private System.Windows.Forms.Label LBL_Sifre;
        private System.Windows.Forms.Button BTN_Giris;
    }
}


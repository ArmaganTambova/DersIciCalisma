namespace OdevMiniHesapMakinesi
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
            this.LBL_Sayi1 = new System.Windows.Forms.Label();
            this.LBL_Sayi2 = new System.Windows.Forms.Label();
            this.TB_Sayi1 = new System.Windows.Forms.TextBox();
            this.TB_Sayi2 = new System.Windows.Forms.TextBox();
            this.BTN_Carpma = new System.Windows.Forms.Button();
            this.TB_Sonuc = new System.Windows.Forms.TextBox();
            this.LBL_Sonuc = new System.Windows.Forms.Label();
            this.BTN_Cikarma = new System.Windows.Forms.Button();
            this.BTN_Toplam = new System.Windows.Forms.Button();
            this.BTN_Bolme = new System.Windows.Forms.Button();
            this.BTN_ModAlma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_Sayi1
            // 
            this.LBL_Sayi1.AutoSize = true;
            this.LBL_Sayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_Sayi1.Location = new System.Drawing.Point(12, 10);
            this.LBL_Sayi1.Name = "LBL_Sayi1";
            this.LBL_Sayi1.Size = new System.Drawing.Size(47, 16);
            this.LBL_Sayi1.TabIndex = 0;
            this.LBL_Sayi1.Text = "Sayı 1:";
            // 
            // LBL_Sayi2
            // 
            this.LBL_Sayi2.AutoSize = true;
            this.LBL_Sayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_Sayi2.Location = new System.Drawing.Point(12, 45);
            this.LBL_Sayi2.Name = "LBL_Sayi2";
            this.LBL_Sayi2.Size = new System.Drawing.Size(47, 16);
            this.LBL_Sayi2.TabIndex = 1;
            this.LBL_Sayi2.Text = "Sayı 2:";
            // 
            // TB_Sayi1
            // 
            this.TB_Sayi1.Location = new System.Drawing.Point(65, 10);
            this.TB_Sayi1.Name = "TB_Sayi1";
            this.TB_Sayi1.Size = new System.Drawing.Size(299, 20);
            this.TB_Sayi1.TabIndex = 2;
            // 
            // TB_Sayi2
            // 
            this.TB_Sayi2.Location = new System.Drawing.Point(65, 45);
            this.TB_Sayi2.Name = "TB_Sayi2";
            this.TB_Sayi2.Size = new System.Drawing.Size(299, 20);
            this.TB_Sayi2.TabIndex = 3;
            // 
            // BTN_Carpma
            // 
            this.BTN_Carpma.Location = new System.Drawing.Point(157, 71);
            this.BTN_Carpma.Name = "BTN_Carpma";
            this.BTN_Carpma.Size = new System.Drawing.Size(65, 20);
            this.BTN_Carpma.TabIndex = 4;
            this.BTN_Carpma.Text = "Çarpma";
            this.BTN_Carpma.UseVisualStyleBackColor = true;
            this.BTN_Carpma.Click += new System.EventHandler(this.BTN_Carpma_Click);
            // 
            // TB_Sonuc
            // 
            this.TB_Sonuc.Location = new System.Drawing.Point(65, 98);
            this.TB_Sonuc.Name = "TB_Sonuc";
            this.TB_Sonuc.Size = new System.Drawing.Size(299, 20);
            this.TB_Sonuc.TabIndex = 5;
            // 
            // LBL_Sonuc
            // 
            this.LBL_Sonuc.AutoSize = true;
            this.LBL_Sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_Sonuc.Location = new System.Drawing.Point(12, 98);
            this.LBL_Sonuc.Name = "LBL_Sonuc";
            this.LBL_Sonuc.Size = new System.Drawing.Size(48, 16);
            this.LBL_Sonuc.TabIndex = 6;
            this.LBL_Sonuc.Text = "Sonuç:";
            // 
            // BTN_Cikarma
            // 
            this.BTN_Cikarma.Location = new System.Drawing.Point(86, 71);
            this.BTN_Cikarma.Name = "BTN_Cikarma";
            this.BTN_Cikarma.Size = new System.Drawing.Size(65, 20);
            this.BTN_Cikarma.TabIndex = 7;
            this.BTN_Cikarma.Text = "Çıkarma";
            this.BTN_Cikarma.UseVisualStyleBackColor = true;
            this.BTN_Cikarma.Click += new System.EventHandler(this.BTN_Cikarma_Click);
            // 
            // BTN_Toplam
            // 
            this.BTN_Toplam.Location = new System.Drawing.Point(15, 71);
            this.BTN_Toplam.Name = "BTN_Toplam";
            this.BTN_Toplam.Size = new System.Drawing.Size(65, 20);
            this.BTN_Toplam.TabIndex = 8;
            this.BTN_Toplam.Text = "Toplam";
            this.BTN_Toplam.UseVisualStyleBackColor = true;
            this.BTN_Toplam.Click += new System.EventHandler(this.BTN_Toplam_Click);
            // 
            // BTN_Bolme
            // 
            this.BTN_Bolme.Location = new System.Drawing.Point(228, 71);
            this.BTN_Bolme.Name = "BTN_Bolme";
            this.BTN_Bolme.Size = new System.Drawing.Size(65, 20);
            this.BTN_Bolme.TabIndex = 9;
            this.BTN_Bolme.Text = "Bölme";
            this.BTN_Bolme.UseVisualStyleBackColor = true;
            this.BTN_Bolme.Click += new System.EventHandler(this.BTN_Bolme_Click);
            // 
            // BTN_ModAlma
            // 
            this.BTN_ModAlma.Location = new System.Drawing.Point(299, 71);
            this.BTN_ModAlma.Name = "BTN_ModAlma";
            this.BTN_ModAlma.Size = new System.Drawing.Size(65, 20);
            this.BTN_ModAlma.TabIndex = 10;
            this.BTN_ModAlma.Text = "Mod Alma";
            this.BTN_ModAlma.UseVisualStyleBackColor = true;
            this.BTN_ModAlma.Click += new System.EventHandler(this.BTN_ModAlma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 136);
            this.Controls.Add(this.BTN_ModAlma);
            this.Controls.Add(this.BTN_Bolme);
            this.Controls.Add(this.BTN_Toplam);
            this.Controls.Add(this.BTN_Cikarma);
            this.Controls.Add(this.LBL_Sonuc);
            this.Controls.Add(this.TB_Sonuc);
            this.Controls.Add(this.BTN_Carpma);
            this.Controls.Add(this.TB_Sayi2);
            this.Controls.Add(this.TB_Sayi1);
            this.Controls.Add(this.LBL_Sayi2);
            this.Controls.Add(this.LBL_Sayi1);
            this.Name = "Form1";
            this.Text = "Mini Hesap Makinesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Sayi1;
        private System.Windows.Forms.Label LBL_Sayi2;
        private System.Windows.Forms.TextBox TB_Sayi1;
        private System.Windows.Forms.TextBox TB_Sayi2;
        private System.Windows.Forms.Button BTN_Carpma;
        private System.Windows.Forms.TextBox TB_Sonuc;
        private System.Windows.Forms.Label LBL_Sonuc;
        private System.Windows.Forms.Button BTN_Cikarma;
        private System.Windows.Forms.Button BTN_Toplam;
        private System.Windows.Forms.Button BTN_Bolme;
        private System.Windows.Forms.Button BTN_ModAlma;
    }
}


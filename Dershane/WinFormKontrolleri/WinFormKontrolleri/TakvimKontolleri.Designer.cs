namespace WinFormKontrolleri
{
    partial class TakvimKontolleri
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
            this.LBL_Tarih = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LBL_Gun = new System.Windows.Forms.Label();
            this.LBL_Ay = new System.Windows.Forms.Label();
            this.LBL_Yil = new System.Windows.Forms.Label();
            this.LBL_Saniye = new System.Windows.Forms.Label();
            this.LBL_Dakika = new System.Windows.Forms.Label();
            this.LBL_Saat = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LBL_UzunTarih = new System.Windows.Forms.Label();
            this.LBL_KisaTarih = new System.Windows.Forms.Label();
            this.DTP_Tarih = new System.Windows.Forms.DateTimePicker();
            this.BTN_Getir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DTP_2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DTP_3 = new System.Windows.Forms.DateTimePicker();
            this.BTN_Sec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_Tarih
            // 
            this.LBL_Tarih.AutoSize = true;
            this.LBL_Tarih.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_Tarih.Location = new System.Drawing.Point(12, 9);
            this.LBL_Tarih.Name = "LBL_Tarih";
            this.LBL_Tarih.Size = new System.Drawing.Size(57, 30);
            this.LBL_Tarih.TabIndex = 0;
            this.LBL_Tarih.Text = "Tarih";
            this.LBL_Tarih.Click += new System.EventHandler(this.LBL_Tarih_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yıl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gün";
            // 
            // LBL_Gun
            // 
            this.LBL_Gun.AutoSize = true;
            this.LBL_Gun.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_Gun.Location = new System.Drawing.Point(73, 150);
            this.LBL_Gun.Name = "LBL_Gun";
            this.LBL_Gun.Size = new System.Drawing.Size(31, 17);
            this.LBL_Gun.TabIndex = 6;
            this.LBL_Gun.Text = "Gün";
            // 
            // LBL_Ay
            // 
            this.LBL_Ay.AutoSize = true;
            this.LBL_Ay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_Ay.Location = new System.Drawing.Point(73, 133);
            this.LBL_Ay.Name = "LBL_Ay";
            this.LBL_Ay.Size = new System.Drawing.Size(22, 17);
            this.LBL_Ay.TabIndex = 5;
            this.LBL_Ay.Text = "Ay";
            // 
            // LBL_Yil
            // 
            this.LBL_Yil.AutoSize = true;
            this.LBL_Yil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_Yil.Location = new System.Drawing.Point(73, 116);
            this.LBL_Yil.Name = "LBL_Yil";
            this.LBL_Yil.Size = new System.Drawing.Size(21, 17);
            this.LBL_Yil.TabIndex = 4;
            this.LBL_Yil.Text = "Yıl";
            // 
            // LBL_Saniye
            // 
            this.LBL_Saniye.AutoSize = true;
            this.LBL_Saniye.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_Saniye.Location = new System.Drawing.Point(237, 150);
            this.LBL_Saniye.Name = "LBL_Saniye";
            this.LBL_Saniye.Size = new System.Drawing.Size(45, 17);
            this.LBL_Saniye.TabIndex = 12;
            this.LBL_Saniye.Text = "Saniye";
            // 
            // LBL_Dakika
            // 
            this.LBL_Dakika.AutoSize = true;
            this.LBL_Dakika.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_Dakika.Location = new System.Drawing.Point(237, 133);
            this.LBL_Dakika.Name = "LBL_Dakika";
            this.LBL_Dakika.Size = new System.Drawing.Size(46, 17);
            this.LBL_Dakika.TabIndex = 11;
            this.LBL_Dakika.Text = "Dakika";
            // 
            // LBL_Saat
            // 
            this.LBL_Saat.AutoSize = true;
            this.LBL_Saat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_Saat.Location = new System.Drawing.Point(237, 116);
            this.LBL_Saat.Name = "LBL_Saat";
            this.LBL_Saat.Size = new System.Drawing.Size(33, 17);
            this.LBL_Saat.TabIndex = 10;
            this.LBL_Saat.Text = "Saat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(176, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Saniye";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(176, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Dakika";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(176, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Saat";
            // 
            // LBL_UzunTarih
            // 
            this.LBL_UzunTarih.AutoSize = true;
            this.LBL_UzunTarih.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_UzunTarih.Location = new System.Drawing.Point(12, 39);
            this.LBL_UzunTarih.Name = "LBL_UzunTarih";
            this.LBL_UzunTarih.Size = new System.Drawing.Size(105, 30);
            this.LBL_UzunTarih.TabIndex = 13;
            this.LBL_UzunTarih.Text = "UzunTarih";
            // 
            // LBL_KisaTarih
            // 
            this.LBL_KisaTarih.AutoSize = true;
            this.LBL_KisaTarih.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_KisaTarih.Location = new System.Drawing.Point(12, 69);
            this.LBL_KisaTarih.Name = "LBL_KisaTarih";
            this.LBL_KisaTarih.Size = new System.Drawing.Size(94, 30);
            this.LBL_KisaTarih.TabIndex = 14;
            this.LBL_KisaTarih.Text = "KısaTarih";
            // 
            // DTP_Tarih
            // 
            this.DTP_Tarih.Location = new System.Drawing.Point(12, 220);
            this.DTP_Tarih.Name = "DTP_Tarih";
            this.DTP_Tarih.Size = new System.Drawing.Size(193, 20);
            this.DTP_Tarih.TabIndex = 15;
            // 
            // BTN_Getir
            // 
            this.BTN_Getir.Location = new System.Drawing.Point(211, 220);
            this.BTN_Getir.Name = "BTN_Getir";
            this.BTN_Getir.Size = new System.Drawing.Size(75, 20);
            this.BTN_Getir.TabIndex = 16;
            this.BTN_Getir.Text = "Getir";
            this.BTN_Getir.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(292, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Saniye";
            // 
            // DTP_2
            // 
            this.DTP_2.Location = new System.Drawing.Point(467, 25);
            this.DTP_2.Name = "DTP_2";
            this.DTP_2.Size = new System.Drawing.Size(200, 20);
            this.DTP_2.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Birinci Tarih";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(464, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "İkinci Tarih";
            // 
            // DTP_3
            // 
            this.DTP_3.Location = new System.Drawing.Point(467, 64);
            this.DTP_3.Name = "DTP_3";
            this.DTP_3.Size = new System.Drawing.Size(200, 20);
            this.DTP_3.TabIndex = 22;
            // 
            // BTN_Sec
            // 
            this.BTN_Sec.Location = new System.Drawing.Point(591, 91);
            this.BTN_Sec.Name = "BTN_Sec";
            this.BTN_Sec.Size = new System.Drawing.Size(75, 23);
            this.BTN_Sec.TabIndex = 24;
            this.BTN_Sec.Text = "Seç";
            this.BTN_Sec.UseVisualStyleBackColor = true;
            // 
            // TakvimKontolleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 528);
            this.Controls.Add(this.BTN_Sec);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DTP_3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DTP_2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTN_Getir);
            this.Controls.Add(this.DTP_Tarih);
            this.Controls.Add(this.LBL_KisaTarih);
            this.Controls.Add(this.LBL_UzunTarih);
            this.Controls.Add(this.LBL_Saniye);
            this.Controls.Add(this.LBL_Dakika);
            this.Controls.Add(this.LBL_Saat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LBL_Gun);
            this.Controls.Add(this.LBL_Ay);
            this.Controls.Add(this.LBL_Yil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBL_Tarih);
            this.Name = "TakvimKontolleri";
            this.Text = "TakvimKontolleri";
            this.Load += new System.EventHandler(this.TakvimKontolleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Tarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBL_Gun;
        private System.Windows.Forms.Label LBL_Ay;
        private System.Windows.Forms.Label LBL_Yil;
        private System.Windows.Forms.Label LBL_Saniye;
        private System.Windows.Forms.Label LBL_Dakika;
        private System.Windows.Forms.Label LBL_Saat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LBL_UzunTarih;
        private System.Windows.Forms.Label LBL_KisaTarih;
        private System.Windows.Forms.DateTimePicker DTP_Tarih;
        private System.Windows.Forms.Button BTN_Getir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DTP_2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DTP_3;
        private System.Windows.Forms.Button BTN_Sec;
    }
}
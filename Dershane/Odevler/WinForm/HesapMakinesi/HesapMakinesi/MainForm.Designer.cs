namespace HesapMakinesi
{
    partial class MainForm
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
            this.TB_Hesap = new System.Windows.Forms.TextBox();
            this.BTN_Backspace = new System.Windows.Forms.Button();
            this.BTN_C = new System.Windows.Forms.Button();
            this.BTN_7 = new System.Windows.Forms.Button();
            this.BTN_8 = new System.Windows.Forms.Button();
            this.BTN_9 = new System.Windows.Forms.Button();
            this.BTN_Bolme = new System.Windows.Forms.Button();
            this.BTN_sqrt = new System.Windows.Forms.Button();
            this.BTN_Yuzde = new System.Windows.Forms.Button();
            this.BTN_Carpma = new System.Windows.Forms.Button();
            this.BTN_6 = new System.Windows.Forms.Button();
            this.BTN_5 = new System.Windows.Forms.Button();
            this.BTN_4 = new System.Windows.Forms.Button();
            this.BTN_1slashX = new System.Windows.Forms.Button();
            this.BTN_Eksi = new System.Windows.Forms.Button();
            this.BTN_3 = new System.Windows.Forms.Button();
            this.BTN_2 = new System.Windows.Forms.Button();
            this.BTN_1 = new System.Windows.Forms.Button();
            this.BTN_Esittir = new System.Windows.Forms.Button();
            this.BTN_Arti = new System.Windows.Forms.Button();
            this.BTN_Nokta = new System.Windows.Forms.Button();
            this.BTN_ArtiSlashEksi = new System.Windows.Forms.Button();
            this.BTN_0 = new System.Windows.Forms.Button();
            this.BTN_MArti = new System.Windows.Forms.Button();
            this.BTN_MS = new System.Windows.Forms.Button();
            this.BTN_MR = new System.Windows.Forms.Button();
            this.BTN_MC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_Hesap
            // 
            this.TB_Hesap.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TB_Hesap.Location = new System.Drawing.Point(12, 12);
            this.TB_Hesap.Name = "TB_Hesap";
            this.TB_Hesap.Size = new System.Drawing.Size(526, 93);
            this.TB_Hesap.TabIndex = 0;
            this.TB_Hesap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TB_Hesap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Hesap_KeyPress);
            // 
            // BTN_Backspace
            // 
            this.BTN_Backspace.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_Backspace.Location = new System.Drawing.Point(232, 111);
            this.BTN_Backspace.Name = "BTN_Backspace";
            this.BTN_Backspace.Size = new System.Drawing.Size(150, 50);
            this.BTN_Backspace.TabIndex = 1;
            this.BTN_Backspace.Text = "Backspace";
            this.BTN_Backspace.UseVisualStyleBackColor = true;
            this.BTN_Backspace.Click += new System.EventHandler(this.BTN_Backspace_Click);
            // 
            // BTN_C
            // 
            this.BTN_C.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_C.Location = new System.Drawing.Point(388, 111);
            this.BTN_C.Name = "BTN_C";
            this.BTN_C.Size = new System.Drawing.Size(150, 50);
            this.BTN_C.TabIndex = 3;
            this.BTN_C.Text = "C";
            this.BTN_C.UseVisualStyleBackColor = true;
            this.BTN_C.Click += new System.EventHandler(this.BTN_C_Click);
            // 
            // BTN_7
            // 
            this.BTN_7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_7.Location = new System.Drawing.Point(76, 181);
            this.BTN_7.Name = "BTN_7";
            this.BTN_7.Size = new System.Drawing.Size(85, 50);
            this.BTN_7.TabIndex = 4;
            this.BTN_7.Text = "7";
            this.BTN_7.UseVisualStyleBackColor = true;
            this.BTN_7.Click += new System.EventHandler(this.BTN_DegerEkle);
            // 
            // BTN_8
            // 
            this.BTN_8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_8.Location = new System.Drawing.Point(167, 181);
            this.BTN_8.Name = "BTN_8";
            this.BTN_8.Size = new System.Drawing.Size(85, 50);
            this.BTN_8.TabIndex = 5;
            this.BTN_8.Text = "8";
            this.BTN_8.UseVisualStyleBackColor = true;
            this.BTN_8.Click += new System.EventHandler(this.BTN_DegerEkle);
            // 
            // BTN_9
            // 
            this.BTN_9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_9.Location = new System.Drawing.Point(258, 181);
            this.BTN_9.Name = "BTN_9";
            this.BTN_9.Size = new System.Drawing.Size(85, 50);
            this.BTN_9.TabIndex = 6;
            this.BTN_9.Text = "9";
            this.BTN_9.UseVisualStyleBackColor = true;
            this.BTN_9.Click += new System.EventHandler(this.BTN_DegerEkle);
            // 
            // BTN_Bolme
            // 
            this.BTN_Bolme.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_Bolme.Location = new System.Drawing.Point(349, 181);
            this.BTN_Bolme.Name = "BTN_Bolme";
            this.BTN_Bolme.Size = new System.Drawing.Size(85, 50);
            this.BTN_Bolme.TabIndex = 7;
            this.BTN_Bolme.Text = "/";
            this.BTN_Bolme.UseVisualStyleBackColor = true;
            this.BTN_Bolme.Click += new System.EventHandler(this.BTN_DegerEkle);
            // 
            // BTN_sqrt
            // 
            this.BTN_sqrt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_sqrt.Location = new System.Drawing.Point(440, 181);
            this.BTN_sqrt.Name = "BTN_sqrt";
            this.BTN_sqrt.Size = new System.Drawing.Size(98, 50);
            this.BTN_sqrt.TabIndex = 8;
            this.BTN_sqrt.Text = "sqrt";
            this.BTN_sqrt.UseVisualStyleBackColor = true;
            this.BTN_sqrt.Click += new System.EventHandler(this.BTN_DahaOlmadi);
            // 
            // BTN_Yuzde
            // 
            this.BTN_Yuzde.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_Yuzde.Location = new System.Drawing.Point(440, 237);
            this.BTN_Yuzde.Name = "BTN_Yuzde";
            this.BTN_Yuzde.Size = new System.Drawing.Size(98, 50);
            this.BTN_Yuzde.TabIndex = 13;
            this.BTN_Yuzde.Text = "%";
            this.BTN_Yuzde.UseVisualStyleBackColor = true;
            this.BTN_Yuzde.Click += new System.EventHandler(this.BTN_DahaOlmadi);
            // 
            // BTN_Carpma
            // 
            this.BTN_Carpma.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_Carpma.Location = new System.Drawing.Point(349, 237);
            this.BTN_Carpma.Name = "BTN_Carpma";
            this.BTN_Carpma.Size = new System.Drawing.Size(85, 50);
            this.BTN_Carpma.TabIndex = 12;
            this.BTN_Carpma.Text = "*";
            this.BTN_Carpma.UseVisualStyleBackColor = true;
            this.BTN_Carpma.Click += new System.EventHandler(this.BTN_DegerEkle);
            // 
            // BTN_6
            // 
            this.BTN_6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_6.Location = new System.Drawing.Point(258, 237);
            this.BTN_6.Name = "BTN_6";
            this.BTN_6.Size = new System.Drawing.Size(85, 50);
            this.BTN_6.TabIndex = 11;
            this.BTN_6.Text = "6";
            this.BTN_6.UseVisualStyleBackColor = true;
            this.BTN_6.Click += new System.EventHandler(this.BTN_DegerEkle);
            // 
            // BTN_5
            // 
            this.BTN_5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_5.Location = new System.Drawing.Point(167, 237);
            this.BTN_5.Name = "BTN_5";
            this.BTN_5.Size = new System.Drawing.Size(85, 50);
            this.BTN_5.TabIndex = 10;
            this.BTN_5.Text = "5";
            this.BTN_5.UseVisualStyleBackColor = true;
            this.BTN_5.Click += new System.EventHandler(this.BTN_DegerEkle);
            // 
            // BTN_4
            // 
            this.BTN_4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_4.Location = new System.Drawing.Point(76, 237);
            this.BTN_4.Name = "BTN_4";
            this.BTN_4.Size = new System.Drawing.Size(85, 50);
            this.BTN_4.TabIndex = 9;
            this.BTN_4.Text = "4";
            this.BTN_4.UseVisualStyleBackColor = true;
            this.BTN_4.Click += new System.EventHandler(this.BTN_DegerEkle);
            // 
            // BTN_1slashX
            // 
            this.BTN_1slashX.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_1slashX.Location = new System.Drawing.Point(440, 293);
            this.BTN_1slashX.Name = "BTN_1slashX";
            this.BTN_1slashX.Size = new System.Drawing.Size(98, 50);
            this.BTN_1slashX.TabIndex = 18;
            this.BTN_1slashX.Text = "1/x";
            this.BTN_1slashX.UseVisualStyleBackColor = true;
            this.BTN_1slashX.Click += new System.EventHandler(this.BTN_DahaOlmadi);
            // 
            // BTN_Eksi
            // 
            this.BTN_Eksi.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_Eksi.Location = new System.Drawing.Point(349, 293);
            this.BTN_Eksi.Name = "BTN_Eksi";
            this.BTN_Eksi.Size = new System.Drawing.Size(85, 50);
            this.BTN_Eksi.TabIndex = 17;
            this.BTN_Eksi.Text = "-";
            this.BTN_Eksi.UseVisualStyleBackColor = true;
            this.BTN_Eksi.Click += new System.EventHandler(this.BTN_DegerEkle);
            // 
            // BTN_3
            // 
            this.BTN_3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_3.Location = new System.Drawing.Point(258, 293);
            this.BTN_3.Name = "BTN_3";
            this.BTN_3.Size = new System.Drawing.Size(85, 50);
            this.BTN_3.TabIndex = 16;
            this.BTN_3.Text = "3";
            this.BTN_3.UseVisualStyleBackColor = true;
            this.BTN_3.Click += new System.EventHandler(this.BTN_DegerEkle);
            // 
            // BTN_2
            // 
            this.BTN_2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_2.Location = new System.Drawing.Point(167, 293);
            this.BTN_2.Name = "BTN_2";
            this.BTN_2.Size = new System.Drawing.Size(85, 50);
            this.BTN_2.TabIndex = 15;
            this.BTN_2.Text = "2";
            this.BTN_2.UseVisualStyleBackColor = true;
            this.BTN_2.Click += new System.EventHandler(this.BTN_DegerEkle);
            // 
            // BTN_1
            // 
            this.BTN_1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_1.Location = new System.Drawing.Point(76, 293);
            this.BTN_1.Name = "BTN_1";
            this.BTN_1.Size = new System.Drawing.Size(85, 50);
            this.BTN_1.TabIndex = 14;
            this.BTN_1.Text = "1";
            this.BTN_1.UseVisualStyleBackColor = true;
            this.BTN_1.Click += new System.EventHandler(this.BTN_DegerEkle);
            // 
            // BTN_Esittir
            // 
            this.BTN_Esittir.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_Esittir.Location = new System.Drawing.Point(440, 349);
            this.BTN_Esittir.Name = "BTN_Esittir";
            this.BTN_Esittir.Size = new System.Drawing.Size(98, 50);
            this.BTN_Esittir.TabIndex = 23;
            this.BTN_Esittir.Text = "=";
            this.BTN_Esittir.UseVisualStyleBackColor = true;
            this.BTN_Esittir.Click += new System.EventHandler(this.BTN_Esittir_Click);
            // 
            // BTN_Arti
            // 
            this.BTN_Arti.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_Arti.Location = new System.Drawing.Point(349, 349);
            this.BTN_Arti.Name = "BTN_Arti";
            this.BTN_Arti.Size = new System.Drawing.Size(85, 50);
            this.BTN_Arti.TabIndex = 22;
            this.BTN_Arti.Text = "+";
            this.BTN_Arti.UseVisualStyleBackColor = true;
            this.BTN_Arti.Click += new System.EventHandler(this.BTN_DegerEkle);
            // 
            // BTN_Nokta
            // 
            this.BTN_Nokta.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_Nokta.Location = new System.Drawing.Point(258, 349);
            this.BTN_Nokta.Name = "BTN_Nokta";
            this.BTN_Nokta.Size = new System.Drawing.Size(85, 50);
            this.BTN_Nokta.TabIndex = 21;
            this.BTN_Nokta.Text = ".";
            this.BTN_Nokta.UseVisualStyleBackColor = true;
            this.BTN_Nokta.Click += new System.EventHandler(this.BTN_DegerEkle);
            // 
            // BTN_ArtiSlashEksi
            // 
            this.BTN_ArtiSlashEksi.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_ArtiSlashEksi.Location = new System.Drawing.Point(167, 349);
            this.BTN_ArtiSlashEksi.Name = "BTN_ArtiSlashEksi";
            this.BTN_ArtiSlashEksi.Size = new System.Drawing.Size(85, 50);
            this.BTN_ArtiSlashEksi.TabIndex = 20;
            this.BTN_ArtiSlashEksi.Text = "+/-";
            this.BTN_ArtiSlashEksi.UseVisualStyleBackColor = true;
            this.BTN_ArtiSlashEksi.Click += new System.EventHandler(this.BTN_DahaOlmadi);
            // 
            // BTN_0
            // 
            this.BTN_0.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_0.Location = new System.Drawing.Point(76, 349);
            this.BTN_0.Name = "BTN_0";
            this.BTN_0.Size = new System.Drawing.Size(85, 50);
            this.BTN_0.TabIndex = 19;
            this.BTN_0.Text = "0";
            this.BTN_0.UseVisualStyleBackColor = true;
            this.BTN_0.Click += new System.EventHandler(this.BTN_DegerEkle);
            // 
            // BTN_MArti
            // 
            this.BTN_MArti.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_MArti.Location = new System.Drawing.Point(12, 349);
            this.BTN_MArti.Name = "BTN_MArti";
            this.BTN_MArti.Size = new System.Drawing.Size(58, 50);
            this.BTN_MArti.TabIndex = 27;
            this.BTN_MArti.Text = "M+";
            this.BTN_MArti.UseVisualStyleBackColor = true;
            this.BTN_MArti.Click += new System.EventHandler(this.BTN_MArti_Click);
            // 
            // BTN_MS
            // 
            this.BTN_MS.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_MS.Location = new System.Drawing.Point(12, 293);
            this.BTN_MS.Name = "BTN_MS";
            this.BTN_MS.Size = new System.Drawing.Size(58, 50);
            this.BTN_MS.TabIndex = 26;
            this.BTN_MS.Text = "MS";
            this.BTN_MS.UseVisualStyleBackColor = true;
            this.BTN_MS.Click += new System.EventHandler(this.BTN_MS_Click);
            // 
            // BTN_MR
            // 
            this.BTN_MR.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_MR.Location = new System.Drawing.Point(12, 237);
            this.BTN_MR.Name = "BTN_MR";
            this.BTN_MR.Size = new System.Drawing.Size(58, 50);
            this.BTN_MR.TabIndex = 25;
            this.BTN_MR.Text = "MR";
            this.BTN_MR.UseVisualStyleBackColor = true;
            this.BTN_MR.Click += new System.EventHandler(this.BTN_MR_Click);
            // 
            // BTN_MC
            // 
            this.BTN_MC.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_MC.Location = new System.Drawing.Point(12, 181);
            this.BTN_MC.Name = "BTN_MC";
            this.BTN_MC.Size = new System.Drawing.Size(58, 50);
            this.BTN_MC.TabIndex = 24;
            this.BTN_MC.Text = "MC";
            this.BTN_MC.UseVisualStyleBackColor = true;
            this.BTN_MC.Click += new System.EventHandler(this.BTN_MC_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 411);
            this.Controls.Add(this.BTN_MArti);
            this.Controls.Add(this.BTN_MS);
            this.Controls.Add(this.BTN_MR);
            this.Controls.Add(this.BTN_MC);
            this.Controls.Add(this.BTN_Esittir);
            this.Controls.Add(this.BTN_Arti);
            this.Controls.Add(this.BTN_Nokta);
            this.Controls.Add(this.BTN_ArtiSlashEksi);
            this.Controls.Add(this.BTN_0);
            this.Controls.Add(this.BTN_1slashX);
            this.Controls.Add(this.BTN_Eksi);
            this.Controls.Add(this.BTN_3);
            this.Controls.Add(this.BTN_2);
            this.Controls.Add(this.BTN_1);
            this.Controls.Add(this.BTN_Yuzde);
            this.Controls.Add(this.BTN_Carpma);
            this.Controls.Add(this.BTN_6);
            this.Controls.Add(this.BTN_5);
            this.Controls.Add(this.BTN_4);
            this.Controls.Add(this.BTN_sqrt);
            this.Controls.Add(this.BTN_Bolme);
            this.Controls.Add(this.BTN_9);
            this.Controls.Add(this.BTN_8);
            this.Controls.Add(this.BTN_7);
            this.Controls.Add(this.BTN_C);
            this.Controls.Add(this.BTN_Backspace);
            this.Controls.Add(this.TB_Hesap);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Makinesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Hesap;
        private System.Windows.Forms.Button BTN_Backspace;
        private System.Windows.Forms.Button BTN_C;
        private System.Windows.Forms.Button BTN_7;
        private System.Windows.Forms.Button BTN_8;
        private System.Windows.Forms.Button BTN_9;
        private System.Windows.Forms.Button BTN_Bolme;
        private System.Windows.Forms.Button BTN_sqrt;
        private System.Windows.Forms.Button BTN_Yuzde;
        private System.Windows.Forms.Button BTN_Carpma;
        private System.Windows.Forms.Button BTN_6;
        private System.Windows.Forms.Button BTN_5;
        private System.Windows.Forms.Button BTN_4;
        private System.Windows.Forms.Button BTN_1slashX;
        private System.Windows.Forms.Button BTN_Eksi;
        private System.Windows.Forms.Button BTN_3;
        private System.Windows.Forms.Button BTN_2;
        private System.Windows.Forms.Button BTN_1;
        private System.Windows.Forms.Button BTN_Esittir;
        private System.Windows.Forms.Button BTN_Arti;
        private System.Windows.Forms.Button BTN_Nokta;
        private System.Windows.Forms.Button BTN_ArtiSlashEksi;
        private System.Windows.Forms.Button BTN_0;
        private System.Windows.Forms.Button BTN_MArti;
        private System.Windows.Forms.Button BTN_MS;
        private System.Windows.Forms.Button BTN_MR;
        private System.Windows.Forms.Button BTN_MC;
    }
}


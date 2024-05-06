namespace OtoparkSistemi
{
    partial class ParkAlanlariniDuzenle
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
            this.BTN_Ekle = new System.Windows.Forms.Button();
            this.BTN_Sil = new System.Windows.Forms.Button();
            this.GB_Ekle = new System.Windows.Forms.GroupBox();
            this.RB_SUV = new System.Windows.Forms.RadioButton();
            this.RB_Motor = new System.Windows.Forms.RadioButton();
            this.RB_Araba = new System.Windows.Forms.RadioButton();
            this.BTN_PEkle = new System.Windows.Forms.Button();
            this.TB_NumaraEkleme = new System.Windows.Forms.TextBox();
            this.LBL_NumaraEkleme = new System.Windows.Forms.Label();
            this.LBL_SutunEkleme = new System.Windows.Forms.Label();
            this.CB_SutunEkleme = new System.Windows.Forms.ComboBox();
            this.GB_Silme = new System.Windows.Forms.GroupBox();
            this.TB_Numara2Silme = new System.Windows.Forms.TextBox();
            this.LBL_Numara2Silme = new System.Windows.Forms.Label();
            this.BTN_PSil = new System.Windows.Forms.Button();
            this.TB_Numara1Silme = new System.Windows.Forms.TextBox();
            this.LBL_Numara1Silme = new System.Windows.Forms.Label();
            this.LBL_SutunSime = new System.Windows.Forms.Label();
            this.CB_SutunSilme = new System.Windows.Forms.ComboBox();
            this.GB_Ekle.SuspendLayout();
            this.GB_Silme.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Ekle
            // 
            this.BTN_Ekle.Location = new System.Drawing.Point(12, 12);
            this.BTN_Ekle.Name = "BTN_Ekle";
            this.BTN_Ekle.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ekle.TabIndex = 0;
            this.BTN_Ekle.Text = "Ekle";
            this.BTN_Ekle.UseVisualStyleBackColor = true;
            this.BTN_Ekle.Click += new System.EventHandler(this.BTN_Ekle_Click);
            // 
            // BTN_Sil
            // 
            this.BTN_Sil.Location = new System.Drawing.Point(165, 12);
            this.BTN_Sil.Name = "BTN_Sil";
            this.BTN_Sil.Size = new System.Drawing.Size(75, 23);
            this.BTN_Sil.TabIndex = 1;
            this.BTN_Sil.Text = "Sil";
            this.BTN_Sil.UseVisualStyleBackColor = true;
            this.BTN_Sil.Click += new System.EventHandler(this.BTN_Sil_Click);
            // 
            // GB_Ekle
            // 
            this.GB_Ekle.Controls.Add(this.GB_Silme);
            this.GB_Ekle.Controls.Add(this.RB_SUV);
            this.GB_Ekle.Controls.Add(this.RB_Motor);
            this.GB_Ekle.Controls.Add(this.RB_Araba);
            this.GB_Ekle.Controls.Add(this.BTN_PEkle);
            this.GB_Ekle.Controls.Add(this.TB_NumaraEkleme);
            this.GB_Ekle.Controls.Add(this.LBL_NumaraEkleme);
            this.GB_Ekle.Controls.Add(this.LBL_SutunEkleme);
            this.GB_Ekle.Controls.Add(this.CB_SutunEkleme);
            this.GB_Ekle.Location = new System.Drawing.Point(12, 41);
            this.GB_Ekle.Name = "GB_Ekle";
            this.GB_Ekle.Size = new System.Drawing.Size(211, 126);
            this.GB_Ekle.TabIndex = 2;
            this.GB_Ekle.TabStop = false;
            this.GB_Ekle.Text = "Ekleme Ekranı";
            // 
            // RB_SUV
            // 
            this.RB_SUV.AutoSize = true;
            this.RB_SUV.Location = new System.Drawing.Point(151, 74);
            this.RB_SUV.Name = "RB_SUV";
            this.RB_SUV.Size = new System.Drawing.Size(47, 17);
            this.RB_SUV.TabIndex = 8;
            this.RB_SUV.TabStop = true;
            this.RB_SUV.Text = "SUV";
            this.RB_SUV.UseVisualStyleBackColor = true;
            // 
            // RB_Motor
            // 
            this.RB_Motor.AutoSize = true;
            this.RB_Motor.Location = new System.Drawing.Point(77, 74);
            this.RB_Motor.Name = "RB_Motor";
            this.RB_Motor.Size = new System.Drawing.Size(52, 17);
            this.RB_Motor.TabIndex = 7;
            this.RB_Motor.TabStop = true;
            this.RB_Motor.Text = "Motor";
            this.RB_Motor.UseVisualStyleBackColor = true;
            // 
            // RB_Araba
            // 
            this.RB_Araba.AutoSize = true;
            this.RB_Araba.Location = new System.Drawing.Point(10, 74);
            this.RB_Araba.Name = "RB_Araba";
            this.RB_Araba.Size = new System.Drawing.Size(53, 17);
            this.RB_Araba.TabIndex = 6;
            this.RB_Araba.TabStop = true;
            this.RB_Araba.Text = "Araba";
            this.RB_Araba.UseVisualStyleBackColor = true;
            // 
            // BTN_PEkle
            // 
            this.BTN_PEkle.Location = new System.Drawing.Point(77, 97);
            this.BTN_PEkle.Name = "BTN_PEkle";
            this.BTN_PEkle.Size = new System.Drawing.Size(121, 23);
            this.BTN_PEkle.TabIndex = 5;
            this.BTN_PEkle.Text = "Park Alanlarını Ekle";
            this.BTN_PEkle.UseVisualStyleBackColor = true;
            // 
            // TB_NumaraEkleme
            // 
            this.TB_NumaraEkleme.Location = new System.Drawing.Point(77, 48);
            this.TB_NumaraEkleme.Name = "TB_NumaraEkleme";
            this.TB_NumaraEkleme.Size = new System.Drawing.Size(121, 20);
            this.TB_NumaraEkleme.TabIndex = 4;
            // 
            // LBL_NumaraEkleme
            // 
            this.LBL_NumaraEkleme.AutoSize = true;
            this.LBL_NumaraEkleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_NumaraEkleme.Location = new System.Drawing.Point(6, 46);
            this.LBL_NumaraEkleme.Name = "LBL_NumaraEkleme";
            this.LBL_NumaraEkleme.Size = new System.Drawing.Size(69, 20);
            this.LBL_NumaraEkleme.TabIndex = 3;
            this.LBL_NumaraEkleme.Text = "Numara:";
            // 
            // LBL_SutunEkleme
            // 
            this.LBL_SutunEkleme.AutoSize = true;
            this.LBL_SutunEkleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_SutunEkleme.Location = new System.Drawing.Point(6, 16);
            this.LBL_SutunEkleme.Name = "LBL_SutunEkleme";
            this.LBL_SutunEkleme.Size = new System.Drawing.Size(56, 20);
            this.LBL_SutunEkleme.TabIndex = 1;
            this.LBL_SutunEkleme.Text = "Sütün:";
            // 
            // CB_SutunEkleme
            // 
            this.CB_SutunEkleme.FormattingEnabled = true;
            this.CB_SutunEkleme.Location = new System.Drawing.Point(77, 18);
            this.CB_SutunEkleme.Name = "CB_SutunEkleme";
            this.CB_SutunEkleme.Size = new System.Drawing.Size(121, 21);
            this.CB_SutunEkleme.TabIndex = 0;
            // 
            // GB_Silme
            // 
            this.GB_Silme.Controls.Add(this.TB_Numara2Silme);
            this.GB_Silme.Controls.Add(this.LBL_Numara2Silme);
            this.GB_Silme.Controls.Add(this.BTN_PSil);
            this.GB_Silme.Controls.Add(this.TB_Numara1Silme);
            this.GB_Silme.Controls.Add(this.LBL_Numara1Silme);
            this.GB_Silme.Controls.Add(this.LBL_SutunSime);
            this.GB_Silme.Controls.Add(this.CB_SutunSilme);
            this.GB_Silme.Location = new System.Drawing.Point(0, 0);
            this.GB_Silme.Name = "GB_Silme";
            this.GB_Silme.Size = new System.Drawing.Size(228, 138);
            this.GB_Silme.TabIndex = 3;
            this.GB_Silme.TabStop = false;
            this.GB_Silme.Text = "Silme Ekranı";
            // 
            // TB_Numara2Silme
            // 
            this.TB_Numara2Silme.Location = new System.Drawing.Point(94, 78);
            this.TB_Numara2Silme.Name = "TB_Numara2Silme";
            this.TB_Numara2Silme.Size = new System.Drawing.Size(121, 20);
            this.TB_Numara2Silme.TabIndex = 7;
            // 
            // LBL_Numara2Silme
            // 
            this.LBL_Numara2Silme.AutoSize = true;
            this.LBL_Numara2Silme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_Numara2Silme.Location = new System.Drawing.Point(6, 76);
            this.LBL_Numara2Silme.Name = "LBL_Numara2Silme";
            this.LBL_Numara2Silme.Size = new System.Drawing.Size(82, 20);
            this.LBL_Numara2Silme.TabIndex = 6;
            this.LBL_Numara2Silme.Text = "Numara 2:";
            // 
            // BTN_PSil
            // 
            this.BTN_PSil.Location = new System.Drawing.Point(94, 104);
            this.BTN_PSil.Name = "BTN_PSil";
            this.BTN_PSil.Size = new System.Drawing.Size(121, 23);
            this.BTN_PSil.TabIndex = 5;
            this.BTN_PSil.Text = "Park Alanlarını Sil";
            this.BTN_PSil.UseVisualStyleBackColor = true;
            // 
            // TB_Numara1Silme
            // 
            this.TB_Numara1Silme.Location = new System.Drawing.Point(94, 48);
            this.TB_Numara1Silme.Name = "TB_Numara1Silme";
            this.TB_Numara1Silme.Size = new System.Drawing.Size(121, 20);
            this.TB_Numara1Silme.TabIndex = 4;
            // 
            // LBL_Numara1Silme
            // 
            this.LBL_Numara1Silme.AutoSize = true;
            this.LBL_Numara1Silme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_Numara1Silme.Location = new System.Drawing.Point(6, 46);
            this.LBL_Numara1Silme.Name = "LBL_Numara1Silme";
            this.LBL_Numara1Silme.Size = new System.Drawing.Size(82, 20);
            this.LBL_Numara1Silme.TabIndex = 3;
            this.LBL_Numara1Silme.Text = "Numara 1:";
            // 
            // LBL_SutunSime
            // 
            this.LBL_SutunSime.AutoSize = true;
            this.LBL_SutunSime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_SutunSime.Location = new System.Drawing.Point(6, 16);
            this.LBL_SutunSime.Name = "LBL_SutunSime";
            this.LBL_SutunSime.Size = new System.Drawing.Size(56, 20);
            this.LBL_SutunSime.TabIndex = 1;
            this.LBL_SutunSime.Text = "Sütün:";
            // 
            // CB_SutunSilme
            // 
            this.CB_SutunSilme.FormattingEnabled = true;
            this.CB_SutunSilme.Location = new System.Drawing.Point(94, 16);
            this.CB_SutunSilme.Name = "CB_SutunSilme";
            this.CB_SutunSilme.Size = new System.Drawing.Size(121, 21);
            this.CB_SutunSilme.TabIndex = 0;
            // 
            // ParkAlanlariniDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 178);
            this.Controls.Add(this.GB_Ekle);
            this.Controls.Add(this.BTN_Sil);
            this.Controls.Add(this.BTN_Ekle);
            this.Name = "ParkAlanlariniDuzenle";
            this.Text = "ParkAlanlariniDuzenle";
            this.GB_Ekle.ResumeLayout(false);
            this.GB_Ekle.PerformLayout();
            this.GB_Silme.ResumeLayout(false);
            this.GB_Silme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Ekle;
        private System.Windows.Forms.Button BTN_Sil;
        private System.Windows.Forms.GroupBox GB_Ekle;
        private System.Windows.Forms.Label LBL_NumaraEkleme;
        private System.Windows.Forms.Label LBL_SutunEkleme;
        private System.Windows.Forms.ComboBox CB_SutunEkleme;
        private System.Windows.Forms.Button BTN_PEkle;
        private System.Windows.Forms.TextBox TB_NumaraEkleme;
        private System.Windows.Forms.GroupBox GB_Silme;
        private System.Windows.Forms.TextBox TB_Numara2Silme;
        private System.Windows.Forms.Label LBL_Numara2Silme;
        private System.Windows.Forms.Button BTN_PSil;
        private System.Windows.Forms.TextBox TB_Numara1Silme;
        private System.Windows.Forms.Label LBL_Numara1Silme;
        private System.Windows.Forms.Label LBL_SutunSime;
        private System.Windows.Forms.ComboBox CB_SutunSilme;
        private System.Windows.Forms.RadioButton RB_SUV;
        private System.Windows.Forms.RadioButton RB_Motor;
        private System.Windows.Forms.RadioButton RB_Araba;
    }
}
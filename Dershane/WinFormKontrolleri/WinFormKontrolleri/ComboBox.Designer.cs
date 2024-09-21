namespace WinFormKontrolleri
{
    partial class ComboBox
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
            this.CB_Sehir = new System.Windows.Forms.ComboBox();
            this.BTN_Getir = new System.Windows.Forms.Button();
            this.LBL_Sonuc = new System.Windows.Forms.Label();
            this.BTN_Sonuc2 = new System.Windows.Forms.Label();
            this.BTN_Getir2 = new System.Windows.Forms.Button();
            this.CB_Sehir2 = new System.Windows.Forms.ComboBox();
            this.LBL_Sehir2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şehir";
            // 
            // CB_Sehir
            // 
            this.CB_Sehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Sehir.FormattingEnabled = true;
            this.CB_Sehir.Items.AddRange(new object[] {
            "Adana",
            " Adıyaman",
            " Afyonkarahisar",
            " Ağrı",
            " Aksaray",
            " Amasya",
            " Ankara",
            " Antalya",
            " Ardahan",
            " Artvin",
            " Aydın",
            " Balıkesir",
            " Bartın",
            " Batman",
            " Bayburt",
            " Bilecik",
            " Bingöl",
            " Bitlis",
            " Bolu",
            " Burdur",
            " Bursa",
            " Çanakkale",
            " Çankırı",
            " Çorum",
            " Denizli",
            " Diyarbakır",
            " Düzce",
            " Edirne",
            " Elazığ",
            " Erzincan",
            " Erzurum",
            " Eskişehir",
            " Gaziantep",
            " Giresun",
            " Gümüşhane",
            " Hakkâri",
            " Hatay",
            " Iğdır",
            " Isparta",
            " İstanbul",
            " İzmir",
            " Kahramanmaraş",
            " Karabük",
            " Karaman",
            " Kars",
            " Kastamonu",
            " Kayseri",
            " Kilis",
            " Kırıkkale",
            " Kırklareli",
            " Kırşehir",
            " Kocaeli",
            " Konya",
            " Kütahya",
            " Malatya",
            " Manisa",
            " Mardin",
            " Mersin",
            " Muğla",
            " Muş",
            " Nevşehir",
            " Niğde",
            " Ordu",
            " Osmaniye",
            " Rize",
            " Sakarya",
            " Samsun",
            " Şanlıurfa",
            " Siirt",
            " Sinop",
            " Sivas",
            " Şırnak",
            " Tekirdağ",
            " Tokat",
            " Trabzon",
            " Tunceli",
            " Uşak",
            " Van",
            " Yalova",
            " Yozgat",
            " Zonguldak"});
            this.CB_Sehir.Location = new System.Drawing.Point(12, 25);
            this.CB_Sehir.Name = "CB_Sehir";
            this.CB_Sehir.Size = new System.Drawing.Size(202, 21);
            this.CB_Sehir.TabIndex = 1;
            // 
            // BTN_Getir
            // 
            this.BTN_Getir.Location = new System.Drawing.Point(220, 25);
            this.BTN_Getir.Name = "BTN_Getir";
            this.BTN_Getir.Size = new System.Drawing.Size(75, 21);
            this.BTN_Getir.TabIndex = 2;
            this.BTN_Getir.Text = "Getir";
            this.BTN_Getir.UseVisualStyleBackColor = true;
            this.BTN_Getir.Click += new System.EventHandler(this.BTN_Getir_Click);
            // 
            // LBL_Sonuc
            // 
            this.LBL_Sonuc.AutoSize = true;
            this.LBL_Sonuc.Location = new System.Drawing.Point(12, 53);
            this.LBL_Sonuc.Name = "LBL_Sonuc";
            this.LBL_Sonuc.Size = new System.Drawing.Size(38, 13);
            this.LBL_Sonuc.TabIndex = 3;
            this.LBL_Sonuc.Text = "Sonuc";
            // 
            // BTN_Sonuc2
            // 
            this.BTN_Sonuc2.AutoSize = true;
            this.BTN_Sonuc2.Location = new System.Drawing.Point(12, 135);
            this.BTN_Sonuc2.Name = "BTN_Sonuc2";
            this.BTN_Sonuc2.Size = new System.Drawing.Size(38, 13);
            this.BTN_Sonuc2.TabIndex = 7;
            this.BTN_Sonuc2.Text = "Sonuc";
            // 
            // BTN_Getir2
            // 
            this.BTN_Getir2.Location = new System.Drawing.Point(220, 107);
            this.BTN_Getir2.Name = "BTN_Getir2";
            this.BTN_Getir2.Size = new System.Drawing.Size(75, 21);
            this.BTN_Getir2.TabIndex = 6;
            this.BTN_Getir2.Text = "Getir";
            this.BTN_Getir2.UseVisualStyleBackColor = true;
            // 
            // CB_Sehir2
            // 
            this.CB_Sehir2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Sehir2.FormattingEnabled = true;
            this.CB_Sehir2.Location = new System.Drawing.Point(12, 107);
            this.CB_Sehir2.Name = "CB_Sehir2";
            this.CB_Sehir2.Size = new System.Drawing.Size(202, 21);
            this.CB_Sehir2.TabIndex = 5;
            // 
            // LBL_Sehir2
            // 
            this.LBL_Sehir2.AutoSize = true;
            this.LBL_Sehir2.Location = new System.Drawing.Point(12, 91);
            this.LBL_Sehir2.Name = "LBL_Sehir2";
            this.LBL_Sehir2.Size = new System.Drawing.Size(31, 13);
            this.LBL_Sehir2.TabIndex = 4;
            this.LBL_Sehir2.Text = "Şehir";
            // 
            // ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_Sonuc2);
            this.Controls.Add(this.BTN_Getir2);
            this.Controls.Add(this.CB_Sehir2);
            this.Controls.Add(this.LBL_Sehir2);
            this.Controls.Add(this.LBL_Sonuc);
            this.Controls.Add(this.BTN_Getir);
            this.Controls.Add(this.CB_Sehir);
            this.Controls.Add(this.label1);
            this.Name = "ComboBox";
            this.Text = "ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Sehir;
        private System.Windows.Forms.Button BTN_Getir;
        private System.Windows.Forms.Label LBL_Sonuc;
        private System.Windows.Forms.Label BTN_Sonuc2;
        private System.Windows.Forms.Button BTN_Getir2;
        private System.Windows.Forms.ComboBox CB_Sehir2;
        private System.Windows.Forms.Label LBL_Sehir2;
    }
}
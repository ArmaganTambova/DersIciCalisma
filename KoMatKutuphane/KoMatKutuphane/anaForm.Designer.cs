namespace KoMatKutuphane
{
    partial class anaForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMI_dosya = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_kapat = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_kutuphaneislemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_diller = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_turler = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_yazarlar = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_yayinevleri = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_kitaplar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_kiralamalar = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_yardim = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_dosya,
            this.TSMI_kutuphaneislemleri,
            this.TSMI_kiralamalar,
            this.TSMI_yardim});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMI_dosya
            // 
            this.TSMI_dosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_kapat});
            this.TSMI_dosya.Name = "TSMI_dosya";
            this.TSMI_dosya.Size = new System.Drawing.Size(51, 20);
            this.TSMI_dosya.Text = "Dosya";
            // 
            // TSMI_kapat
            // 
            this.TSMI_kapat.Name = "TSMI_kapat";
            this.TSMI_kapat.Size = new System.Drawing.Size(104, 22);
            this.TSMI_kapat.Text = "Kapat";
            // 
            // TSMI_kutuphaneislemleri
            // 
            this.TSMI_kutuphaneislemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_diller,
            this.TSMI_turler,
            this.TSMI_yazarlar,
            this.TSMI_yayinevleri,
            this.toolStripSeparator1,
            this.TSMI_kitaplar,
            this.toolStripSeparator2});
            this.TSMI_kutuphaneislemleri.Name = "TSMI_kutuphaneislemleri";
            this.TSMI_kutuphaneislemleri.Size = new System.Drawing.Size(124, 20);
            this.TSMI_kutuphaneislemleri.Text = "Kütüphane İşlemleri";
            // 
            // TSMI_diller
            // 
            this.TSMI_diller.Name = "TSMI_diller";
            this.TSMI_diller.Size = new System.Drawing.Size(180, 22);
            this.TSMI_diller.Text = "Diller";
            this.TSMI_diller.Click += new System.EventHandler(this.TSMI_diller_Click);
            // 
            // TSMI_turler
            // 
            this.TSMI_turler.Name = "TSMI_turler";
            this.TSMI_turler.Size = new System.Drawing.Size(180, 22);
            this.TSMI_turler.Text = "Türler";
            // 
            // TSMI_yazarlar
            // 
            this.TSMI_yazarlar.Name = "TSMI_yazarlar";
            this.TSMI_yazarlar.Size = new System.Drawing.Size(180, 22);
            this.TSMI_yazarlar.Text = "Yazarlar";
            // 
            // TSMI_yayinevleri
            // 
            this.TSMI_yayinevleri.Name = "TSMI_yayinevleri";
            this.TSMI_yayinevleri.Size = new System.Drawing.Size(180, 22);
            this.TSMI_yayinevleri.Text = "Yayınevleri";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // TSMI_kitaplar
            // 
            this.TSMI_kitaplar.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold);
            this.TSMI_kitaplar.ForeColor = System.Drawing.Color.Green;
            this.TSMI_kitaplar.Name = "TSMI_kitaplar";
            this.TSMI_kitaplar.Size = new System.Drawing.Size(180, 22);
            this.TSMI_kitaplar.Text = "Kitaplar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // TSMI_kiralamalar
            // 
            this.TSMI_kiralamalar.Name = "TSMI_kiralamalar";
            this.TSMI_kiralamalar.Size = new System.Drawing.Size(78, 20);
            this.TSMI_kiralamalar.Text = "Kiralamalar";
            // 
            // TSMI_yardim
            // 
            this.TSMI_yardim.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TSMI_yardim.Name = "TSMI_yardim";
            this.TSMI_yardim.Size = new System.Drawing.Size(56, 20);
            this.TSMI_yardim.Text = "Yardım";
            // 
            // anaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "anaForm";
            this.Text = "Kokpit & Matrix Kütüphanesi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_dosya;
        private System.Windows.Forms.ToolStripMenuItem TSMI_kapat;
        private System.Windows.Forms.ToolStripMenuItem TSMI_kutuphaneislemleri;
        private System.Windows.Forms.ToolStripMenuItem TSMI_diller;
        private System.Windows.Forms.ToolStripMenuItem TSMI_turler;
        private System.Windows.Forms.ToolStripMenuItem TSMI_yazarlar;
        private System.Windows.Forms.ToolStripMenuItem TSMI_yayinevleri;
        private System.Windows.Forms.ToolStripMenuItem TSMI_kitaplar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem TSMI_kiralamalar;
        private System.Windows.Forms.ToolStripMenuItem TSMI_yardim;
    }
}
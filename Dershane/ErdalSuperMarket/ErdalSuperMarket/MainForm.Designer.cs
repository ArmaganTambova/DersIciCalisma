namespace ErdalSuperMarket
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMI_Dosya = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Urun = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_UrunIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_KategoriIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_TumUrunler = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Dosya,
            this.TSMI_Urun});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1190, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMI_Dosya
            // 
            this.TSMI_Dosya.Name = "TSMI_Dosya";
            this.TSMI_Dosya.Size = new System.Drawing.Size(51, 20);
            this.TSMI_Dosya.Text = "Dosya";
            // 
            // TSMI_Urun
            // 
            this.TSMI_Urun.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_UrunIslemleri,
            this.TSMI_KategoriIslemleri,
            this.TSMI_TumUrunler});
            this.TSMI_Urun.Name = "TSMI_Urun";
            this.TSMI_Urun.Size = new System.Drawing.Size(45, 20);
            this.TSMI_Urun.Text = "Ürün";
            // 
            // TSMI_UrunIslemleri
            // 
            this.TSMI_UrunIslemleri.Name = "TSMI_UrunIslemleri";
            this.TSMI_UrunIslemleri.Size = new System.Drawing.Size(180, 22);
            this.TSMI_UrunIslemleri.Text = "Ürün İşlemleri";
            // 
            // TSMI_KategoriIslemleri
            // 
            this.TSMI_KategoriIslemleri.Name = "TSMI_KategoriIslemleri";
            this.TSMI_KategoriIslemleri.Size = new System.Drawing.Size(180, 22);
            this.TSMI_KategoriIslemleri.Text = "Kategori İşlemleri";
            this.TSMI_KategoriIslemleri.Click += new System.EventHandler(this.TSMI_KategoriIslemleri_Click);
            // 
            // TSMI_TumUrunler
            // 
            this.TSMI_TumUrunler.Name = "TSMI_TumUrunler";
            this.TSMI_TumUrunler.Size = new System.Drawing.Size(180, 22);
            this.TSMI_TumUrunler.Text = "Tüm Ürünler";
            this.TSMI_TumUrunler.Click += new System.EventHandler(this.TSMI_TumUrunler_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 568);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Dosya;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Urun;
        private System.Windows.Forms.ToolStripMenuItem TSMI_UrunIslemleri;
        private System.Windows.Forms.ToolStripMenuItem TSMI_KategoriIslemleri;
        private System.Windows.Forms.ToolStripMenuItem TSMI_TumUrunler;
    }
}
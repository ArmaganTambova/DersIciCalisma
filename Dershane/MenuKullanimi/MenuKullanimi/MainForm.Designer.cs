namespace MenuKullanimi
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
            this.TSM_Dosya = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Yeni = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Kaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_FarkliKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_Kapat = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_OgrenciIsleri = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_OgrenciKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_OgrenciSil = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_OgrenciGetir = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Yardim = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_Dosya,
            this.TSM_OgrenciIsleri,
            this.TSM_Yardim});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSM_Dosya
            // 
            this.TSM_Dosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Yeni,
            this.TSMI_Kaydet,
            this.TSMI_FarkliKaydet,
            this.toolStripSeparator1,
            this.TSMI_Kapat});
            this.TSM_Dosya.Name = "TSM_Dosya";
            this.TSM_Dosya.Size = new System.Drawing.Size(51, 20);
            this.TSM_Dosya.Text = "Dosya";
            // 
            // TSMI_Yeni
            // 
            this.TSMI_Yeni.Name = "TSMI_Yeni";
            this.TSMI_Yeni.Size = new System.Drawing.Size(145, 22);
            this.TSMI_Yeni.Text = "Yeni";
            // 
            // TSMI_Kaydet
            // 
            this.TSMI_Kaydet.Name = "TSMI_Kaydet";
            this.TSMI_Kaydet.Size = new System.Drawing.Size(145, 22);
            this.TSMI_Kaydet.Text = "Kaydet";
            // 
            // TSMI_FarkliKaydet
            // 
            this.TSMI_FarkliKaydet.Name = "TSMI_FarkliKaydet";
            this.TSMI_FarkliKaydet.Size = new System.Drawing.Size(145, 22);
            this.TSMI_FarkliKaydet.Text = "Farklı Kaydet";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // TSMI_Kapat
            // 
            this.TSMI_Kapat.Image = global::MenuKullanimi.Properties.Resources.Close;
            this.TSMI_Kapat.Name = "TSMI_Kapat";
            this.TSMI_Kapat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.TSMI_Kapat.Size = new System.Drawing.Size(145, 22);
            this.TSMI_Kapat.Text = "Kapat";
            this.TSMI_Kapat.Click += new System.EventHandler(this.TSMI_Kapat_Click);
            // 
            // TSM_OgrenciIsleri
            // 
            this.TSM_OgrenciIsleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_OgrenciKaydet,
            this.TSMI_OgrenciSil,
            this.TSMI_OgrenciGetir});
            this.TSM_OgrenciIsleri.Name = "TSM_OgrenciIsleri";
            this.TSM_OgrenciIsleri.Size = new System.Drawing.Size(88, 20);
            this.TSM_OgrenciIsleri.Text = "Öğrenci İşleri";
            // 
            // TSMI_OgrenciKaydet
            // 
            this.TSMI_OgrenciKaydet.Name = "TSMI_OgrenciKaydet";
            this.TSMI_OgrenciKaydet.Size = new System.Drawing.Size(155, 22);
            this.TSMI_OgrenciKaydet.Text = "Öğrenci Kaydet";
            this.TSMI_OgrenciKaydet.Click += new System.EventHandler(this.TSMI_OgrenciKaydet_Click);
            // 
            // TSMI_OgrenciSil
            // 
            this.TSMI_OgrenciSil.Name = "TSMI_OgrenciSil";
            this.TSMI_OgrenciSil.Size = new System.Drawing.Size(155, 22);
            this.TSMI_OgrenciSil.Text = "Öğrenci Sil";
            // 
            // TSMI_OgrenciGetir
            // 
            this.TSMI_OgrenciGetir.Name = "TSMI_OgrenciGetir";
            this.TSMI_OgrenciGetir.Size = new System.Drawing.Size(155, 22);
            this.TSMI_OgrenciGetir.Text = "Öğrenci Getir";
            // 
            // TSM_Yardim
            // 
            this.TSM_Yardim.Name = "TSM_Yardim";
            this.TSM_Yardim.Size = new System.Drawing.Size(56, 20);
            this.TSM_Yardim.Text = "Yardım";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSM_Dosya;
        private System.Windows.Forms.ToolStripMenuItem TSM_OgrenciIsleri;
        private System.Windows.Forms.ToolStripMenuItem TSMI_OgrenciKaydet;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Yeni;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Kaydet;
        private System.Windows.Forms.ToolStripMenuItem TSMI_FarkliKaydet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Kapat;
        private System.Windows.Forms.ToolStripMenuItem TSMI_OgrenciSil;
        private System.Windows.Forms.ToolStripMenuItem TSMI_OgrenciGetir;
        private System.Windows.Forms.ToolStripMenuItem TSM_Yardim;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}


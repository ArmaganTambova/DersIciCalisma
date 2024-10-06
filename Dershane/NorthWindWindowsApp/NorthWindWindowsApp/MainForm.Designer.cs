namespace NorthWindWindowsApp
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
            this.MS_MainForm = new System.Windows.Forms.MenuStrip();
            this.TSMI_Dosya = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_KategoriIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_UrunIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.SS_MainForm = new System.Windows.Forms.StatusStrip();
            this.TSMI_TedarikciIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_MainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // MS_MainForm
            // 
            this.MS_MainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Dosya,
            this.TSMI_KategoriIslemleri,
            this.TSMI_UrunIslemleri,
            this.TSMI_TedarikciIslemleri});
            this.MS_MainForm.Location = new System.Drawing.Point(0, 0);
            this.MS_MainForm.Name = "MS_MainForm";
            this.MS_MainForm.Size = new System.Drawing.Size(984, 24);
            this.MS_MainForm.TabIndex = 1;
            this.MS_MainForm.Text = "MS_MainForm";
            // 
            // TSMI_Dosya
            // 
            this.TSMI_Dosya.Name = "TSMI_Dosya";
            this.TSMI_Dosya.Size = new System.Drawing.Size(51, 20);
            this.TSMI_Dosya.Text = "Dosya";
            // 
            // TSMI_KategoriIslemleri
            // 
            this.TSMI_KategoriIslemleri.Name = "TSMI_KategoriIslemleri";
            this.TSMI_KategoriIslemleri.Size = new System.Drawing.Size(110, 20);
            this.TSMI_KategoriIslemleri.Text = "Kategori İşlemleri";
            this.TSMI_KategoriIslemleri.Click += new System.EventHandler(this.TSMI_KategoriIslemleri_Click);
            // 
            // TSMI_UrunIslemleri
            // 
            this.TSMI_UrunIslemleri.Name = "TSMI_UrunIslemleri";
            this.TSMI_UrunIslemleri.Size = new System.Drawing.Size(92, 20);
            this.TSMI_UrunIslemleri.Text = "Ürün İşlemleri";
            // 
            // SS_MainForm
            // 
            this.SS_MainForm.Location = new System.Drawing.Point(0, 439);
            this.SS_MainForm.Name = "SS_MainForm";
            this.SS_MainForm.Size = new System.Drawing.Size(984, 22);
            this.SS_MainForm.TabIndex = 2;
            this.SS_MainForm.Text = "SS_MainForm";
            // 
            // TSMI_TedarikciIslemleri
            // 
            this.TSMI_TedarikciIslemleri.Name = "TSMI_TedarikciIslemleri";
            this.TSMI_TedarikciIslemleri.Size = new System.Drawing.Size(112, 20);
            this.TSMI_TedarikciIslemleri.Text = "Tedarikçi işlemleri";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.SS_MainForm);
            this.Controls.Add(this.MS_MainForm);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MS_MainForm;
            this.Name = "MainForm";
            this.Text = "NorthWind";
            this.MS_MainForm.ResumeLayout(false);
            this.MS_MainForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MS_MainForm;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Dosya;
        private System.Windows.Forms.ToolStripMenuItem TSMI_KategoriIslemleri;
        private System.Windows.Forms.ToolStripMenuItem TSMI_UrunIslemleri;
        private System.Windows.Forms.ToolStripMenuItem TSMI_TedarikciIslemleri;
        private System.Windows.Forms.StatusStrip SS_MainForm;
    }
}
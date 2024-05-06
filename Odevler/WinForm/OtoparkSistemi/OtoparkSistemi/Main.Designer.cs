namespace OtoparkSistemi
{
    partial class Main
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
            this.araçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sorgulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alanlarıDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parkAlanlarınıGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.araçToolStripMenuItem,
            this.parkToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // araçToolStripMenuItem
            // 
            this.araçToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girişToolStripMenuItem,
            this.çıkışToolStripMenuItem,
            this.sorgulaToolStripMenuItem});
            this.araçToolStripMenuItem.Name = "araçToolStripMenuItem";
            this.araçToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.araçToolStripMenuItem.Text = "Araç";
            // 
            // girişToolStripMenuItem
            // 
            this.girişToolStripMenuItem.Name = "girişToolStripMenuItem";
            this.girişToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.girişToolStripMenuItem.Text = "Giriş";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // sorgulaToolStripMenuItem
            // 
            this.sorgulaToolStripMenuItem.Name = "sorgulaToolStripMenuItem";
            this.sorgulaToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.sorgulaToolStripMenuItem.Text = "Sorgula";
            // 
            // parkToolStripMenuItem
            // 
            this.parkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alanlarıDüzenleToolStripMenuItem,
            this.parkAlanlarınıGörüntüleToolStripMenuItem});
            this.parkToolStripMenuItem.Name = "parkToolStripMenuItem";
            this.parkToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.parkToolStripMenuItem.Text = "Park";
            // 
            // alanlarıDüzenleToolStripMenuItem
            // 
            this.alanlarıDüzenleToolStripMenuItem.Name = "alanlarıDüzenleToolStripMenuItem";
            this.alanlarıDüzenleToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.alanlarıDüzenleToolStripMenuItem.Text = "Alanları Düzenle";
            // 
            // parkAlanlarınıGörüntüleToolStripMenuItem
            // 
            this.parkAlanlarınıGörüntüleToolStripMenuItem.Name = "parkAlanlarınıGörüntüleToolStripMenuItem";
            this.parkAlanlarınıGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.parkAlanlarınıGörüntüleToolStripMenuItem.Text = "Park Alanlarını Görüntüle";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 24);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1200, 576);
            this.webBrowser1.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otopark Sistemi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem araçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sorgulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alanlarıDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parkAlanlarınıGörüntüleToolStripMenuItem;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}
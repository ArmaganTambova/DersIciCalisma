namespace Ungabunga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MenuS_1 = new System.Windows.Forms.MenuStrip();
            this.TSMIB_Dosya = new System.Windows.Forms.ToolStripMenuItem();
            this.TMSI_Yeni = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Ac = new System.Windows.Forms.ToolStripMenuItem();
            this.TSS1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_Kaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_FarkliKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.TSS2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_Kapat = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIB_Duzen = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIB_Yardim = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSB_Kaydet = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.MenuS_1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuS_1
            // 
            this.MenuS_1.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuS_1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIB_Dosya,
            this.TSMIB_Duzen,
            this.TSMIB_Yardim});
            this.MenuS_1.Location = new System.Drawing.Point(0, 0);
            this.MenuS_1.Name = "MenuS_1";
            this.MenuS_1.Size = new System.Drawing.Size(800, 24);
            this.MenuS_1.TabIndex = 0;
            this.MenuS_1.Text = "MenuS1";
            // 
            // TSMIB_Dosya
            // 
            this.TSMIB_Dosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TMSI_Yeni,
            this.TSMI_Ac,
            this.TSS1,
            this.TSMI_Kaydet,
            this.TSMI_FarkliKaydet,
            this.TSS2,
            this.TSMI_Kapat});
            this.TSMIB_Dosya.Name = "TSMIB_Dosya";
            this.TSMIB_Dosya.Size = new System.Drawing.Size(51, 20);
            this.TSMIB_Dosya.Text = "Dosya";
            // 
            // TMSI_Yeni
            // 
            this.TMSI_Yeni.Name = "TMSI_Yeni";
            this.TMSI_Yeni.Size = new System.Drawing.Size(180, 22);
            this.TMSI_Yeni.Text = "Yeni";
            // 
            // TSMI_Ac
            // 
            this.TSMI_Ac.Name = "TSMI_Ac";
            this.TSMI_Ac.Size = new System.Drawing.Size(180, 22);
            this.TSMI_Ac.Text = "Aç";
            this.TSMI_Ac.Click += new System.EventHandler(this.TSMI_Ac_Click);
            // 
            // TSS1
            // 
            this.TSS1.Name = "TSS1";
            this.TSS1.Size = new System.Drawing.Size(177, 6);
            // 
            // TSMI_Kaydet
            // 
            this.TSMI_Kaydet.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_Kaydet.Image")));
            this.TSMI_Kaydet.Name = "TSMI_Kaydet";
            this.TSMI_Kaydet.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.TSMI_Kaydet.Size = new System.Drawing.Size(180, 22);
            this.TSMI_Kaydet.Text = "Kaydet";
            this.TSMI_Kaydet.Click += new System.EventHandler(this.TSMI_Kaydet_Click);
            // 
            // TSMI_FarkliKaydet
            // 
            this.TSMI_FarkliKaydet.Name = "TSMI_FarkliKaydet";
            this.TSMI_FarkliKaydet.Size = new System.Drawing.Size(180, 22);
            this.TSMI_FarkliKaydet.Text = "Farklı Kaydet";
            // 
            // TSS2
            // 
            this.TSS2.Name = "TSS2";
            this.TSS2.Size = new System.Drawing.Size(177, 6);
            // 
            // TSMI_Kapat
            // 
            this.TSMI_Kapat.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_Kapat.Image")));
            this.TSMI_Kapat.Name = "TSMI_Kapat";
            this.TSMI_Kapat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.TSMI_Kapat.Size = new System.Drawing.Size(180, 22);
            this.TSMI_Kapat.Text = "Kapat";
            this.TSMI_Kapat.Click += new System.EventHandler(this.TSMI_Kapat_Click);
            // 
            // TSMIB_Duzen
            // 
            this.TSMIB_Duzen.Name = "TSMIB_Duzen";
            this.TSMIB_Duzen.Size = new System.Drawing.Size(52, 20);
            this.TSMIB_Duzen.Text = "Düzen";
            // 
            // TSMIB_Yardim
            // 
            this.TSMIB_Yardim.Name = "TSMIB_Yardim";
            this.TSMIB_Yardim.Size = new System.Drawing.Size(56, 20);
            this.TSMIB_Yardim.Text = "Yardım";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.richTextBox1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 401);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.MenuS_1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 401);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Kaydet});
            this.toolStrip1.Location = new System.Drawing.Point(3, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(57, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSB_Kaydet
            // 
            this.TSB_Kaydet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Kaydet.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Kaydet.Image")));
            this.TSB_Kaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Kaydet.Name = "TSB_Kaydet";
            this.TSB_Kaydet.Size = new System.Drawing.Size(23, 22);
            this.TSB_Kaydet.Text = "Kaydet";
            this.TSB_Kaydet.Click += new System.EventHandler(this.TSMI_Kaydet_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.MenuS_1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MenuS_1.ResumeLayout(false);
            this.MenuS_1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuS_1;
        private System.Windows.Forms.ToolStripMenuItem TSMIB_Dosya;
        private System.Windows.Forms.ToolStripMenuItem TMSI_Yeni;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Ac;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Kaydet;
        private System.Windows.Forms.ToolStripMenuItem TSMI_FarkliKaydet;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Kapat;
        private System.Windows.Forms.ToolStripSeparator TSS1;
        private System.Windows.Forms.ToolStripSeparator TSS2;
        private System.Windows.Forms.ToolStripMenuItem TSMIB_Duzen;
        private System.Windows.Forms.ToolStripMenuItem TSMIB_Yardim;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_Kaydet;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}


namespace WinFormKontrolleri
{
    partial class RadioButton
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
            this.GB_Cinsiyet = new System.Windows.Forms.GroupBox();
            this.RB_Erkek = new System.Windows.Forms.RadioButton();
            this.RB_Kadin = new System.Windows.Forms.RadioButton();
            this.GB_MedeniHal = new System.Windows.Forms.GroupBox();
            this.RB_Evli = new System.Windows.Forms.RadioButton();
            this.RB_Bekar = new System.Windows.Forms.RadioButton();
            this.LBL_Sonuc = new System.Windows.Forms.Label();
            this.BTN_Getir = new System.Windows.Forms.Button();
            this.BTN_GizleGoster = new System.Windows.Forms.Button();
            this.GB_Cinsiyet.SuspendLayout();
            this.GB_MedeniHal.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Cinsiyet
            // 
            this.GB_Cinsiyet.Controls.Add(this.RB_Kadin);
            this.GB_Cinsiyet.Controls.Add(this.RB_Erkek);
            this.GB_Cinsiyet.Location = new System.Drawing.Point(12, 12);
            this.GB_Cinsiyet.Name = "GB_Cinsiyet";
            this.GB_Cinsiyet.Size = new System.Drawing.Size(97, 66);
            this.GB_Cinsiyet.TabIndex = 0;
            this.GB_Cinsiyet.TabStop = false;
            this.GB_Cinsiyet.Text = "Cinsiyet";
            // 
            // RB_Erkek
            // 
            this.RB_Erkek.AutoSize = true;
            this.RB_Erkek.Location = new System.Drawing.Point(7, 20);
            this.RB_Erkek.Name = "RB_Erkek";
            this.RB_Erkek.Size = new System.Drawing.Size(53, 17);
            this.RB_Erkek.TabIndex = 0;
            this.RB_Erkek.Text = "Erkek";
            this.RB_Erkek.UseVisualStyleBackColor = true;
            // 
            // RB_Kadin
            // 
            this.RB_Kadin.AutoSize = true;
            this.RB_Kadin.Location = new System.Drawing.Point(7, 44);
            this.RB_Kadin.Name = "RB_Kadin";
            this.RB_Kadin.Size = new System.Drawing.Size(52, 17);
            this.RB_Kadin.TabIndex = 1;
            this.RB_Kadin.Text = "Kadın";
            this.RB_Kadin.UseVisualStyleBackColor = true;
            // 
            // GB_MedeniHal
            // 
            this.GB_MedeniHal.Controls.Add(this.RB_Evli);
            this.GB_MedeniHal.Controls.Add(this.RB_Bekar);
            this.GB_MedeniHal.Location = new System.Drawing.Point(115, 12);
            this.GB_MedeniHal.Name = "GB_MedeniHal";
            this.GB_MedeniHal.Size = new System.Drawing.Size(97, 66);
            this.GB_MedeniHal.TabIndex = 1;
            this.GB_MedeniHal.TabStop = false;
            this.GB_MedeniHal.Text = "Medeni Hal";
            // 
            // RB_Evli
            // 
            this.RB_Evli.AutoSize = true;
            this.RB_Evli.Location = new System.Drawing.Point(7, 44);
            this.RB_Evli.Name = "RB_Evli";
            this.RB_Evli.Size = new System.Drawing.Size(42, 17);
            this.RB_Evli.TabIndex = 1;
            this.RB_Evli.Text = "Evli";
            this.RB_Evli.UseVisualStyleBackColor = true;
            // 
            // RB_Bekar
            // 
            this.RB_Bekar.AutoSize = true;
            this.RB_Bekar.Location = new System.Drawing.Point(7, 20);
            this.RB_Bekar.Name = "RB_Bekar";
            this.RB_Bekar.Size = new System.Drawing.Size(53, 17);
            this.RB_Bekar.TabIndex = 0;
            this.RB_Bekar.Text = "Bekar";
            this.RB_Bekar.UseVisualStyleBackColor = true;
            // 
            // LBL_Sonuc
            // 
            this.LBL_Sonuc.AutoSize = true;
            this.LBL_Sonuc.Location = new System.Drawing.Point(13, 85);
            this.LBL_Sonuc.Name = "LBL_Sonuc";
            this.LBL_Sonuc.Size = new System.Drawing.Size(38, 13);
            this.LBL_Sonuc.TabIndex = 2;
            this.LBL_Sonuc.Text = "Sonuc";
            // 
            // BTN_Getir
            // 
            this.BTN_Getir.Location = new System.Drawing.Point(219, 54);
            this.BTN_Getir.Name = "BTN_Getir";
            this.BTN_Getir.Size = new System.Drawing.Size(75, 23);
            this.BTN_Getir.TabIndex = 3;
            this.BTN_Getir.Text = "Getir";
            this.BTN_Getir.UseVisualStyleBackColor = true;
            this.BTN_Getir.Click += new System.EventHandler(this.BTN_Getir_Click);
            // 
            // BTN_GizleGoster
            // 
            this.BTN_GizleGoster.Location = new System.Drawing.Point(219, 85);
            this.BTN_GizleGoster.Name = "BTN_GizleGoster";
            this.BTN_GizleGoster.Size = new System.Drawing.Size(75, 23);
            this.BTN_GizleGoster.TabIndex = 4;
            this.BTN_GizleGoster.Text = "Gizle";
            this.BTN_GizleGoster.UseVisualStyleBackColor = true;
            this.BTN_GizleGoster.Click += new System.EventHandler(this.BTN_GizleGoster_Click);
            // 
            // RadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_GizleGoster);
            this.Controls.Add(this.BTN_Getir);
            this.Controls.Add(this.LBL_Sonuc);
            this.Controls.Add(this.GB_MedeniHal);
            this.Controls.Add(this.GB_Cinsiyet);
            this.Name = "RadioButton";
            this.Text = "RadioButton";
            this.GB_Cinsiyet.ResumeLayout(false);
            this.GB_Cinsiyet.PerformLayout();
            this.GB_MedeniHal.ResumeLayout(false);
            this.GB_MedeniHal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Cinsiyet;
        private System.Windows.Forms.RadioButton RB_Kadin;
        private System.Windows.Forms.RadioButton RB_Erkek;
        private System.Windows.Forms.GroupBox GB_MedeniHal;
        private System.Windows.Forms.RadioButton RB_Evli;
        private System.Windows.Forms.RadioButton RB_Bekar;
        private System.Windows.Forms.Label LBL_Sonuc;
        private System.Windows.Forms.Button BTN_Getir;
        private System.Windows.Forms.Button BTN_GizleGoster;
    }
}
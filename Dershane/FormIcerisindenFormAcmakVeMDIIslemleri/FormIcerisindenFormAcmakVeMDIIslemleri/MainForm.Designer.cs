namespace FormIcerisindenFormAcmakVeMDIIslemleri
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
            this.BTN_ChieldFormAc = new System.Windows.Forms.Button();
            this.BTN_ChieldFormAcIki = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_ChieldFormAc
            // 
            this.BTN_ChieldFormAc.Location = new System.Drawing.Point(13, 13);
            this.BTN_ChieldFormAc.Name = "BTN_ChieldFormAc";
            this.BTN_ChieldFormAc.Size = new System.Drawing.Size(95, 23);
            this.BTN_ChieldFormAc.TabIndex = 1;
            this.BTN_ChieldFormAc.Text = "Chield Form Aç";
            this.BTN_ChieldFormAc.UseVisualStyleBackColor = true;
            this.BTN_ChieldFormAc.Click += new System.EventHandler(this.BTN_ChieldFormAc_Click);
            // 
            // BTN_ChieldFormAcIki
            // 
            this.BTN_ChieldFormAcIki.Location = new System.Drawing.Point(114, 13);
            this.BTN_ChieldFormAcIki.Name = "BTN_ChieldFormAcIki";
            this.BTN_ChieldFormAcIki.Size = new System.Drawing.Size(95, 23);
            this.BTN_ChieldFormAcIki.TabIndex = 2;
            this.BTN_ChieldFormAcIki.Text = "Chield Form Aç";
            this.BTN_ChieldFormAcIki.UseVisualStyleBackColor = true;
            this.BTN_ChieldFormAcIki.Click += new System.EventHandler(this.BTN_ChieldFormAcIki_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_ChieldFormAcIki);
            this.Controls.Add(this.BTN_ChieldFormAc);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_ChieldFormAc;
        private System.Windows.Forms.Button BTN_ChieldFormAcIki;
    }
}
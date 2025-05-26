namespace FormIcerisindenFormAcmakVeMDIIslemleri
{
    partial class IkinciBilgiFormu
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
            this.BTN_Kapat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Kapat
            // 
            this.BTN_Kapat.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_Kapat.Location = new System.Drawing.Point(292, 250);
            this.BTN_Kapat.Name = "BTN_Kapat";
            this.BTN_Kapat.Size = new System.Drawing.Size(185, 94);
            this.BTN_Kapat.TabIndex = 3;
            this.BTN_Kapat.Text = "Kapat";
            this.BTN_Kapat.UseVisualStyleBackColor = true;
            this.BTN_Kapat.Click += new System.EventHandler(this.BTN_Kapat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(141, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 86);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ben 2. Formum";
            // 
            // IkınciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_Kapat);
            this.Controls.Add(this.label1);
            this.Name = "IkınciForm";
            this.Text = "İkinci Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Kapat;
        private System.Windows.Forms.Label label1;
    }
}
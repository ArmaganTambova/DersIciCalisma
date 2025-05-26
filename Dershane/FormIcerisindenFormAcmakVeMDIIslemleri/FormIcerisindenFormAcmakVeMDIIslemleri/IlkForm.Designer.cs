namespace FormIcerisindenFormAcmakVeMDIIslemleri
{
    partial class IlkForm
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
            this.BTN_FormAc = new System.Windows.Forms.Button();
            this.LBL_DialogOlarakAc = new System.Windows.Forms.Label();
            this.BTN_DialogPenceresiOlarakAc = new System.Windows.Forms.Button();
            this.BTN_BirTaneAc = new System.Windows.Forms.Button();
            this.LBL_BiTaneFormAc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_FormAc
            // 
            this.BTN_FormAc.Location = new System.Drawing.Point(12, 13);
            this.BTN_FormAc.Name = "BTN_FormAc";
            this.BTN_FormAc.Size = new System.Drawing.Size(161, 23);
            this.BTN_FormAc.TabIndex = 0;
            this.BTN_FormAc.Text = "Form Aç";
            this.BTN_FormAc.UseVisualStyleBackColor = true;
            this.BTN_FormAc.Click += new System.EventHandler(this.BTN_FormAc_Click);
            // 
            // LBL_DialogOlarakAc
            // 
            this.LBL_DialogOlarakAc.AutoSize = true;
            this.LBL_DialogOlarakAc.Location = new System.Drawing.Point(179, 47);
            this.LBL_DialogOlarakAc.Name = "LBL_DialogOlarakAc";
            this.LBL_DialogOlarakAc.Size = new System.Drawing.Size(137, 13);
            this.LBL_DialogOlarakAc.TabIndex = 1;
            this.LBL_DialogOlarakAc.Text = "Dialog Penceresi Olarak Aç";
            // 
            // BTN_DialogPenceresiOlarakAc
            // 
            this.BTN_DialogPenceresiOlarakAc.Location = new System.Drawing.Point(12, 42);
            this.BTN_DialogPenceresiOlarakAc.Name = "BTN_DialogPenceresiOlarakAc";
            this.BTN_DialogPenceresiOlarakAc.Size = new System.Drawing.Size(161, 23);
            this.BTN_DialogPenceresiOlarakAc.TabIndex = 2;
            this.BTN_DialogPenceresiOlarakAc.Text = "Dialog Penceresi Olarak Aç";
            this.BTN_DialogPenceresiOlarakAc.UseVisualStyleBackColor = true;
            this.BTN_DialogPenceresiOlarakAc.Click += new System.EventHandler(this.BTN_DialogPenceresiOlarakAc_Click);
            // 
            // BTN_BirTaneAc
            // 
            this.BTN_BirTaneAc.Location = new System.Drawing.Point(12, 71);
            this.BTN_BirTaneAc.Name = "BTN_BirTaneAc";
            this.BTN_BirTaneAc.Size = new System.Drawing.Size(161, 23);
            this.BTN_BirTaneAc.TabIndex = 4;
            this.BTN_BirTaneAc.Text = "Bir Tane Form Aç";
            this.BTN_BirTaneAc.UseVisualStyleBackColor = true;
            this.BTN_BirTaneAc.Click += new System.EventHandler(this.BTN_BirTaneAc_Click);
            // 
            // LBL_BiTaneFormAc
            // 
            this.LBL_BiTaneFormAc.AutoSize = true;
            this.LBL_BiTaneFormAc.Location = new System.Drawing.Point(179, 76);
            this.LBL_BiTaneFormAc.Name = "LBL_BiTaneFormAc";
            this.LBL_BiTaneFormAc.Size = new System.Drawing.Size(89, 13);
            this.LBL_BiTaneFormAc.TabIndex = 3;
            this.LBL_BiTaneFormAc.Text = "Bir Tane Form Aç";
            // 
            // IlkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_BirTaneAc);
            this.Controls.Add(this.LBL_BiTaneFormAc);
            this.Controls.Add(this.BTN_DialogPenceresiOlarakAc);
            this.Controls.Add(this.LBL_DialogOlarakAc);
            this.Controls.Add(this.BTN_FormAc);
            this.Name = "IlkForm";
            this.Text = "İlk Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_FormAc;
        private System.Windows.Forms.Label LBL_DialogOlarakAc;
        private System.Windows.Forms.Button BTN_DialogPenceresiOlarakAc;
        private System.Windows.Forms.Button BTN_BirTaneAc;
        private System.Windows.Forms.Label LBL_BiTaneFormAc;
    }
}


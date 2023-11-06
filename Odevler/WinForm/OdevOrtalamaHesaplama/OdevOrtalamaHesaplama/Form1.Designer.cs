namespace OdevOrtalamaHesaplama
{
    partial class Form1
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
            this.LBL_Not1 = new System.Windows.Forms.Label();
            this.LBL_Not2 = new System.Windows.Forms.Label();
            this.TB_Not1 = new System.Windows.Forms.TextBox();
            this.TB_Not2 = new System.Windows.Forms.TextBox();
            this.BTN_Ortalama = new System.Windows.Forms.Button();
            this.LBL_Ortalama = new System.Windows.Forms.Label();
            this.TB_Ortalama = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LBL_Not1
            // 
            this.LBL_Not1.AutoSize = true;
            this.LBL_Not1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_Not1.Location = new System.Drawing.Point(12, 10);
            this.LBL_Not1.Name = "LBL_Not1";
            this.LBL_Not1.Size = new System.Drawing.Size(41, 16);
            this.LBL_Not1.TabIndex = 0;
            this.LBL_Not1.Text = "Not 1:";
            // 
            // LBL_Not2
            // 
            this.LBL_Not2.AutoSize = true;
            this.LBL_Not2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_Not2.Location = new System.Drawing.Point(12, 40);
            this.LBL_Not2.Name = "LBL_Not2";
            this.LBL_Not2.Size = new System.Drawing.Size(41, 16);
            this.LBL_Not2.TabIndex = 1;
            this.LBL_Not2.Text = "Not 2:";
            // 
            // TB_Not1
            // 
            this.TB_Not1.Location = new System.Drawing.Point(60, 10);
            this.TB_Not1.Name = "TB_Not1";
            this.TB_Not1.Size = new System.Drawing.Size(216, 20);
            this.TB_Not1.TabIndex = 2;
            // 
            // TB_Not2
            // 
            this.TB_Not2.Location = new System.Drawing.Point(60, 40);
            this.TB_Not2.Name = "TB_Not2";
            this.TB_Not2.Size = new System.Drawing.Size(216, 20);
            this.TB_Not2.TabIndex = 3;
            // 
            // BTN_Ortalama
            // 
            this.BTN_Ortalama.Location = new System.Drawing.Point(290, 10);
            this.BTN_Ortalama.Name = "BTN_Ortalama";
            this.BTN_Ortalama.Size = new System.Drawing.Size(75, 50);
            this.BTN_Ortalama.TabIndex = 4;
            this.BTN_Ortalama.Text = "Ortalama Hesapla";
            this.BTN_Ortalama.UseVisualStyleBackColor = true;
            this.BTN_Ortalama.Click += new System.EventHandler(this.BTN_Ortalama_Click);
            // 
            // LBL_Ortalama
            // 
            this.LBL_Ortalama.AutoSize = true;
            this.LBL_Ortalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_Ortalama.Location = new System.Drawing.Point(12, 86);
            this.LBL_Ortalama.Name = "LBL_Ortalama";
            this.LBL_Ortalama.Size = new System.Drawing.Size(81, 16);
            this.LBL_Ortalama.TabIndex = 5;
            this.LBL_Ortalama.Text = "Ortalamanız:";
            // 
            // TB_Ortalama
            // 
            this.TB_Ortalama.Location = new System.Drawing.Point(99, 86);
            this.TB_Ortalama.Name = "TB_Ortalama";
            this.TB_Ortalama.Size = new System.Drawing.Size(177, 20);
            this.TB_Ortalama.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 125);
            this.Controls.Add(this.TB_Ortalama);
            this.Controls.Add(this.LBL_Ortalama);
            this.Controls.Add(this.BTN_Ortalama);
            this.Controls.Add(this.TB_Not2);
            this.Controls.Add(this.TB_Not1);
            this.Controls.Add(this.LBL_Not2);
            this.Controls.Add(this.LBL_Not1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Not1;
        private System.Windows.Forms.Label LBL_Not2;
        private System.Windows.Forms.TextBox TB_Not1;
        private System.Windows.Forms.TextBox TB_Not2;
        private System.Windows.Forms.Button BTN_Ortalama;
        private System.Windows.Forms.Label LBL_Ortalama;
        private System.Windows.Forms.TextBox TB_Ortalama;
    }
}


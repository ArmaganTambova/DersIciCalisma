namespace RichTextBoxKontrolu
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BTN_Ac = new System.Windows.Forms.Button();
            this.BTN_Kaydet = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 17);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(322, 475);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // BTN_Ac
            // 
            this.BTN_Ac.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_Ac.Location = new System.Drawing.Point(345, 17);
            this.BTN_Ac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_Ac.Name = "BTN_Ac";
            this.BTN_Ac.Size = new System.Drawing.Size(123, 46);
            this.BTN_Ac.TabIndex = 1;
            this.BTN_Ac.Text = "Aç";
            this.BTN_Ac.UseVisualStyleBackColor = true;
            this.BTN_Ac.Click += new System.EventHandler(this.BTN_Ac_Click);
            // 
            // BTN_Kaydet
            // 
            this.BTN_Kaydet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_Kaydet.Location = new System.Drawing.Point(345, 71);
            this.BTN_Kaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_Kaydet.Name = "BTN_Kaydet";
            this.BTN_Kaydet.Size = new System.Drawing.Size(123, 46);
            this.BTN_Kaydet.TabIndex = 2;
            this.BTN_Kaydet.Text = "Kaydet";
            this.BTN_Kaydet.UseVisualStyleBackColor = true;
            this.BTN_Kaydet.Click += new System.EventHandler(this.BTN_Kaydet_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 505);
            this.Controls.Add(this.BTN_Kaydet);
            this.Controls.Add(this.BTN_Ac);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BTN_Ac;
        private System.Windows.Forms.Button BTN_Kaydet;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}


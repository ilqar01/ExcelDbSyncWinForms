namespace ExcelVTIntegrasyonProjesi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVtdenOku = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btnExceldenOku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVtdenOku
            // 
            this.btnVtdenOku.Location = new System.Drawing.Point(506, 105);
            this.btnVtdenOku.Name = "btnVtdenOku";
            this.btnVtdenOku.Size = new System.Drawing.Size(133, 74);
            this.btnVtdenOku.TabIndex = 0;
            this.btnVtdenOku.Text = "Veri tabanindan oku ve Excel e yaz";
            this.btnVtdenOku.UseVisualStyleBackColor = true;
            this.btnVtdenOku.Click += new System.EventHandler(this.btnVtdenOku_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(30, 81);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(343, 120);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(30, 263);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(343, 120);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // btnExceldenOku
            // 
            this.btnExceldenOku.Location = new System.Drawing.Point(506, 281);
            this.btnExceldenOku.Name = "btnExceldenOku";
            this.btnExceldenOku.Size = new System.Drawing.Size(133, 74);
            this.btnExceldenOku.TabIndex = 3;
            this.btnExceldenOku.Text = "Excel den oku ve veri tabanina yaz";
            this.btnExceldenOku.UseVisualStyleBackColor = true;
            this.btnExceldenOku.Click += new System.EventHandler(this.btnExceldenOku_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExceldenOku);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnVtdenOku);
            this.Name = "Form1";
            this.Text = "VeriTabaniExcelIntegrasyon";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnVtdenOku;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button btnExceldenOku;
    }
}
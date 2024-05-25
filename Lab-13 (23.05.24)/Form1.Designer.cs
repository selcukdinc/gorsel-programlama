namespace Lab_13__23._05._24_
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
            this.btnOlustur = new System.Windows.Forms.Button();
            this.btnDosyaDurum = new System.Windows.Forms.Button();
            this.tbDosyaAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUzanti = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(95, 167);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(101, 23);
            this.btnOlustur.TabIndex = 0;
            this.btnOlustur.Text = "Dosya Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // btnDosyaDurum
            // 
            this.btnDosyaDurum.Location = new System.Drawing.Point(279, 167);
            this.btnDosyaDurum.Name = "btnDosyaDurum";
            this.btnDosyaDurum.Size = new System.Drawing.Size(101, 23);
            this.btnDosyaDurum.TabIndex = 1;
            this.btnDosyaDurum.Text = "Dosyayı kontrol et";
            this.btnDosyaDurum.UseVisualStyleBackColor = true;
            this.btnDosyaDurum.Click += new System.EventHandler(this.btnDosyaDurum_Click);
            // 
            // tbDosyaAdi
            // 
            this.tbDosyaAdi.Location = new System.Drawing.Point(158, 101);
            this.tbDosyaAdi.Name = "tbDosyaAdi";
            this.tbDosyaAdi.Size = new System.Drawing.Size(100, 20);
            this.tbDosyaAdi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dosya Adı: ";
            // 
            // cbUzanti
            // 
            this.cbUzanti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUzanti.FormattingEnabled = true;
            this.cbUzanti.Items.AddRange(new object[] {
            ".ini",
            ".txt"});
            this.cbUzanti.Location = new System.Drawing.Point(279, 101);
            this.cbUzanti.Name = "cbUzanti";
            this.cbUzanti.Size = new System.Drawing.Size(93, 21);
            this.cbUzanti.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 316);
            this.Controls.Add(this.cbUzanti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDosyaAdi);
            this.Controls.Add(this.btnDosyaDurum);
            this.Controls.Add(this.btnOlustur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Button btnDosyaDurum;
        private System.Windows.Forms.TextBox tbDosyaAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUzanti;
    }
}


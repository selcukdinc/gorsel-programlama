namespace FinalPratik_RandevuSistemi
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
            this.tbRandevuID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dtpTarihSec = new System.Windows.Forms.DateTimePicker();
            this.cbRandevuTuru = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIsim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSifre = new System.Windows.Forms.TextBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRandevuListele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbRandevuID
            // 
            this.tbRandevuID.Location = new System.Drawing.Point(103, 54);
            this.tbRandevuID.Name = "tbRandevuID";
            this.tbRandevuID.Size = new System.Drawing.Size(121, 20);
            this.tbRandevuID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Randevu ID : ";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(12, 222);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 23);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dtpTarihSec
            // 
            this.dtpTarihSec.Location = new System.Drawing.Point(347, 51);
            this.dtpTarihSec.MinDate = new System.DateTime(2024, 6, 12, 0, 0, 0, 0);
            this.dtpTarihSec.Name = "dtpTarihSec";
            this.dtpTarihSec.Size = new System.Drawing.Size(200, 20);
            this.dtpTarihSec.TabIndex = 3;
            this.dtpTarihSec.Value = new System.DateTime(2024, 6, 12, 0, 0, 0, 0);
            // 
            // cbRandevuTuru
            // 
            this.cbRandevuTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRandevuTuru.FormattingEnabled = true;
            this.cbRandevuTuru.Location = new System.Drawing.Point(103, 157);
            this.cbRandevuTuru.Name = "cbRandevuTuru";
            this.cbRandevuTuru.Size = new System.Drawing.Size(121, 21);
            this.cbRandevuTuru.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Randevu Oluştur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "İsim : ";
            // 
            // tbIsim
            // 
            this.tbIsim.Location = new System.Drawing.Point(103, 85);
            this.tbIsim.Name = "tbIsim";
            this.tbIsim.Size = new System.Drawing.Size(121, 20);
            this.tbIsim.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Şifre : ";
            // 
            // tbSifre
            // 
            this.tbSifre.Location = new System.Drawing.Point(103, 124);
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.Size = new System.Drawing.Size(121, 20);
            this.tbSifre.TabIndex = 8;
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(124, 222);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(100, 23);
            this.btnIptal.TabIndex = 10;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tarih Seçici : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Randevu Türü : ";
            // 
            // btnRandevuListele
            // 
            this.btnRandevuListele.Location = new System.Drawing.Point(335, 222);
            this.btnRandevuListele.Name = "btnRandevuListele";
            this.btnRandevuListele.Size = new System.Drawing.Size(121, 23);
            this.btnRandevuListele.TabIndex = 13;
            this.btnRandevuListele.Text = "Randevuları Listele";
            this.btnRandevuListele.UseVisualStyleBackColor = true;
            this.btnRandevuListele.Click += new System.EventHandler(this.btnRandevuListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRandevuListele);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbIsim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbRandevuTuru);
            this.Controls.Add(this.dtpTarihSec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRandevuID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRandevuID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DateTimePicker dtpTarihSec;
        private System.Windows.Forms.ComboBox cbRandevuTuru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIsim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSifre;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRandevuListele;
    }
}


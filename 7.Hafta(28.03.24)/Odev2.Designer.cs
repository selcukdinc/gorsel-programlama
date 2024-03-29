namespace _7.Hafta_28._03._24_
{
    partial class Odev2
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbSay1 = new System.Windows.Forms.TextBox();
            this.tbSay2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbIslemler = new System.Windows.Forms.ComboBox();
            this.tbSonuc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbElemanListe = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTabOrder = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTaborder = new System.Windows.Forms.Button();
            this.btnAktar = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Sayı:";
            // 
            // tbSay1
            // 
            this.tbSay1.Location = new System.Drawing.Point(101, 38);
            this.tbSay1.Name = "tbSay1";
            this.tbSay1.Size = new System.Drawing.Size(133, 25);
            this.tbSay1.TabIndex = 1;
            // 
            // tbSay2
            // 
            this.tbSay2.Location = new System.Drawing.Point(101, 69);
            this.tbSay2.Name = "tbSay2";
            this.tbSay2.Size = new System.Drawing.Size(133, 25);
            this.tbSay2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "2. Sayı:";
            // 
            // cbIslemler
            // 
            this.cbIslemler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIslemler.FormattingEnabled = true;
            this.cbIslemler.Items.AddRange(new object[] {
            "Topla",
            "Çıkar",
            "Böl",
            "Çarp"});
            this.cbIslemler.Location = new System.Drawing.Point(12, 100);
            this.cbIslemler.Name = "cbIslemler";
            this.cbIslemler.Size = new System.Drawing.Size(222, 25);
            this.cbIslemler.TabIndex = 4;
            this.cbIslemler.SelectedIndexChanged += new System.EventHandler(this.cbIslemler_SelectedIndexChanged);
            // 
            // tbSonuc
            // 
            this.tbSonuc.Location = new System.Drawing.Point(101, 131);
            this.tbSonuc.Name = "tbSonuc";
            this.tbSonuc.Size = new System.Drawing.Size(133, 25);
            this.tbSonuc.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sonuç: ";
            // 
            // lbElemanListe
            // 
            this.lbElemanListe.FormattingEnabled = true;
            this.lbElemanListe.ItemHeight = 17;
            this.lbElemanListe.Location = new System.Drawing.Point(240, 41);
            this.lbElemanListe.Name = "lbElemanListe";
            this.lbElemanListe.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbElemanListe.Size = new System.Drawing.Size(205, 208);
            this.lbElemanListe.TabIndex = 7;
            this.lbElemanListe.DoubleClick += new System.EventHandler(this.lbElemanListe_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Buton ve Textboxlar";
            // 
            // lbTabOrder
            // 
            this.lbTabOrder.FormattingEnabled = true;
            this.lbTabOrder.ItemHeight = 17;
            this.lbTabOrder.Location = new System.Drawing.Point(451, 41);
            this.lbTabOrder.Name = "lbTabOrder";
            this.lbTabOrder.Size = new System.Drawing.Size(201, 208);
            this.lbTabOrder.TabIndex = 9;
            this.lbTabOrder.DoubleClick += new System.EventHandler(this.lbTabOrder_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tab order Listesi";
            // 
            // btnTaborder
            // 
            this.btnTaborder.Location = new System.Drawing.Point(451, 255);
            this.btnTaborder.Name = "btnTaborder";
            this.btnTaborder.Size = new System.Drawing.Size(97, 23);
            this.btnTaborder.TabIndex = 11;
            this.btnTaborder.Text = "Taborder";
            this.btnTaborder.UseVisualStyleBackColor = true;
            this.btnTaborder.Click += new System.EventHandler(this.btnTaborder_Click);
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(240, 255);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(97, 23);
            this.btnAktar.TabIndex = 12;
            this.btnAktar.Text = "Aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(554, 255);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(97, 23);
            this.btnTemizle.TabIndex = 13;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Odev2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 293);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.btnTaborder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTabOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbElemanListe);
            this.Controls.Add(this.tbSonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbIslemler);
            this.Controls.Add(this.tbSay2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSay1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Odev2";
            this.Text = "Odev2";
            this.Load += new System.EventHandler(this.Odev2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSay1;
        private System.Windows.Forms.TextBox tbSay2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbIslemler;
        private System.Windows.Forms.TextBox tbSonuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbElemanListe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbTabOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTaborder;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.Button btnTemizle;
    }
}
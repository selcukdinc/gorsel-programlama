namespace _7.Hafta_28._03._24_
{
    partial class Odev3
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
            this.btnDogrula = new System.Windows.Forms.Button();
            this.btnAsalBul = new System.Windows.Forms.Button();
            this.tbDogrula = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbDogrula = new System.Windows.Forms.ListBox();
            this.lbAsal = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDogrula
            // 
            this.btnDogrula.Location = new System.Drawing.Point(177, 251);
            this.btnDogrula.Name = "btnDogrula";
            this.btnDogrula.Size = new System.Drawing.Size(153, 23);
            this.btnDogrula.TabIndex = 21;
            this.btnDogrula.Text = "Doğrula";
            this.btnDogrula.UseVisualStyleBackColor = true;
            this.btnDogrula.Click += new System.EventHandler(this.btnDogrula_Click);
            // 
            // btnAsalBul
            // 
            this.btnAsalBul.Location = new System.Drawing.Point(12, 251);
            this.btnAsalBul.Name = "btnAsalBul";
            this.btnAsalBul.Size = new System.Drawing.Size(153, 23);
            this.btnAsalBul.TabIndex = 20;
            this.btnAsalBul.Text = "Asal Çarpanları bul";
            this.btnAsalBul.UseVisualStyleBackColor = true;
            this.btnAsalBul.Click += new System.EventHandler(this.btnAsalBul_Click);
            // 
            // tbDogrula
            // 
            this.tbDogrula.Location = new System.Drawing.Point(177, 17);
            this.tbDogrula.Name = "tbDogrula";
            this.tbDogrula.Size = new System.Drawing.Size(153, 20);
            this.tbDogrula.TabIndex = 19;
            this.tbDogrula.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbDogrula_KeyDown);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "45";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbDogrula
            // 
            this.lbDogrula.FormattingEnabled = true;
            this.lbDogrula.Location = new System.Drawing.Point(177, 46);
            this.lbDogrula.Name = "lbDogrula";
            this.lbDogrula.Size = new System.Drawing.Size(153, 199);
            this.lbDogrula.TabIndex = 17;
            // 
            // lbAsal
            // 
            this.lbAsal.FormattingEnabled = true;
            this.lbAsal.Location = new System.Drawing.Point(12, 46);
            this.lbAsal.Name = "lbAsal";
            this.lbAsal.Size = new System.Drawing.Size(153, 199);
            this.lbAsal.TabIndex = 16;
            // 
            // Odev3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 287);
            this.Controls.Add(this.btnDogrula);
            this.Controls.Add(this.btnAsalBul);
            this.Controls.Add(this.tbDogrula);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbDogrula);
            this.Controls.Add(this.lbAsal);
            this.Name = "Odev3";
            this.Text = "Odev3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDogrula;
        private System.Windows.Forms.Button btnAsalBul;
        private System.Windows.Forms.TextBox tbDogrula;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lbDogrula;
        private System.Windows.Forms.ListBox lbAsal;
    }
}
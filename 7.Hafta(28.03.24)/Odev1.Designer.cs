namespace _7.Hafta_28._03._24_
{
    partial class Odev1
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
            this.BtnSonraki = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lbMain = new System.Windows.Forms.ListBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSonraki
            // 
            this.BtnSonraki.Location = new System.Drawing.Point(117, 275);
            this.BtnSonraki.Name = "BtnSonraki";
            this.BtnSonraki.Size = new System.Drawing.Size(99, 23);
            this.BtnSonraki.TabIndex = 10;
            this.BtnSonraki.Text = "Sonraki";
            this.BtnSonraki.UseVisualStyleBackColor = true;
            this.BtnSonraki.Click += new System.EventHandler(this.BtnSonraki_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(12, 249);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(204, 20);
            this.txtAra.TabIndex = 9;
            // 
            // lbMain
            // 
            this.lbMain.FormattingEnabled = true;
            this.lbMain.Items.AddRange(new object[] {
            "den1",
            "den2",
            "den3",
            "den4",
            "den1"});
            this.lbMain.Location = new System.Drawing.Point(33, 9);
            this.lbMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbMain.Name = "lbMain";
            this.lbMain.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbMain.Size = new System.Drawing.Size(153, 199);
            this.lbMain.TabIndex = 8;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(12, 275);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(99, 23);
            this.btnAra.TabIndex = 11;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // Odev1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 308);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.BtnSonraki);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lbMain);
            this.Name = "Odev1";
            this.Text = "Odev1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSonraki;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ListBox lbMain;
        private System.Windows.Forms.Button btnAra;
    }
}
namespace _7.Hafta_28._03._24_
{
    partial class anaMenu
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
            this.btnForm1 = new System.Windows.Forms.Button();
            this.btnOdev1 = new System.Windows.Forms.Button();
            this.btnOdev3 = new System.Windows.Forms.Button();
            this.btnOdev2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnForm1
            // 
            this.btnForm1.Location = new System.Drawing.Point(263, 133);
            this.btnForm1.Name = "btnForm1";
            this.btnForm1.Size = new System.Drawing.Size(106, 53);
            this.btnForm1.TabIndex = 0;
            this.btnForm1.Text = "Form1";
            this.btnForm1.UseVisualStyleBackColor = true;
            this.btnForm1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btnOdev1
            // 
            this.btnOdev1.Location = new System.Drawing.Point(375, 133);
            this.btnOdev1.Name = "btnOdev1";
            this.btnOdev1.Size = new System.Drawing.Size(106, 53);
            this.btnOdev1.TabIndex = 1;
            this.btnOdev1.Text = "Ödev 1";
            this.btnOdev1.UseVisualStyleBackColor = true;
            this.btnOdev1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btnOdev3
            // 
            this.btnOdev3.Location = new System.Drawing.Point(375, 192);
            this.btnOdev3.Name = "btnOdev3";
            this.btnOdev3.Size = new System.Drawing.Size(106, 53);
            this.btnOdev3.TabIndex = 3;
            this.btnOdev3.Text = "Ödev 3";
            this.btnOdev3.UseVisualStyleBackColor = true;
            this.btnOdev3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btnOdev2
            // 
            this.btnOdev2.Location = new System.Drawing.Point(263, 192);
            this.btnOdev2.Name = "btnOdev2";
            this.btnOdev2.Size = new System.Drawing.Size(106, 53);
            this.btnOdev2.TabIndex = 2;
            this.btnOdev2.Text = "Ödev 2";
            this.btnOdev2.UseVisualStyleBackColor = true;
            this.btnOdev2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // anaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOdev3);
            this.Controls.Add(this.btnOdev2);
            this.Controls.Add(this.btnOdev1);
            this.Controls.Add(this.btnForm1);
            this.Name = "anaMenu";
            this.Text = "anaMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnForm1;
        private System.Windows.Forms.Button btnOdev1;
        private System.Windows.Forms.Button btnOdev3;
        private System.Windows.Forms.Button btnOdev2;
    }
}
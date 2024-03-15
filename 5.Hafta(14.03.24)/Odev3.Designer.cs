namespace _5.Hafta_14._03._24_
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
            this.txtKntrol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKntrl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKntrol
            // 
            this.txtKntrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKntrol.Location = new System.Drawing.Point(89, 64);
            this.txtKntrol.Name = "txtKntrol";
            this.txtKntrol.Size = new System.Drawing.Size(181, 31);
            this.txtKntrol.TabIndex = 0;
            this.txtKntrol.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC No:";
            // 
            // lblKntrl
            // 
            this.lblKntrl.AutoSize = true;
            this.lblKntrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKntrl.Location = new System.Drawing.Point(100, 28);
            this.lblKntrl.Name = "lblKntrl";
            this.lblKntrl.Size = new System.Drawing.Size(157, 20);
            this.lblKntrl.TabIndex = 3;
            this.lblKntrl.Text = "Kontrol: Geçerli Değil";
            // 
            // Odev3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 139);
            this.Controls.Add(this.lblKntrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKntrol);
            this.Name = "Odev3";
            this.Text = "Odev3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKntrol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKntrl;
    }
}
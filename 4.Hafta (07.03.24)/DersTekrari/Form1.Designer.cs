namespace DersTekrari
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lbl_Deg = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.btnRastgele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.White;
            this.trackBar1.Location = new System.Drawing.Point(97, 318);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(223, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lbl_Deg
            // 
            this.lbl_Deg.AutoSize = true;
            this.lbl_Deg.BackColor = System.Drawing.Color.White;
            this.lbl_Deg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Deg.Location = new System.Drawing.Point(93, 291);
            this.lbl_Deg.Name = "lbl_Deg";
            this.lbl_Deg.Size = new System.Drawing.Size(117, 24);
            this.lbl_Deg.TabIndex = 2;
            this.lbl_Deg.Text = "Opaklık : 100";
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnReset.BackgroundImage = global::DersTekrari.Properties.Resources.Car_Tire2_NBG;
            this.BtnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnReset.FlatAppearance.BorderSize = 0;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnReset.Location = new System.Drawing.Point(674, 12);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(111, 102);
            this.BtnReset.TabIndex = 3;
            this.BtnReset.Text = "Renk Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnRastgele
            // 
            this.btnRastgele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRastgele.BackgroundImage = global::DersTekrari.Properties.Resources.Car_Tire2_NBG;
            this.btnRastgele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRastgele.FlatAppearance.BorderSize = 0;
            this.btnRastgele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRastgele.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRastgele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRastgele.Location = new System.Drawing.Point(525, 12);
            this.btnRastgele.Name = "btnRastgele";
            this.btnRastgele.Size = new System.Drawing.Size(143, 102);
            this.btnRastgele.TabIndex = 4;
            this.btnRastgele.Text = "Rastgele Renk";
            this.btnRastgele.UseVisualStyleBackColor = false;
            this.btnRastgele.Click += new System.EventHandler(this.btnRastgele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::DersTekrari.Properties.Resources.Red_Car_NBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(797, 525);
            this.Controls.Add(this.btnRastgele);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.lbl_Deg);
            this.Controls.Add(this.trackBar1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lbl_Deg;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button btnRastgele;
    }
}


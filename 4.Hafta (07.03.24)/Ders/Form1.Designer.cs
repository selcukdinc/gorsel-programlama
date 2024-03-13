namespace _4.Hafta
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
            this.btnCncl = new System.Windows.Forms.Button();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.btnFnt = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblDgr = new System.Windows.Forms.Label();
            this.btnBckGrnd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCncl
            // 
            this.btnCncl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCncl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCncl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCncl.Location = new System.Drawing.Point(270, 263);
            this.btnCncl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCncl.Name = "btnCncl";
            this.btnCncl.Size = new System.Drawing.Size(138, 73);
            this.btnCncl.TabIndex = 0;
            this.btnCncl.Text = "Cancel";
            this.btnCncl.UseVisualStyleBackColor = true;
            this.btnCncl.Click += new System.EventHandler(this.btnCncl_Click);
            // 
            // btn_Accept
            // 
            this.btn_Accept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Accept.Location = new System.Drawing.Point(270, 182);
            this.btn_Accept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(138, 73);
            this.btn_Accept.TabIndex = 1;
            this.btn_Accept.Text = "Accept";
            this.btn_Accept.UseVisualStyleBackColor = true;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // btnFnt
            // 
            this.btnFnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFnt.Location = new System.Drawing.Point(125, 182);
            this.btnFnt.Name = "btnFnt";
            this.btnFnt.Size = new System.Drawing.Size(138, 73);
            this.btnFnt.TabIndex = 2;
            this.btnFnt.Text = "Font";
            this.btnFnt.UseVisualStyleBackColor = true;
            this.btnFnt.Click += new System.EventHandler(this.btnFnt_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar1.Location = new System.Drawing.Point(187, 385);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(221, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblDgr
            // 
            this.lblDgr.AutoSize = true;
            this.lblDgr.BackColor = System.Drawing.SystemColors.Control;
            this.lblDgr.Location = new System.Drawing.Point(184, 366);
            this.lblDgr.Name = "lblDgr";
            this.lblDgr.Size = new System.Drawing.Size(58, 16);
            this.lblDgr.TabIndex = 4;
            this.lblDgr.Text = "Değer: ";
            // 
            // btnBckGrnd
            // 
            this.btnBckGrnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBckGrnd.Location = new System.Drawing.Point(125, 261);
            this.btnBckGrnd.Name = "btnBckGrnd";
            this.btnBckGrnd.Size = new System.Drawing.Size(138, 73);
            this.btnBckGrnd.TabIndex = 5;
            this.btnBckGrnd.Text = "Renk Değiştir";
            this.btnBckGrnd.UseVisualStyleBackColor = true;
            this.btnBckGrnd.Click += new System.EventHandler(this.btnBckGrnd_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_Accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::_4.Hafta.Properties.Resources._00008_2948520105_V2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCncl;
            this.ClientSize = new System.Drawing.Size(540, 508);
            this.Controls.Add(this.btnBckGrnd);
            this.Controls.Add(this.lblDgr);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnFnt);
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.btnCncl);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCncl;
        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.Button btnFnt;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblDgr;
        private System.Windows.Forms.Button btnBckGrnd;
    }
}


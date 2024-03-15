namespace _5.Hafta_14._03._24_
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Odev1));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnIf = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnFor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ekle.ico");
            this.ımageList1.Images.SetKeyName(1, "iptal.ico");
            this.ımageList1.Images.SetKeyName(2, "sil.ico");
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "ekle.ico");
            this.ımageList2.Images.SetKeyName(1, "iptal.ico");
            this.ımageList2.Images.SetKeyName(2, "sil.ico");
            // 
            // btnIf
            // 
            this.btnIf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnIf.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIf.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIf.Location = new System.Drawing.Point(12, 12);
            this.btnIf.Name = "btnIf";
            this.btnIf.Size = new System.Drawing.Size(97, 38);
            this.btnIf.TabIndex = 0;
            this.btnIf.Text = "If";
            this.btnIf.UseVisualStyleBackColor = false;
            this.btnIf.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnIf_MouseDown);
            this.btnIf.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnIf_MouseMove);
            this.btnIf.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnIf_MouseUp);
            // 
            // btnWhile
            // 
            this.btnWhile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnWhile.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnWhile.ForeColor = System.Drawing.Color.Black;
            this.btnWhile.Location = new System.Drawing.Point(12, 56);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(97, 37);
            this.btnWhile.TabIndex = 1;
            this.btnWhile.Text = "While";
            this.btnWhile.UseVisualStyleBackColor = false;
            this.btnWhile.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnWhile_MouseDown);
            this.btnWhile.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnWhile_MouseMove);
            this.btnWhile.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnWhile_MouseUp);
            // 
            // btnFor
            // 
            this.btnFor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFor.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFor.Location = new System.Drawing.Point(12, 99);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(97, 37);
            this.btnFor.TabIndex = 2;
            this.btnFor.Text = "For";
            this.btnFor.UseVisualStyleBackColor = false;
            this.btnFor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFor_MouseDown);
            this.btnFor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnFor_MouseMove);
            this.btnFor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnFor_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 450);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Odev1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnIf);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Odev1";
            this.Text = "Odev1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Button btnIf;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
namespace DersTekrari
{
    partial class Secenekler
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
            this.btnEvet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnHayir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEvet
            // 
            this.btnEvet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEvet.BackgroundImage = global::DersTekrari.Properties.Resources.Car_Tire_NBG;
            this.btnEvet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEvet.FlatAppearance.BorderSize = 0;
            this.btnEvet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvet.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEvet.ImageKey = "(none)";
            this.btnEvet.Location = new System.Drawing.Point(34, 294);
            this.btnEvet.Name = "btnEvet";
            this.btnEvet.Size = new System.Drawing.Size(105, 91);
            this.btnEvet.TabIndex = 0;
            this.btnEvet.Text = "Evet";
            this.btnEvet.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Programdan çıkılsın mı?";
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIptal.BackgroundImage = global::DersTekrari.Properties.Resources.Car_Tire_NBG;
            this.btnIptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIptal.FlatAppearance.BorderSize = 0;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIptal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnIptal.ImageKey = "(none)";
            this.btnIptal.Location = new System.Drawing.Point(485, 294);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(105, 91);
            this.btnIptal.TabIndex = 3;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            // 
            // btnHayir
            // 
            this.btnHayir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHayir.BackgroundImage = global::DersTekrari.Properties.Resources.Car_Tire_NBG;
            this.btnHayir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHayir.FlatAppearance.BorderSize = 0;
            this.btnHayir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHayir.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHayir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHayir.ImageKey = "(none)";
            this.btnHayir.Location = new System.Drawing.Point(250, 294);
            this.btnHayir.Name = "btnHayir";
            this.btnHayir.Size = new System.Drawing.Size(105, 91);
            this.btnHayir.TabIndex = 4;
            this.btnHayir.Text = "Hayır";
            this.btnHayir.UseVisualStyleBackColor = false;
            // 
            // Secenekler
            // 
            this.AcceptButton = this.btnEvet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::DersTekrari.Properties.Resources.Red_Car2_NBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.btnIptal;
            this.ClientSize = new System.Drawing.Size(664, 385);
            this.Controls.Add(this.btnHayir);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEvet);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Secenekler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Secenekler";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEvet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnHayir;
    }
}
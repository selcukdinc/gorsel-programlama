namespace _13.Hafta_16._05._24_
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpCreate = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlSheet = new System.Windows.Forms.Panel();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnForecolor = new System.Windows.Forms.Button();
            this.ımageListExcel = new System.Windows.Forms.ImageList(this.components);
            this.btnWrap = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnBackcolor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnCenter = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDeleteRowCloumn = new System.Windows.Forms.Button();
            this.tcMain.SuspendLayout();
            this.tpCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlSheet.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcMain.Controls.Add(this.tpCreate);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.ItemSize = new System.Drawing.Size(68, 20);
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Margin = new System.Windows.Forms.Padding(4);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1364, 614);
            this.tcMain.TabIndex = 1;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            // 
            // tpCreate
            // 
            this.tpCreate.Controls.Add(this.dataGridView1);
            this.tpCreate.Location = new System.Drawing.Point(4, 4);
            this.tpCreate.Margin = new System.Windows.Forms.Padding(4);
            this.tpCreate.Name = "tpCreate";
            this.tpCreate.Padding = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.tpCreate.Size = new System.Drawing.Size(1356, 586);
            this.tpCreate.TabIndex = 1;
            this.tpCreate.Text = "+ Yeni Sayfa";
            this.tpCreate.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(727, 412);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pnlSheet
            // 
            this.pnlSheet.Controls.Add(this.tcMain);
            this.pnlSheet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSheet.Location = new System.Drawing.Point(0, 113);
            this.pnlSheet.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSheet.Name = "pnlSheet";
            this.pnlSheet.Size = new System.Drawing.Size(1364, 614);
            this.pnlSheet.TabIndex = 2;
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.btnForecolor);
            this.pnlControl.Controls.Add(this.btnWrap);
            this.pnlControl.Controls.Add(this.btnFont);
            this.pnlControl.Controls.Add(this.btnBackcolor);
            this.pnlControl.Controls.Add(this.panel1);
            this.pnlControl.Controls.Add(this.btnDeleteRowCloumn);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControl.Location = new System.Drawing.Point(0, 0);
            this.pnlControl.Margin = new System.Windows.Forms.Padding(4);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(1364, 113);
            this.pnlControl.TabIndex = 3;
            // 
            // btnForecolor
            // 
            this.btnForecolor.FlatAppearance.BorderSize = 0;
            this.btnForecolor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForecolor.ImageIndex = 6;
            this.btnForecolor.ImageList = this.ımageListExcel;
            this.btnForecolor.Location = new System.Drawing.Point(244, 15);
            this.btnForecolor.Name = "btnForecolor";
            this.btnForecolor.Size = new System.Drawing.Size(33, 42);
            this.btnForecolor.TabIndex = 7;
            this.btnForecolor.UseVisualStyleBackColor = true;
            this.btnForecolor.Click += new System.EventHandler(this.btnFormatClick);
            // 
            // ımageListExcel
            // 
            this.ımageListExcel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListExcel.ImageStream")));
            this.ımageListExcel.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListExcel.Images.SetKeyName(0, "alignLeft.png");
            this.ımageListExcel.Images.SetKeyName(1, "alignMid.png");
            this.ımageListExcel.Images.SetKeyName(2, "alignRight.png");
            this.ımageListExcel.Images.SetKeyName(3, "color.png");
            this.ımageListExcel.Images.SetKeyName(4, "font.png");
            this.ımageListExcel.Images.SetKeyName(5, "wrap.png");
            this.ımageListExcel.Images.SetKeyName(6, "formatColor.png");
            // 
            // btnWrap
            // 
            this.btnWrap.FlatAppearance.BorderSize = 0;
            this.btnWrap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWrap.ImageIndex = 5;
            this.btnWrap.ImageList = this.ımageListExcel;
            this.btnWrap.Location = new System.Drawing.Point(283, 15);
            this.btnWrap.Name = "btnWrap";
            this.btnWrap.Size = new System.Drawing.Size(33, 42);
            this.btnWrap.TabIndex = 6;
            this.btnWrap.UseVisualStyleBackColor = true;
            this.btnWrap.Click += new System.EventHandler(this.btnFormatClick);
            // 
            // btnFont
            // 
            this.btnFont.FlatAppearance.BorderSize = 0;
            this.btnFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFont.ImageIndex = 4;
            this.btnFont.ImageList = this.ımageListExcel;
            this.btnFont.Location = new System.Drawing.Point(205, 15);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(33, 42);
            this.btnFont.TabIndex = 5;
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFormatClick);
            // 
            // btnBackcolor
            // 
            this.btnBackcolor.FlatAppearance.BorderSize = 0;
            this.btnBackcolor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackcolor.ImageIndex = 3;
            this.btnBackcolor.ImageList = this.ımageListExcel;
            this.btnBackcolor.Location = new System.Drawing.Point(152, 17);
            this.btnBackcolor.Name = "btnBackcolor";
            this.btnBackcolor.Size = new System.Drawing.Size(33, 42);
            this.btnBackcolor.TabIndex = 4;
            this.btnBackcolor.UseVisualStyleBackColor = true;
            this.btnBackcolor.Click += new System.EventHandler(this.btnFormatClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRight);
            this.panel1.Controls.Add(this.btnCenter);
            this.panel1.Controls.Add(this.btnLeft);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 47);
            this.panel1.TabIndex = 2;
            // 
            // btnRight
            // 
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.ImageIndex = 2;
            this.btnRight.ImageList = this.ımageListExcel;
            this.btnRight.Location = new System.Drawing.Point(81, 3);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(33, 42);
            this.btnRight.TabIndex = 3;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnAlignClick);
            // 
            // btnCenter
            // 
            this.btnCenter.FlatAppearance.BorderSize = 0;
            this.btnCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCenter.ImageIndex = 1;
            this.btnCenter.ImageList = this.ımageListExcel;
            this.btnCenter.Location = new System.Drawing.Point(42, 3);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(33, 42);
            this.btnCenter.TabIndex = 2;
            this.btnCenter.UseVisualStyleBackColor = true;
            this.btnCenter.Click += new System.EventHandler(this.btnAlignClick);
            // 
            // btnLeft
            // 
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.ImageIndex = 0;
            this.btnLeft.ImageList = this.ımageListExcel;
            this.btnLeft.Location = new System.Drawing.Point(3, 3);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(33, 42);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnAlignClick);
            // 
            // btnDeleteRowCloumn
            // 
            this.btnDeleteRowCloumn.Location = new System.Drawing.Point(12, 67);
            this.btnDeleteRowCloumn.Name = "btnDeleteRowCloumn";
            this.btnDeleteRowCloumn.Size = new System.Drawing.Size(179, 39);
            this.btnDeleteRowCloumn.TabIndex = 0;
            this.btnDeleteRowCloumn.Text = "Seçili satır ve sütunu sil";
            this.btnDeleteRowCloumn.UseVisualStyleBackColor = true;
            this.btnDeleteRowCloumn.Click += new System.EventHandler(this.btnDeleteRowCloumn_Click);
            // 
            // Odev1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 727);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlSheet);
            this.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Odev1";
            this.Text = "Odev1";
            this.Load += new System.EventHandler(this.Odev1_Load);
            this.tcMain.ResumeLayout(false);
            this.tpCreate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlSheet.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpCreate;
        private System.Windows.Forms.Panel pnlSheet;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnDeleteRowCloumn;
        private System.Windows.Forms.ImageList ımageListExcel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnCenter;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnBackcolor;
        private System.Windows.Forms.Button btnWrap;
        private System.Windows.Forms.Button btnForecolor;
    }
}
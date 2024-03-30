using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.Hafta_14._03._24_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button2.Size = new Size(100, 100);
            //MessageBox.Show($"Genişliği: {button2.Width.ToString()} Yüksekliği: {button2.Height.ToString()}");
            if (btnCilgin.Location.Y  >= 10)
            {
                btnCilgin.Location = new Point(btnCilgin.Location.X, btnCilgin.Location.Y - 10);
            }
            else
            {
                btnCilgin.Location = new Point(btnCilgin.Location.X, 0);
            }

        }

        private void btnCilgin_MouseMove(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Üzerine gelndi");
            int butEn = btnCilgin.Width, butBoy = btnCilgin.Height;
            int formEn = this.ClientSize.Width, formBoy = this.ClientSize.Height;
            Random rnd = new Random();
            int yeniX = rnd.Next(0, (formEn - butEn)), yeniY = rnd.Next(0, (formBoy - butBoy));
            btnCilgin.Location = new Point(yeniX, yeniY);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ImageList imgList = new ImageList();
            imgList.ColorDepth = ColorDepth.Depth32Bit;
            imgList.ImageSize = new Size(32, 32);
            // 3 farklı şekilde resimler alınabilir
            imgList.Images.Add(Image.FromFile(@".\images\ekle.ico"));
            imgList.Images.Add(new Bitmap(@".\images\iptal.ico"));
            imgList.Images.Add(Bitmap.FromFile(@".\images\sil.ico"));

            btnCilgin.ImageList = imgList;
            btnCilgin.ImageIndex = 0;
            
            // btnCilgin.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCilgin.TextAlign = ContentAlignment.MiddleRight;
            btnCilgin.ImageAlign = ContentAlignment.MiddleLeft;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btnNew = new Button() { Name = "btnNew", Text = "Yeni Buton"};
            Random rnd2 = new Random();
            btnNew.Size = new Size(150, 150);
            int frmEn = this.ClientSize.Width, frmBoy = this.ClientSize.Height, btnEn = btnNew.Width, btnBoy = btnNew.Height;
            btnNew.Location = new Point(rnd2.Next(0, frmEn-btnEn), rnd2.Next(0, frmBoy-btnBoy));
            btnNew.BackColor = Color.Red;
            btnNew.Click += new EventHandler(btn_click);
            this.Controls.Add(btnNew);
        }

        private void btn_click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeni butona tıklanıldı");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtIslem.Select(0, 4);
            MessageBox.Show(txtIslem.SelectedText);
            // hide selection false yapıldığı zaman seçim görünür olur

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtMulti.Multiline = true;
            txtMulti.Size = new Size(150, 100);
            txtMulti.ScrollBars = ScrollBars.Vertical;
            txtMulti.Text = "1. Satır";
            for (int i = 0; i < 10; i++)
            {
                txtMulti.Text += Environment.NewLine + $"{i+2}. Satır";
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] dizi = txtMulti.Lines.ToArray();
            textBox2.Lines = dizi;
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(0,5);
            switch (sayi)
            {
                case 0: textBox3.PasswordChar = '?'; break;
                case 1: textBox3.PasswordChar = '#'; break;
                case 2: textBox3.PasswordChar = '+'; break;
                case 3: textBox3.PasswordChar = '$'; break;
                case 4: textBox3.PasswordChar = '!'; break;
            }
            // max lengh ile karakter sayısı belirlenebilir
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Yellow;
            textBox3.ForeColor = Color.Navy;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
            textBox3.ForeColor = Color.Black;
        }

        private void btnCilgin_Click(object sender, EventArgs e)
        {

        }
    }
}

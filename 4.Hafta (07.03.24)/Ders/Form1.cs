using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Hafta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // MessageBox.Show("Yapıcı çalıştı");
        }

        private void btnCncl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancel");
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Accept");
        }

        private void btnFnt_Click(object sender, EventArgs e)
        {
            //FontDialog fd = new FontDialog();
            //if (fd.ShowDialog() == DialogResult.OK)
            //{
            //    this.Font = fd.Font;
            //}

            Font fnt = new Font("Verdana", 10, FontStyle.Bold | FontStyle.Italic);
            this.Font = fnt;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblDgr.Text = $"Değer: {trackBar1.Value}";
            this.Opacity = (double)trackBar1.Value / 100;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // MessageBox.Show("Form yükleniyor");
        }

        // switch - case ile kaydetmeyi yap
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var sorguEkranı = new Form2();
            // sorguEkranı.Show();
            e.Cancel = true;
            //if (sorguEkranı.ShowDialog() == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
            //else
            //{
            //    e.Cancel = false;
            //}
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Form kapatıldı");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show($"{e.KeyCode}");
        }

        private void btnBckGrnd_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            this.BackColor = Color.FromArgb(rd.Next(0,256), rd.Next(0, 256), rd.Next(0, 256));
        }
    }
}

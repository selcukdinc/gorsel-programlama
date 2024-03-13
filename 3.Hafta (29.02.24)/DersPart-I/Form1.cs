using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace DersPart_I
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKydt_Click(object sender, EventArgs e)
        {
            this.Text = "Teknoloji";
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.Text = "Teknoloji_double";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("mesajım", "Bilgilendirme ekranı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("KAyıt silinsin mi?", "Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) 
                MessageBox.Show("Silindi");
            else 
                MessageBox.Show("Silme iptal");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // İnput box nedir?
            string formAdi = Interaction.InputBox("Form Adını gir: ", "Bilgi Ekranı", "Form1");
            this.Text = formAdi;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // this.BackColor = Color.White;
            // this.ForeColor = Color.Blue;
            button3.BackColor = Color.Aqua;
            button3.ForeColor = Color.Brown;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = cd.Color;   
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Icon ico = new Icon(@".\arac.ico");
            this.Icon = ico;
            // dinamik adresleme?
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            string d = Environment.CurrentDirectory;
            opf.InitialDirectory = d;
            opf.Title = "Icon Seçme Ekranı";
            opf.Filter = "ico | *.ico";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                this.Icon = new Icon(opf.FileName);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            string d = Environment.CurrentDirectory;
            opf.InitialDirectory = d;
            opf.Title = "Png Seçme Ekranı";
            opf.Filter = "png | *.png";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                this.BackgroundImage = new Bitmap(opf.FileName);
            }
        }
        // this.Background = new Bitmap(opf.FileName)


        /*  
            subrutinler, F7 ile kod penceresi açılır
            kendi komponentlerimiz?
            inputbox?
         */
    }
}

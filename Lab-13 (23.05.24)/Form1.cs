using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab_13__23._05._24_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbUzanti.SelectedIndex = 0;
        }

        private string dosyaIsmi()
        {
            return tbDosyaAdi.Text + cbUzanti.Text;
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(dosyaIsmi()))
                {
                    File.Create(dosyaIsmi());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnDosyaDurum_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(dosyaIsmi()))
                {
                    MessageBox.Show("Dosya bulunmaktadır");
                }
                else
                {
                    MessageBox.Show("Dosya dizinde bulunmuyor");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}

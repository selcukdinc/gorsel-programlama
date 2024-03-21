using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6.Hafta_21._03._24_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //comboBox1.DropDownStyle = ComboBoxStyle.Simple;
            //comboBox1.Width = 100;
            //comboBox1.Height = 100;
            //comboBox1.DropDownWidth = 150;
            //comboBox1.DropDownHeight = 50;
            //MessageBox.Show($"{comboBox1.Text}");

            //for (int i = 0; i < comboBox1.Items.Count; i++)
            //{
            //    MessageBox.Show($"{comboBox1.Items[i]}"); 
            //}

            //foreach (var okunanDeg in comboBox1.Items)
            //{
            //    MessageBox.Show($"{okunanDeg}");
            //}

            comboBox1.Items.Clear();
            comboBox1.Text = "";

            //comboBox1.Items.Add("Kadın");
            //comboBox1.Items.Add("Erkek");
            //comboBox1.Text = "Cinsiyet seçiniz";

            string[] dizi = new string[10];
            for (int i = 0; i < 10; i++)
            {
                dizi[i] = $"Deneme: {i+1}";
            }

            foreach (string eleman in dizi)
            {
                comboBox1.Items.Add(eleman);
            }
            comboBox1.Items.Insert(2, "Merhaba");
            comboBox1.Items.Remove("Deneme: 5");
            comboBox1.Items.RemoveAt(5);
            MessageBox.Show($"{comboBox1.Items.Contains("Deneme: 8")}");
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"{comboBox1.SelectedIndex}");
            MessageBox.Show($"{comboBox1.SelectedItem}");
            MessageBox.Show($"{comboBox1.SelectedText}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!comboBox1.Items.Contains(textBox1.Text))
            {
                comboBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("Toplama");
            comboBox2.Items.Add("Çıkarma");
            comboBox2.Items.Add("Bölme");
            comboBox2.Items.Add("çarpma");
            // fonksiyonun içine aktarılması tercih edilir

            illerOku();

        }
        private void illerOku()
        {
            string il;
            StreamReader sr = new StreamReader(@".\iller\iller.txt");
            try
            {
                while ((il = sr.ReadLine()) != null)
                {
                    cmbIller.Items.Add(il);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally 
            { 
                sr.Close(); 
            }

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txbBirinci.Text);int  b = Convert.ToInt32(txbİkinci.Text);
            int secim = comboBox2.SelectedIndex;
            switch (secim)
            {
                case 0:
                    txbSonuc.Text = $"{a + b}";
                    break;
                case 1:
                    txbSonuc.Text = $"{a - b}";
                    break;
                case 2:
                    txbSonuc.Text = $"{(double)a / b}";
                    break;
                case 3:
                    txbSonuc.Text = $"{a * b}";
                    break;
            }
        }

        private void cmbIller_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ilceler;
            cmbIl.Items.Clear();
            cmbIl.Text = "";
            cmbIl.SelectedIndex = -1;
            StreamReader sr = new StreamReader($@".\iller\{cmbIller.Text}.txt");
            try
            {
                while ((ilceler = sr.ReadLine()) != null)
                {
                    cmbIl.Items.Add(ilceler);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sr.Close();
            }
        }
    }
}

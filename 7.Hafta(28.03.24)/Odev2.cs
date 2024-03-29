using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7.Hafta_28._03._24_
{
    public partial class Odev2 : Form
    {
        public Odev2()
        {
            InitializeComponent();
        }

        private void Odev2_Load(object sender, EventArgs e)
        {
            KelimeOku();
            //FindControlNames(this);
        }

        private void KelimeOku()
        {
            foreach (Control knt in this.Controls)
            {
                if (knt.GetType() == typeof(Button) || knt.GetType() == typeof(TextBox) || knt.GetType() == typeof(ComboBox))
                {
                    lbElemanListe.Items.Add(knt.Name);
                }

            }
        }

        private void cbIslemler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Regex r1 = new Regex(@"^-[0-9]+$|^[0-9]+$");
            Match m1 = r1.Match(tbSay1.Text), m2 = r1.Match(tbSay2.Text);
            if (m1.Success == true && m2.Success == true)
            {
                switch (cbIslemler.SelectedIndex)
                {
                    case 0:
                        tbSonuc.Text = $"{Convert.ToInt32(tbSay1.Text) + Convert.ToInt32(tbSay2.Text)}";
                        break;
                    case 1:
                        tbSonuc.Text = $"{Convert.ToInt32(tbSay1.Text) - Convert.ToInt32(tbSay2.Text)}";
                        break;
                    case 2:
                        tbSonuc.Text = $"{Convert.ToInt32(tbSay1.Text) / Convert.ToInt32(tbSay2.Text)}";
                        break;
                    case 3:
                        tbSonuc.Text = $"{Convert.ToInt32(tbSay1.Text) * Convert.ToInt32(tbSay2.Text)}";
                        break;
                }
            }
            else
            {
                MessageBox.Show("Yanlış değer girdiniz", "Sayı girdilerinizde hata!");
            }

        }
        private void btnTaborder_Click(object sender, EventArgs e)
        {
            int syc = 0;
            string[] Eklenenler = new string[lbTabOrder.Items.Count];
            for (int i = 0; i < lbTabOrder.Items.Count; i++)
            {
                //MessageBox.Show(lbTabOrder.Items[i].ToString());
                this.Controls[lbTabOrder.Items[i].ToString()].TabIndex = i; 
                if (i == 0)
                    this.Controls[lbTabOrder.Items[i].ToString()].Focus();
                if (syc == 0)
                {
                    Eklenenler[i] = lbTabOrder.Items[i].ToString();
                    int ilkDeg = Array.IndexOf(Eklenenler, lbTabOrder.Items[i].ToString()), sonDeg = Array.LastIndexOf(Eklenenler, lbTabOrder.Items[i].ToString());
                    if (ilkDeg != sonDeg)
                    {
                        syc++;
                    }
                }
            }
            if (syc > 0)
                MessageBox.Show("Taborder işlemi bazı elemanlar 1'den fazla eklendiği için düzgün çalışmayacak");
            else 
                MessageBox.Show("Taborder işlemi başarılı bir şekilde gerçekleşti");
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbElemanListe.SelectedIndices.Count; i++)
            {
                lbTabOrder.Items.Add(lbElemanListe.Items[lbElemanListe.SelectedIndices[i]]);
            }
            lbElemanListe.SelectedIndex = -1;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lbTabOrder.Items.Clear();
        }

        private void lbElemanListe_DoubleClick(object sender, EventArgs e)
        {
            lbTabOrder.Items.Add(lbElemanListe.Items[lbElemanListe.SelectedIndex]);
            lbElemanListe.SelectedIndex = -1;
        }

        private void lbTabOrder_DoubleClick(object sender, EventArgs e)
        {
            lbTabOrder.Items.Remove(lbTabOrder.Items[lbTabOrder.SelectedIndex]);
            lbTabOrder.SelectedIndex = -1;
        }
    }
}

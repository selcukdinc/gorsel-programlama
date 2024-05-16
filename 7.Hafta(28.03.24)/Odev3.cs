using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7.Hafta_28._03._24_
{
    public partial class Odev3 : Form
    {
        public Odev3()
        {
            InitializeComponent();
        }

        private void tbDogrula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                lbDogrula.Items.Add(tbDogrula.Text);
                tbDogrula.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lbAsal.Items.Clear();
            lbDogrula.Items.Clear();
            btnDogrula.BackColor = Color.White;
        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            btnAsalBul.PerformClick();
            int carpim = 1, girilenDeg = 1;
            for (int i = 0; i < lbAsal.Items.Count; i++)
            {
                carpim *= (int)lbAsal.Items[i];
            }
            // tbDogrula.Text = $"{carpim}";
            for (int i = 0; i < lbDogrula.Items.Count; i++)
            {
                girilenDeg *= Convert.ToInt32(lbDogrula.Items[i]);
            }
            if (girilenDeg == carpim)
            {
                btnDogrula.BackColor = Color.LightGreen;
            }
            else
            {
                btnDogrula.BackColor = Color.LightSalmon;
            }
        }

        private void btnAsalBul_Click(object sender, EventArgs e)
        {
            lbAsal.Items.Clear();
            int bolum = 2;
            int sayi = Convert.ToInt32(textBox1.Text);
            while (sayi >= bolum)
            {
                if (asalmi(bolum) && sayi % bolum == 0)
                {
                    sayi /= bolum;
                    lbAsal.Items.Add(bolum);
                }
                else
                {
                    bolum++;
                }
            }
        }

        private bool asalmi(int bolum)
        {
            if (bolum == 2)
            {
                return true;
            }
            else
            {
                for (int i = 2; i < bolum; i++)
                {
                    if (bolum % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}

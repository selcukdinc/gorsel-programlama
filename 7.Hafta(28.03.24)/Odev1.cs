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
    public partial class Odev1 : Form
    {
        public Odev1()
        {
            InitializeComponent();
        }

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            int deger;
            if (lbMain.SelectedIndex < 0)
            {
                btnAra.PerformClick();
            }
            else
            {
                deger = lbMain.SelectedIndex;
                if (lbMain.FindString(txtAra.Text, deger) > -1)
                {
                    lbMain.SelectedIndex = -1;
                    if (lbMain.FindString(txtAra.Text, deger) > deger)
                    {
                        deger = lbMain.FindString(txtAra.Text, deger);
                        lbMain.SelectedIndex = deger;
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("Başa dönülsün mü ?", "Son kelimeye gelindi", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            deger = 0;
                        }
                        else
                            lbMain.SelectedIndex = deger;
                    }
                }
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (lbMain.FindString(txtAra.Text) > -1)
            {
                lbMain.SelectedIndex = lbMain.FindString(txtAra.Text);
            }
            else
                MessageBox.Show("Aranana değer bulunamadı");
        }


    }
}

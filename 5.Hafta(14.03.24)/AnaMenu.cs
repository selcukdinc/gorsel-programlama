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
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void btnFrm1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void btnOdev1_Click(object sender, EventArgs e)
        {
            Odev1 frm = new Odev1();
            frm.ShowDialog();
        }

        private void brnOdev2_Click(object sender, EventArgs e)
        {
            Odev2 frm = new Odev2();
            frm.ShowDialog();
        }

        private void btnOdev3_Click(object sender, EventArgs e)
        {
            Odev3 frm = new Odev3();
            frm.ShowDialog();
        }
    }
}

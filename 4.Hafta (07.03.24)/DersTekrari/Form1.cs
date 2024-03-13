using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DersTekrari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lbl_Deg.Text = $"Opaklık : {trackBar1.Value}";
            this.Opacity = (double)trackBar1.Value/100;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Secenekler ScnkFrm = new Secenekler();
            ScnkFrm.ShowDialog();
            switch (ScnkFrm.DialogResult)
            {
                case DialogResult.OK: ; break;
                case DialogResult.Cancel: e.Cancel = true; break;
            }
        }

        private void btnRastgele_Click(object sender, EventArgs e)
        {
            Random Rast = new Random();
            int a, b, c;
            this.BackColor = Color.FromArgb(a = Rast.Next(0, 256), b = Rast.Next(0, 256), c = Rast.Next(0, 256));
            btnRastgele.BackColor = Color.FromArgb(a,b,c);
            BtnReset.BackColor = Color.FromArgb(a, b, c);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(224, 224, 224);
            btnRastgele.BackColor = Color.FromArgb(224, 224, 224);
            BtnReset.BackColor = Color.FromArgb(224, 224, 224);
        }
    }
}

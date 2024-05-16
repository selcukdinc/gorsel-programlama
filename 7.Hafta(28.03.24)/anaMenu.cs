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
    public partial class anaMenu : Form
    {
        public anaMenu()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name == btnForm1.Name)
            {
                Form1 frm = new Form1();
                frm.ShowDialog();
            }else if (btn.Name == btnOdev1.Name)
            {
                Odev1 frm = new Odev1();
                frm.ShowDialog();
            }else if (btn.Name == btnOdev2.Name)
            {
                Odev2 frm = new Odev2();
                frm.ShowDialog();
            }else if (btn.Name == btnOdev3.Name)
            {
                Odev3 frm = new Odev3();
                frm.ShowDialog();
            }
        }
    }
}

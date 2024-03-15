using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.Hafta_14._03._24_
{
    public partial class Odev1 : Form
    {
        /*
        * Ödev1:Farklı şekillerde buton, flowchartta olduğu gibi butonlar eklenebilecek,
        * butona tıkladın, çizgiyi geçtiği an o butondan eklenecek
        * butonlar çoğaltılmış olacak
        */
        #region Ödevin Cevabı
        public Odev1()
        {
            InitializeComponent();
            Ifilkkonum = new Point(btnIf.Left, btnIf.Top);
            WhlilkKonum = new Point(btnWhile.Left, btnWhile.Top);
            ForilkKonum = new Point(btnFor.Left, btnFor.Top);
        }

        public static void OzMiras( System.Windows.Forms.Button Source, ref System.Windows.Forms.Button[] Target, int Sayac)
        {
            Target[Sayac] = new Button();
            Target[Sayac].Name = $"{Source.Name}{Sayac}";
            Target[Sayac].Text = $"{Source.Text}{Sayac}";
            Target[Sayac].Height = Source.Height;
            Target[Sayac].Width = Source.Width;
            Target[Sayac].Font = Source.Font;
            Target[Sayac].BackColor = Source.BackColor;
            Target[Sayac].ForeColor = Source.ForeColor;
            Target[Sayac].Location = Source.Location;
        }

        System.Windows.Forms.Button[] WhlBtns = new System.Windows.Forms.Button[0];
        int btnWhileSyc = 0;
        System.Windows.Forms.Button[] IfBtns = new System.Windows.Forms.Button[0];
        int btnifSayac = 0;
        System.Windows.Forms.Button[] ForBtns = new System.Windows.Forms.Button[0];
        int btnforSayac = 0;

        #region WhileBtn

        Point WhlKonum, WhlilkKonum;
        private void btnWhile_MouseDown(object sender, MouseEventArgs e)
        {
            WhlKonum = e.Location;
        }

        private void btnWhile_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                btnWhile.Left += e.X - (WhlKonum.X);
                btnWhile.Top += e.Y - (WhlKonum.Y);
            }
        }

        private void btnWhile_MouseUp(object sender, MouseEventArgs e)
        {
            if (btnWhile.Location.X + btnWhile.Width > pictureBox1.Width + btnWhile.Width)
            {
                Array.Resize(ref WhlBtns, btnWhileSyc+1);
                OzMiras( btnWhile, ref WhlBtns, btnWhileSyc);
                this.Controls.Add(WhlBtns[btnWhileSyc]);
                btnWhile.Location = WhlilkKonum;
                btnWhileSyc++;
            }else btnWhile.Location = WhlilkKonum;
        }
        #endregion

        #region IfBtn

        Point Ifkonum, Ifilkkonum;
        private void btnIf_MouseDown(object sender, MouseEventArgs e)
        {
            Ifkonum = e.Location;
        }

        private void btnIf_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                btnIf.Left += e.X - (Ifkonum.X);
                btnIf.Top += e.Y - (Ifkonum.Y);
            }
        }
        private void btnIf_MouseUp(object sender, MouseEventArgs e)
        {
            
            if (btnIf.Location.X + btnIf.Width > pictureBox1.Width + btnIf.Width)
            {
                Array.Resize(ref IfBtns, btnifSayac+1);
                OzMiras(btnIf,ref IfBtns, btnifSayac);
                this.Controls.Add(IfBtns[btnifSayac]);
                btnIf.Location = Ifilkkonum;
                btnifSayac++;
            }
            else
            {
                btnIf.Location = Ifilkkonum;
            }
        }
        #endregion

        #region ForBtn

        Point ForKonum, ForilkKonum;

        private void btnFor_MouseDown(object sender, MouseEventArgs e)
        {
            ForKonum = e.Location;
        }

        private void btnFor_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                btnFor.Left += e.X - (ForKonum.X);
                btnFor.Top += e.Y - (ForKonum.Y);
            }
        }

        private void btnFor_MouseUp(object sender, MouseEventArgs e)
        {
            if (btnFor.Location.X + btnFor.Width > pictureBox1.Width + btnFor.Width)
            {
                Array.Resize(ref ForBtns, btnforSayac+1);
                OzMiras(btnFor, ref ForBtns, btnforSayac);
                this.Controls.Add(ForBtns[btnforSayac]);
                btnFor.Location = ForilkKonum;
                btnforSayac++;
            }
            else btnFor.Location = ForilkKonum;
        }
        #endregion

        #endregion
    }
}

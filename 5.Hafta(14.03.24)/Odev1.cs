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
        * Edit1: Butonlar artık hareket ettiriliebiliyorlar
        */
        #region Ödevin Cevabı
        public Odev1()
        {
            InitializeComponent();
            Ifilkkonum = new Point(btnIf.Left, btnIf.Top);
            WhlilkKonum = new Point(btnWhile.Left, btnWhile.Top);
            ForilkKonum = new Point(btnFor.Left, btnFor.Top);
            this.StartPosition = FormStartPosition.CenterParent;
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

        Button[] WhlBtns = new Button[0]; int btnWhileSyc = 0;  int WhlSecilen = 0;
        Button[] IfBtns = new Button[0];  int btnifSayac = 0;   int IfSecilen = 0;
        Button[] ForBtns = new Button[0]; int btnforSayac = 0;  int ForSecilen = 0;

        // int[] Xkonum = new int[0];
        // int[] Ykonum = new int[0];

        Point WhlKonum, WhlilkKonum;
        Point Ifkonum, Ifilkkonum;
        Point ForKonum, ForilkKonum;

        #region WhileBtn
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
                // Array.Resize(ref Xkonum, btnWhileSyc + 1);
                // Array.Resize(ref Ykonum, btnWhileSyc + 1);
                // Xkonum[btnWhileSyc] = btnWhile.Location.X;
                // Ykonum[btnWhileSyc] = btnWhile.Location.Y;
                btnWhile.Location = WhlilkKonum;  
                this.WhlBtns[btnWhileSyc].MouseDown += new System.Windows.Forms.MouseEventHandler(this.WhileButtons_MouseDown);
                this.WhlBtns[btnWhileSyc].MouseMove += new System.Windows.Forms.MouseEventHandler(this.WhileButtons_MouseMove);
                btnWhileSyc++;
            }
            else 
                btnWhile.Location = WhlilkKonum;
        }

        private void WhileButtons_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < WhlBtns.Length; i++)
            {
                Point ptCursor = Cursor.Position;
                ptCursor = PointToClient(ptCursor);
                if (WhlBtns[i].Bounds.Contains(ptCursor))
                {
                    WhlSecilen = i;
                    break;
                }
            }
            WhlKonum = e.Location; // *
        }

        private void WhileButtons_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.WhlBtns[WhlSecilen].Left += e.X - (WhlKonum.X); // *
                this.WhlBtns[WhlSecilen].Top += e.Y - (WhlKonum.Y); // *
            }
        }
        #endregion

        #region IfBtn

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
                Array.Resize(ref IfBtns, btnifSayac + 1);
                OzMiras(btnIf, ref IfBtns, btnifSayac);
                this.Controls.Add(IfBtns[btnifSayac]);
                btnIf.Location = Ifilkkonum;
                this.IfBtns[btnifSayac].MouseDown += new System.Windows.Forms.MouseEventHandler(this.IfButtons_MouseDown);
                this.IfBtns[btnifSayac].MouseMove += new System.Windows.Forms.MouseEventHandler(this.IfButtons_MouseMove);
                btnifSayac++;
            }
            else
                btnIf.Location = Ifilkkonum;   
        }
        private void IfButtons_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < IfBtns.Length; i++)
            {
                Point ptCursor = Cursor.Position;
                ptCursor = PointToClient(ptCursor);
                if (IfBtns[i].Bounds.Contains(ptCursor))
                {
                    IfSecilen = i;
                    break;
                }
            }
            Ifkonum = e.Location; // *
        }

        private void IfButtons_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.IfBtns[IfSecilen].Left += e.X - (Ifkonum.X); // *
                this.IfBtns[IfSecilen].Top += e.Y - (Ifkonum.Y); // *
            }
        }
        #endregion

        #region ForBtn

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
                this.ForBtns[btnforSayac].MouseDown += new System.Windows.Forms.MouseEventHandler(this.ForButtons_MouseDown);
                this.ForBtns[btnforSayac].MouseMove += new System.Windows.Forms.MouseEventHandler(this.ForButtons_MouseMove);
                btnforSayac++;
            }
            else btnFor.Location = ForilkKonum;
        }

        private void ForButtons_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < ForBtns.Length; i++)
            {
                Point ptCursor = Cursor.Position;
                ptCursor = PointToClient(ptCursor);
                if (ForBtns[i].Bounds.Contains(ptCursor))
                {
                    ForSecilen = i;
                    break;
                }
            }
            ForKonum = e.Location; // *
        }

        private void ForButtons_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.ForBtns[ForSecilen].Left += e.X - (ForKonum.X); // *
                this.ForBtns[ForSecilen].Top += e.Y - (ForKonum.Y); // *
            }
        }
        #endregion

        #endregion
    }
}

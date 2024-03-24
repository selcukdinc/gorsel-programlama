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
    internal class Buttons
    {
        Point ilk_Konum, Konum;
        Button[] Btns = new Button[1];
        public int BtnSyc = 0, Secilen = 0;
        int[] Xkonum = new int[0];
        int[] Ykonum = new int[0];
        PictureBox AreaMain;
        public Buttons(PictureBox Area, Button Source)
        {
            ilk_Konum = new Point(Source.Left, Source.Top);
            Btns[BtnSyc] = new Button()
            {
                Name = $"{Source.Name} {BtnSyc}",
                Text = $"{Source.Text} {BtnSyc}",
                Height = Source.Height,
                Width = Source.Width,
                Font = Source.Font,
                BackColor = Source.BackColor,
                ForeColor = Source.ForeColor,
                Location = Source.Location
            };
            AreaMain = Area;
        }

        public void OzMiras()
        {
            Btns[BtnSyc] = new Button()
            {
                Name = $"{Btns[0].Name} {BtnSyc}",
                Text = $"{Btns[0].Text} {BtnSyc}",
                Height = Btns[0].Height,
                Width = Btns[0].Width,
                Font = Btns[0].Font,
                BackColor = Btns[0].BackColor,
                ForeColor = Btns[0].ForeColor,
                Location = Btns[0].Location
            };
        }

        public void Btn_MouseDown(MouseEventArgs e)
        {
            Konum = e.Location;
        }

        public void Btn_MouseMove(MouseEventArgs e , ref Button Source)
        {
            if (e.Button == MouseButtons.Left)
            {
                Source.Left += e.X - (Konum.X);
                Source.Top += e.Y - (Konum.Y);
            }
        }

        public void Btn_MouseUp()
        {
            if (Btns[0].Location.X + Btns[0].Width > AreaMain.Width + Btns[0].Width)
            {
                Array.Resize(ref Btns ,++BtnSyc);
                OzMiras();
                // ControlCollection(Btns[BtnSyc - 1]);
            }
        }
    }
}

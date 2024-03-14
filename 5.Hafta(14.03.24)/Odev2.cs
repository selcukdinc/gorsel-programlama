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
    public partial class Odev2 : Form
    {
        public Odev2()
        {
            InitializeComponent();
        }

        enum ZeminRenk
        {
            Siyah, Beyaz
        }
        ZeminRenk rnk = ZeminRenk.Siyah;
        private void button1_Click(object sender, EventArgs e)
        {
           
            //int frmEn = this.ClientSize.Width, frmBoy = this.ClientSize.Height, btnEn = btnNew.Width, btnBoy = btnNew.Height;
            // btnNew.Location = new Point(rnd2.Next(0, frmEn - btnEn), rnd2.Next(0, frmBoy - btnBoy));
            
            int Xlokasyonu = 100, Ylokasyonu = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Button btnNew = new Button() { Name = "btnNew", Text = "Yeni Buton" };
                    Random rnd2 = new Random();
                    btnNew.Size = new Size(50, 50);
                    switch (rnk)
                    {
                        case ZeminRenk.Siyah:
                            btnNew.Location = new Point(Xlokasyonu, Ylokasyonu);
                            btnNew.BackColor = Color.Black;
                            Xlokasyonu += 50;
                            rnk = ZeminRenk.Beyaz;
                            break;
                        case ZeminRenk.Beyaz:
                            btnNew.Location = new Point(Xlokasyonu, Ylokasyonu);
                            btnNew.BackColor = Color.White;
                            Xlokasyonu += 50;
                            rnk = ZeminRenk.Siyah;
                            break;
                    }
                    
                    this.Controls.Add(btnNew);
                }
                Ylokasyonu += 50;
                Xlokasyonu = 100;
            }

            
        }
    }
}

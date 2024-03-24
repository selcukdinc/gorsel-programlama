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
            int barSizeY = this.Height - this.ClientSize.Height, barSizeX = this.Width - this.ClientSize.Width;
            this.MinimizeBox = false; this.MaximizeBox = false; this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.Width = 100 + 8 * 50 + barSizeX; this.Height = 8 * 50 + barSizeY;
        }

        /* ödev 2, 
         *          butona tıklanıldığı zaman,
         *          formun x noktasındaki 100'den sonrasına butonlar oluşturulacak, 
         *          8x8 adet buton oluşturulacak,
         *          üstlerinde 1'den 64'e yazılar yazılacak
         * satranç tahtası gibi siyah ve bayaz renklerinden oluşturulacak
         */

        #region Ödevin Cevabı

        enum ZeminRenk
        {
            Siyah, Beyaz

        }
        ZeminRenk rnk = ZeminRenk.Beyaz;

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            //int frmEn = this.ClientSize.Width, frmBoy = this.ClientSize.Height, btnEn = btnNew.Width, btnBoy = btnNew.Height;
            // btnNew.Location = new Point(rnd2.Next(0, frmEn - btnEn), rnd2.Next(0, frmBoy - btnBoy));
            //int barSizeY = this.Height - this.ClientSize.Height, barSizeX = this.Width - this.ClientSize.Width;
            //this.MinimizeBox = false; this.MaximizeBox = false; this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            //this.Width = 100 + 8 * 50+barSizeX; this.Height = 8*50+barSizeY;
            int Xlokasyonu = 100, Ylokasyonu = 0, sayac = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Button btnTas = new Button() { Name = "btnTas", Text = $"{sayac++}" };
                    Random rnd2 = new Random();
                    btnTas.Size = new Size(50, 50);
                    btnTas.FlatStyle = FlatStyle.Flat;
                    btnTas.FlatAppearance.BorderSize = 0;
                    switch (rnk)
                    {
                        case ZeminRenk.Siyah:
                            btnTas.Location = new Point(Xlokasyonu, Ylokasyonu);
                            btnTas.BackColor = Color.Black;
                            btnTas.ForeColor = Color.White;
                            Xlokasyonu += 50;
                            rnk = ZeminRenk.Beyaz;
                            break;
                        case ZeminRenk.Beyaz:
                            btnTas.Location = new Point(Xlokasyonu, Ylokasyonu);
                            btnTas.BackColor = Color.White;
                            btnTas.ForeColor = Color.Black;
                            Xlokasyonu += 50;
                            rnk = ZeminRenk.Siyah;
                            break;
                    }
                    this.Controls.Add(btnTas);
                }
                Ylokasyonu += 50;
                Xlokasyonu = 100;
                if (rnk == ZeminRenk.Beyaz)
                   rnk = ZeminRenk.Siyah;
                else
                   rnk = ZeminRenk.Beyaz;
            }
        }
        #endregion
    }
}

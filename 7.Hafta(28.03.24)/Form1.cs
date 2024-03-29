using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _7.Hafta_28._03._24_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbMain.SelectionMode = SelectionMode.MultiExtended;
            rbtTr.Checked = true;
            // btnAsalBul.Visible = false;
            // lbAsal.Visible = false;
        }

        string[] Kelimeler;

        private void KelimeleriOku(int secilen)
        {
            lblKelimeler.Items.Clear();
            Kelimeler = File.ReadAllLines(@".\VeriTabaniEng.txt", Encoding.Default);
            string[] bolunmusKelimeler;
            foreach (var item in Kelimeler)
            {
                bolunmusKelimeler = item.Split(';');
                lblKelimeler.Items.Add(bolunmusKelimeler[secilen]);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lbMain.Items.Add(txtEkle.Text);
            txtEkle.Text = "";
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{lbMain.SelectedIndex}");
            lbOther.Items.Add(lbMain.Items[lbMain.SelectedIndex]);
            //lbOther.Items.Add(lbMain.SelectedItem);
            //lbOther.Items.Add(lbMain.SelectedItem);
        }

        private void btnCokluAktar_Click(object sender, EventArgs e)
        {
            //// lbOther.Items.Add(lbMain.SelectedItems);
            //foreach (var item in lbMain.SelectedIndices)
            //{
            //    // MessageBox.Show($"{item}");
            //    lbOther.Items.Add(lbMain.Items[(int)item]);
            //}

            for (int i = 0; i < lbMain.SelectedIndices.Count; i++)
            {
                lbOther.Items.Add(lbMain.Items[lbMain.SelectedIndices[i]]);
            }
        }

        private void btnIdisIslem_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < lbMain.Items.Count; i++)
            {
                lbMain.SelectedIndices.Add(i);
            }

            lbMain.SelectedIndices.Remove(2);

            lbOther.Sorted = true;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"{lbMain.FindString(txtAra.Text)}");
            //lbMain.SelectedIndex = lbMain.FindString(txtAra.Text);

            if (lbMain.FindString(txtAra.Text) > -1)
            {
                lbMain.SelectedIndex = lbMain.FindString(txtAra.Text);
            }
            else
                MessageBox.Show("Aranana değer bulunamadı");
        }
        
        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < lbMain.Items.Count; i++)
            //{
            //    if (lbMain.Items[i].ToString() == txtAra.Text)
            //    {
            //        lbMain.SelectedIndex = i;
            //    }
            //}

            //for (int i = 0; i < lbMain.Items.Count; i++)
            //{
            //    lbMain.SelectedIndex = lbMain.FindString(txtAra.Text, i);
            //}
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

                    //deger = lbMain.FindString(txtAra.Text, deger);
                    //if (deger >= 0)
                    //{
                    //    lbMain.SelectedIndex = deger;
                    //}

                    if (lbMain.FindString(txtAra.Text, deger) > deger)
                    {
                        deger = lbMain.FindString(txtAra.Text, deger);
                        lbMain.SelectedIndex = deger;
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("Başa dönülsün mü ?","Son kelimeye gelindi",MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            deger = 0;
                        }
                        else 
                            lbMain.SelectedIndex = deger;
                    }

                        
                }
            }
            /*
             * ödev1: son seçimden sonra başa dönmeli, 
             * 
             * ödev2: 
             * birinci sayı (label) : textbox
             * ikinci sayı (label) : textbox
             * listbox1 : buton ve textbox'ları listele
             * listbox2 : Taborder'i gösteren liste olacak
             * aktar, taborderi düzenle
             * tabroder'a basıldıktan sonra focus atılacak
             * 
             * ödev3:
             * asal çarpan kontrol yapılacak
             */
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

        private void btnAsalCarpanlar_Click(object sender, EventArgs e)
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
            // lbAsal.Visible = true;
            // btnAsalBul.Visible = true;
        }

        private void rbtEn_CheckedChanged(object sender, EventArgs e)
        {
            KelimeleriOku(0);
        }

        private void rbtTr_CheckedChanged(object sender, EventArgs e)
        {
            KelimeleriOku(1);
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            lblKelimeler.SelectedIndex = lblKelimeler.FindString(txtKelimeAra.Text);
            string[] aa;
            aa = Kelimeler[lblKelimeler.SelectedIndex].Split(';');
            foreach (var item in aa)
            {
                MessageBox.Show($"{item}");
            }

        }

        private void tbDogrula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                lbDogrula.Items.Add(tbDogrula.Text);
                tbDogrula.Text = "";
            }
    }

        private void button1_Click(object sender, EventArgs e)
        {
            Odev2 frm = new Odev2();
            frm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lbAsal.Items.Clear();
            lbDogrula.Items.Clear();
            btnDogrula.BackColor = Color.White;
        }
    }
}

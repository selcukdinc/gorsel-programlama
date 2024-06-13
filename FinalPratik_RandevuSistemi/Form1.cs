using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinalPratik_RandevuSistemi
{
    public partial class Form1 : Form
    {
        //static string[] pathAndSql = new string[0];
        //OleDbConnection conTest;
        public Form1()
        {
            InitializeComponent();
            //string path = $"{Application.StartupPath}\\con&Sql.txt";
            //FileStream fs = new FileStream(path, FileMode.Open);
            //StreamReader sw = new StreamReader(fs);
            //string text;
            //int counter = 0;
            //while ((text = sw.ReadLine()) != null)
            //{
            //    Array.Resize(ref pathAndSql, counter + 1);
            //    pathAndSql[counter] = text;
            //    counter++;
            //}
            //string con = String.Format("{0}{1}{2}", pathAndSql[0], Application.StartupPath,pathAndSql[2]);
            //MessageBox.Show(con);
            //conTest = new OleDbConnection(con);
        }
        //static string conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+ Application.StartupPath +"\\dbRandevu.accdb";

        DataAccessClass dac = new DataAccessClass();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            tbSifre.UseSystemPasswordChar = true;

            try
            {
                FileStream fs = new FileStream($@"{Application.StartupPath}\RandevuTuru.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string _text;
                while ((_text = sr.ReadLine()) != null)
                {
                    cbRandevuTuru.Items.Add(_text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void btnRandevuListele_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }
        private void sifirla()
        {
            tbRandevuID.Text = string.Empty;
            tbIsim.Text = "";
            tbSifre.Text = String.Empty;
            cbRandevuTuru.SelectedIndex = -1;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(tbIsim.Text != "" && tbRandevuID.Text != "" && tbSifre.Text != "" && cbRandevuTuru.SelectedIndex != -1)
            {
                dac.veriYaz(tbRandevuID, tbIsim, tbSifre, dtpTarihSec.Text, cbRandevuTuru.SelectedText);
                MessageBox.Show("Kayıt Başarılı");
                sifirla();
            }
            else
            {
                MessageBox.Show("Boş alan bırakmayın");
            }
        }
    }
}

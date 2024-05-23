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

namespace _1X.Hafta__23._05._24_
{
    public partial class Form1 : Form
    {
        
        static string conStr = "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=" + @"C:\Users\selcu\Masaüstü" + "\\normalOgretim.accdb;";
        //  "Jet OLEDB:Database Password=4444";

        OleDbConnection baglanti = new OleDbConnection(conStr);
        OleDbCommand cmd;

        public Form1()
        {
            InitializeComponent();
            tabloOku("ogrenciler");
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabloOku(string tabloAdi)
        {
            string sqlKomut = "select * from " + tabloAdi;
            DataTable dt = new DataTable();
            if (baglanti.State != ConnectionState.Open)
                baglanti.Open();
            OleDbCommand komut = new OleDbCommand(sqlKomut, baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            da.Fill(dt);
            baglanti.Close();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlKomut = "insert into ogrenciler (adi, soyadi, vizeNotu, finalNotu) values ('emirhan', 'demirel', '80', '100');";
            if(baglanti.State != ConnectionState.Open)
                baglanti.Open();
            cmd = new OleDbCommand(sqlKomut, baglanti);
            cmd.ExecuteNonQuery(); // sadece sql komutunu işlet 
            tabloOku("ogrenciler");
            baglanti.Close();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string sqlKomut = "insert into ogrenciler (adi, soyadi, vizeNotu, finalNotu) values " +
                            "('"+txtAdi.Text+"', '"+txtSoyadi.Text+"', "+txtVize.Text+", "+txtFinal.Text+");";
            if (baglanti.State != ConnectionState.Open)
                baglanti.Open();
            cmd = new OleDbCommand(sqlKomut, baglanti);
            cmd.ExecuteNonQuery(); // sadece sql komutunu işlet 
            tabloOku("ogrenciler");
            baglanti.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sqlKomut = "update ogrenciler set finalNotu = 10 where adi='mehmetAli'";
            using (OleDbConnection cn = new OleDbConnection(conStr))
            {
                try
                {
                    if (cn.State != ConnectionState.Open)
                        cn.Open();
                    using (OleDbCommand cm = new OleDbCommand(sqlKomut, cn))
                    {
                        cm.ExecuteNonQuery();
                    }
                }
                finally
                {
                    tabloOku("ogrenciler");
                    cn.Close();
                }

            }
            //if (baglanti.State != ConnectionState.Open)
            //    baglanti.Open();
            //cmd = new OleDbCommand(sqlKomut, baglanti);
            //cmd.ExecuteNonQuery(); // sadece sql komutunu işlet 
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sqlKomut = "delete * from ogrenciler where adi='emirhan' and kayitNo = 10";
            if (baglanti.State != ConnectionState.Open)
                baglanti.Open();
            cmd = new OleDbCommand(sqlKomut, baglanti);
            if (MessageBox.Show("Silme işlemi yapılsın mı?\nBu işlem geri alınamaz!", "Dikkat!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery(); // sadece sql komutunu işlet 
                tabloOku("ogrenciler");
                baglanti.Close();
            }
            
        }
    }
}

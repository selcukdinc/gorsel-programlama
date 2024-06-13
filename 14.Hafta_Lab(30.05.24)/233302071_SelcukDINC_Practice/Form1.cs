using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _233302071_SelcukDINC_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            veriGoster();
        }

        //static string _conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+ Application.StartupPath +@"\dbStudents.accdb";
        static string _conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+ Application.StartupPath +"\\dbStudents.accdb";

        private void veriYaz()
        {
            try
            {
                using (OleDbConnection bag = new OleDbConnection(_conString))
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = bag;
                    cmd.CommandText = "INSERT INTO tblStudents (ogrAd, ogrNo, ogrEposta) VALUES (P1, P2, P3)";
                    cmd.Parameters.Add("@P1", OleDbType.VarChar).Value = tbAd.Text;
                    cmd.Parameters.Add("@P2", OleDbType.SmallInt).Value = Convert.ToInt32(tbOgNo.Text);
                    cmd.Parameters.Add("@P3", OleDbType.VarChar).Value = tbEposta.Text;
                    bag.Open();
                    cmd.ExecuteNonQuery();
                    bag.Close();
                }
                tbAd.Text = "";
                tbOgNo.Text = "";
                tbEposta.Text = "";
                veriGoster();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void veriGoster()
        {
            try
            {
                using (OleDbConnection bag = new OleDbConnection(_conString))
                using (OleDbCommand cmd1 = new OleDbCommand())
                {
                    cmd1.Connection = bag;
                    cmd1.CommandText = "SELECT * FROM tblStudents";
                    DataTable dt = new DataTable();
                    bag.Open();
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd1);
                    da.Fill(dt);
                    bag.Close();
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (tbAd.Text != "" && tbOgNo.Text != "" && tbEposta.Text != "")
            {
                veriYaz();
                veriGoster();
            }
            else MessageBox.Show("Boş Alan Bırakmayın");
        }

      
    }
}

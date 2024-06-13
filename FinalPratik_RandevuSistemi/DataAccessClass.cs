using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPratik_RandevuSistemi
{
    internal class DataAccessClass
    {
        static string[] pathAndSql = new string[0];
        OleDbConnection conTest;
        string dbConnection = "";
        public DataAccessClass()
        {
            string path = $"{Application.StartupPath}\\con&Sql.txt";
            FileStream fs = new FileStream(path, FileMode.Open);
            StreamReader sw = new StreamReader(fs);
            string text;
            int counter = 0;
            while ((text = sw.ReadLine()) != null)
            {
                Array.Resize(ref pathAndSql, counter + 1);
                pathAndSql[counter] = text;
                counter++;
            }
            string con = String.Format("{0}{1}{2}", pathAndSql[0], Application.StartupPath, pathAndSql[2]);
            //MessageBox.Show(con);
            dbConnection = con;
            conTest = new OleDbConnection(con);
            fs.Close();
            conTest.Open();
            conTest.Close();
        }

        public void verOku(DataGridView dgv)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(dbConnection))
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "select * from tblRandevu";
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    con.Open();
                    da.Fill(dt);
                    con.Close();
                    dgv.DataSource = dt;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void veriYaz(TextBox tbRandveuID, TextBox tbIsim, TextBox tbSifre, string RandevuTarihi, string RandevuTuru)
        {
            try
            {
                using(OleDbConnection con = new OleDbConnection(dbConnection))
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO tblRandevu (RandevuID, Isim, Sifre, RandevuTarihi, RandevuTuru) values (P1,P2,P3,P4,P5)";
                    cmd.Parameters.Add("P1", OleDbType.VarChar).Value = tbRandveuID.Text;
                    cmd.Parameters.Add("P2", OleDbType.VarChar).Value = tbIsim.Text;
                    cmd.Parameters.Add("P3", OleDbType.VarChar).Value = tbSifre.Text;
                    cmd.Parameters.Add("P4", OleDbType.VarChar).Value = RandevuTarihi;
                    cmd.Parameters.Add("P5", OleDbType.VarChar).Value = RandevuTuru;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

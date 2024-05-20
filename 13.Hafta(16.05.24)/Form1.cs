using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13.Hafta_16._05._24_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] harfler = { "A","B","C","D" };
            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 3;
            //dataGridView1[1, 2].Value = "hey hey hey";
            Random R = new Random();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1[i, j].Value = R.Next(50,101); 
                }
            }
            //MessageBox.Show(
            //[2,0].Value.ToString());
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].HeaderText = harfler[i];
                dataGridView1.Rows[i].HeaderCell.Value = $"{i + 1}";
            }

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].Width = 150;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable("ogrenciler");
            
            dt1.Columns.Add("ogrenciNo", typeof(int));
            dt1.Columns.Add("ogrenciAdi", typeof(string));

            dt1.Rows.Add(123, "Ali");
            dt1.Rows.Add(124, "Veli");
            dt1.Rows.Add(125, "Volkan");

            //dataGridView1.DataSource = dt1;


            DataTable dt2 = new DataTable("notlar");

            dt2.Columns.Add("ogrenciNo", typeof(int));
            dt2.Columns.Add("notu", typeof(int));

            dt2.Rows.Add(123, 25);
            dt2.Rows.Add(124, 30);
            dt2.Rows.Add(125, 35);

            DataSet ds = new DataSet("Kayitlar");
            ds.Tables.Add(dt1);
            ds.Tables.Add(dt2);

            dataGridView1.DataSource = ds.Tables[1];// indis yerine tablonun adıda kullanılabilir
        
        }

        /*
         
            //MessageBox.Show("satır no:"+e.RowIndex.ToString());
            //MessageBox.Show("sütun no:" + e.ColumnIndex.ToString());
            //MessageBox.Show("içerideki veri =" + dataGridView1[e.ColumnIndex,e.RowIndex].Value);
         
         */

        int selectedRow = -1, selectedColumn = -1;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            selectedColumn = e.ColumnIndex;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!dataGridView1.Rows[selectedRow].IsNewRow && !dataGridView1.Columns[selectedColumn].IsDataBound)
            {
                dataGridView1.Rows.RemoveAt(selectedRow);
                dataGridView1.Columns.RemoveAt(selectedColumn);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dataGridView1.SelectedRows.Count.ToString());
            
            // Çözüm 1
            //for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            //{
            //    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[i].Index);
            //    button3.PerformClick();
            //}


            //çözüm 2
            while (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            
        }


    }
}

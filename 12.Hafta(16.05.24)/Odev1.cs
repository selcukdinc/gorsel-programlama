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
    public partial class Odev1 : Form
    {
        public Odev1()
        {
            InitializeComponent();
        }

        excelControl ec = new excelControl();

        private void Odev1_Load(object sender, EventArgs e)
        {
            ec.createNewSheet(tcMain, this);
            
        }


        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcMain.SelectedTab == tpCreate)
            {
                ec.createNewSheet(tcMain, this);
            }
        }


        private void btnAlignClick(object sender, EventArgs e)
        {
            ec.btnAlignClick(sender, e, tcMain);
        }


        private void btnFormatClick(object sender, EventArgs e)
        {
            ec.FormatClick(sender, e, tcMain);
            DataGridView selectedDGV = ec.getActiveDGV(tcMain);
            selectedDGV.Focus();
        }


        int selectedCellRow = -1, selectedCellColumn = -1;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView selectedCell = (DataGridView)sender;
            selectedCellRow = e.RowIndex;
            selectedCellColumn = e.ColumnIndex;
        } 


        private void btnDeleteRowCloumn_Click(object sender, EventArgs e)
        {
            DataGridView selectedDGV = new DataGridView();
            foreach (var i in tcMain.SelectedTab.Controls.OfType<DataGridView>().ToList())
            {
                if (i.Name.Contains($"dgv{tcMain.SelectedIndex}"))
                {
                    selectedDGV = i;
                }
            }

            if (ec.selectedCellRow != -1 && ec.selectedCellColumn != -1)
            {
                selectedDGV.Rows.RemoveAt(ec.selectedCellRow);
                selectedDGV.Columns.RemoveAt(ec.selectedCellColumn);
            }
        }
    }
}

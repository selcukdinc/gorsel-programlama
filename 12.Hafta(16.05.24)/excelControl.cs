using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13.Hafta_16._05._24_
{
    internal class excelControl
    {
        // Yeni sütun eklemek için chatgpt'nin hazırlamış olduğu cevap 
        public string GetExcelColumnName(int columnNumber)
        {
            string columnName = "";
            while (columnNumber > 0)
            {
                columnNumber--; // 1 tabanlı sistemden 0 tabanlı sisteme geçiş
                int remainder = columnNumber % 26;
                columnName = (char)(remainder + 'A') + columnName;
                columnNumber = (columnNumber - remainder) / 26;
            }
            return columnName;
        }

        public void createNewSheet(TabControl tc, Control frm)
        {
            int newTabIndex = tc.TabCount - 1;
            tc.TabPages.Insert(newTabIndex, $"Yeni sayfa {newTabIndex}");
            DataGridView dgv = new DataGridView
            {
                Name = $"dgv{newTabIndex}",
                ColumnCount = 150,
                RowCount = 100,
                RowHeadersWidth = 80,
                Dock = DockStyle.Fill
            };
            tc.TabPages[newTabIndex].Controls.Add(dgv);
            dgv[0, 0].Value = $"Çalışma sayfası {newTabIndex}";
            dgv.Columns[0].Width = 150;
            dgv.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvMain_Scroll);
            dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            firstRunColumn(dgv, 150);
            firstRunRow(dgv, 100);
            dgv.BringToFront();
            tc.SelectedIndex = newTabIndex;
        }

        public int selectedCellRow = -1, selectedCellColumn = -1;
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView selectedCell = (DataGridView)sender;
            selectedCellRow = e.RowIndex;
            selectedCellColumn = e.ColumnIndex;
        }

        private void firstRunColumn(DataGridView dgv, int maxColumn)
        {
            for (int i = 0; i < maxColumn; i++)
            {
                dgv.Columns[i].HeaderText = this.GetExcelColumnName(i + 1);
            }
        }

        private void firstRunRow(DataGridView dgv, int maxRow)
        {
            for (int i = 0; i < maxRow; i++)
            {
                dgv.Rows[i].HeaderCell.Value = $"{i + 1}";
            }
        }

        private void dgvMain_Scroll(object sender, ScrollEventArgs e)
        {
            // İsteği gönderen DataGridView nesnesini 'dgvselected' adında yeni bir nesneye tanımla
            DataGridView dgvSelected = (DataGridView)sender;
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll) // dikey kaydırma yapıldığında
            {
                if (e.NewValue > e.OldValue)// kaydırıldığında 'kaydırma değeri' ilk değerine göre büyük mü?
                {// evet büyük, yeni satır ekle
                    int RowIndex = dgvSelected.Rows.Add();
                    dgvSelected.Rows[RowIndex - 1].HeaderCell.Value = $"{RowIndex}";
                }
            }
            else if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll) // yatay kaydırma yapıldığında
            {
                if (e.NewValue > e.OldValue)// kaydırıldığında 'kaydırma değeri' ilk değerine göre büyük mü?
                {// evet büyük, yeni sütun ekle
                    string result = this.GetExcelColumnName(dgvSelected.ColumnCount); // Yazdırılacak sütunun ismini getir (chatgpt 3.5'in cevabı)
                    dgvSelected.Columns.Add(result, result);
                }
            }
        }



        // Kodu okurken kolaylık sağlaması açısından butonların seçme işlemleri enum ile yapılması tercih edilmiştir.
        enum cellAlignment 
        {
            Left, Center, Right, def
        }
        
        public DataGridView getActiveDGV(TabControl tc)
        {
            DataGridView dgv = new DataGridView();
            foreach (var i in tc.SelectedTab.Controls.OfType<DataGridView>().ToList())
            {
                if (i.Name.Contains($"dgv{tc.SelectedIndex}"))
                {
                    dgv = i;
                }
            }
            return dgv;
        }

        public void btnAlignClick(object sender, EventArgs e, TabControl tc)
        {
            Button btn = (Button)sender;

            // ekranda aktif olarak açık olan dgv'nin bulunması
            DataGridView selectedDGV = getActiveDGV(tc);

            // tıklanan butona göre 'selectedAlignment' adında değişkene seçimi kaydetme bölümü
            cellAlignment selectedAlignment = cellAlignment.def;
            
            if (btn.Name == "btnLeft")
            {
                selectedAlignment = cellAlignment.Left;
            }
            else if (btn.Name == "btnCenter")
            {
                selectedAlignment = cellAlignment.Center;
            }
            else
            {
                selectedAlignment = cellAlignment.Right;
            }

            // seçili hücrelere her döngüde bir hücrenin 'alignment' özelliğini değiştiren döngü
            DataGridViewCell selectedCell;
            
            for (int i = 0; i < selectedDGV.SelectedCells.Count; i++)
            {
                selectedCell = selectedDGV.SelectedCells[i];
                switch (selectedAlignment)
                {
                    case cellAlignment.Left:
                        selectedCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    
                    case cellAlignment.Center:
                        selectedCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    
                    case cellAlignment.Right:
                            selectedCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    
                    case cellAlignment.def:
                        break;
                }
            }
        }
        enum texFormat
        {
            foreColor, backColor, wrap, font, def
        }
        public void FormatClick(object sender, EventArgs e, TabControl tc)
        {
            Button btn = (Button)sender;
            DataGridView selectedDGV = getActiveDGV(tc);
            texFormat selectedFormat = texFormat.def;

            ColorDialog cd = new ColorDialog();
            FontDialog fd = new FontDialog();

            if (btn.Name == "btnBackcolor")
            {
                if(cd.ShowDialog() == DialogResult.OK)
                    selectedFormat = texFormat.backColor;
            }
            else if (btn.Name == "btnFont")
            {
                if (fd.ShowDialog() == DialogResult.OK)
                    selectedFormat = texFormat.font;
            }
            else if (btn.Name == "btnForecolor")
            {
                if (cd.ShowDialog() == DialogResult.OK)
                    selectedFormat = texFormat.foreColor;
            }
            else if (btn.Name == "btnWrap")
            {
                selectedFormat = texFormat.wrap;
            }

            DataGridViewCell selectedCell;
            if(selectedFormat != texFormat.def)
            for (int i = 0; i < selectedDGV.SelectedCells.Count; i++)
            {
                selectedCell = selectedDGV.SelectedCells[i];
                
                switch (selectedFormat)
                {
                    case texFormat.foreColor:
                        selectedCell.Style.ForeColor = cd.Color;
                        break;


                    case texFormat.backColor:    
                            selectedCell.Style.BackColor = cd.Color;
                        break;


                    case texFormat.wrap:

                        if (selectedCell.Style.WrapMode != DataGridViewTriState.True)
                            selectedCell.Style.WrapMode = DataGridViewTriState.True;
                        else
                            selectedCell.Style.WrapMode = DataGridViewTriState.False;
                        break;


                    case texFormat.font:
                        selectedCell.Style.Font = fd.Font;
                        break;
                }
            }

        }



    }
}

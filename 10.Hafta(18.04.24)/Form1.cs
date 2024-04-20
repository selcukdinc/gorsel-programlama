using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _10.Hafta_18._04._24_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum NIList
        {
            None, Info, Warning, Error
        }
        NIList secilen = NIList.None;
        private void Form1_Load(object sender, EventArgs e)
        {
            //timer1.Start();
            cbNIIcon.SelectedItem = 0;
            for (int i = 0; i < Enum.GetNames(typeof(NIList)).Length; i++)
            {
                cbNIIcon.Items.Add($"{Enum.GetName(typeof(NIList), i)}");
            }
            cbNIIcon.Text = secilen.ToString();

            flpSol.FlowDirection = FlowDirection.TopDown;

            tooltipAyarla();
        }
        private void tooltipAyarla()
        {
            tp1.AutoPopDelay = 5000;
            tp1.InitialDelay = 1000;
            tp1.ReshowDelay = 500;
            tp1.ToolTipIcon = ToolTipIcon.Info;
            tp1.ToolTipTitle = "Uyarı..!";
            tp1.IsBalloon = true;
            tp1.SetToolTip(tbKimlikTooltip, "Burada kayıt işlemleri yapılır");
        }
        #region Kısaltma


        private void timer1_Tick(object sender, EventArgs e)
        {
            string saat = DateTime.Now.ToLongTimeString();
            toolStripStatusLabel2.Text = $"saat: {saat}";
            toolStripProgressBar1.Value = DateTime.Now.Second;
            //TimeSpan ts = new TimeSpan(dt,2,3);

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            rtbMetin.ZoomFactor = tbMetinBoyut.Value;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
                rtbMetin.SelectionFont = fd.Font;
        }

        private void btnArkaRenk_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                rtbMetin.SelectionBackColor = cd.Color;
        }

        private void btnSecilenGoster_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtbMetin.SelectedText,"Seçilen metin");
        }

        private void MetniHizala(object sender, EventArgs e)
        {
            RadioButton rdbtn = (RadioButton)sender;
            switch (rdbtn.Name)
            {
                case "rdbOrta":
                    if (rtbMetin.SelectedText != String.Empty)
                        rtbMetin.SelectionAlignment = HorizontalAlignment.Center;
                    else
                    {
                        rtbMetin.SelectAll();
                        rtbMetin.SelectionAlignment = HorizontalAlignment.Center;
                    }
                    break;
                case "rdbSag":
                    if (rtbMetin.SelectedText != String.Empty)
                        rtbMetin.SelectionAlignment = HorizontalAlignment.Right;
                    else
                    {
                        rtbMetin.SelectAll();
                        rtbMetin.SelectionAlignment = HorizontalAlignment.Right;
                    }
                    break;
                case "rdbSol":
                    if (rtbMetin.SelectedText != String.Empty)
                        rtbMetin.SelectionAlignment = HorizontalAlignment.Left;
                    else
                    {
                        rtbMetin.SelectAll();
                        rtbMetin.SelectionAlignment = HorizontalAlignment.Left;
                    }
                    break;
                default:MessageBox.Show("Hatalı tanımlama yaptın,\n\tMetinHizala > Switch-Case");break;
            }
        }

        private void btnSonra_Click(object sender, EventArgs e)
        {
            if (rtbMetin.CanRedo == true)
                rtbMetin.Redo();
        }

        private void btnOnce_Click(object sender, EventArgs e)
        {
            if (rtbMetin.CanUndo == true)
                rtbMetin.Undo();
        }

        private void btnUstKarakter_Click(object sender, EventArgs e)
        {
            int type = rtbMetin.SelectionCharOffset;
            if (type <= 0)
            {
                rtbMetin.SelectionCharOffset = 10;
                btnUstKarakter.FlatStyle = FlatStyle.Flat;
                btnAltKarakter.FlatStyle = FlatStyle.Standard;
            }
            else
            {
                rtbMetin.SelectionCharOffset = 0;
                btnUstKarakter.FlatStyle = FlatStyle.Standard;
            }
        }

        private void btnAltKarakter_Click(object sender, EventArgs e)
        {
            int type = rtbMetin.SelectionCharOffset;
            if (type >= 0)
            {
                rtbMetin.SelectionCharOffset = -10;
                btnAltKarakter.FlatStyle = FlatStyle.Flat;
                btnUstKarakter.FlatStyle = FlatStyle.Standard;
            }
            else
            {
                rtbMetin.SelectionCharOffset = 0;
                btnAltKarakter.FlatStyle = FlatStyle.Standard;
            }
                
        }

        private void btnSakla_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            
            sfd.Filter = "Zengin Metin Belgesi | *.rtf";
            sfd.Title = "Metni Kaydet";
            sfd.InitialDirectory = Application.StartupPath;         
            if(sfd.ShowDialog() == DialogResult.OK){
                string result = "", resultF = "", fileEdited = sfd.FileName, trimMain = $"{Application.StartupPath}\\", fileType = ".rtf";
                for (int i = 0; i < trimMain.Length; i++)
                {
                    result = fileEdited.TrimStart(trimMain[i]);
                    fileEdited = result;
                }
                for(int i = fileType.Length-1; i >= 0; i--)
                {
                    resultF = result.TrimEnd(fileType[i]);
                    result = resultF;
                }
                    
                this.Text = result;
                rtbMetin.SaveFile(sfd.FileName);
            }
        }

        private void boslukMadde(object sender, EventArgs e)
        {
            switch (cbBosluk.Checked){
                case true:  rtbMetin.SelectionIndent = 8; break;
                case false: rtbMetin.SelectionIndent = 0; break;
            }
            switch (cbMadİsrt.Checked){
                case true:  rtbMetin.SelectionBullet = true; break;
                case false: rtbMetin.SelectionBullet = false; break;
            }
        }

        private void tabKontrol(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            switch (rdb.Name)
            {
                case "rdbTop":      tabControlMain.Alignment = TabAlignment.Top;    break;
                case "rdbLeft":     tabControlMain.Alignment = TabAlignment.Left;   break;
                case "rdbRight":    tabControlMain.Alignment = TabAlignment.Right;  break;
                case "rdbBottom":   tabControlMain.Alignment = TabAlignment.Bottom; break;
                default: MessageBox.Show("Hatalı tanımlama yaptın,\n\tabKontrol > Switch-Case"); break;
            }
        }

        private void tabGecis(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnTabOnce":
                    int aktifV1 = tabControlMain.SelectedIndex;
                    if(aktifV1 - 1 >= 0)
                    {
                        tabControlMain.SelectTab(--aktifV1);
                    }
                    break;
                case "btnTabSonraki":
                    int aktifV2 = tabControlMain.SelectedIndex;
                    if (aktifV2 + 1 < tabControlMain.TabPages.Count)
                        tabControlMain.SelectTab(++aktifV2);
                    break;
                default: MessageBox.Show("Hatalı tanımlama yaptın,\n\tTabGecis > Switch-Case"); break;
            }
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedIndex == 1)
                dtpBaslangic.Value = new DateTime(2002, 01, 12);
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            DateTime std = dtpBaslangic.Value.Date;
            DateTime etd = dtpBitis.Value.Date;

            TimeSpan ts = etd - std;
            int day = ts.Days;
            int month = ((etd.Year - std.Year) * 12) + etd.Month - std.Month;
            //int year = (etd.Year - std.Year);
            //double yearV2 = (double)month / 12
            double yearV3 = (double)day / 365.4;  // En hassas ölçümü gün hesabında, yılların artık zamanını ekleyerek buluruz
            lblYil.Text = $"Yıl : {Math.Round(yearV3, 2)}";
            lblAy.Text = $"Ay: {month}";
            lblGun.Text = $"Gün: {day}";
        }

        private void mcTakvim_DateChanged(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show($"{mcTakvim.SelectionStart.ToLongDateString()}");
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            Satranc(flpSol, 3);
            Satranc(flpSag, 5);
        }

        private void Satranc(FlowLayoutPanel flp, int bosluk)
        {
            flp.Controls.Clear();
            bool siyah = false;
            int syc = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Button btn = new Button() { Name = $"{flp.Name}_btn_{syc}", Size = new Size(30, 30), FlatStyle = FlatStyle.Flat};
                    switch (siyah)
                    {
                        case true:
                            btn.Text = $"{syc++}";
                            btn.FlatAppearance.BorderSize = 0;
                            btn.ForeColor = Color.White;
                            btn.BackColor = Color.Black;
                            siyah = false;
                            break;
                        case false:
                            btn.Text = $"{syc++}";
                            btn.FlatAppearance.BorderSize = 0;
                            btn.ForeColor = Color.Black;
                            btn.BackColor = Color.White;
                            siyah = true;
                            break;
                    }
                    btn.Margin = new Padding(bosluk);
                    flp.Controls.Add(btn);
                    btn.Click += new EventHandler(strncBtnClick);
                }
                siyah = (siyah == true) ? false : true;
            }
        }

        private void strncBtnClick(object sender, EventArgs e){
            Button btn = (Button)sender;
            MessageBox.Show($"{btn.Name} isimli butona tıkladın");
        }

        #endregion

        private void btnMsjGndr_Click(object sender, EventArgs e)
        {
            switch (secilen)
            {
                case NIList.None: notifyIcon1.BalloonTipIcon = ToolTipIcon.None; break;
                case NIList.Info: notifyIcon1.BalloonTipIcon = ToolTipIcon.Info; break;
                case NIList.Warning: notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning; break;
                case NIList.Error: notifyIcon1.BalloonTipIcon = ToolTipIcon.Error; break;
            }
           
                notifyIcon1.ShowBalloonTip(Convert.ToInt32(tbNISure.Text), tbNIBaslik.Text, tbNIMesaj.Text, notifyIcon1.BalloonTipIcon);
        }

        private void cbNIIcon_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilen = (NIList)cbNIIcon.SelectedIndex;
            //MessageBox.Show($"{secilen}");
        }

        private void btnKaydetBilgiler_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tbKimlikBilgiler.Text))
            {
                ep1.SetError(tbKimlikBilgiler, "Tc kimlik no girin...");
            }else if (String.IsNullOrEmpty(tbTelBilgiler.Text))
            {
                ep1.SetError(tbTelBilgiler, "Telefon numarası girin...");
            }else if(tbKimlikBilgiler.Text.Length != 11)
            {
                ep1.SetError(tbKimlikBilgiler, "11 Haneli TC no girin...");
            }else if (lbTcTel.Items.Contains($"{tbKimlikBilgiler.Text} {tbTelBilgiler.Text}"))
            {
                ep1.SetError(tbKimlikBilgiler, "Daha önce eklendi...");
                ep1.SetError(tbTelBilgiler, "Daha önce eklendi...");
            }else
            {
                lbTcTel.Items.Add($"{tbKimlikBilgiler.Text} {tbTelBilgiler.Text}");
                tbTelBilgiler.Text = String.Empty;
                tbKimlikBilgiler.Text = String.Empty;
                ep1.Clear();
                tbKimlikBilgiler.Focus();
            }
        }
    }
    /*
     * 
     *  HAFTAYA HATIRLATMA,
     *          ANCHOR VE DOCK HATIRLATILACAK, derste dock özelliği gösterildi
     *  
     * rich textbox, tab control, date time picker, flow layout, tooltip
     * rich textbox: normal textbox'tan daha çok görsel fayda sağlar.
     *      zoom factor; yakınlaştırma
     *      link ; güncel versiyonlarda çalışmıyor
     *      yapılan işlemleri geriye ve sonrasında ileriye sarabiliriz
     *      .SelectionBackColor     Seçilen metnin arkaplan rengini değiştirebiliriz    
     *      .SelectionFont          Seçilen metnin fontunu değiştirebiliriz         
     *      .SelectionAlignment     Seçilen metnin 
     *      .SelectionIndent        boşluk verilir
     *      .SelectionBullet        madde işareti verir
     *      
     *      .canUndo --> bool statements
     *      .canRedo --> bool statements
     *      
     *      .Redo();
     *      .Undo();
     *      
     *      .Selectioncharoffset    üst veya alt karakter
     *      
     *      Application.StartupPath;
     *      SaveFileDialog
     *      "Zengin Metin | *.rtf"
     *      
     * deteced url; .Net framework 4.8'de çalışmıyor, 4.6'ya geçildiğinde çalışabiliyor
     *                  Project > Properties > Target Framework
     * 
     * 
     * farklı butonlarla aynı metotu çalıştırabiliriz,
     *      Button btn = (Button)sender;
     *          şeklinde bir kullanım ile 
     *          sender, gönderen, yönlendiren komponentin bilgileri taşır.
     *          
     *  
     *  
     *  
     *  Tab Kontrol
     *  tab control | tab page arasındaki fark
     *          sekmelerle ilgili işlemler için tab control
     *          sekme içinde bir özellikle işlemler için tab page control
     *  
     *  tab page control grubunda, 
     *          radiobutonları aynı methota bağlanmış
     *  
     *      .SelectedIndex;
     *      .SelecetTab(int x);
     *      .TabControl.TabPages.Add(string x); x tab text'i olabilir // string ifade vermeden yeni tab oluşur mu?
     *      // tabpages değişimi sırasında 0 index'inde -1 değeri alırsa ne olur?
     *      
     *      Event, 
     *      SelectedIndexChanged       tablar arası geçiş olduğunda çalışan event
     *      
     *
     *  Date Time Picker
     *  combobox şeklilnde kullanılabilir
     *  S Y N T A X
     *      DateTime std = dtStart.Value.Data;
     *      DateTime edt = dtEnd.Value.Data;
     *      TimeSpan ts
     *      
     *      dtStart 
     *          tarih formatları    Long, short
     *          
     *     Mounth Calendar
     *     Width : sütunda kaç adet ay olsun
     *     Height: satırda kaç adet ay olsun
     *          Event
     *              dateChanged
     *     
     *     FlowLayoutPanel
     *          panel       -->     Container
     *          groupBox    -->     Container
     *     bir akış içerisinde komponenetleri sıralar, panel ve groupBox'tan farkı budur
     *     
     *     Dock ile panellerin konumları değiştirilebilir
     *     
     *     Error Provider 
     *     .SetError(object x, )
     *     
     *     NotifyIcon
     *     bildirim göndermek için kullanılır
     *     
     *     ToolTip
     *     fareyi üzerinde tuttuğumuz komponent hakkında bilgi alabiliriz
     *     
     *     Context Menu Strip || Menu Strip
     *          Menu Strip              formun üstünde görünür
     *          Context Menu Strip      sağ tıklandığında açılır
     *          
     *      Context Menu Strip
     *          component özelinde atama yapılabilir
     *      
     *      Menu Strip 
     *          seperator eklenebilir
     *          comboBox, textBox eklenebilir
     *     
     *      statusStrip
     *          spring özelliği
     *      
     *      timer
     *          tick özelliği
     *          interval milisaiyede cinsinden tick olayını çalıştırır
     *          .Start(); 
     *          ile çalıştırılmalı
     */

    // <a href="https://www.flaticon.com/free-icons/shoot" title="shoot icons">Shoot icons created by Freepik - Flaticon</a>
}

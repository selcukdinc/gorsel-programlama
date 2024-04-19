using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10.Hafta_18._04._24_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            rtbMetin.ZoomFactor = tbMetinBoyut.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string saat = DateTime.Now.ToLongTimeString();
            toolStripStatusLabel2.Text = $"saat: {saat}";
            toolStripProgressBar1.Value = DateTime.Now.Second;
            //TimeSpan ts = new TimeSpan(dt,2,3);

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

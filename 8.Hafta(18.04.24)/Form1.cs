using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8.Hafta_18._04._24_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = trackBar1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 50;
            //progressBar1.Value += 12;
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
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12.Hafta_02._05._24_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //tabControl1.SelectTab(3);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            statusStrip1.GripStyle = ToolStripGripStyle.Hidden;
            btnGroupLoc.Enabled = false;
        }

        #region TreeViewSection

        // Dersin ilk 20 dakikası yazılanlar ⬇️
        private void btnNodeAddV1_Click(object sender, EventArgs e)
        {
            // yapıyı oluştur
            TreeNode tn1 = new TreeNode("Root1");
            TreeNode tn2 = new TreeNode("Root2");
            TreeNode tn3 = new TreeNode("Root3");
            TreeNode[] tnDizi = { tn1, tn2, tn3 };
            treeView1.Nodes.AddRange(tnDizi); // Dizi olduğu zaman .addRange kullanılması uygun olur
            TreeNode tn4 = new TreeNode("R1_child1");
            treeView1.Nodes[0].Nodes.Add(tn4);
            TreeNode tn5 = new TreeNode("R1_child_child1");
            treeView1.Nodes[0].Nodes[0].Nodes.Add(tn5);
            //MessageBox.Show(treeView1.Nodes[0].Nodes[0].Nodes[0].Text);
            TreeNode tn6 = new TreeNode("R2_child1");
            TreeNode tn7 = new TreeNode("R2_child2");
            treeView1.Nodes[1].Nodes.Add(tn6);
            treeView1.Nodes[1].Nodes.Add(tn7);
        }

        private void getir()
        {
            string[] suruculer = Directory.GetLogicalDrives();

            foreach (string s in suruculer)
            {
                treeView1.Nodes.Add(s);
            }
        }

        private void btnNodeAddV2_Click(object sender, EventArgs e)
        {
            getir();
        }
        // Dersten bağımsız, hazır verilen uygulamanın içinden.
        private void btnNodeAddV3_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string yol = treeView1.SelectedNode.Text;

            try
            {
                string[] dosyalar = Directory.GetFiles(yol);
                string[] klasorler = Directory.GetDirectories(yol);
                foreach (string s in dosyalar)
                    e.Node.Nodes.Add(s);

                foreach (string s in klasorler)
                    e.Node.Nodes.Add(s);
                e.Node.Expand();
            }
            catch (Exception)
            {
                try
                {
                    System.Diagnostics.Process.Start(yol);
                }
                catch (Exception)
                {
                    ;
                }
            }
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }

        // Add new nodes
        int subNum = 0;
        private void treeView1_AfterSelectV2(object sender, TreeViewEventArgs e)
        {
            TreeNode tn1 = new TreeNode($"{e.Node.Text}_child1");
            TreeNode tn2 = new TreeNode($"{e.Node.Text}_child2");
            TreeNode tn3 = new TreeNode($"{e.Node.Text}_child3");
            TreeNode[] tnDizi = { tn1, tn2, tn3 };
            e.Node.Nodes.AddRange(tnDizi);
        }

        private void btnNodeAdd1_Click(object sender, EventArgs e)
        {
            treeView2.Nodes.Clear();
            subNum = 0;
            treeView2.Nodes.Add("Main Title");
            for (int i = 0; i < 2; i++)
            {
                TreeNode sub = new TreeNode($"Sub Title {i + 1}");
                treeView2.Nodes[0].Nodes.Add(sub);
            }

        }

        private void btnNodeAdd2_Click(object sender, EventArgs e)
        {


            treeView2.Nodes[0].Nodes[1].Nodes.Add("Sub title 3");
            for (int i = 0; i < 2; i++)
            {
                TreeNode subSub = new TreeNode($"Bottom sub title {i + 1}");
                treeView2.Nodes[0].Nodes[1].Nodes[subNum].Nodes.Add(subSub);
            }
            subNum++;




            // Bu iki kod arasındaki fark yukardaki kod önce üst dalı oluşturur, sonrasında alt dalları ekler
            // alttaki kod ise önce alt dallar tanımlanır ve bir diziye aktarılır, sonrasında yeni node oluşturma aşamasında metotta yazılarak oluşturulması sağlanır


            /*
            
            //bu şekilde yapılacabileceği gibi en alttaki nodları bir diziye aktardıktan sonra, 
            //bir üstündeki nodun elemanı şeklinde ekleme yöntemide kullanılabilir
            
            TreeNode tnsub1 = new TreeNode("sub Sub title 1");
            TreeNode tnsub2 = new TreeNode("sub Sub title 2");
            TreeNode[] subs = { tnsub1, tnsub2 };
            TreeNode tn = new TreeNode("sub title 3", subs); // Bahsedilen durum burdaki overload işlemidir, bu şlem sayesinde yeni node tanımlarken altındaki nodlarda eklenmiş olur
            treeView2.Nodes[0].Nodes[1].Nodes.Add(tn);
            
            */
        }
        #endregion


        #region ListViewSection

        Random R = new Random();
        int itemCount = 0;
        
        enum isimler
        {
            Ali, Ayşe, Mehmet, Zeynep, Mustafa, Fatma, Emre, Esra, Ahmet, Büşra, Hasan, Elif, İbrahim, Hatice, 
            Burak, Seda, Yusuf, Aslı, Osman, Derya, Ömer, Nazlı, Cem, Gizem, Serkan, Deniz, Murat, İrem, Eren, 
            Şeyma, Kerem, İpek, Barış, Pınar, Can, Gamze, Tolga, Selin, Umut, Ceren, Taylan, Bengü, Kaan, Defne, 
            Tarık, İlayda, Gökhan, Cansu, Alper, Sevim, Hakan
        }

        enum soyisimler
        {
            Yılmaz, Kaya, Demir, Çelik, Öztürk, Aydın, Arslan, Doğan, Tekin, Kocaman, Şahin, Erdoğan, Özdemir, Yıldırım, 
            Karadağ, Şen, Şimşek, Aksoy, Kılıç, Korkmaz, Alkan, Güler, Yıldız, Çetin, Aslan, Güneş, Koç, Avcı, Korkut, Taş, 
            Aktaş, Özkan, Atalay, Erten, Özmen, Serbest, Yavuz, Çolak, Ay, Tuna, Şeker, Çiçek, Akın, Öz, Polat, Özgür, 
            Karakuş, Şanlı, Saraçoğlu, Aytaç, Çalışkan
        }

        isimler isim;
        soyisimler soyisim;
        private void btnAddList1_Click(object sender, EventArgs e)
        {
            string[] icerik1 = {    $"{(isimler)R.Next(0, 51)}", // Rastgele isim seçme
                                    $"{(soyisimler)R.Next(0, 51)}", // Rastgele soyisim seçme
                                    $"{R.Next(100, 1000)} - {R.Next(100, 1000)} - {R.Next(100, 1000)}" // Rastgele telefon numarası oluşturma
                                };
                                

            string[] icerik2 = {    $"{isim = (isimler)R.Next(0, 51)}", // değişkene atanarak gelecekte bir yerde kullanılabilir veya yukardaki gibi değişkene atanmadan kullanılabilir
                                    $"{soyisim = (soyisimler)R.Next(0, 51)}", 
                                    $"{R.Next(100, 1000)} - {R.Next(100, 1000)} - {R.Next(100, 1000)}" 
                                };

            ListViewItem item1 = new ListViewItem(icerik1);
            ListViewItem item2 = new ListViewItem(icerik2);
            ListViewItem[] items = {item1, item2};
            listView1.Items.AddRange(items);

            listView1.SmallImageList = ımageList2;
            listView1.LargeImageList = ımageList1;

            listView1.Items[itemCount].ImageIndex = R.Next(0, ımageList1.Images.Count); // imagelist içerisinden rastgele bir image seçimi yapar
            listView1.Items[itemCount + 1].ImageIndex = R.Next(0, ımageList1.Images.Count);
            itemCount += 2; // itemCount gibi bir global değişken olmazsa program sonraki eklenen itemlerde image ekleyemez

            // Eğer Details modunda olmadan .CheckBoxes özelliğini true yapmaya çalışırsa program 'Seçilen görünümde CheckBox'lar desteklenmiyor' hatası verir
            if (listView1.View == View.Details)
                listView1.CheckBoxes = true;
        }

        private void listViewChanger(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            listView1.CheckBoxes = false;
            
            switch (btn.Name)
            {
                case "btnView":         listView1.View = View.Details;      break;
                case "btnLargeIcon":    listView1.View = View.LargeIcon;    break;
                case "btnDetails":      listView1.View = View.List;         break;
                case "btnSmallicon":    listView1.View = View.SmallIcon;    break;
                case "btnTile":         listView1.View = View.Tile;         break;
            }
        }

        

        private void btnAddList2_Click(object sender, EventArgs e)
        {
            listView2.Clear();
            listView2.SmallImageList = ımageList2;

            ColumnHeader pAdi = new ColumnHeader() {
                Text = "Personel Adı", 
                ImageIndex = 0, 
                Width = 100
            } ;
            ColumnHeader pSoyadi = new ColumnHeader() {
                Text = "Personel Soyadı",
                ImageIndex = 1,
                Width = 150
            };
            ColumnHeader pId = new ColumnHeader(){
                Text = "Id",
                ImageIndex = 2,
                Width = 50
            };
            ColumnHeader[] basliklar = { pAdi, pSoyadi , pId};
            listView2.Columns.AddRange(basliklar);

            ListViewGroup group1 = new ListViewGroup("Grup1", HorizontalAlignment.Right);
            ListViewGroup group2 = new ListViewGroup("Grup2", HorizontalAlignment.Center);
            ListViewGroup group3 = new ListViewGroup("Grup3", HorizontalAlignment.Left);

            ListViewGroup[] gruplar = { group1, group2, group3};
            listView2.Groups.AddRange(gruplar);
            
            // 4 item için fazla satır kullandık, döngüler ile istediğimiz sayıda rastele veriyi ekleme yolumuz var,

            /*
            
            // Listview itemler oluşturuluyor
            string[] item1Str = { "Ahmet", "CAN"};
            string[] item2Str = { "Mehmet", "KAN" };
            string[] item3Str = { "Veli", "SON" };

            ListViewItem item1 = new ListViewItem(item1Str);
            ListViewItem item2 = new ListViewItem(item2Str);
            ListViewItem item3 = new ListViewItem(item3Str);
            ListViewItem item4 = new ListViewItem();
            item4.Text = "ALİ";
            item4.SubItems.Add("SOM");

            listView2.Items.Add(item1);
            listView2.Items.Add(item2);
            listView2.Items.Add(item3);
            listView2.Items.Add(item4);

            listView2.Items[0].Group = listView2.Groups[0];
            listView2.Items[1].Group = listView2.Groups[0];
            listView2.Items[2].Group = listView2.Groups[1];
            listView2.Items[3].Group = listView2.Groups[2];
            
             */

            /* 
             Optimizasyonlu haline bakalım, rastgele 50 kişi oluşturmak isteyelim,
                Grup1'in içine index'i tek olan personeller katılsın
                Grup2'nin içine index'i çift olan personeller katılsın
                Grup3'ün içine index'i yuvarlanmak istediğinde aşayığa yuvarlanabilen personeller katılsın
                                [Grup3'e itemler ekledğimiz için grup1 ve grup2'de birler basamağı 0-4 arası eleman bulunmamaktadır]
             */

            // itemleri oluştur
            int kisiSayisi = 50;
            for (int i = 0; i < kisiSayisi; i++)
            {
                string[] itemStrTemp = { $"{(isimler)R.Next(0, kisiSayisi + 1)}", $"{(soyisimler)R.Next(0, kisiSayisi + 1)}", $"id_{i}" };
                ListViewItem lvItem = new ListViewItem(itemStrTemp);
                listView2.Items.Add(lvItem);
                if (i % 2 == 0)
                    listView2.Items[i].Group = listView2.Groups[1];
                else
                    listView2.Items[i].Group = listView2.Groups[0];
                if (i - ((i / 10) * 10) <= 4)
                    listView2.Items[i].Group = listView2.Groups[2];
            }

            listView2.View = View.Details;
        }

        #endregion

        
        #region FolderDialog.CheckedListSection
        

        private void btnSrcLoc_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbDialog = new FolderBrowserDialog();
            if(fbDialog.ShowDialog() == DialogResult.OK)
            {
                clbVeriler.Items.Clear();
                clbVeriler.Items.AddRange(Directory.GetFiles(fbDialog.SelectedPath));
            }
        }
        string yeniKonum;

        private void btnTargetLoc_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbDialogYeni = new FolderBrowserDialog();
            if (fbDialogYeni.ShowDialog() == DialogResult.OK){
                yeniKonum = fbDialogYeni.SelectedPath;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (clbVeriler.CheckedItems.Count == 0 || yeniKonum == string.Empty) return;

            foreach (var item in clbVeriler.CheckedItems)
            {
                if (File.Exists(item.ToString()))
                {
                    string yeni = Path.Combine(yeniKonum, Path.GetFileName(item.ToString()));
                    if (File.Exists(yeni)) continue;
                    File.Copy(item.ToString(), yeni);
                }
            }
            Process.Start(yeniKonum);
        }


        #endregion

        #region ExampleGroupingFileSection

        // Örnek henüz düzgün çalışmıyor, hata verebilir!!!

        private void btnGroupLoc_Click(object sender, EventArgs e)
        {
            listView3.Clear();
            FolderBrowserDialog fbDialog = new FolderBrowserDialog();
            if(fbDialog.ShowDialog() == DialogResult.OK)
            {
                
                listView3.LargeImageList = ımageList1;
                listView3.SmallImageList = ımageList2;
                int itemCnt = 0, groupCnt = 0;
                ColumnHeader pDosyaAdi = new ColumnHeader()
                {
                    Text = "Dosya Adı",
                    Width = 200,
                    ImageIndex = 0
                };
                ColumnHeader pUzanti = new ColumnHeader()
                {
                    Text = "Dosya Uzantısı",
                    Width = 150,
                    ImageIndex = 1
                };
                ColumnHeader[] basliklar = { pDosyaAdi, pUzanti };
                listView3.Columns.AddRange(basliklar);

                /*
                    ColumnHeader[] basliklar = { pAdi, pSoyadi , pId};
                    listView2.Columns.AddRange(basliklar);
                 */

                ListViewGroup group1 = new ListViewGroup("Grup1", HorizontalAlignment.Right);
                ListViewGroup group2 = new ListViewGroup("Grup2", HorizontalAlignment.Center);
                ListViewGroup group3 = new ListViewGroup("Grup3", HorizontalAlignment.Left);

                ListViewGroup[] gruplar = { group1, group2, group3 };
                listView3.Groups.AddRange(gruplar);

                foreach (var item in Directory.GetFiles(fbDialog.SelectedPath))
                {
                    //item.LastIndexOf('.')
                    //item.Substring(item.LastIndexOf('.'));
                    string dosyaAdi = item.Substring(item.LastIndexOf('\\') + 1);
                    dosyaAdi = dosyaAdi.Remove(dosyaAdi.LastIndexOf('.'));
                    string dosyaUzanti = item.Substring(item.LastIndexOf('.'));
                    string[] sira = { dosyaAdi, dosyaUzanti };
                    ListViewItem itemTemp = new ListViewItem(sira);
                    listView3.Items.Add(itemTemp);
                    ListViewGroup groupTemp = new ListViewGroup($"{dosyaUzanti}");
                    listView3.Groups.IndexOf(groupTemp);
                    listView3.Groups.Add(groupTemp);
                    listView3.Items[itemCnt].Group = listView3.Groups[groupCnt];
                    if (listView3.Groups.Contains(groupTemp) == false)
                        groupCnt++;
                        
                }
                listView3.View = View.Details;
            }

        }

        #endregion
    }

}

/*
    
    Konu: x - TreeView, ListView
    TreeView    
        * Expand all, Genişlet
        * Collapse All, Daralt
        * node, düğümlerden faydalanılır
    
    ListView 
        !excel, word, pdf dosyalarını grupla
        !progress bar ile 3 dosya kopyalanıyor, ilerleme progress bar ile göster, 2 checkbox ile işlemler yapılacak
 */



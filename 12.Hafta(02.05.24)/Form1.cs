using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        // First 20 Minutes
        private void btnNode_Click(object sender, EventArgs e)
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

        private void btnNodeAddV2_Click(object sender, EventArgs e)
        {
            string[] suruculer = Directory.GetLogicalDrives();
            
            foreach (string s in suruculer)
            {
                treeView1.Nodes.Add(s);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

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
        private void treeView1_AfterSelectV2(object sender, TreeViewEventArgs e)
        {
            TreeNode tn1 = new TreeNode($"{e.Node.Text}_child1");
            TreeNode tn2 = new TreeNode($"{e.Node.Text}_child2");
            TreeNode tn3 = new TreeNode($"{e.Node.Text}_child3");
            TreeNode[] tnDizi = { tn1, tn2, tn3 };
            e.Node.Nodes.AddRange(tnDizi);
        }



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



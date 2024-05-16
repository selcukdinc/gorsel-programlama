using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13.Hafta_16._05._24_
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


        /*
         
            DataGridView
                !! satır ve sütunların yeri farklı
                
            ödev
                Excel benzeri bir uygulama
                - A-Z otomatik devamı gelecek 
            
        
            seçilen satır ve sütunu silme
         
            
         */
    }
}

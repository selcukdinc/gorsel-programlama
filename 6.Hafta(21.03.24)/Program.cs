using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6.Hafta_21._03._24_
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
         * Konu : Combobox (Açılır kutular) {Haftaya listbox gösterilecek}
         * DropDownStyle : simple, dropdown, dropdownlist
         * Properties > Items ile yeni satır eklenebilir
         * Properties > DropDownStyle
         *              -   Simple: listeyi açık getirir
         *              -   dropdown: ile seçilen değer sonrasında yeni girdi combobox'a ekelenebilir
         *              -   dropdownlist : ile seçilen değer combobox'a değer eklenemez
         * Properties > Text : Bir şeyler yazıldığında başlangıçta değer oalra yazılır
         * açılan pencerenin ve formdaki görün
         * Events > selectedindexChanged
         * 
         * combobox1.SelectedIndex : 
         * 
         * Class gibi birden fazla içerik combobox'da kullanılabilir  text ve items  birbirinden farklıdır
         * 
         * combobox1.Contanins
         */
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DersTekrari
{
    internal static class Program
    {
        /*
         * Hafıza canlandırma programı 11.03
         *  - Transparan arka plana sahip bir form hazırla, slider ile arka planı opaklaştırabil
         *  - 2. bir form ile ana ilk formu kapatmak istediğinde uyarı formunu göster
         *      > 2. formda transparan ve farklı olsun
         */
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

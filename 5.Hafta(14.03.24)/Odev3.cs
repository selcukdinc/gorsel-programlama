using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.Hafta_14._03._24_
{
    public partial class Odev3 : Form
    {
        public Odev3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        /*
         * Tc kimlik algoritması
         * 
         * ilk hanesi sıfır olamaz
         * 
         *  10. hanenin bulunması: (1, 3, 5, 7, 9 hanelerinin toplamının 7 katı) - (2, 4, 6, 8 hanelerinin toplamı)
         *  elde edilen sonucun 10'a bölümünden kalan bize 10. haneyi verir
         *  
         *  1-10. hanelerin toplamının mod 10'u bize 11. haneyi verir ve 11. hane tek olamaz.
         * 
         */

        #region Ödevin Cevabı
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            Regex r1 = new Regex(@"^[1-9][0-9]{9}[0,2,4,6,8]$");
            Match m1 = r1.Match(txtKntrol.Text);
            if (m1.Success == true)
            {
                char[] charDizi = txtKntrol.Text.ToCharArray();
                int TempTek = 0, TempCift = 0, Hane10 = 0, Hane11 = 0;
                for (int i = 0; i < 9; i += 2) // Tek sayıların dizi karşılığı 0, 2, 4, 6, 8
                {
                    TempTek += Convert.ToInt32(charDizi[i].ToString());
                    // Console.WriteLine($"Tek sayılar: {charDizi[i]} , TempTek: {TempTek}");
                }
                // 1, 3, 5, 7, 9
                for (int i = 1; i < 9; i += 2) // Çift sayıların dizi karşılığı 1, 3, 5, 7, 9
                {
                    TempCift += Convert.ToInt32(charDizi[i].ToString());
                    // Console.WriteLine($"Çift sayılar: {charDizi[i]} , TempCift: {TempCift}");
                }
                // Console.WriteLine($"TempTek: {TempTek} , TempCift: {TempCift}");
                int Temp1 = TempTek * 7 - TempCift;
                Hane10 = Temp1 % 10;
                int Temp2 = TempTek + TempCift + Hane10;
                Hane11 = Temp2 % 10;
                // Console.WriteLine($"charDizi[9]: {charDizi[9]} , 10. hane Hesaplaması: {Hane10} \ncharDizi[10]: {charDizi[10]} , 11. hane Hesaplaması: {Hane11} ");
                if (Convert.ToInt32(charDizi[9].ToString()) == Hane10 && Convert.ToInt32(charDizi[10].ToString()) == Hane11)
                {
                    lblKntrl.Text = "Kontrol: Geçerli";
                }
            }
            else lblKntrl.Text = "Kontrol: Geçerli Değil";
        }
        #endregion
    }
}

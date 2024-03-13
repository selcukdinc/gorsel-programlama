using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
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
         * Akıllı ev otomasyon yazılımı
         *      Ev aydınlatmasının kontrolü (ışığa bağlı)
         *      klima kontrolü (akıllı, tasarruflu)
         *      çamaşır mak. aç kapa kontrolü
         *      kapı kilit kontrolü
         *      kapı zili (kişi) kontrolü fotolu
         *      Güç tüketim analizi
         *      Sigorta kontrolü
         *      plaka tanıma sistemi
         *      evcil hayvan besleme sistemi
         *      Afet yönetimi
         *      Hırsız alarm sistemi
         *      Robot süpürgülerin kontrolü
         *      fırın kontrolü
         *      Müzik sistemi kontrolü
         *      Panjur sistemi
         *      Yenilenebilir enerji sistemi kontrolü
         *      
         *      
         *      Programın ana yapısı
         *      
         *          - Ayarlar 
         *              * İletişim (USB, Ethernet, RS232, Wifi)
         *              * Ağ adı, şifre, iletişim hızı
         *              * Arayüz ayarları
         *              * İletişim -> mail, telefon
         *              * Dil seçeneği (birimler)
         *              * Profil ayarları (tatil modu, parti modu)
         *              * Sesli asistan
         *          
         *          - Arayüz
         *              * Bağlı cihazların simgesi (Aktif - Pasif)
         *              * Cihazların sınıflandırılması
         *              * Oda/bölüm ayrımı
         *              * Arama girişi
         *              * Güç tüketimi
         *              * Güç üretimi
         *              * Raporlar
         *              * Kişi sayısı (varlık/yokluk)
         *              * Tarih, saat
         *              * Hava durumu (tahmin)
         *          
         *          - Buton ve arayüzler
         *              * Cihaz ekleme / çıkarma
         *              * Sistem açma / kapama
         *              * SOS
         *              * Favori uygulamalar (ekle / çıkar)
         *              * 
         *              
         *              Form tasarımları yapılacak 
         *              OgNo_İsim
         *              
         *           
         */
    }
}

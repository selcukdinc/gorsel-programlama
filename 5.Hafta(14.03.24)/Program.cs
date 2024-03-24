using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.Hafta_14._03._24_
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
            Application.Run(new Odev2());
        }
        /*
         *  - Buton Özellikleri arasında -
         * Enable:      özelliği ile butonun pasif hale getirilmesi
         * Flat | Flat Appearance
         * Visible:     Form üzerinde gözükmez 
         * 
         * ImageList (butonlar üstünde çalışması) [Komponent olarak kullanıldı]
         *      Buton ikonları (.png) 32x32 veya 16x16
         *      ekran çözünürlüğüne göre seçim
         *      images klasörü içine cancel, add ve apply buton ikonları eklendi
         *      imagesize eklenen ikonun, görselin renk derinliğini ifade eder
         *      images  (collections) ile klasöre eklenen ikonlar eklenir
         *      butonlar toplu seçildikten sonra imagelist seçilir
         *      image index; ile toplu seçim ve atama işlemi
         *      textimagerelations; def: overlay, image before text seçildi, image above text
         *      text align ile text'in konumu, image align ile görselin konumu ayarlanabilir
         *      İkonlarımız olduğu zaman, 
         *      
         * Çılgın buton uygulaması yapıldı
         * 
         * Kod ile ImageList yazma [Arka planda komponent olarak kullanılmadan]
         * 
         * ⚠️Ödev:Farklı şekillerde buton, flowchartta olduğu gibi butonları
         * butona tıkladın, çizgiyi geçtiği an o butondan eklenecek
         * butonlar çoğaltılmış olacak
         * 
         * ödev 2, 
         *          butona tıklanıldığı zaman,
         *          formun x noktasındaki 100'den sonrasına butonlar oluşturulacak, 
         *          8x8 adet buton oluşturulacak,
         *          üstlerinde 1'den 64'e yazılar yazılacak
         *          satranç tahtası gibi siyah ve bayaz renklerinden oluşturulacak
         * 
         * 
         * 
         * Dizilerde kullanılan contains özelliği
         * 
         * ödev 3
         *          text box ile tc kimlik numarasını kontrol eden 
         *          text box'a sadece sayı girilebilecek, ve 11 haneli sayı girildikten sonra girilen sayının tc kimlik no olup olmadığı kontrol edilecek
         *          Sonrasında bir bilgi ekranı ile bilgi verilecek
         *          
         */
    }
}

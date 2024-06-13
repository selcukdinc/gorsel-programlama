using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPratik_RandevuSistemi
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
    }

    /*
     
    Sınav Sorusu: Randevu Yönetim Sistemi

    Görev: Bir Windows Forms uygulaması geliştirerek randevu oluşturma ve randevu listesini görüntüleme işlemlerini gerçekleştirin. Uygulamanızın aşağıdaki gereksinimleri karşılaması beklenmektedir:
    Tasarım:

    Form1 - Randevu Oluşturma Formu:
        Randevu ID (TextBox)
        İsim (TextBox)
        Şifre (TextBox) (PassChar ile maskelenmiş olmalı)
        Randevu Tarihi (DateTimePicker)
        Randevu Türü (ComboBox - Seçenekler: "Doktor", "Diş Hekimi", "Göz Doktoru")
        Kaydet (Button)
        İptal (Button)

    Form2 - Randevu Listesi Formu:
        DataGridView (Randevuları listeleyecek)

    Gereksinimler:

        Randevu Oluşturma:
            Randevu ID, İsim, Şifre, Randevu Tarihi ve Randevu Türü girilmeden kaydetme işlemi yapılamasın.
            Kaydet butonuna basıldığında tüm alanlar kontrol edilmeli. Boş alan varsa uygun bir mesaj gösterilmeli.
            Tüm kontroller geçildikten sonra randevu bilgileri Access veritabanına (accdb) kaydedilsin.
            Kaydetme işlemi başarılı olduğunda "Randevu ID olan [ID] adında [İsim] kullanıcısı [Randevu Türü] randevusu oluşturuldu" mesajı gösterilsin.
            İptal butonuna basıldığında girilen tüm bilgiler sıfırlansın ve "Randevu oluşturma işlemi iptal edildi" mesajı kırmızı renkte gösterilsin.

        Randevu Listesi:
            Form2'de DataGridView kullanarak Access veritabanındaki randevular listelensin.
            Form1'de yeni bir randevu eklendiğinde Form2'deki liste güncellensin.

        Veritabanı ve Dosya İşlemleri:
            Access veritabanına bağlanarak randevu bilgileri kaydedilsin ve okunsun.
            Veritabanı bağlantı bilgileri, veritabanı yolu ve SQL komutları bir TXT dosyasından okunsun.
            Veritabanı bağlantısı ve komutları OleDb kullanılarak yapılsın.
            Veritabanı işlemleri sırasında parametreler kullanılsın.

        Ekstra Gereksinimler:
            TXT dosyası, uygulama açıldığında okunmalı ve bağlantı bilgileri (örneğin, veritabanı yolu ve bağlantı string'i) uygun şekilde kullanılmalıdır.
            TXT dosyasındaki format şu şekilde olmalıdır:

        DatabasePath=your_database_path.accdb
        ConnectionString=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=your_database_path.accdb;

        İpuçları:

            Dosya Okuma: Uygulama açıldığında bağlantı bilgilerini bir TXT dosyasından okuyarak kullanın. Dosya içeriğini okumak için uygun yöntemleri kullanın ve veritabanı bağlantısını bu bilgilere göre kurun.
            Tasarım: Formlar arası geçiş ve arayüz düzenlemeleri kullanıcı dostu olacak şekilde tasarlanmalıdır.
            Kullanıcı Girişi Kontrolü: Kaydet butonuna basıldığında tüm alanların dolu olup olmadığını kontrol edin. Eksik bilgi varsa MessageBox ile kullanıcıyı uyarın.
            Access Veritabanı Bağlantısı: Veritabanına bağlanmak için gerekli olan bağlantı cümlesini txt dosyasından okuyun ve komutları parametreler ile kullanın.

        Not:

            Sınav süresi 60 dakikadır.
            Tasarım ve kullanıcı dostu arayüz puanlamada önemlidir.
            Kodun okunabilir ve iyi yapılandırılmış olması gerekmektedir.
            Gerekli dosyaları (örneğin, veritabanı dosyasını ve txt dosyasını) projenize dahil etmeyi unutmayın.
     
             */
}

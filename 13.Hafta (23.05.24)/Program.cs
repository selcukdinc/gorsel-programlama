using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1X.Hafta__23._05._24_
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
}

/*
 
CRUD
    Create
        Read
            Update
                Delete
 
SQL     |   NOSQL
--------|--------------
Oracle  |   Firebase
MSSQL   |

select, where

    *s* --> arada s olsun
    _s* --> ilk karakter önemli değil 2. karekter s geri kalanı önemli değil
    *s_ --> sondan bir önceki karakter s öncesi ve sonrası önemli değil
    

    select * from ogrenciler where vizeNotu > 70 and adi = 'Selçuk'

    select * from ogrenciler where adi like 'S*'

    select * from ogrenciler


    - veritabanına eriş
    - veritabanına işlem yapmak için aç

    .ExecuteNonQuery(); --> insert into, update, delete

    // insert into ogrenciler (adi, soyadi, vizeNotu, finalNotu) values ('eda', 'yerlihelvacı', '55', '100')

    // update ogrenciler set finalNotu = 40 where adi='mehmetAli'


    using ifadesi ile daha optimize programlar!

    // satıra tıkladığında tb'lere yerleşsin
    // çift tıkladıktan sonra hücre içindeki verinin silinmesi

 */

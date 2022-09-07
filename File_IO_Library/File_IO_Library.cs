using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_IO_Repository
{
    public class File_IO_Library
    {
        public File_IO_Library()
        {
            //Klasör İşlemleri

            string dosyaİsmi = @"D:\Test_File_IO"; // Oluşturulacak dosyanın ismini dizin olarak tanımlama

            string altDosya1 = Path.Combine(dosyaİsmi, "AltDosya1");  // Klasör içine yeni alt klasörler oluşturma
            string altDosya2 = Path.Combine(@"D:\Test_File_IO", "AltDosya2"); 

            Directory.CreateDirectory(altDosya1); // Belirtilen dizine klasör oluşturur
            Directory.CreateDirectory(altDosya2);

            Directory.Delete(altDosya2); // Belirtilen dizindeki bir klasörü siler.

            Directory.Exists(altDosya2); // Dizinde klasörün varlığını kontrol eder. Boolean değer döndürür.

            DateTime creationTime = Directory.GetCreationTime(altDosya1);   // Farklı metotlarla klasör bilgilerine erişilebilir.
            DateTime lastWriteTime = Directory.GetLastWriteTime(altDosya1);

            //Dosya İşlemleri

            string yeniDosya = Path.Combine(dosyaİsmi, @"\YeniText.txt");

            FileStream fs = File.Create(yeniDosya);
            fs.Close(); //FileStream nesnesi kapatılmadan dosya ve taşıma işlemi yapılamaz.

            File.Move(yeniDosya, altDosya1 + @"YeniText.txt"); // Dosyayı belirtilen dizine taşır

            File.Delete(altDosya1 + @"YeniText.txt");   // Dizinde belirtilen dosyayı siler.

            Path.ChangeExtension(yeniDosya, ".doc");

            Path.GetExtension(yeniDosya); // Dizindeki dosyanın uzantısını getirme

            //FileInfo Sınıfı

            FileInfo ff = new FileInfo(yeniDosya);

            //Directory Sınıfı

            DirectoryInfo dd = new DirectoryInfo(altDosya1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_IO_Repository
{
    public class File_IO_Dosya_Okuma_Yazma
    {
        public File_IO_Dosya_Okuma_Yazma()
        {
            // Var olan bir dosya içerisine yazma

            string dosyaDizin = @"D:\Test_File_IO\YeniText.txt";

            FileStream fs = new FileStream(dosyaDizin, FileMode.OpenOrCreate, FileAccess.Write);
            // FileMode dosyanın olup olmadığını kontrol eder. Dosya bulunamazsa belirtilen isimde yenisini oluşturur.
            // File access dosyanın kullanım amacını belirtir.

            StreamWriter sw = new StreamWriter(fs); // StreamWriter nesnesi oluşturularak dosyanın içine yazma işlemi yapılır.

            sw.WriteLine("Furkan Şahin");

            sw.Flush(); // Arabelleği temizler, verilerin akışa yazılmasını sağlar.
            sw.Close(); // Nesneyi ve akışı kapatır.
            fs.Close();

            // Var olan bir dosya içerisinden okuma

            fs = new FileStream(dosyaDizin, FileMode.Open,FileAccess.Write);

            StreamReader sr = new StreamReader(fs); // StreamWriter sınıfı gibidir, okuma işlemleri için kullanılır.

            Console.WriteLine(sr.ReadToEnd()); // Okunulan verileri kullanabiliriz.

            //https://www.kodlamamerkezi.com/c-net/c-ile-dosya-okuma-ve-yazma-islemleri/
            //https://docs.microsoft.com/en-us/dotnet/api/system.io.streamwriter?view=net-6.0

        }
    }
}

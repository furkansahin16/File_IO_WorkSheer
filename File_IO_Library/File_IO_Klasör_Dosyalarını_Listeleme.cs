using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_IO_Repository
{
    public class File_IO_Klasör_Dosyalarını_Listeleme
    {
        public File_IO_Klasör_Dosyalarını_Listeleme()
        {
            
            List<Object> KlasörlerİçindekiDosyalarıBul(string path)
            {
                List<Object> dosyalar = new List<object>();

                foreach (var file in Directory.GetFiles(path))
                {
                    dosyalar.Add(Path.GetFileName(file));
                }

                return dosyalar;
            }
        }
    }
}

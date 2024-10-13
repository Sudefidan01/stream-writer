using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20230826_StreamWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StreamWriter sınıfı aracılığı ile bir dosya içerisine yazılar yazdırabiliriz
            //Bu class ı kullanabilmek için SYstem.IO kütüphanesini eklemek gerekir
            StreamWriter yazici = new StreamWriter(@"C:\Users\pcc\Desktop\Yeni klasör\deneme.txt");

            yazici.WriteLine("Deneme Metini");
            yazici.Write("Merhaba");
            yazici.Write(" ");
            yazici.Write("Nasılsın");

            //Dosya içerisine yazdırma işlemi bittikten sonra yazıcıyı kapatmamız gerekmektedir
            yazici.Close();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CryptoFramework
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
           
           
            Console.WriteLine("Şifrelenecek metni giriniz:enter tusuna basiniz:");
            string metin= Console.ReadLine();

            Console.WriteLine(Crypto.Sifrele(metin));
           
            Console.WriteLine("çözmek istediğiniz şifreli metni giriniz:");
            string sifreliMetin = Console.ReadLine();
            Console.WriteLine(Crypto.SifreCoz(sifreliMetin));

            Console.ReadLine();
        }
    }
}

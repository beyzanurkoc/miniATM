using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int bakiye = 50000;
            Console.WriteLine("Atm'ye Hosgeldiniz:");
            Console.WriteLine("Sifrenizi giriniz:");
            Console.ReadLine();
            int sifre = 1234;
           
                Console.WriteLine("Yapmak istediginiz islemi giriniz:");
                Console.WriteLine("1 = bakiye goruntule");
                Console.WriteLine("2 = para cekme ");
                Console.WriteLine("3 = para yatırma ");
                Console.WriteLine("q = cıkıs yapma ");
                string secim = Console.ReadLine();
            
            if (secim == "1")
            {
                Console.WriteLine("Su anki bakıyeniz:" + bakiye);
                Console.ReadLine();
            }
            else if (secim == "2") {
                Console.WriteLine("Cekmek istediginiz miktarı giriniz:");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());

                if (cekilecek_tutar <= bakiye)
                {
                    Console.WriteLine("kalan tutar:"+ (bakiye - cekilecek_tutar));
                    Console.ReadLine();
                }
                else{
                    Console.WriteLine("bakiyenizden fazla para cekemezsiniz");
                    Console.ReadLine();
                }
                }
            else if (secim == "3" )
                {
                  Console.WriteLine("yatırmak istediginiz miktarı giriniz:");
                  int yatirilacak_tutar =Convert.ToInt32(Console.ReadLine()); 
                  Console.WriteLine("yeni bakiyeniz:" + (bakiye + yatirilacak_tutar));
                  Console.ReadLine();
                }
             else  if(secim == "q" )
                {
                    Console.WriteLine("Cıkıs yapılıyor ");
                    Console.ReadLine() ;
                }
            else
                {
                   Console.WriteLine("gecerli bir numara giriniz");
                   Console.ReadLine();
                }
            }
        }
    }


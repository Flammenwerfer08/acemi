using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {

            // seçim 1  bakiye sorgulama
            // seçim 2 para çekme
            // seçim 3 para yatırma
            // seçim q çıkış
            int bakiye = 824000;
            Console.WriteLine(" Flammenwerfer'a hoş geldiniz");
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin");
            string secim = Console.ReadLine();
            if (secim == "1")
            {
                Console.WriteLine("Şuanki bakiyeniz :" + bakiye);
                Console.ReadLine();
            }
            else if (secim == "2")
            {
                Console.WriteLine("Lütfen çekmek istediğiniz tuturaı giriniz");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                

                if (cekilecek_tutar <= bakiye)
                {
                    Console.WriteLine("Kalan tutar:" + (bakiye - cekilecek_tutar));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Bakiyeniz fazla para çekemezsiniz");
                    Console.ReadLine();
                }
            }
            else if (secim == "3") 
            {
                Console.WriteLine("Lütfen yatırmak istediğiniz tutarı giriniz");
                int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Yatırmak istediğiniz tutar hesabınız geçmiştir yeni bakiyeniz :" + (bakiye+yatirilacak_tutar));
                Console.ReadLine();

            }
            else if (secim == "q") 
            {
                Console.WriteLine(" Flammenwerfer hesabınızdan çıkılıyor");
                Console.WriteLine(" Flammenwerfer iyi günler diler");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir işlem yapınız ");
                Console.ReadLine();
            }









        }

    }
}

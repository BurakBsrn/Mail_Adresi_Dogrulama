using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
        
        
        tekrar:
            Console.Write("Mail Adresinizi Giriniz... ");
            string mail = Console.ReadLine();

            if (mail.Contains("@") == true) 
                Console.Write("Kullanıcı kaydı yapılmıştır...");
            else
            {
                Console.Write("Doğru bir mail adresi giriniz...");
                goto tekrar;
            }

            Console.ReadKey();
        }
    }
}
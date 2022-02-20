using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ektandan girilen sayıya kadar olan tek sayıları ekrana yazdır.
            /* Console.WriteLine("Lütfen bir sayı giriniz : ");
            int sayac = int.Parse(Console.ReadLine());

            for (int i = 1; i <= sayac; i++)
            {
                if (i%2 == 1)
                {
                    System.Console.WriteLine(i);                    
                }
            }

            // 1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdır.
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    tekToplam += i;
                }
                else
                ciftToplam += i;
            }

            Console.WriteLine("Tek toplam : " + tekToplam);
            Console.WriteLine("Çift toplam : " + ciftToplam);
            */

            // break, continue
            
            
           
                for (int i = 1; i <10; i++)
                {
                    if (i == 4)  
                        break;  // 4'e gelince duracak.(1-2-3)
                    Console.WriteLine(i);
                }

                 for (int i = 1; i < 10; i++)
                
                {
                    if (i == 4)
                        continue; // 4'ü yazdırmayıp devam edecek. (3-5)
                     Console.WriteLine(i);
                }
                
            
        
        }
    }
}

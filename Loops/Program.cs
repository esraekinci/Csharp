using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ekrandan girilen sayıya kadar olan tek sayılar yazdır.
            Console.WriteLine("Please enter a number:");
            int counter = int.Parse(Console.ReadLine());
            for (int i = 0; i < counter; i++)
            {
                if(i % 2 ==1)
                    Console.WriteLine(i);
            }

            Console.WriteLine("-------------------------");

            // 1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdır.
            int oddSum = 0;
            int evenSum = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if (i%2 == 1)
                    oddSum += i;
                else   
                    evenSum += i;
            }
            Console.WriteLine($"Odd Summation : {oddSum}");
            Console.WriteLine($"Even Summation : {evenSum}");

            Console.WriteLine("-------------------------");

            // Break : Eğer bir döngü içerisinde bir case'e bağlı olarak looptan çıkmak istiyorsak kullanılır. Döngüyü sonlandırır.
            // Continue : Eğer bir şarta bağlı olarak mevcut döngünün o cycle'ını atlamak istiyorsanız kullanılır.

            for (int i = 0; i < 10; i++)
            {
                if(i == 4)
                    break;
                Console.WriteLine(i); // 4'e gelince döngüden çıkar.

            }
             for (int i = 0; i < 10; i++)
            {
                if(i == 4)
                    continue; 
                Console.WriteLine(i); // Outputta 4'ü atlayarak yazdırıcak.

            }
        }
    }
}

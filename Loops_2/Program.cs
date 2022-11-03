using System;

namespace Loops_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //While Loop
            // 1'den başlayarak console'dan girilen sayıya kadar (sayı dahil) ortalama hesaplayarak console'a yazdır.
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            int counter=1;
            int sum=0;
            while (counter <= number)
            {
                sum += counter;
                counter ++;
            }
            Console.WriteLine($"Summation: {sum}");
            Console.WriteLine("Average:" + sum/number);

            

            //Foreach Sample
            Console.WriteLine("---Foreach---");

            string[] cars= {"BMW","Audi","Mercedes"};
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}

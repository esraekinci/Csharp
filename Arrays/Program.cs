using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi Tanımlama //Defining Arrays

            string[] colors= new string[5];
            string[] animals={"cat","dog","bird","monkey"};

            int[] array;
            array= new int[5];

            //Dizilere Değer Atama ve Erişim / Assigning and Accessing Values to Arrays

            colors[0]="Blue";             
            array[3]=10;

            // Console.WriteLine(array[3]);
            // Console.WriteLine(animals[1]);
            // Console.WriteLine(colors[0]);

            //Döngülerle Dizi Kullanımı / Using arrays with loops
            //Klavyeden girilen n tane sayının ortalaması / The average of n numbers entered from the keyboard

            Console.Write("Please enter the length of the array:");
            int lenghtArray=int.Parse(Console.ReadLine());
            int[] numArr= new int[lenghtArray];

            for (int i=0 ; i < lenghtArray ; i++)
            {
                Console.Write("Please enter a number that index number is {0}:" , i+1);
                numArr[i]=int.Parse(Console.ReadLine());
            }

            int sum=0;
            foreach (var number in numArr)          
                sum += number;
            Console.WriteLine("Average :" + sum/lenghtArray);

            
        



        }
    }
}

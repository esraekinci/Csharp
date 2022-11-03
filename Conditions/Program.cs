using System;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
           int time = DateTime.Now.Hour;

           if(time >= 6 && time <= 11)
                Console.WriteLine("Good Morning!");

            else if(time <= 18)
                Console.WriteLine("Have a Nice day!");

            else
                Console.WriteLine("Good Night!");
                

            // Same thing but different way    
            string result = time >= 6 && time <= 11 ? "Good Morning!" : time <= 18 ? "Have a Nice Day!" : "Good Night!";
            Console.WriteLine(result);


        }
    }
}

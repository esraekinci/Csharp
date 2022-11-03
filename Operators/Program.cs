using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
          // Describing the variable
            int x = 3 ;
            int y = 4 ;
            y += 2 ;

            Console.WriteLine(y);
            y += 2 ;
            Console.WriteLine(y);
            y /= 1 ;
            Console.WriteLine(y);
            x *= 2 ;
            Console.WriteLine(x);

             Console.WriteLine("--- Logical Operators ---");
            //Logical Operators
            // && , || , ! 

            bool isSuccess = true ; 
            bool isCompleted = false; 

            if(isSuccess && isCompleted) // If both two conditions are true , write "Excellent" to the terminal. 
                Console.WriteLine("Excellent!");

            if(isSuccess || isCompleted) //If one of the two conditions is true , write "Great" to the terminal. 
                Console.WriteLine("Great!"); 
            
            if(isSuccess && !isCompleted) // If the first condition is true and the second condition is false , write "Fine!" to the terminal. 
                Console.WriteLine("Fine!");

            

            Console.WriteLine("--- Relational Operators ---");
            //Relational Operators
            // < , > , <= , >= , == , !=

            int i = 3 ;
            int j = 4 ;
            bool result = i < j ;

            Console.WriteLine(result);
            result = i > j ; 
            Console.WriteLine(result);
            result = i >= j ; 
            Console.WriteLine(result);
            result = i <= j ; 
            Console.WriteLine(result);
            result = i == j ; 
            Console.WriteLine(result);
            result = i != j ; 
            Console.WriteLine(result);
        
            //Arithmetic Operators
            // * , / , + , -
            Console.WriteLine("--- Arithmetic Operators --- ");

            int num = 10 ;
            int num2 = 5 ;
            int res = num / num2 ;
            Console.WriteLine(res);

            // % : Mod 
            int res2 = 20%3 ;
            Console.WriteLine(res2);
        }
    }
}

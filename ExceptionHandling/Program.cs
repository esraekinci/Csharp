using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { //block of code that could cause a possible error  

                Console.WriteLine("Enter a number :");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"The number you have entered is {number}");

            }
            catch (Exception ex)
            { // catch the error and write it to the console.

                Console.WriteLine("Error" + ex.Message.ToString());

            }
            finally
            { // another block of code that is requested to be executed. This part is optional. 

                Console.Write("The process is completed.");
            }

            try
            {
                // int a = int.Parse(null);
                // int a =int.Parse("test");
                int a = int.Parse("-20000000000");

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("You entered a null value.");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("The data type is not proper.");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("The value that you have entered is too small or too large.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("The process is successfully completed.");
            }

        }
    }
}

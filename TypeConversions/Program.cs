using System;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            // There are two types of conversion. 
            // Implicit Conversion (Bilinçsiz Dönüşüm)

            byte a = 5;
            sbyte b = 30 ;
            short c = 10 ;

            int d = a+b+c;
            Console.WriteLine("d:" + d);

            long h = d ;
            Console.WriteLine("h:" + h);

            float i = h ;
            Console.WriteLine("i:" + i);

            string e ="esra";
            char f='e';
            object g = e+f+d ;
            Console.WriteLine("g:" + g);

            
            // Explicit Conversion (Bilinçli Dönüşüm) 
            
            Console.WriteLine("----Explicit Conversions----");

            int x = 4 ;
            byte y = (byte)x ;
            Console.WriteLine("y:" + y);

            int z = 4 ;
            byte t = (byte)z ;
            Console.WriteLine("t:" + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:" + v);

            // ToString()
            Console.WriteLine("---ToString() Method");

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy:" + yy);

            // System.Convert()
            Console.WriteLine("---System.Convert() Class---");
            string s1 = "10" , s2="20";
            int num1 , num2 ;
            int Sum ;

            num1 = Convert.ToInt32(s1);
            num2 = Convert.ToInt32(s2);

            Sum= num1 + num2; 
            Console.WriteLine("Summation : " + Sum);

            // Parse - convert to string 
            Console.WriteLine("---Parse() Method---");
            string metin1="10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);
            Console.WriteLine("rakam1:" + rakam1);
            Console.WriteLine("double1:" + double1);

        }
       
    }
}

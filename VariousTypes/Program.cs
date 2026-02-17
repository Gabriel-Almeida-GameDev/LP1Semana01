using System;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int var1 = 1;
            byte var2 = 64;
            uint var3 = 5u;
            Console.WriteLine(var1);
            Console.WriteLine(var2);
            Console.WriteLine(var3);

            char emoji1 = '\u2615';
            char emoji2 = '\u2605';
            char emoji3 = '\u260E';
            Console.WriteLine(emoji1);
            Console.WriteLine(emoji2);
            Console.WriteLine(emoji3);

            float var4 = 2315.982346f;
            double var5 = 2.0e15;
            Console.WriteLine(var4);
            Console.WriteLine(var5);
             
            bool bowling1 = true;
            bool bowling2 = 7 < -7;
            Console.WriteLine(bowling1);
            Console.WriteLine(bowling2);
        }
    }
}

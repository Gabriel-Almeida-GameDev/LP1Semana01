using System;
using System.Text;
using System.Globalization;


namespace Smiley
{
    
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            string código = Console.ReadLine($"Insere código : ");
            
            Console.WriteLine($"Caráter Unicode : {(char)int.Parse(código, NumberStyles.HexNumber)}");

        }
    }
}

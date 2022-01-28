using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bin2Dec
{
    class Program
    {
        static void Main(string[] args)
        {
            Prompt:
            Console.Write("Enter binary string to convert (8 bits): ");
            string binstring = Console.ReadLine();
             
            if (!Bin.ValidBin(binstring))
            {
                Console.Clear();
                Console.WriteLine("Invalid format for binary number");
                goto Prompt;
            }

            Bin bin = new Bin(binstring);

            int equiv = bin.Convert();

            Console.WriteLine();
            Console.WriteLine($"{bin.Binary}(2) => {equiv}(10)");


            Console.ReadKey();
        }
    }
}

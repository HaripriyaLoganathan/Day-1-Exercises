using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the numbers");
            try {
                a = Convert.ToInt16(Console.ReadLine());
                b = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Addition = {0}" + (a + b));
            }
            catch
            {
                Console.WriteLine("Input mismatch");
            }
            Console.ReadLine();

        }
    }
}

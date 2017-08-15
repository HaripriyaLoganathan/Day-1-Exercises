using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("Enter the 4 numbers");
            a = Convert.ToInt16(Console.ReadLine());
            b = Convert.ToInt16(Console.ReadLine());
            c = Convert.ToInt16(Console.ReadLine());
            d = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Average of 4 numbers is {0}", (a + b + c + d)/4);
            Console.ReadLine();
        }
    }
}

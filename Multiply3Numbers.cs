using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter the numbers");
            a = Convert.ToInt16(Console.ReadLine());
            b = Convert.ToInt16(Console.ReadLine());
            c = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Multiplication of 3 numbers ={0} ",(a * b * c));
            Console.ReadLine();
        }
    }
}

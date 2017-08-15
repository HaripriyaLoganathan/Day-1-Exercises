using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the numbers");
            a = Convert.ToInt16(Console.ReadLine());
            b= Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Addition ={0}" ,(a + b));
            Console.WriteLine("Subtraction ={0} ",(a-b));
            Console.WriteLine("Multiplication={0} " , (a * b));
            Console.WriteLine("Division ={0} ",(a / b));
            Console.ReadLine();
        }
    }
}

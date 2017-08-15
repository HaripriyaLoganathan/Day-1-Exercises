using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the numbers");
            a = Convert.ToInt16(Console.ReadLine());
            b = Convert.ToInt16(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("A value = {0}\n B value = {1}",a,b);
            Console.ReadLine();
        }
    }
}

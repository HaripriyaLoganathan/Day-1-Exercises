using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Area ={0}", 3.14 * a * a);
            Console.WriteLine("Perimeter={0}", 2 * 3.14 * a);
            Console.ReadLine();
        }
    }
}

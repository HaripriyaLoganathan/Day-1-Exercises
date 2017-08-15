using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter the three numbers");
            a =Convert.ToInt16(Console.ReadLine());
            b = Convert.ToInt16(Console.ReadLine());
            c = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("{0},{1},{2}",a, b, c);
            Console.ReadLine();
        }
    }
}

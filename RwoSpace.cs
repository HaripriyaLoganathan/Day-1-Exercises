using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("{0} {1} {2} {3}", a, a, a, a);
            Console.WriteLine("{0}{1}{2}{3}", a, a, a, a);
            Console.ReadLine();
        }
    }
}

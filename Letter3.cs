using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letter3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the three letters");
            char a = Convert.ToChar(Console.ReadLine());
            char b = Convert.ToChar(Console.ReadLine());
            char c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("{0} {1} {2}",c,b,a);
            Console.ReadLine();
        }
    }
}

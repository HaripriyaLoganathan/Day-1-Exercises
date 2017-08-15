using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter the age");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("You look older than {0}", a);
            Console.ReadLine();
        }
    }
}

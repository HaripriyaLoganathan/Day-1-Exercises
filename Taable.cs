using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the table's number");
            int a =Convert.ToInt16( Console.ReadLine());
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine("{0}x{1}={2}", i, a, (i * a));
                
            }
            Console.ReadLine();
        }
    }
}

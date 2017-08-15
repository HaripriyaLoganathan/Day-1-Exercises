using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers");
            int a = Convert.ToInt16(Console.ReadLine());
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the operation \n +\n - \n * \n /");
            char c = Convert.ToChar(Console.ReadLine());
            if (c == '+')
                Console.WriteLine(a + b);
            else if (c == '-')
                Console.WriteLine(a - b);
            else if (c == '*')
                Console.WriteLine(a * b);
            else (c == '/')
                Console.WriteLine(a / b);

            Console.ReadLine();
        }
    }
}

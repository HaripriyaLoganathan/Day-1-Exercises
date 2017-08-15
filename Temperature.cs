using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the celsius");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Kelvin ={0}", a + 273);
            Console.WriteLine("Fahrenheit ={0}",a*18/10+32);

            Console.ReadLine();
        }
    }
}

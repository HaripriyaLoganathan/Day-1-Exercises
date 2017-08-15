using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt16(Console.ReadLine());
            for(int i=0;i<5;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write("{0}",a);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

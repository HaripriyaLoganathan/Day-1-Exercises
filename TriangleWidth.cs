using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trianglewidth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the width");
            int w = Convert.ToInt16(Console.ReadLine());
            for(int i=w;i>0;i--)
            {
                for(int j=0;j<i;j++)
                {
                    Console.Write(a);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
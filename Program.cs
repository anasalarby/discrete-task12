using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1n");
             int start = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2n");
            int end = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int x = start; x <= end; x++)
            {
                sum = 0;

                for (int i = 1; i <= x / 2; i++)
                {
                    if (x % i == 0)
                        sum += i;
                       
                }
                if (sum == x)
                    Console.WriteLine(x + " is a perfect number");
                
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace pro_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            Console.WriteLine("Enter the first number");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine("the perfect numbers is :");

            for ( i = first; i <= second; i++)
            {
                int sum = 0;
                for ( j=1; j<i; j++)
                {
                    if (i % j == 0)
                        sum = sum + j;
                }
                if (sum == i)
                    Console.WriteLine(i);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number you want to check:");
            int first=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number you want to check:");
            int second =int.Parse(Console.ReadLine());  
            for(int i=first;i<second;i++)
            {
                int divisor = 0;
                for(int j=2;j<i;j++)
                {
                    if (i % j == 0)
                    {
                        divisor++;
                        break;
                    }


                }
                if (divisor == 0 && i != 1)
                    Console.WriteLine(i);

            }
        }
    }
}

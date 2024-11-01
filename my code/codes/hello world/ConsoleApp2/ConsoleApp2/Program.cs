using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 34;
            int num2 = 45;
            int num3 = 32;
             
            //Calculation
            int sum =num1 + num2+ num3;
            Double avg = sum / 3;

            //Display
            Console.WriteLine("Sum is=" + sum);
            Console.WriteLine("AVG is=" + avg);e
            Console.WriteLine("sum is {0}", sum);
            Console.WriteLine("{0} is the sum and avarage is {1}", sum, avg);
            Console.ReadKey();
        }
    }
}

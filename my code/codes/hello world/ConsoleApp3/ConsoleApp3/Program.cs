using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            double num3;
            double avg2;

            Console.WriteLine("Input num1");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input num2");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Decimal Number");
            num3 = Convert.ToDouble(Console.ReadLine());

            //calculation
            double sum=num1 + num2;
            double avg = sum / 3;

            //display
            Console.WriteLine("num1 is=" + num1);
            Console.WriteLine("num2 is=" + num2);
            Console.WriteLine("{0} is the sum and avarage is {1}", sum, avg);
          
            
            Console.ReadKey();
        }
    }
}

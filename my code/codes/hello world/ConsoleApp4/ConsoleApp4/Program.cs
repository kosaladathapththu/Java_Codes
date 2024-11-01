us
    ing System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mathmarks;
            int Scmarks;
            int Engmarks;
            int index;

            Console.WriteLine("Enter Index Number:");
            index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Maths Marks :");
            mathmarks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Science Marks :");
            Scmarks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter English Marks :");
            Engmarks = Convert.ToInt32(Console.ReadLine());

            // Calculate
            double sum = mathmarks + Scmarks + Engmarks;
            double avgmarks = sum / 3;

            Console.WriteLine("Your Average is: " + avgmarks);

            if (avgmarks < 40)
            {
                Console.WriteLine("Your Grade is: F");
            }
            else if (avgmarks < 60)
            {
                Console.WriteLine("Your Grade is: S");
            }
            else if (avgmarks < 80)
            {
                Console.WriteLine("Your Grade is: C");
            }
            else
            {
                Console.WriteLine("Your Grade is: D");
            }
            Console.ReadKey();
        }
    }
}

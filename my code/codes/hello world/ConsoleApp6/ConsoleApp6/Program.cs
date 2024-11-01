using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd Numbers 1-50");
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + ", ");
                }
            }

            Console.WriteLine("\n\nEven Numbers 1-50");
            for (int count = 1; count <= 50; count++)
            {
                if (count % 2 == 0)
                {
                    Console.Write(count + ", ");
                }
            }

            Console.ReadKey();  
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0;i<=100;i++)
            {
                sum += i;
            }
            Console.WriteLine("sum of 1 to 100 is:" +sum);
            Console.ReadLine();
        }
    }
}

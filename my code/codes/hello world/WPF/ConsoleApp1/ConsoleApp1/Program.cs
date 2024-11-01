using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nut;
using System.Speech;

namespace nut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 7800;
            Console.WriteLine(x);
            Console.WriteLine(x.ToText());
            Console.ReadKey();
        }
    }
}

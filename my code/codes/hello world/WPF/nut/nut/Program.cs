using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nut;
//using System.Speech;
//using System.Speech.Synthesis;


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
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech;
using System.Speech.Synthesis;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                string textToSpeak = "Hello, this is a predefined text being spoken.";

                Console.WriteLine("Speaking the text: " + textToSpeak);
                synth.Speak(textToSpeak);
            }
        }
    }
} 
*/

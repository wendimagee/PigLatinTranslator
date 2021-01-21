using System;
using System.Linq;

namespace PigLatinTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the Pig Latin Translator! Please enter a word");
            string input = Console.ReadLine();
            Console.WriteLine(input.Substring(0,1));
            if(input.Substring(0,1) == "a" || input.Substring(0, 1) == "e" || input.Substring(0, 1) == "o" || input.Substring(0, 1) == "u" || input.Substring(0, 1) == "i")
            {
                Console.WriteLine(input + "way");
            }
            else
            {
                Console.WriteLine("yikes");
            }
        }
        

    
    
    }
}

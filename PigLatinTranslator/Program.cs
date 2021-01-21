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
            //creating an array of string length
            char[] word = new char[input.Length];
            //copying character by character into array
            for (int i = 0; i < input.Length; i++)
            {
                word[i] = input[i];
            }
            // Printing content of array  
            foreach (char c in word)
            {
                Console.WriteLine(c);
            }


        }
    }
}

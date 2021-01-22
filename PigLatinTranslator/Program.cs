using System;
using System.Linq;

namespace PigLatinTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goAgain = true;

            do
            {


                Console.WriteLine("Hello and Welcome to the Pig Latin Translator!");
                Console.WriteLine("\nPlease enter a word: ");
                string input = Console.ReadLine();

                // make an array of vowels to search for
                char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

                //test input for vowels, find out where they are
                int vowelPlace = input.IndexOfAny(vowels);

                if (vowelPlace == 0)
                {
                    Console.WriteLine(input + "way");
                }
                //if the word doesn't begin with a vowel
                else if (vowelPlace == 1)
                {

                    string split1 = input.Substring(0, vowelPlace);
                    string split2 = input.Substring(vowelPlace);
                    Console.WriteLine(split2 + split1 + "ay");
                }
                else
                {
                    string split1 = input.Substring(0, vowelPlace);
                    string split2 = input.Substring(vowelPlace);
                    Console.WriteLine(split2 + split1 + "ay");
                }

                Console.WriteLine("Would you like to translate another word?(y/n)");
                char answer = char.Parse(Console.ReadLine());
                if (char.ToLower(answer) == 'y')
                {
                    goAgain = true;
                }
                else
                {
                    goAgain = false;
                }
            }
            while (goAgain == true);
        }

    }
}


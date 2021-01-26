using System;
using System.Linq;
//this code works for every word except those that end in y and have no other consonants.
//my apologies! I am learning. I used a try/catch block to handle this exception! Practicing is fun
namespace PigLatinTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goAgain = true;
            Console.WriteLine("Hello and Welcome to the Pig Latin Translator!");

            do
            {
                try
                {
                    Console.WriteLine("\nPlease enter a word or sentence to translate: ");
                    string input = Console.ReadLine();
                    //split those words up!
                    string[] words = input.Split(' ');
                    foreach (var word in words)
                    {
                        // make an array of vowels to search for
                        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

                        //make an array of symbols to search for
                        char[] symbols = { '@', '0', '1', '2', '3', '4',
                        '5', '6', '7', '8', '9', '#', '$', '%', '&',
                        '~', '^', '*', '+', '='};

                        //test input for vowels, find out where they are
                        int vowelPlace = word.IndexOfAny(vowels);

                        if (string.IsNullOrEmpty(input))
                        {
                            Console.Beep();
                            Console.Beep();
                            Console.Beep();
                            Console.WriteLine("HEY! I said enter a word or sentence! Try again.");
                            break;
                        }

                        else if (word.IndexOfAny(symbols) != -1)
                        {
                            break;
                        }

                        else if (vowelPlace == 0)
                        {
                            Console.Write(word + "way ");
                        }
                        //if the word doesn't begin with a vowel

                        else
                        {
                            string split4 = SplitEmUp(word, vowelPlace);
                            Console.Write(split4);
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("\nI’m sorry, my translator does not accept words where the letter y is used as a vowel.Try a different word or sentence!");
                }
            
            

                Console.WriteLine("\n\nWould you like to translate another word?(y/n)");
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

        public static string SplitEmUp(string word, int vowelPlace)
        {
           
                string split1 = word.Substring(0, vowelPlace);
                string split2 = word.Substring(vowelPlace);
                return (split2 + split1 + "ay ");
            
        }
    }
}


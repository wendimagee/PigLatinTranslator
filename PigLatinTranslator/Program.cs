using System;
using System.Linq;

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
                    string input = Console.ReadLine().ToLower();
                    string[] words = input.Split(' ');
                    foreach (var word in words)
                    {
                        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

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
                        //words with y as a vowel
                        else if (word.IndexOfAny(symbols) == -1)
                        {
                            if (word.Contains('y'))
                            {
                                vowelPlace = word.IndexOf('y');
                                string split4 = SplitEmUp(word, vowelPlace);
                                Console.Write(split4);
                            }
                            //words beginning with vowels:
                            else if (vowelPlace == 0)
                            {
                                Console.Write(word + "way ");
                            }
                            //words that don't begin with vowels:
                            else if (vowelPlace > 0)
                            {
                                string split4 = SplitEmUp(word, vowelPlace);
                                Console.Write(split4);
                            }
                            else
                            {
                                throw new Exception();
                            }
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("\nWe cannot detect an English word or sentence. Try a different word or sentence!");
                }

                try
                {
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
                catch
                {
                    Console.WriteLine("\nYou must enter a y or n");

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


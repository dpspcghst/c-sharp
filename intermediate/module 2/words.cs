using System;
using System.Collections.Generic;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();
            bool found_match = false;
            
            //your code goes here
            foreach (string word in words)
            {
                if (word.Contains(letter))
                {
                    Console.WriteLine(word);
                    found_match = true;
                }
            }

            if (!found_match)
            {
                Console.WriteLine("No match");
            }
        }
    }
}

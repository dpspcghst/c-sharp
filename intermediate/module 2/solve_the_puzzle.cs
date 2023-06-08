using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] games = { "Alien Shooter", "Tic Tac Toe", "Snake", "Puzzle", "Football" };

            //your code goes here
            string initial_selection = Console.ReadLine();
            int converted_selection = Convert.ToInt32(initial_selection);

            if (converted_selection < 0)
            {
                Console.WriteLine("Invalid number");
            }
            else if (converted_selection > 4)
            {
                Console.WriteLine("Invalid number");
            }
            else
            {
                string final_selection = games[converted_selection];
                Console.WriteLine(final_selection);
            }
        }
    }
}

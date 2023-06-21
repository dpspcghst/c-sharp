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
            MusicGenres genres = new MusicGenres();

            int count = 0;
            while (count<5)
            {
                genres[count] = Console.ReadLine();
                count++;
            }

            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Following: " + genres[x]);
            }
        }
    }

    class MusicGenres
    {
        private string[] genres = new string[5];
        
        //declare an indexer
        public string this[int y]
        {
            get
            {
                return genres[y];
            }

            set
            {
                genres[y] = value;
            }
        }
    }
}

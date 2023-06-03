using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] num = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            //your code goes here
            for (int row_value = 0; row_value < 3; row_value++)
            {
                for (int column_value = 0; column_value < 3; column_value++)
                {
                    Console.Write(num[row_value, column_value]);
                }
                Console.WriteLine();
            }
        }
    }
}

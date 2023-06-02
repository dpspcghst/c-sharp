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
            int[] numbers = new int[5];
            int count = 0;
            int sum = 0;
            while (count <5)
            {
                numbers[count] = Convert.ToInt32(Console.ReadLine());
                count++;
            }
            //your code goes here
            for (int item = 0; item < numbers.Length; item++)
            {
                if (numbers[item] % 2 == 0)
                {
                    sum += numbers[item];
                }
            }

            Console.WriteLine(sum);
        }
    }
}

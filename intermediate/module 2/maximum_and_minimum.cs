using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            //your code goes here
            int[] arr = new int[5];
            int count = 0;

            while (count < 5)
            {
                arr[count] = Convert.ToInt32(Console.ReadLine());
                count++;
            }

            int biggest = arr.Max();
            int smallest = arr.Min();
            int sum = biggest + smallest;

            Console.WriteLine(sum);
        }
    }
}

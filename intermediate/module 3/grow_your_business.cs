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
            int numOfDeps = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            while (count < numOfDeps)
            {
                string depName = Console.ReadLine();
                Department dep = new Department(depName);
                count++;
            }

            int original_count = Convert.ToInt32(Department.depCount);
            int additional_count = Convert.ToInt32(numOfDeps);

            int total_count = original_count + additional_count;

            Console.WriteLine("Number of departments: " + total_count);
        }
    }

    class Department
    {
        public string depName;

        //declare static depCount member with value of 2
        public static int depCount = 2;

        //complete the constructor
        public Department(string name)
        {
            Console.WriteLine("Department opened: " + name);
            this.depName = name;
        }
    }
}

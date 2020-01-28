using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bogusArray = new string[]
            {
                "tom",
                "richard",
                "harry"
            };
            Console.WriteLine("The second name is " + " " + bogusArray[1]);
            Console.WriteLine($"The third name is : {bogusArray[2]}");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"The second is : {bogusArray[i]}");
            }

            foreach (var name in bogusArray)
            {
                Console.WriteLine($"The second name is: {name}");
            }

        }
    }
}

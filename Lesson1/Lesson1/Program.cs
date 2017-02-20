using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");

            string b = Console.ReadLine();

            Console.WriteLine("You said:");

            Console.WriteLine(b);

            int a = Convert.ToInt32(b);


            Console.WriteLine("Say answer");

            string c = Console.ReadLine();

            int answer = Convert.ToInt32(c);

            if (answer == 42)
            {
                Console.WriteLine("Right answer");
            }
            else
            {
                Console.WriteLine("Incorrect answer");
            }


            Console.ReadLine();

        }
    }
}

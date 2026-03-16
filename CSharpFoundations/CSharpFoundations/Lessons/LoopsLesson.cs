using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFoundations.Lessons
{
    internal class LoopsLesson
    {
        internal static void Run()
        {
            Console.WriteLine('\n');

            Console.WriteLine("Example For loop");
            int x = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + x);
            }



            for (int i = 0; i < 100; i+=10)
            {
                for (int j = i; j < i+10; j++)
                {
                    Console.Write($" { j}");
                }

                Console.WriteLine();
            }
            Console.WriteLine('\n');

            Console.WriteLine("Example While loop");
            //While Loop
            /*bool condition = false;
            while (!condition)
            {
                doSomework();
                condition = checkCondition();
            }
            */

            int y = 0;

            while(y < 10)
            {
                Console.WriteLine($"Y is: {y} ");
                y++;
            }

            Console.WriteLine('\n');

            Console.WriteLine("Example For Each Loop");
            //For Each Loop
            int[] numbers = { 1, 2, 3, 4, 5 };

            foreach(int num in numbers) {
                Console.WriteLine(num);
            }
        }
    }
}

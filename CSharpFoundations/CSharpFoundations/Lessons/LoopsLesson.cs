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

        }
    }
}

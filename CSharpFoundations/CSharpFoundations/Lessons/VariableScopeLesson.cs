using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFoundations.Lessons
{
    internal class VariableScopeLesson
    {
        internal static void Run()
        {
            int x = 5;
            Console.WriteLine(x);

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(i + x);
            }
            Console.WriteLine();
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine(i + x);
            }
        }
    }
}
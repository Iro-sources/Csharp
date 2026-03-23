using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFoundations.Lessons
{
    internal class StringLesson
    {
        internal static void Run()
        {

        
        int x = 3, y = 4;
        FormattableString s = $"The result of {x} + {y} is {x + y}";
        Console.WriteLine($"format: {s.Format}");    
    
            }
}
}
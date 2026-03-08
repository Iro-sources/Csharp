using System;

namespace CSharpFoundations.Lessons
{
    internal class VariablesLesson
    {
        internal static void Run()
        {
            
            string message = "Hello World! ";
            var message2 = "Hello World! ";
            string s4 = "C# 9";

            Console.WriteLine(message);

            Console.WriteLine(message2);

            Console.WriteLine(s4);

            const int weight = 69;
            int height = 178;
            double result = (height*2) / weight;
            Console.WriteLine("The result is: " +result );
        }
    }
}

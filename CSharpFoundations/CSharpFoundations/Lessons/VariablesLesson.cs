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

            //Characters And Escape Sequence 
            char letter = 'a';
            Console.WriteLine(letter);


            string name = "hilo";
            Console.WriteLine(name.Substring(0,1).ToUpper() + name.Substring(1));

            int age = 25;
            string occupation = "developer";
            double salary = 24.657;

            Console.WriteLine("Her name is " +name.ToUpper()+ "\n and she is " + age + " years old" + " \n works as " + occupation+ " \n and her salary is " + salary);

        }


    }
}

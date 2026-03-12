using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFoundations.Lessons
{
    internal class TheIfStatementLesson
    {
        internal static void Run()
        {
            /*   Console.WriteLine("Type a string");
               string? input = Console.ReadLine();

               if (string.IsNullOrEmpty(input))
               {
                   Console.WriteLine("You typed an empty string");
               }
               else if (input?.Length < 5)
               {
                   Console.WriteLine("The string has less than 5 characters");
               }
               else { Console.WriteLine("Read any ther string");
               }
               Console.WriteLine("The string was " + input);
           }
            */

            //This method accepts any object
            //void patternMatching(object o) { }

            //BMI CALCULATOR
            Console.WriteLine("Enter your height in m: ");
            double height = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter your weight in kg: ");
            double weight = double.Parse(Console.ReadLine()!);

            double bmi = weight / (height * height);

            if (bmi < 18.5)
            {
                Console.WriteLine($"Your BMI is {bmi:f2}, You are underweight");
            }
            else if (bmi < 25)
            {
                Console.WriteLine($"Your BMI is {bmi:f2}, You have a normal weight.");
            }
            else if (bmi < 30)
            {
                Console.WriteLine($"Your BMI is {bmi:f2}, You are slightly overweight");
            }
            else if (bmi < 35)
            {
                Console.WriteLine($"Your BMI is {bmi:f2}, You are obese");
            }
            else
            {
                Console.WriteLine($"Your BMI is {bmi:f2}, You are clinically obese");

            }
        }
    }
}
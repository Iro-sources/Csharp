using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFoundations.Lessons
{
    internal class Class1
    {
        internal static void Run()
        {
            bool correctAnswer = false;
            while (!correctAnswer)
            {


                for (int i = 1; i < 5; i++)

                {
                    for (int j = 1; j < 5; j++)
                    {
                        Console.WriteLine($"What is {i} * {j} ");
                        int input = int.Parse(Console.ReadLine()!);

                        if (input == i * j)
                        {
                            Console.WriteLine("Correct answer");
                            correctAnswer = true;
                        }
                        else
                        {
                            Console.WriteLine("Wrong answer"); 
                        }

                    }
                    Console.WriteLine();
                }


            }


        }
    }
}
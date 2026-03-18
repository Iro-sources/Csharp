using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFoundations.Lessons
{
    internal class MultiplicationTable
    {
        internal static void Run()
        {
            int score = 0;

            for (int i = 1; i <= 12; i++)
            {
                //Console.Write($"{i} ");

                for (int j = 1; j <= 12; j++)
                {

                    int input = 0;
                    //bool correctAnswer = false;

                    while (input != i * j)
                    {
                        Console.WriteLine($"What is {i} * {j}");
                        input = int.Parse(Console.ReadLine()!);

                        if (input == i * j)
                        {
                            Console.WriteLine("Correct answer");
                            score++;    
                            Console.WriteLine($"Your score is: {score}");
                            //correctAnswer = true;
                            //break;
                        }
                        else
                        {
                            Console.WriteLine("Wrong answer");
                            //Console.WriteLine($"What is {i} * {j}");
                        }

                    }
                    
                }
                
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace CSharpFoundations.Lessons
{
    internal class MultiplicationTable
    {
        internal static void Run()
        {
            int correctScore = 0;
            int wrongScore = 0;

            Random random = new Random();

            int num1 = random.Next(1, 13);
            int num2 = random.Next(1, 13);

            Console.WriteLine($"What is {num1} * {num2} OR type 'quit' to stop the program");
            string userInput = Console.ReadLine();
            userInput = userInput.ToLower();

            while(userInput != "quit"){
                if (int.TryParse(userInput, out int number)){
                }
                else
                {
                    Console.WriteLine("Please use numerics");
                    Console.WriteLine($"What is {num1} * {num2} OR type 'quit' to stop the program");
                    userInput = Console.ReadLine();
                    userInput = userInput.ToLower();
                    continue;

                }

                if( number ==  num1 * num2)
                {
                    correctScore++;
                    Console.WriteLine("Correct answer");

                }
                          
                else{
                    Console.WriteLine("Wrong answer");
                    wrongScore++;
                                
                }
                    num1 = random.Next(1, 13);
                    num2 = random.Next(1, 13);
                    Console.WriteLine($"What is {num1} * {num2} OR type 'quit' to stop");
                    userInput = Console.ReadLine();
                    userInput = userInput.ToLower();

            }

            Console.WriteLine($"Your final score of the quiz is correct: {correctScore} failed: {wrongScore}");

                    }

                }
            }
        
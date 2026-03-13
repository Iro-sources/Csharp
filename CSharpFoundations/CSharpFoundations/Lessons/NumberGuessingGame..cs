using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFoundations.Lessons
{
    internal class NumberGuessingGame
    {
        internal static void Run()
        {

            //Number guessing version 2
            int num = 9;
            bool gameOver = false;

            while (!gameOver)
            {
                Console.WriteLine("Gues a number between 1 and 10");
                int input = int.Parse(Console.ReadLine());
                if (input > num)
                {
                    Console.WriteLine("Too high");

                }
                else if (input < num)
                {
                    Console.WriteLine("Too low");

                }
                else {
                    Console.WriteLine("You win, that is the correct number");
                    gameOver = true;
                }
            } 
        }
    }
}
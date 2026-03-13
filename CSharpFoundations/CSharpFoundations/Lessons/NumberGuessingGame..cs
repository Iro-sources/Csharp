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
            //Number guessing version 1
            int num = 9; 

            Console.WriteLine("Gues a number");
            int input = int.Parse(Console.ReadLine());

            if (input == num)
            {
                Console.WriteLine("You win, that is the correct number");
            }
            else if(input > num)
            {
                Console.WriteLine("Too high");
            }
            else if(input < num)
            {
                Console.WriteLine("Too low");
            }
        }
    }
}
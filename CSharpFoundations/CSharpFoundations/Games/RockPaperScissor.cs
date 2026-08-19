using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFoundations.Games
{
    internal class RockPaperScissor
    {
        internal static void Run()
        {
            Random random = new Random();
            Console.WriteLine("Let us play");

            Console.WriteLine("type 0 for rock, 1 for paper, 2 for scissors:  ");
            int userChoice = int.Parse(Console.ReadLine()!);

            int computerChoice = random.Next(0, 3);
            Console.WriteLine($"computer choice: {computerChoice}");

            if (userChoice >= 3 || userChoice < 0)
            {
                Console.WriteLine("You entered a wrong number. You lose");

            }
            else if (userChoice == computerChoice)
            {
                Console.WriteLine("Draw");
            }

            else if (computerChoice == 0 && userChoice == 2)
            {
                Console.WriteLine("You lose");
            }

            else if (computerChoice == 2 && userChoice == 0)
            {
                Console.WriteLine("You win");
            }

            else if (computerChoice > userChoice)
            {
                Console.WriteLine("You lose");
            }


            else
            {
                Console.WriteLine("You win");
            }

        }
    }
}

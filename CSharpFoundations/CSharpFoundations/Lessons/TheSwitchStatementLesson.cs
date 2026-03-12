using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFoundations.Lessons
{
    internal class TheSwitchStatementLesson
    {
        
        internal static void Run()

        {//A switch statement evaluates the value of a variable 'x' and jumps directly to the matching case.
         //The code inside that case executes, and the 'break' statements exits the switch.  
            static void switchSample(int x)
            {
                switch (x)
                {
                    case 1:
                        Console.WriteLine("case 1");
                        break;

                    case 2:
                        Console.WriteLine("case 2");
                        break;

                    case 3:
                        Console.WriteLine("case 3");
                        break;

                    case 4:
                        Console.WriteLine("case 4");
                        break;

                    case 5:
                        Console.WriteLine("case 5");
                        break;
                }
            }
            switchSample(4);

            //Multiple cases can be grouped together, so that different values execute the same code block 
            string country = "au";
            string language = "";
            switch (country)
            {
                case "au":
                case "uk":
                case "us":
                    language = "English";
                    break;

                case "at":
                case "de":
                    language = "German";
                    break;
            }

            Console.WriteLine(language);
        }
    }
}

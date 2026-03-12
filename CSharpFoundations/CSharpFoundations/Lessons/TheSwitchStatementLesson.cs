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

        {
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
                    default:
                        Console.WriteLine("All cases");
                        break;
                }  

            }

            switchSample(3);

        }
    }
}

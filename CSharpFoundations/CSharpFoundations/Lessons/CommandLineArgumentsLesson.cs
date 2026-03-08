using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFoundations.Lessons
{
    internal class CommandLineArgumentsLesson
    {
        internal static void Run(string[] args)
            {
                foreach (var arg in args)
                {
                Console.WriteLine("First number: " + arg[0]);
                Console.WriteLine("Second number: 0" + arg[1]);
                }

            //Console.WriteLine(arg[0] + arg[1]);

            }
        }
    }

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
                Console.WriteLine("First number: " + arg[0]);
                }

            //Nullable Types
            //int num = null; this is wrong because variables can't hold null

            int? number = null;

            Nullable<int> num2 = null;


            }
        }
    }

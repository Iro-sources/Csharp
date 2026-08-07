using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFoundations.Lessons
{
    internal class Arrays
    {
        internal static void Run()
        {

            /*  int [] myNumbers = new int[5] {5, 11, 25, 0, 3}; 

              int [] myNumbers2 = new int[] {5, 11, 25, 0, 3};

              int[] myNumbers3 = { 5, 11, 25, 0, 3 };
            */

            int[] myNumbers = new int[5] { 4, 11, 25, 0, 3 };

            int num1 = myNumbers[0];
            myNumbers[2] = 88;

            Console.WriteLine(myNumbers[2]);

            //checking the length of an array
            //Console.WriteLine(myNumbers.Length);

            //getting the size using for loop
           /* for (int i = 0; i < myNumbers.Length; i++)
            {
                Console.WriteLine(myNumbers[i]);
            }
            */
            //getting the size using for each loop
            foreach (var val in myNumbers)
            {
                Console.WriteLine(val);
            }
        }
    }
}
  
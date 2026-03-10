using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFoundations.Lessons
{
    internal class NullableTypesLesson
    {
        internal static void Run()
        {

            int? discount = null;
            int num = 20;
            Nullable<int> age = null;

            if (discount.HasValue)
            {
                Console.WriteLine(discount.Value);
            }

            else
            {
                discount = num;
                Console.WriteLine(num);

            }

            string? name = null;
            if (name is not null)
            {
                string name2 = name.ToUpper();
            }
                
        }
    }
}
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFoundations.Lessons
{
    internal class Methods
    {
        public int AddNum(int a, int b) => a + b;
        internal static void Run()
        {



            Methods math = new();
            int result = math.AddNum(2, 3);

            Console.WriteLine(result);

        }
    }
}
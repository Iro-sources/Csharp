using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFoundations.Lessons
{
    internal class ConstructorSamples
    {
        string _firstName;
        string _lastName;
        private int _state;
        //string _fullName;

        /*ConstructorSamples(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
        */
        private int _state;
        //Expression bodied constructor is used when the expression just consists of single expression
        private ConstructorSamples(int state) => _state = state;

        public static ConstructorSamples Instance => s_instance ?? = new ConstructorSamples(42);
        //Using expression-bodied property
        public string FullName => $"{_firstName} {_lastName}"; 

        internal static void Run()
        {
            ConstructorSamples person = new("ali", "abdi");
            Console.Write(person.FullName);

        }
    }
}

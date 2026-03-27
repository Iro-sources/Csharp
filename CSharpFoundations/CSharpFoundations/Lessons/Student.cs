using CSharpFoundations.Lessons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFoundations.Lessons
{
    internal class Student
    {
        internal static void Run()
        {
            private readonly string _firstName;
            private readonly string _lastName;


            public Student(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }



            private int _age;
            public int Age
        {
            get => _age;
            set => _age = value;
        }
    }
        }



//If you want more than one statement with the implementation of the property accessor  
/*private int _age;
public int Age;
    {
        get { return _age;

        }
        set
        {
            _age = value;

        }
    }*/

//Auto implemented properties
/*public int Age
{get; set;  } = 4;
*/

//Access modifiers for properties 
/*private string _name;
public string Name
{
    get => _name;
    private set _name = value; 
}
*/

//Different access levels can aslo be set with auto implemented properties
/*publicsf int Age
    {get, private set}
    */
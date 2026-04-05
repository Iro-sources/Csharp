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
//Auto-property → “just store this” 📦
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

//Different access levels can aslo be set with auto-implemented properties
/*public int Age
    {get, private set}
    */

//Readonly properties
//To make a property readonly you just need to omit the set accessor
/*private string _firstName;
public string FirstName
{get => _firstName;}
*/

//Auto-implemented readonly properties 
/*public string Id
{get;} = Guid.NewGuid().ToString();

//Auto-implemented readonly properties can also be initialized from the constructor
public class Book{
    public Book(string title) =>Title = title;
{   public string Title{ get;}
   
}     
}
*/



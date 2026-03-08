// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

string s1 = new string("hello world");

//Explicit Type 
string message = "Hellow world";

//Type inference invented in C# 3 edition. 
var message2 = "hello world";

//Targeted type moders C# 
string s4 = new ("hello world");

Console.WriteLine(s1);
Console.WriteLine(message);
Console.WriteLine(message2);
Console.WriteLine(s4);
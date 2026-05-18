//.csproj- use this file to specify project settings and dependencies
//.sln- use this file to manage multiple projects in a solution

//What is a namespace?-->A logical grouping of classes
//What is a class?-->A blueprint for creating objects
//What is an object?-->An instance of a class
//What is a method?-->A function defined within a class
//What is a property?-->A member of a class that provides access to data


using System;
using C_Learning.lists;
using C_Learning.strings;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Creating an object of the ProgramStrings class
            // ProgramStrings programStrings = new ProgramStrings();
            // programStrings.PrintName();


            //Creating an object of the ProgramLists class
            // ProgramLists programlist=new ProgramLists();
            // programlist.ListMethods();
        }
    }
}
//.csproj- use this file to specify project settings and dependencies
//.sln- use this file to manage multiple projects in a solution

//What is a namespace?-->A logical grouping of classes
//What is a class?-->A blueprint for creating objects
//What is an object?-->An instance of a class
//What is a method?-->A function defined within a class
//What is a property?-->A member of a class that provides access to data


using System;
using C_Learning.lists;
using C_Learning.methods;
using C_Learning.strings;
using Control;
using LINQ;

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


            //Creating object for Control Flow
            // ProgramControlFlow p1=new ProgramControlFlow();
            // p1.ControlFlowMethods();

            //Creating object for Methods
            // ProgramMethods p2=new ProgramMethods();
            // p2.PrintName();
            // p2.Greet("Neeraja");
            // Console.WriteLine(p2.Add(2,3)); // Output: 5
            // p2.Greet();
            
            //Creating object for Collections
            // Collections.Collect collect=new Collections.Collect();
            // Console.WriteLine("Collections in C#:");
            // collect.meth();
              
            //Creating object for Generics
            // Collections.generics<int> gen1 = new Collections.generics<int>();
            // gen1.Value = 42;
            // gen1.Display();
            Collections.generics<string> gen2 = new Collections.generics<string>();
            gen2.Value = "Hello, Generics!";
            gen2.Display();


            //creating object for LINQ
            LINQExamples l=new LINQExamples();
            l.Example();


            //calling collections.delegates
            Collections.DelegateExample d=new Collections.DelegateExample();
            Collections.MyDelegate del1 = d.Method1;
            Collections.MyDelegate del2 = d.Method2;
            del1(); // Output: Method1 called
            del2(); // Output: Method2 called
        }
    }
}
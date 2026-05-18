using System;
using System.Collections.Generic;

namespace C_Learning.methods
{
    class ProgramMethods
    {
        //A method is a block of code that performs a specific task. It is defined within a class and can be called to execute the code it contains. Methods can take parameters, return values, and can be overloaded (having multiple methods with the same name but different parameters).

        //Declaring a method
        //Methods structure:
        //AccessModifier ReturnType MethodName(ParameterList)
        //Access modifiers: public, private, protected, internal    
        //Return types: void (no return value), int, string, etc.
        //Parameter list: a comma-separated list of parameters (type and name)
        public void PrintName()
        {
            Console.WriteLine("Hello");

        }
        //Method with parameters
        public void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
        //Method with return value
        public int Add(int a, int b)
        {
            return a + b;
        }
        //overloaded method
        public void Greet()
        {
            Console.WriteLine("Hello!");
        }





        // public void PrintName()
        // {
        //     Console.WriteLine("Hello, my name is John.");
        // }

        // //Method with parameters
        // public void Greet(string name)
        // {
        //     Console.WriteLine($"Hello, {name}!");
        // }

        // //Method with return value
        // public int Add(int a, int b)
        // {
        //     return a + b;
        // }

        // //Overloaded method
        // public void Greet()
        // {
        //     Console.WriteLine("Hello!");
        // }
    }
}

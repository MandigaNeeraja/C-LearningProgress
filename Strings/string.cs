using System;

namespace C_Learning.strings
{
    class ProgramStrings
    {
        //String is a class in C# that represents a sequence of characters. It is a reference type and is immutable, meaning that once a string is created, it cannot be changed. Any operation that appears to modify a string actually creates a new string.

        string name = "John";
        //Common string methods:
        //Length: Returns the number of characters in a string.
        public void StringMethods()
        {
            Console.WriteLine(name.Length); // Output: 4
            Console.WriteLine(name.Substring(0, 2)); // Output: John
            Console.WriteLine(name.ToUpper()); // Output: JOHN  
            Console.WriteLine(name.ToLower()); // Output: john
            Console.WriteLine(name.Trim()); // Output: John (removes whitespace from the beginning and end of the string)
            Console.WriteLine(name + " Doe"); // Output: John Doe (string concatenation using + operator)
            Console.WriteLine(String.Concat(name, " Doe")); // Output: John Doe (string concatenation using String.Concat method)
            Console.WriteLine(String.Format("My name is {0}", name)); // Output: My name is John (string formatting)    
            Console.WriteLine(String.Join(", ", "John", "Jane", "Doe")); // Output: John, Jane, Doe (joining strings with a separator)
            
        }
        //Substring: Extracts a portion of a string.
        //ToUpper: Converts a string to uppercase.
        //ToLower: Converts a string to lowercase.
        //Trim: Removes whitespace from the beginning and end of a string.
        //String concatenation: You can concatenate strings using the + operator or the String.Concat method
        public void PrintName()
        {
            Console.WriteLine(name);
        }
        
    }
}
using System;
using System.Globalization;
using System.Collections.Generic;

namespace C_Learning.lists
{
    class ProgramLists
    {
        //A list is a collection of objects that can be accessed by index. It is a reference type and is part of the System.Collections.Generic namespace. Lists are dynamic, meaning that they can grow and shrink in size as needed.

        //Declaring and initializing a list
        List<int> numbers = new List<int>() {1,2,3,4,5};
        List<string> names = new List<string>() { "John", "Jane", "Doe" };
        
        //Common list methods:
        public void ListMethods()
        {
            Console.WriteLine(numbers.Count); // Output: 5 (returns the number of elements in the list)
            Console.WriteLine(names[0]); // Output: John (accessing an element by index)
            Console.WriteLine(numbers.IndexOf(3)); // Output: 2 (returns the index of the first occurrence of a value)
            Console.WriteLine(names.Contains("Jane")); // Output: True (checks if an element exists in the list)
            numbers.Add(6); // Adds an element to the end of the list
            Console.WriteLine(string.Join(", ", numbers));
            numbers.Remove(3); // Removes the first occurrence of a value from the list
            Console.WriteLine(string.Join(", ", numbers));
            //numbers.Clear(); // Removes all elements from the list
                
            numbers.Insert(0, 0); // Inserts an element at a specified index
            Console.WriteLine(string.Join(", ", numbers));
            numbers.Sort(); // Sorts the elements in the list  
            Console.WriteLine(string.Join(", ", numbers));
            numbers.Reverse(); // Reverses the order of the elements in the list
            Console.WriteLine(string.Join(", ", numbers));
            //numbers.ToArray(); // Converts the list to an array
            numbers.RemoveAt(0); // Removes an element at a specified index
            Console.WriteLine(string.Join(", ", numbers));
            foreach (int number in numbers)
            {
                Console.WriteLine(number); // Output: 0, 1, 2, 4, 5, 6 (iterating through the list)
            }
            
        }
    }
}
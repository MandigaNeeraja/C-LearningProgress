using System;

namespace arrays
{
    class ProgramArrays
    {
        //An array is a data structure that can hold a fixed number of values of the same type. 
        // It is a reference type and is used to store multiple values in a single variable.

        //Declaring and initializing an array
        int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
        string[] names = new string[] { "John", "Jane", "Doe" };

        //Common array methods:
        public void ArrayMethods()
        {
            Console.WriteLine(numbers.Length); // Output: 5 (returns the number of elements in the array)
            Console.WriteLine(names[0]); // Output: John (accessing an element by index)
            Console.WriteLine(Array.IndexOf(numbers, 3)); // Output: 2 (returns the index of the first occurrence of a value)
            Console.WriteLine(Array.Exists(names, name => name == "Jane")); // Output: True (checks if an element exists in the array)
            Array.Sort(numbers); // Sorts the array in ascending order
            Array.Reverse(numbers); // Reverses the order of the elements in the array
            Array.Clear(numbers, 0, numbers.Length); // Clears all elements in the array (sets them to default values)
        }
    }
}
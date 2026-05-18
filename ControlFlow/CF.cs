using System;
using System.Collections.Generic;
using System.IO.Compression;

namespace Control
{
    class ProgramControlFlow
    {
        //Control flow is the order in which individual statements, instructions or function calls are executed or evaluated. In C#, control flow is determined by conditional statements, loops, and other control structures.

        //Conditional statements:
        //if statement: Executes a block of code if a specified condition is true.
        //else statement: Executes a block of code if the condition in the if statement is false.
        //else if statement: Specifies a new condition to test if the previous condition is false.
        //switch statement: Selects one of many code blocks to execute based on the value of an expression.

        //Loops:
        //for loop: Repeats a block of code a specified number of times.
        //while loop: Repeats a block of code as long as a specified condition is true.
        //do-while loop: Similar to the while loop, but it guarantees that the block of code will be executed at least once.

        public void ControlFlowMethods()
        {
            int number = 10;

            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i); // Output: 0, 1, 2, 3, 4
            }

            int j = 0;
            while (j < 5)
            {
                Console.WriteLine(j); // Output: 0, 1, 2, 3, 4
                j++;
            }

            int k = 0;
            do
            {
                Console.WriteLine(k); // Output: 0, 1, 2, 3, 4
                k++;
            } while (k < 5);


            int d=2;
            int res=d switch
            {
                1=>10,
                2=>20,
                3=>30,
                _=>0
            };
            Console.WriteLine(res); // Output: 20 (switch expression)
        }
    }
}
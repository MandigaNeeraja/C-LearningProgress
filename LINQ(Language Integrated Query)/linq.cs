namespace LINQ
{
    class LINQExamples
    {
        public void Example()
        {
            // LINQ query example
            int[] numbers = { 1, 2, 3, 4, 5 };
            //Two types of syntax for LINQ queries: 
            // Method Syntax and Query Syntax
            
            // Method Syntax
            var evenNumbers = numbers.Where(n=>n%2==0);
            // Query Syntax
            var evenNumbers2 = from n in numbers
                               where n % 2 == 0
                               select n;

            Console.WriteLine("Even numbers:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
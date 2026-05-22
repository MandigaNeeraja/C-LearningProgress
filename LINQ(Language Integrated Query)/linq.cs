namespace LINQ
{
    class LINQExamples
    {
        public void Example()
        {
            // LINQ query example
            int[] numbers = { 1, 2, 3, 4, 5 };
            var evenNumbers = from num in numbers
                              where num % 2 == 0
                              select num;

            Console.WriteLine("Even numbers:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
namespace Collections
{
    internal class Collect
    {
        public void meth()
        {
            //List
            List<string> names = new List<string>();
            names.Add("Neeraja");
            names.Add("Sowmya");
            names.Add("Anu");
            Console.WriteLine("Names in the list:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //Dictionary
            Dictionary<string, int> nameAges = new Dictionary<string, int>();
            nameAges.Add("Neeraja", 22);
            nameAges.Add("Sowmya", 24);
            nameAges.Add("Anu", 21);
            Console.WriteLine("\nNames and Ages in the dictionary:");
            foreach (KeyValuePair<string, int> entry in nameAges)
            {
                Console.WriteLine($"Name: {entry.Key}, Age: {entry.Value}");
            } 

            //Dictionary
            Dictionary<int, string> studentGrades = new Dictionary<int, string>();
            studentGrades.Add(1, "A");
            studentGrades.Add(2, "B");
            studentGrades.Add(3, "C");
            Console.WriteLine("\nStudent Grades:");
            foreach (KeyValuePair<int, string> entry in studentGrades)
            {
                Console.WriteLine($"Student ID: {entry.Key}, Grade: {entry.Value}");
            }

            //HashSet
            HashSet<string> uniqueNames = new HashSet<string>();
            uniqueNames.Add("Neeraja");
            uniqueNames.Add("Sowmya");
            uniqueNames.Add("Anu");
            uniqueNames.Add("Neeraja"); // Duplicate entry will be ignored
            Console.WriteLine("\nUnique Names in the HashSet:");
            foreach (string name in uniqueNames)
            {
                Console.WriteLine(name);
            }
            //Queue
            Queue<string> tasks = new Queue<string>();
            tasks.Enqueue("Learn C#");
            tasks.Enqueue("Build a project");
            tasks.Enqueue("Apply for jobs");
            Console.WriteLine("\nTasks in the Queue:");
            foreach (string task in tasks)            {
                Console.WriteLine(task);
            }
            //Stack 
            Stack<string> books = new Stack<string>();
            books.Push("C# Programming");
            books.Push("Data Structures");
            books.Push("Algorithms");   
            books.Pop(); // Removes "Algorithms"
            Console.WriteLine("\nBooks in the Stack:");
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
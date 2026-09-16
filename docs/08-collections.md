# Collections

**Source:** `Collections/Collect.cs`

The .NET collections framework provides data structures for storing groups of objects.

---

## List\<T\>

Ordered, index-based, allows duplicates.

```csharp
List<string> names = new List<string>();
names.Add("Neeraja");
names.Add("Sowmya");
names.Add("Anu");

foreach (string name in names)
    Console.WriteLine(name);
```

---

## Dictionary\<TKey, TValue\>

Key-value pairs. Each key must be unique.

```csharp
Dictionary<string, int> nameAges = new Dictionary<string, int>();
nameAges.Add("Neeraja", 22);
nameAges.Add("Sowmya", 24);
nameAges.Add("Anu", 21);

foreach (KeyValuePair<string, int> entry in nameAges)
    Console.WriteLine($"Name: {entry.Key}, Age: {entry.Value}");

// Access by key
Console.WriteLine(nameAges["Neeraja"]);  // 22
```

Alternate key type:

```csharp
Dictionary<int, string> studentGrades = new Dictionary<int, string>();
studentGrades.Add(1, "A");
studentGrades.Add(2, "B");
```

---

## HashSet\<T\>

Unordered collection of **unique** elements. Duplicates are silently ignored.

```csharp
HashSet<string> uniqueNames = new HashSet<string>();
uniqueNames.Add("Neeraja");
uniqueNames.Add("Sowmya");
uniqueNames.Add("Neeraja");  // ignored

foreach (string name in uniqueNames)
    Console.WriteLine(name);  // only 2 names
```

Use when you need fast uniqueness checks or set operations (union, intersection).

---

## Queue\<T\> — First In, First Out (FIFO)

Like a line — first added is first removed.

```csharp
Queue<string> tasks = new Queue<string>();
tasks.Enqueue("Learn C#");
tasks.Enqueue("Build a project");
tasks.Enqueue("Apply for jobs");

string next = tasks.Dequeue();  // "Learn C#"

foreach (string task in tasks)
    Console.WriteLine(task);
```

| Method | Description |
|--------|-------------|
| `Enqueue(item)` | Add to back |
| `Dequeue()` | Remove from front |
| `Peek()` | View front without removing |

---

## Stack\<T\> — Last In, First Out (LIFO)

Like a stack of plates — last added is first removed.

```csharp
Stack<string> books = new Stack<string>();
books.Push("C# Programming");
books.Push("Data Structures");
books.Push("Algorithms");
books.Pop();  // removes "Algorithms"

foreach (string book in books)
    Console.WriteLine(book);
```

| Method | Description |
|--------|-------------|
| `Push(item)` | Add to top |
| `Pop()` | Remove from top |
| `Peek()` | View top without removing |

---

## Collection Comparison

| Collection | Order | Duplicates | Access |
|------------|-------|------------|--------|
| `List<T>` | Yes (index) | Allowed | By index |
| `Dictionary<K,V>` | No (by key) | Keys unique | By key |
| `HashSet<T>` | No | Not allowed | Iteration only |
| `Queue<T>` | FIFO | Allowed | Front only |
| `Stack<T>` | LIFO | Allowed | Top only |

---

## Choosing the Right Collection

| Need | Use |
|------|-----|
| Ordered list with index access | `List<T>` |
| Lookup by key | `Dictionary<K,V>` |
| Unique items only | `HashSet<T>` |
| Process in order received | `Queue<T>` |
| Undo/redo, backtracking | `Stack<T>` |

---

## Run This Example

In `Program.cs`:

```csharp
Collections.Collect collect = new Collections.Collect();
collect.meth();
```

---

## Previous | Next

← [07 - OOP](07-oop.md) | [09 - Generics](09-generics.md) →

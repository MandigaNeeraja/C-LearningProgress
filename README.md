# C# Learning Project

A hands-on C# learning repository built on **.NET 10.0**. Each folder covers a core language concept with runnable examples you can explore, uncomment, and extend.

---

## Table of Contents

1. [Getting Started](#getting-started)
2. [Project Structure](#project-structure)
3. [C# Fundamentals](#c-fundamentals)
4. [Arrays](#arrays)
5. [Strings](#strings)
6. [Lists](#lists)
7. [Control Flow](#control-flow)
8. [Methods](#methods)
9. [Object-Oriented Programming (OOP)](#object-oriented-programming-oop)
10. [Collections](#collections)
11. [Generics](#generics)
12. [Delegates](#delegates)
13. [LINQ (Language Integrated Query)](#linq-language-integrated-query)
14. [Project File Reference](#project-file-reference)
15. [How to Run Examples](#how-to-run-examples)

---

## Getting Started

### Prerequisites

- [.NET SDK 10.0](https://dotnet.microsoft.com/download) or later
- A code editor (Visual Studio, VS Code, or Cursor)

### Build and Run

```bash
cd C#Learning
dotnet build
dotnet run
```

The entry point is `Program.cs`. Uncomment the example you want to run in `Main`, then execute `dotnet run`.

---

## Project Structure

```
C#Learning/
├── Program.cs                          # Main entry point
├── C#Learning.csproj                   # Project configuration
├── Arrays/arr.cs                       # Array basics
├── Strings/string.cs                   # String operations
├── Lists/list.cs                       # List<T> collection
├── ControlFlow/CF.cs                   # if/else, loops, switch
├── Methods/meth.cs                     # Methods and overloading
├── OOPs/
│   ├── oop.cs                          # OOP concept notes
│   ├── StudentModel.cs                 # Model with encapsulation
│   ├── StudentService.cs               # Service layer + interface
│   └── pp.cs                           # Student CRUD console app (commented)
├── Collections/
│   ├── Collect.cs                      # List, Dictionary, HashSet, Queue, Stack
│   └── Generics.cs                     # Generic classes
├── Delegates/Delegate.cs               # Delegates
└── LINQ(Language Integrated Query)/linq.cs  # LINQ queries
```

---

## C# Fundamentals

| Term | Description |
|------|-------------|
| **Namespace** | A logical grouping of related classes (e.g., `C_Learning.strings`) |
| **Class** | A blueprint for creating objects |
| **Object** | An instance of a class created with `new` |
| **Method** | A function defined inside a class |
| **Property** | A member that provides controlled access to data (`get` / `set`) |

### Minimal Program Structure

```csharp
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
```

### Value Types vs Reference Types

| Value Types | Reference Types |
|-------------|-----------------|
| `int`, `double`, `bool`, `char`, `struct` | `string`, `array`, `class`, `List<T>` |
| Stored on the stack | Stored on the heap; variable holds a reference |
| Copied by value | Copied by reference |

---

## Arrays

**Location:** `Arrays/arr.cs`

An **array** holds a **fixed number** of elements of the **same type**. It is a reference type.

### Declaration and Initialization

```csharp
int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
string[] names = new string[] { "John", "Jane", "Doe" };
```

### Common Operations

| Operation | Code | Description |
|-----------|------|-------------|
| Length | `numbers.Length` | Number of elements |
| Access by index | `names[0]` | Zero-based indexing |
| Find index | `Array.IndexOf(numbers, 3)` | Returns index or `-1` |
| Check existence | `Array.Exists(names, n => n == "Jane")` | Returns `true`/`false` |
| Sort | `Array.Sort(numbers)` | Ascending order |
| Reverse | `Array.Reverse(numbers)` | Reverse in place |
| Clear | `Array.Clear(numbers, 0, numbers.Length)` | Set elements to default |

### Example

```csharp
int[] numbers = { 1, 2, 3, 4, 5 };
Console.WriteLine(numbers.Length);           // 5
Console.WriteLine(Array.IndexOf(numbers, 3)); // 2
Array.Sort(numbers);
```

### Arrays vs Lists

| Feature | Array | List\<T\> |
|---------|-------|----------|
| Size | Fixed at creation | Dynamic (grows/shrinks) |
| Namespace | Built-in | `System.Collections.Generic` |
| Use when | Size is known and fixed | Size may change |

---

## Strings

**Location:** `Strings/string.cs`

A **string** is a sequence of characters. Strings are **reference types** and **immutable** — any operation that appears to change a string actually creates a new one.

### Common String Methods

| Method | Example | Output |
|--------|---------|--------|
| `Length` | `"John".Length` | `4` |
| `Substring` | `"John".Substring(0, 2)` | `"Jo"` |
| `ToUpper` | `"John".ToUpper()` | `"JOHN"` |
| `ToLower` | `"John".ToLower()` | `"john"` |
| `Trim` | `"  John  ".Trim()` | `"John"` |

### Concatenation and Formatting

```csharp
string name = "John";

// Concatenation
Console.WriteLine(name + " Doe");                    // John Doe
Console.WriteLine(String.Concat(name, " Doe"));      // John Doe

// Formatting
Console.WriteLine(String.Format("My name is {0}", name));  // My name is John
Console.WriteLine($"My name is {name}");                   // Interpolated string

// Join
Console.WriteLine(String.Join(", ", "John", "Jane", "Doe")); // John, Jane, Doe
```

### String Interpolation (Recommended)

```csharp
string greeting = $"Hello, {name}!";
```

---

## Lists

**Location:** `Lists/list.cs`

A **List\<T\>** is a dynamic collection from `System.Collections.Generic`. Unlike arrays, lists can grow and shrink at runtime.

### Declaration

```csharp
List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
List<string> names = new List<string>() { "John", "Jane", "Doe" };
```

### Common List Methods

| Method | Description | Example |
|--------|-------------|---------|
| `Count` | Number of elements | `numbers.Count` |
| `Add(item)` | Add to end | `numbers.Add(6)` |
| `Insert(index, item)` | Insert at index | `numbers.Insert(0, 0)` |
| `Remove(item)` | Remove first match | `numbers.Remove(3)` |
| `RemoveAt(index)` | Remove at index | `numbers.RemoveAt(0)` |
| `Contains(item)` | Check existence | `names.Contains("Jane")` |
| `IndexOf(item)` | Find index | `numbers.IndexOf(3)` |
| `Sort()` | Sort ascending | `numbers.Sort()` |
| `Reverse()` | Reverse order | `numbers.Reverse()` |
| `Clear()` | Remove all | `numbers.Clear()` |
| `ToArray()` | Convert to array | `numbers.ToArray()` |

### Iterating a List

```csharp
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
```

---

## Control Flow

**Location:** `ControlFlow/CF.cs`

Control flow determines the **order** in which statements execute.

### Conditional Statements

#### if / else if / else

```csharp
int number = 10;

if (number > 0)
    Console.WriteLine("The number is positive.");
else if (number < 0)
    Console.WriteLine("The number is negative.");
else
    Console.WriteLine("The number is zero.");
```

#### Switch Expression (C# 8+)

```csharp
int d = 2;
int res = d switch
{
    1 => 10,
    2 => 20,
    3 => 30,
    _ => 0   // default case
};
Console.WriteLine(res); // 20
```

#### Classic switch Statement

```csharp
switch (option)
{
    case 1:
        // Add student
        break;
    case 2:
        // Display students
        break;
    default:
        Console.WriteLine("Invalid option");
        break;
}
```

### Loops

| Loop | Use Case | Example |
|------|----------|---------|
| `for` | Known iteration count | `for (int i = 0; i < 5; i++)` |
| `while` | Condition may never be true | `while (j < 5) { j++; }` |
| `do-while` | At least one execution | `do { k++; } while (k < 5);` |
| `foreach` | Iterate collections | `foreach (var item in list)` |

```csharp
// for loop
for (int i = 0; i < 5; i++)
    Console.WriteLine(i); // 0, 1, 2, 3, 4

// while loop
int j = 0;
while (j < 5)
{
    Console.WriteLine(j);
    j++;
}

// do-while loop
int k = 0;
do
{
    Console.WriteLine(k);
    k++;
} while (k < 5);
```

---

## Methods

**Location:** `Methods/meth.cs`

A **method** is a reusable block of code that performs a specific task.

### Method Structure

```
AccessModifier ReturnType MethodName(ParameterList)
{
    // body
}
```

| Part | Options / Notes |
|------|-----------------|
| Access modifier | `public`, `private`, `protected`, `internal` |
| Return type | `void`, `int`, `string`, or any type |
| Parameters | Comma-separated `(type name, type name)` |

### Examples from This Project

```csharp
// No parameters, no return value
public void PrintName()
{
    Console.WriteLine("Hello");
}

// With parameters
public void Greet(string name)
{
    Console.WriteLine($"Hello, {name}!");
}

// With return value
public int Add(int a, int b)
{
    return a + b;
}

// Method overloading — same name, different parameters
public void Greet()
{
    Console.WriteLine("Hello!");
}
```

### Method Overloading

Multiple methods can share the same name if they differ in **parameter count** or **parameter types**. The compiler picks the correct overload at compile time.

```csharp
ProgramMethods p = new ProgramMethods();
p.Greet("Neeraja");       // Calls Greet(string)
p.Greet();                // Calls Greet()
Console.WriteLine(p.Add(2, 3)); // 5
```

---

## Object-Oriented Programming (OOP)

**Locations:** `OOPs/oop.cs`, `OOPs/StudentModel.cs`, `OOPs/StudentService.cs`

OOP organizes code around **objects** that combine **data** and **behavior**.

### Four Pillars of OOP

| Pillar | Description | Example in Project |
|--------|-------------|-------------------|
| **Encapsulation** | Bundle data and methods; hide internal details | `Age` property with validation in `Student` |
| **Inheritance** | Derived class inherits from base class | (Extend with `class GraduateStudent : Student`) |
| **Polymorphism** | Same interface, different implementations | `IStudentService` implemented by `StudentService` |
| **Abstraction** | Expose only what is necessary | Interface hides implementation details |

### Encapsulation — Fields vs Properties

```csharp
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }

    private int age;  // field — hidden from outside

    public int Age    // property — controlled access
    {
        get { return age; }
        set
        {
            if (value > 0) age = value;
            else age = 0;
        }
    }

    public void Display()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Age: {Age}");
    }
}
```

### Access Modifiers

| Modifier | Visibility |
|----------|------------|
| `public` | Anywhere |
| `private` | Same class only |
| `protected` | Same class + derived classes |
| `internal` | Same assembly (project) |
| `protected internal` | Same assembly OR derived classes |
| `private protected` | Same assembly AND derived classes |

### Constructors

A **constructor** runs when an object is created. It initializes fields and properties.

```csharp
public class Student
{
    public Student() { }  // parameterless constructor

    public Student(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }
}
```

### Static vs Instance Members

| Type | Belongs To | Access |
|------|------------|--------|
| **Static** | The class itself | `ClassName.Member` — no `new` needed |
| **Instance** | A specific object | Requires `new ClassName()` |

```csharp
// Static
Console.WriteLine(Math.PI);

// Instance
Student s = new Student();
s.Display();
```

### Interfaces and Services

An **interface** defines a contract — what a class must implement, not how.

```csharp
internal interface IStudentService
{
    void Add(Student student);
    void Update(int id);
    void Delete(int id);
    void viewStudents();
    Student Findstudent(int id);
}

internal class StudentService : IStudentService
{
    private List<Student> students = new List<Student>();

    public void Add(Student student) => students.Add(student);

    public Student Findstudent(int id) => students.Find(s => s.Id == id);

    public void Delete(int id)
    {
        for (int i = 0; i < students.Count; i++)
        {
            if (students[i].Id == id)
            {
                students.RemoveAt(i);
                break;
            }
        }
    }

    // ... Update, viewStudents
}
```

### Student CRUD Console App

The full interactive CRUD application lives in `OOPs/pp.cs` (currently commented out). It demonstrates:

- Menu-driven `switch` control flow
- `StudentService` for Add, View, Delete, Find, Update
- Console input with `Convert.ToInt32` and `Console.ReadLine()`

To try it, uncomment the code in `pp.cs` and set it as the startup project entry point.

---

## Collections

**Location:** `Collections/Collect.cs`

The .NET **Collections** namespace provides data structures for storing groups of objects.

### List\<T\>

Ordered, index-based, allows duplicates.

```csharp
List<string> names = new List<string>();
names.Add("Neeraja");
names.Add("Sowmya");

foreach (string name in names)
    Console.WriteLine(name);
```

### Dictionary\<TKey, TValue\>

Key-value pairs. Keys must be unique.

```csharp
Dictionary<string, int> nameAges = new Dictionary<string, int>();
nameAges.Add("Neeraja", 22);
nameAges.Add("Sowmya", 24);

foreach (KeyValuePair<string, int> entry in nameAges)
    Console.WriteLine($"Name: {entry.Key}, Age: {entry.Value}");
```

### HashSet\<T\>

Unordered collection of **unique** elements. Duplicates are ignored.

```csharp
HashSet<string> uniqueNames = new HashSet<string>();
uniqueNames.Add("Neeraja");
uniqueNames.Add("Neeraja"); // ignored — already exists
```

### Queue\<T\> — First In, First Out (FIFO)

```csharp
Queue<string> tasks = new Queue<string>();
tasks.Enqueue("Learn C#");
tasks.Enqueue("Build a project");

string next = tasks.Dequeue(); // "Learn C#"
```

### Stack\<T\> — Last In, First Out (LIFO)

```csharp
Stack<string> books = new Stack<string>();
books.Push("C# Programming");
books.Push("Data Structures");
books.Pop(); // removes "Data Structures"
```

### Collection Comparison

| Collection | Order | Duplicates | Access |
|------------|-------|------------|--------|
| `List<T>` | Yes (index) | Allowed | By index |
| `Dictionary<K,V>` | No (by key) | Keys unique | By key |
| `HashSet<T>` | No | Not allowed | Iteration only |
| `Queue<T>` | FIFO | Allowed | Front only |
| `Stack<T>` | LIFO | Allowed | Top only |

---

## Generics

**Location:** `Collections/Generics.cs`

**Generics** let you write type-safe code that works with any data type, without boxing/unboxing or casting.

### Generic Class

```csharp
class generics<T>
{
    public T Value;

    public void Display()
    {
        Console.WriteLine($"Value: {Value}");
    }
}
```

### Usage

```csharp
// int version
generics<int> gen1 = new generics<int>();
gen1.Value = 42;
gen1.Display(); // Value: 42

// string version
generics<string> gen2 = new generics<string>();
gen2.Value = "Hello, Generics!";
gen2.Display(); // Value: Hello, Generics!
```

### Why Use Generics?

| Without Generics | With Generics |
|------------------|---------------|
| `ArrayList` stores `object` — requires casting | `List<int>` is type-safe |
| Runtime errors from wrong casts | Compile-time type checking |
| Boxing value types | No boxing overhead |

### Common Generic Types in .NET

- `List<T>`
- `Dictionary<TKey, TValue>`
- `HashSet<T>`
- `Queue<T>`, `Stack<T>`

---

## Delegates

**Location:** `Delegates/Delegate.cs`

A **delegate** is a type-safe function pointer. It holds a reference to a method and can invoke it.

### Define and Use a Delegate

```csharp
delegate void MyDelegate();

class DelegateExample
{
    public void Method1()
    {
        Console.WriteLine("Method1 called");
    }

    public void Method2()
    {
        Console.WriteLine("Method2 called");
    }
}

// Usage
DelegateExample d = new DelegateExample();
MyDelegate del1 = d.Method1;
MyDelegate del2 = d.Method2;

del1(); // Method1 called
del2(); // Method2 called
```

### Delegates vs Direct Method Calls

| Approach | When to Use |
|----------|-------------|
| Direct call | Simple, one fixed method |
| Delegate | Callbacks, event handlers, passing behavior as a parameter |

### Built-in Delegate Types

| Type | Signature |
|------|-----------|
| `Action` | `void Method()` — no return value |
| `Action<T>` | `void Method(T arg)` |
| `Func<T>` | `T Method()` — returns a value |
| `Func<T, TResult>` | `TResult Method(T arg)` |

```csharp
Action greet = () => Console.WriteLine("Hello!");
Func<int, int, int> add = (a, b) => a + b;

greet();
Console.WriteLine(add(2, 3)); // 5
```

---

## LINQ (Language Integrated Query)

**Location:** `LINQ(Language Integrated Query)/linq.cs`

**LINQ** provides a consistent way to query data from arrays, lists, databases, and more.

### Two Syntax Styles

#### 1. Method Syntax (Fluent / Lambda)

```csharp
int[] numbers = { 1, 2, 3, 4, 5 };
var evenNumbers = numbers.Where(n => n % 2 == 0);
```

#### 2. Query Syntax (SQL-like)

```csharp
var evenNumbers = from n in numbers
                  where n % 2 == 0
                  select n;
```

Both produce the same result. Method syntax is more common in modern C#.

### Common LINQ Methods

| Method | Description | Example |
|--------|-------------|---------|
| `Where` | Filter | `.Where(n => n > 2)` |
| `Select` | Transform/project | `.Select(n => n * 2)` |
| `OrderBy` | Sort ascending | `.OrderBy(s => s.Name)` |
| `OrderByDescending` | Sort descending | `.OrderByDescending(n => n)` |
| `First` / `FirstOrDefault` | First element | `.FirstOrDefault(s => s.Id == 1)` |
| `Any` | Any match? | `.Any(n => n > 10)` |
| `All` | All match? | `.All(n => n > 0)` |
| `Count` | Count elements | `.Count(n => n % 2 == 0)` |
| `Sum` / `Average` / `Min` / `Max` | Aggregates | `numbers.Sum()` |
| `GroupBy` | Group by key | `.GroupBy(s => s.Age)` |

### Extended Example

```csharp
List<Student> students = new List<Student>
{
    new Student { Id = 1, Name = "Alice", Age = 20 },
    new Student { Id = 2, Name = "Bob",   Age = 22 },
    new Student { Id = 3, Name = "Carol", Age = 20 }
};

// Students aged 20
var age20 = students.Where(s => s.Age == 20);

// Names only
var names = students.Select(s => s.Name);

// Average age
double avgAge = students.Average(s => s.Age);

// Group by age
var grouped = students.GroupBy(s => s.Age);
foreach (var group in grouped)
{
    Console.WriteLine($"Age {group.Key}: {group.Count()} students");
}
```

### Deferred Execution

LINQ queries are **lazy** — they run when you iterate (e.g., `foreach`), not when the query is defined.

```csharp
var query = numbers.Where(n => n > 2); // not executed yet
foreach (var n in query)               // executed here
    Console.WriteLine(n);
```

---

## Project File Reference

| File Extension | Purpose |
|----------------|---------|
| `.csproj` | Project settings and dependencies |
| `.sln` | Manages multiple projects in a solution |
| `.cs` | C# source code |
| `.json` | Configuration or structured data |
| `.md` | Documentation (Markdown) |
| `.txt` | Plain text notes |
| `.gitignore` | Files ignored by Git |
| `.editorconfig` | Coding style and formatting rules |
| `.config` | Application settings |
| `.resx` | Resources (strings, images, icons) |
| `.xaml` | WPF user interface |
| `.xml` | Structured configuration data |
| `.html` / `.css` / `.js` | Web UI assets |
| `.sql` | Database queries |
| `.csv` | Tabular data |
| `.log` | Application log output |

---

## How to Run Examples

`Program.cs` is the main entry point. Examples are invoked by creating objects and calling their methods. Most are **commented out** so you can enable one topic at a time.

### Currently Active in Main

```csharp
// Generics
Collections.generics<string> gen2 = new Collections.generics<string>();
gen2.Value = "Hello, Generics!";
gen2.Display();

// LINQ
LINQExamples l = new LINQExamples();
l.Example();

// Delegates
Collections.DelegateExample d = new Collections.DelegateExample();
Collections.MyDelegate del1 = d.Method1;
Collections.MyDelegate del2 = d.Method2;
del1();
del2();
```

### Enable Other Examples

Uncomment the relevant block in `Program.cs`:

| Topic | Code to Uncomment |
|-------|-------------------|
| Strings | `ProgramStrings programStrings = new ProgramStrings();` |
| Lists | `ProgramLists programlist = new ProgramLists();` |
| Control Flow | `ProgramControlFlow p1 = new ProgramControlFlow();` |
| Methods | `ProgramMethods p2 = new ProgramMethods();` |
| Collections | `Collections.Collect collect = new Collections.Collect();` |

Add the required `using` directive at the top of `Program.cs` if the namespace is not already imported.

### Example: Run Strings

```csharp
using C_Learning.strings;

// Inside Main:
ProgramStrings programStrings = new ProgramStrings();
programStrings.PrintName();
programStrings.StringMethods();
```

---

## Quick Reference — C# Type Keywords

| Keyword | .NET Type | Example |
|---------|-----------|---------|
| `int` | `Int32` | `42` |
| `double` | `Double` | `3.14` |
| `bool` | `Boolean` | `true` |
| `char` | `Char` | `'A'` |
| `string` | `String` | `"hello"` |
| `decimal` | `Decimal` | `99.99m` |
| `var` | Inferred at compile time | `var x = 10;` |

---

## Learning Path Suggestion

1. **Fundamentals** — namespaces, classes, `Main`, console I/O  
2. **Data types** — arrays, strings, lists  
3. **Control flow** — if/else, loops, switch  
4. **Methods** — parameters, return values, overloading  
5. **OOP** — encapsulation, properties, interfaces, services  
6. **Collections** — List, Dictionary, HashSet, Queue, Stack  
7. **Generics** — type-safe reusable code  
8. **Delegates** — callbacks and events foundation  
9. **LINQ** — querying collections declaratively  

---

## Resources

- [Microsoft C# Documentation](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [.NET API Reference](https://learn.microsoft.com/en-us/dotnet/api/)
- [C# Language Reference](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/)

---

*Happy learning! Uncomment examples in `Program.cs`, run `dotnet run`, and experiment with the code in each folder.*

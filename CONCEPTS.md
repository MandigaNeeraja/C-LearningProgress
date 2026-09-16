# C# Concepts — Quick Reference

One-page cheat sheet for all topics covered in this project. For detailed explanations and examples, see the [docs folder](docs/README.md).

---

## Fundamentals

| Concept | Definition |
|---------|------------|
| Namespace | Logical grouping of classes |
| Class | Blueprint for objects |
| Object | Instance of a class (`new ClassName()`) |
| Method | Function inside a class |
| Property | Controlled data access (`get` / `set`) |
| Value type | Stored on stack, copied by value (`int`, `bool`) |
| Reference type | Stored on heap, copied by reference (`string`, `class`) |

---

## Arrays

Fixed-size, same-type collection. Zero-based index.

```csharp
int[] nums = { 1, 2, 3 };
nums.Length;              // 3
Array.IndexOf(nums, 2);   // 1
Array.Sort(nums);
```

---

## Strings

Immutable sequence of characters.

```csharp
"hello".Length;                    // 5
"hello".ToUpper();                 // HELLO
$"Hello, {name}";                  // interpolation
String.Join(", ", "a", "b");       // a, b
int.TryParse("42", out int n);     // safe parsing
```

---

## Lists

Dynamic, generic collection (`List<T>`).

```csharp
List<int> list = new() { 1, 2, 3 };
list.Add(4); list.Remove(2); list.Count;
list.Sort(); list.Reverse(); list.Contains(3);
```

---

## Control Flow

```csharp
if (x > 0) { } else if (x < 0) { } else { }

int r = n switch { 1 => 10, 2 => 20, _ => 0 };

for (int i = 0; i < n; i++) { }
while (condition) { }
do { } while (condition);
foreach (var item in collection) { }
```

---

## Methods

```csharp
public void DoWork() { }                    // no return
public int Add(int a, int b) => a + b;       // with return
public void Greet(string name) { }           // with params
public void Greet() { }                      // overload
```

Access modifiers: `public`, `private`, `protected`, `internal`

---

## OOP — Four Pillars

| Pillar | One-liner |
|--------|-----------|
| Encapsulation | Hide data, expose via properties |
| Inheritance | `class Derived : Base` |
| Polymorphism | Same interface, different behavior |
| Abstraction | Interfaces hide implementation |

```csharp
public class Student
{
    public int Id { get; set; }
    private int age;
    public int Age
    {
        get => age;
        set { if (value > 0) age = value; }
    }
}
```

---

## Collections

| Type | Structure | Duplicates |
|------|-----------|------------|
| `List<T>` | Ordered, indexed | Yes |
| `Dictionary<K,V>` | Key-value | Keys unique |
| `HashSet<T>` | Unordered | No |
| `Queue<T>` | FIFO | Yes |
| `Stack<T>` | LIFO | Yes |

```csharp
dict.Add("key", value);
dict["key"];                    // access
queue.Enqueue(x); queue.Dequeue();
stack.Push(x); stack.Pop();
```

---

## Generics

Type-safe reusable code with placeholder `T`.

```csharp
class Box<T> { public T Value { get; set; } }
Box<int> b = new(); b.Value = 42;
List<int>, Dictionary<string, int>  // built-in generics
```

---

## Delegates

Type-safe method references.

```csharp
delegate void MyDel();
MyDel d = obj.Method; d();

Action action = () => Console.WriteLine("Hi");
Func<int,int,int> add = (a,b) => a+b;
```

Events: `public event Action? Clicked;`

---

## LINQ

Query collections declaratively.

```csharp
// Method syntax
nums.Where(n => n % 2 == 0).Select(n => n * 2).OrderBy(n => n);

// Query syntax
from n in nums where n % 2 == 0 select n;

// Common
.FirstOrDefault(), .Any(), .All(), .Count()
.Sum(), .Average(), .GroupBy(), .Distinct()
```

Queries are **lazy** — execute on iteration.

---

## Type Keywords

| Keyword | Example |
|---------|---------|
| `int` | `42` |
| `double` | `3.14` |
| `bool` | `true` |
| `char` | `'A'` |
| `string` | `"text"` |
| `decimal` | `99.99m` |
| `var` | inferred type |

---

## Project Files

| File | Purpose |
|------|---------|
| `.csproj` | Project settings |
| `.sln` | Multi-project solution |
| `.cs` | C# source code |
| `.md` | Documentation |

---

## Full Documentation

| Resource | Link |
|----------|------|
| Project overview | [README.md](README.md) |
| Topic-by-topic docs | [docs/README.md](docs/README.md) |
| Learning path | Fundamentals → Arrays → Strings → Lists → Control Flow → Methods → OOP → Collections → Generics → Delegates → LINQ |

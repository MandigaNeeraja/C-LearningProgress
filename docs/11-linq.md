# LINQ (Language Integrated Query)

**Source:** `LINQ(Language Integrated Query)/linq.cs`

**LINQ** provides a consistent, declarative way to query data from arrays, lists, databases, XML, and more.

---

## Two Syntax Styles

Both produce the same result. Method syntax is more common in modern C#.

### Method Syntax (Lambda)

```csharp
int[] numbers = { 1, 2, 3, 4, 5 };
var evenNumbers = numbers.Where(n => n % 2 == 0);
```

### Query Syntax (SQL-like)

```csharp
var evenNumbers = from n in numbers
                  where n % 2 == 0
                  select n;
```

---

## Basic Example from This Project

```csharp
int[] numbers = { 1, 2, 3, 4, 5 };

var evenNumbers = numbers.Where(n => n % 2 == 0);

Console.WriteLine("Even numbers:");
foreach (var num in evenNumbers)
    Console.WriteLine(num);  // 2, 4
```

---

## Common LINQ Methods

| Method | Description | Example |
|--------|-------------|---------|
| `Where` | Filter | `.Where(n => n > 2)` |
| `Select` | Transform/project | `.Select(n => n * 2)` |
| `OrderBy` | Sort ascending | `.OrderBy(s => s.Name)` |
| `OrderByDescending` | Sort descending | `.OrderByDescending(n => n)` |
| `First` | First element (throws if empty) | `.First()` |
| `FirstOrDefault` | First or default | `.FirstOrDefault(s => s.Id == 1)` |
| `Any` | Any match? | `.Any(n => n > 10)` |
| `All` | All match? | `.All(n => n > 0)` |
| `Count` | Count elements | `.Count(n => n % 2 == 0)` |
| `Sum` / `Average` / `Min` / `Max` | Aggregates | `numbers.Sum()` |
| `GroupBy` | Group by key | `.GroupBy(s => s.Age)` |
| `Distinct` | Remove duplicates | `.Distinct()` |
| `Take(n)` | First n elements | `.Take(3)` |
| `Skip(n)` | Skip first n | `.Skip(2)` |

---

## Extended Example with Student Objects

```csharp
List<Student> students = new List<Student>
{
    new Student { Id = 1, Name = "Alice", Age = 20 },
    new Student { Id = 2, Name = "Bob",   Age = 22 },
    new Student { Id = 3, Name = "Carol", Age = 20 }
};

// Filter: students aged 20
var age20 = students.Where(s => s.Age == 20);

// Project: names only
var names = students.Select(s => s.Name);

// Aggregate
double avgAge = students.Average(s => s.Age);

// Group
var grouped = students.GroupBy(s => s.Age);
foreach (var group in grouped)
    Console.WriteLine($"Age {group.Key}: {group.Count()} students");

// Find one
var alice = students.FirstOrDefault(s => s.Name == "Alice");
```

---

## Method vs Query Syntax Equivalents

```csharp
// Method
var result = students
    .Where(s => s.Age >= 20)
    .OrderBy(s => s.Name)
    .Select(s => s.Name);

// Query
var result = from s in students
             where s.Age >= 20
             orderby s.Name
             select s.Name;
```

---

## Deferred Execution

LINQ queries are **lazy** — they don't run until you iterate:

```csharp
var query = numbers.Where(n => n > 2);  // not executed yet

foreach (var n in query)                // executed here
    Console.WriteLine(n);

// Or force immediate execution:
var list = numbers.Where(n => n > 2).ToList();
int count = numbers.Count(n => n > 2);
```

---

## Chaining LINQ

```csharp
var result = numbers
    .Where(n => n % 2 == 0)
    .Select(n => n * 10)
    .OrderByDescending(n => n)
    .ToList();
// [40, 20]
```

---

## Run This Example

Currently active in `Program.cs`:

```csharp
LINQExamples l = new LINQExamples();
l.Example();
```

---

## Previous

← [10 - Delegates](10-delegates.md)

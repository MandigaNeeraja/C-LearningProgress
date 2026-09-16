# Lists

**Source:** `Lists/list.cs`

A **List\<T\>** is a dynamic collection from `System.Collections.Generic`. Unlike arrays, lists can grow and shrink at runtime.

---

## Declaration and Initialization

```csharp
List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
List<string> names = new List<string>() { "John", "Jane", "Doe" };

// Empty list
List<double> prices = new List<double>();
```

---

## Common List Methods

From `ProgramLists.ListMethods()`:

```csharp
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

Console.WriteLine(numbers.Count);       // 5
Console.WriteLine(numbers.IndexOf(3));  // 2
Console.WriteLine(numbers.Contains(3)); // True

numbers.Add(6);              // [1, 2, 3, 4, 5, 6]
numbers.Remove(3);             // [1, 2, 4, 5, 6]
numbers.Insert(0, 0);          // [0, 1, 2, 4, 5, 6]
numbers.Sort();                // [0, 1, 2, 4, 5, 6]
numbers.Reverse();               // [6, 5, 4, 2, 1, 0]
numbers.RemoveAt(0);             // [5, 4, 2, 1, 0]
```

| Method | Description |
|--------|-------------|
| `.Count` | Number of elements |
| `.Add(item)` | Add to end |
| `.Insert(index, item)` | Insert at index |
| `.Remove(item)` | Remove first match |
| `.RemoveAt(index)` | Remove at index |
| `.Contains(item)` | Check existence |
| `.IndexOf(item)` | Find index |
| `.Sort()` | Sort ascending |
| `.Reverse()` | Reverse order |
| `.Clear()` | Remove all |
| `.ToArray()` | Convert to array |

---

## Accessing Elements

```csharp
List<string> names = new List<string> { "John", "Jane", "Doe" };

Console.WriteLine(names[0]);  // John — index access like arrays
names[1] = "Janet";         // Modify by index
```

---

## Iterating a List

```csharp
foreach (int number in numbers)
{
    Console.WriteLine(number);
}

for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}
```

---

## List of Custom Objects

```csharp
List<Student> students = new List<Student>();
students.Add(new Student { Id = 1, Name = "Alice", Age = 20 });
students.Add(new Student { Id = 2, Name = "Bob", Age = 22 });

foreach (var student in students)
    student.Display();
```

---

## When to Use List vs Array

| Use `List<T>` | Use `Array` |
|---------------|-------------|
| Size changes at runtime | Size is fixed and known |
| Frequent add/remove | Rarely modified after creation |
| Most application code | Interop with fixed-size APIs |

---

## Run This Example

In `Program.cs`:

```csharp
using C_Learning.lists;

ProgramLists programlist = new ProgramLists();
programlist.ListMethods();
```

---

## Previous | Next

← [03 - Strings](03-strings.md) | [05 - Control Flow](05-control-flow.md) →

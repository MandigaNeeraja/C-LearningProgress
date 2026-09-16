# Arrays

**Source:** `Arrays/arr.cs`

An **array** holds a **fixed number** of elements of the **same type**. It is a reference type.

---

## Declaration and Initialization

```csharp
// Fixed size with values
int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

// Shorthand initialization
string[] names = new string[] { "John", "Jane", "Doe" };

// Even shorter
int[] scores = { 90, 85, 88 };
```

Once created, the **size cannot change**. To store more items, use a `List<T>` instead.

---

## Accessing Elements

Arrays use **zero-based indexing** — the first element is at index `0`.

```csharp
Console.WriteLine(names[0]);  // John
Console.WriteLine(names[2]);  // Doe
Console.WriteLine(numbers.Length);  // 5
```

---

## Common Array Methods

From `ProgramArrays.ArrayMethods()`:

```csharp
int[] numbers = { 1, 2, 3, 4, 5 };
string[] names = { "John", "Jane", "Doe" };

Console.WriteLine(numbers.Length);
// Output: 5

Console.WriteLine(Array.IndexOf(numbers, 3));
// Output: 2

Console.WriteLine(Array.Exists(names, name => name == "Jane"));
// Output: True

Array.Sort(numbers);    // Sort ascending in place
Array.Reverse(numbers); // Reverse order in place
Array.Clear(numbers, 0, numbers.Length); // Set all to default (0)
```

| Method | Description |
|--------|-------------|
| `.Length` | Number of elements |
| `Array.IndexOf(arr, value)` | Index of first match, or `-1` |
| `Array.Exists(arr, predicate)` | Returns `true` if any element matches |
| `Array.Sort(arr)` | Sort ascending |
| `Array.Reverse(arr)` | Reverse in place |
| `Array.Clear(arr, start, count)` | Reset elements to default |

---

## Iterating an Array

```csharp
foreach (int num in numbers)
{
    Console.WriteLine(num);
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}
```

---

## Multidimensional Arrays

```csharp
// 2D array (matrix)
int[,] grid = new int[3, 3]
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

Console.WriteLine(grid[1, 2]); // 6
```

---

## Arrays vs Lists

| Feature | Array | List\<T\> |
|---------|-------|----------|
| Size | Fixed | Dynamic |
| Add/Remove | Not supported | `Add`, `Remove` |
| Use when | Size is known and fixed | Size may change |

---

## Run This Example

In `Program.cs`, add:

```csharp
using arrays;

ProgramArrays arr = new ProgramArrays();
arr.ArrayMethods();
```

---

## Previous | Next

← [01 - Fundamentals](01-fundamentals.md) | [03 - Strings](03-strings.md) →

# Strings

**Source:** `Strings/string.cs`

A **string** is a sequence of characters. Strings are **reference types** and **immutable** — any operation that appears to modify a string actually creates a new one.

---

## Creating Strings

```csharp
string name = "John";
string greeting = "Hello, World!";
string empty = string.Empty;
```

---

## Common String Properties and Methods

From `ProgramStrings.StringMethods()`:

```csharp
string name = "John";

Console.WriteLine(name.Length);           // 4
Console.WriteLine(name.Substring(0, 2));  // Jo
Console.WriteLine(name.ToUpper());        // JOHN
Console.WriteLine(name.ToLower());        // john
Console.WriteLine(name.Trim());           // John (removes leading/trailing whitespace)
```

| Method / Property | Description |
|-------------------|-------------|
| `.Length` | Number of characters |
| `.Substring(start, length)` | Extract a portion |
| `.ToUpper()` / `.ToLower()` | Change case |
| `.Trim()` | Remove whitespace from ends |
| `.Contains("text")` | Check if substring exists |
| `.Replace("old", "new")` | Replace occurrences |
| `.Split(',')` | Split into array by delimiter |
| `.StartsWith("J")` / `.EndsWith("n")` | Prefix/suffix check |

---

## Concatenation

```csharp
string name = "John";

// Using + operator
Console.WriteLine(name + " Doe");  // John Doe

// Using String.Concat
Console.WriteLine(String.Concat(name, " Doe"));  // John Doe
```

---

## String Formatting

```csharp
string name = "John";

// String.Format (positional placeholders)
Console.WriteLine(String.Format("My name is {0}", name));
// My name is John

// Interpolation (preferred in modern C#)
Console.WriteLine($"My name is {name}");
// My name is John

// Join multiple strings
Console.WriteLine(String.Join(", ", "John", "Jane", "Doe"));
// John, Jane, Doe
```

---

## Immutability Example

```csharp
string s = "Hello";
s = s + " World";  // Creates a NEW string; original "Hello" is unchanged
```

Because strings are immutable, repeated concatenation in loops is inefficient. Use `StringBuilder` for many concatenations:

```csharp
var sb = new System.Text.StringBuilder();
for (int i = 0; i < 100; i++)
    sb.Append(i);
string result = sb.ToString();
```

---

## Parsing Strings to Other Types

```csharp
int age = int.Parse("25");
double price = double.Parse("19.99");
bool flag = bool.Parse("true");

// Safer — returns false instead of throwing
if (int.TryParse("25", out int value))
    Console.WriteLine(value);  // 25
```

---

## Run This Example

In `Program.cs`:

```csharp
using C_Learning.strings;

ProgramStrings programStrings = new ProgramStrings();
programStrings.PrintName();
programStrings.StringMethods();
```

---

## Previous | Next

← [02 - Arrays](02-arrays.md) | [04 - Lists](04-lists.md) →

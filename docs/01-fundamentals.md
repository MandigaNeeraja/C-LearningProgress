# C# Fundamentals

**Source:** `Program.cs`, `Notes.txt`

---

## Core Terminology

| Term | Description |
|------|-------------|
| **Namespace** | A logical grouping of related classes (e.g., `C_Learning.strings`) |
| **Class** | A blueprint for creating objects |
| **Object** | An instance of a class created with `new` |
| **Method** | A function defined inside a class |
| **Property** | A member that provides controlled access to data (`get` / `set`) |

---

## Minimal Program Structure

Every C# console app has an entry point — the `Main` method.

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

| Part | Role |
|------|------|
| `using System;` | Imports the `System` namespace so you can use `Console` |
| `namespace Program` | Groups your code logically |
| `class Program` | Defines the class |
| `static void Main` | Entry point — execution starts here |
| `Console.WriteLine` | Writes output to the terminal |

---

## Value Types vs Reference Types

| Value Types | Reference Types |
|-------------|-----------------|
| `int`, `double`, `bool`, `char`, `struct` | `string`, `array`, `class`, `List<T>` |
| Stored on the stack | Stored on the heap |
| Copied by value | Variable holds a reference to the object |

```csharp
int a = 10;
int b = a;   // b gets a copy of 10
b = 20;      // a is still 10

List<int> list1 = new List<int> { 1, 2, 3 };
List<int> list2 = list1;  // both point to the same list
list2.Add(4);               // list1 also has 4 elements now
```

---

## Common Type Keywords

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

## Creating and Using Objects

```csharp
// Create an object with 'new'
ProgramStrings programStrings = new ProgramStrings();
programStrings.PrintName();
```

Steps:
1. Declare a variable of the class type
2. Instantiate with `new ClassName()`
3. Call methods or access properties on the object

---

## Project Configuration

This project uses `C#Learning.csproj`:

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
    <RootNamespace>C_Learning</RootNamespace>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>
</Project>
```

| Setting | Meaning |
|---------|---------|
| `OutputType` | Builds a console executable |
| `TargetFramework` | Targets .NET 10 |
| `ImplicitUsings` | Auto-imports common namespaces |
| `Nullable` | Enables nullable reference type checks |

---

## Next

→ [02 - Arrays](02-arrays.md)

# Methods

**Source:** `Methods/meth.cs`

A **method** is a reusable block of code that performs a specific task. Methods live inside classes.

---

## Method Structure

```
AccessModifier ReturnType MethodName(ParameterList)
{
    // body
}
```

| Part | Options |
|------|---------|
| Access modifier | `public`, `private`, `protected`, `internal` |
| Return type | `void` (no return), `int`, `string`, any type |
| Parameters | `(type name, type name, ...)` |

---

## Examples from This Project

### No Parameters, No Return Value

```csharp
public void PrintName()
{
    Console.WriteLine("Hello");
}
```

### With Parameters

```csharp
public void Greet(string name)
{
    Console.WriteLine($"Hello, {name}!");
}
```

### With Return Value

```csharp
public int Add(int a, int b)
{
    return a + b;
}
```

### Method Overloading

Same method name, different parameter lists:

```csharp
public void Greet(string name)
{
    Console.WriteLine($"Hello, {name}!");
}

public void Greet()
{
    Console.WriteLine("Hello!");
}
```

The compiler picks the correct overload based on the arguments you pass.

---

## Calling Methods

```csharp
ProgramMethods p = new ProgramMethods();

p.PrintName();                  // Hello
p.Greet("Neeraja");             // Hello, Neeraja!
p.Greet();                      // Hello!
Console.WriteLine(p.Add(2, 3)); // 5
```

---

## Parameter Types

### By Value (default for value types)

```csharp
public void Increment(int x)
{
    x++;  // does not affect the caller's variable
}
```

### By Reference (`ref` / `out`)

```csharp
public void Increment(ref int x)
{
    x++;  // modifies the caller's variable
}

public bool TryParseAge(string input, out int age)
{
    return int.TryParse(input, out age);
}
```

### Optional Parameters

```csharp
public void Greet(string name, string prefix = "Hello")
{
    Console.WriteLine($"{prefix}, {name}!");
}

Greet("Alice");              // Hello, Alice!
Greet("Bob", "Hi");          // Hi, Bob!
```

---

## Static Methods

Belong to the class, not an instance. Called without `new`.

```csharp
public static int Max(int a, int b) => a > b ? a : b;

// Usage
int result = ProgramMethods.Max(5, 10);  // if static
```

Compare with instance methods that require an object:

```csharp
ProgramMethods p = new ProgramMethods();
p.Greet("Alice");
```

---

## Expression-Bodied Methods (C# 6+)

Short syntax for single-expression methods:

```csharp
public int Add(int a, int b) => a + b;
public void Greet(string name) => Console.WriteLine($"Hello, {name}!");
```

---

## Run This Example

In `Program.cs`:

```csharp
using C_Learning.methods;

ProgramMethods p2 = new ProgramMethods();
p2.PrintName();
p2.Greet("Neeraja");
Console.WriteLine(p2.Add(2, 3));
p2.Greet();
```

---

## Previous | Next

← [05 - Control Flow](05-control-flow.md) | [07 - OOP](07-oop.md) →

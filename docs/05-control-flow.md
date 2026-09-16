# Control Flow

**Source:** `ControlFlow/CF.cs`

Control flow determines the **order** in which statements execute.

---

## Conditional Statements

### if / else if / else

```csharp
int number = 10;

if (number > 0)
{
    Console.WriteLine("The number is positive.");
}
else if (number < 0)
{
    Console.WriteLine("The number is negative.");
}
else
{
    Console.WriteLine("The number is zero.");
}
```

### Ternary Operator (Shorthand if/else)

```csharp
string label = number > 0 ? "positive" : "non-positive";
```

---

## Switch

### Switch Expression (C# 8+)

From `ProgramControlFlow.ControlFlowMethods()`:

```csharp
int d = 2;
int res = d switch
{
    1 => 10,
    2 => 20,
    3 => 30,
    _ => 0   // default
};
Console.WriteLine(res); // 20
```

### Classic switch Statement

Used in the Student CRUD app (`OOPs/pp.cs`):

```csharp
switch (option)
{
    case 1:
        // Add student
        break;
    case 2:
        // Display students
        break;
    case 6:
        n = false;  // Exit
        break;
    default:
        Console.WriteLine("Invalid option");
        break;
}
```

---

## Loops

### for Loop

Best when you know how many iterations you need.

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i); // 0, 1, 2, 3, 4
}
```

### while Loop

Runs while the condition is true. May run zero times.

```csharp
int j = 0;
while (j < 5)
{
    Console.WriteLine(j);
    j++;
}
```

### do-while Loop

Always runs **at least once**, then checks the condition.

```csharp
int k = 0;
do
{
    Console.WriteLine(k);
    k++;
} while (k < 5);
```

### foreach Loop

Best for iterating collections.

```csharp
List<string> names = new List<string> { "John", "Jane", "Doe" };
foreach (string name in names)
{
    Console.WriteLine(name);
}
```

---

## Loop Control Keywords

| Keyword | Effect |
|---------|--------|
| `break` | Exit the loop immediately |
| `continue` | Skip to next iteration |

```csharp
for (int i = 0; i < 10; i++)
{
    if (i == 3) continue;  // skip 3
    if (i == 7) break;     // stop at 7
    Console.WriteLine(i);  // 0, 1, 2, 4, 5, 6
}
```

---

## Comparison Summary

| Construct | Use When |
|-----------|----------|
| `if/else` | Simple branching on conditions |
| `switch` | Many branches on one variable |
| `for` | Known iteration count |
| `while` | Condition checked before each iteration |
| `do-while` | At least one iteration required |
| `foreach` | Iterating collections |

---

## Run This Example

In `Program.cs`:

```csharp
using Control;

ProgramControlFlow p1 = new ProgramControlFlow();
p1.ControlFlowMethods();
```

---

## Previous | Next

← [04 - Lists](04-lists.md) | [06 - Methods](06-methods.md) →

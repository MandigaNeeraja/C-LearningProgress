# Generics

**Source:** `Collections/Generics.cs`

**Generics** let you write type-safe, reusable code that works with any data type without casting or boxing.

---

## Generic Class

From this project:

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

`T` is a **type parameter** — a placeholder replaced with a concrete type at compile time.

---

## Usage

```csharp
// Store an int
generics<int> gen1 = new generics<int>();
gen1.Value = 42;
gen1.Display();  // Value: 42

// Store a string
generics<string> gen2 = new generics<string>();
gen2.Value = "Hello, Generics!";
gen2.Display();  // Value: Hello, Generics!
```

Each instantiation is a separate, type-safe class at compile time.

---

## Why Use Generics?

### Without Generics (old approach)

```csharp
ArrayList list = new ArrayList();
list.Add(42);           // boxed to object
int x = (int)list[0];   // requires cast — runtime error if wrong type
```

### With Generics

```csharp
List<int> list = new List<int>();
list.Add(42);           // type-safe
int x = list[0];        // no cast needed
```

| Benefit | Description |
|---------|-------------|
| Type safety | Compiler catches type errors |
| No boxing | Value types stored directly |
| Reusability | One class works for many types |
| IntelliSense | IDE knows the actual type |

---

## Generic Constraints

Limit which types can be used as `T`:

```csharp
class Repository<T> where T : class
{
    public T? FindById(int id) { ... }
}

class Calculator<T> where T : struct, IComparable<T>
{
    public T Max(T a, T b) => a.CompareTo(b) > 0 ? a : b;
}
```

| Constraint | Meaning |
|------------|---------|
| `where T : struct` | Value type only |
| `where T : class` | Reference type only |
| `where T : new()` | Must have parameterless constructor |
| `where T : BaseClass` | Must inherit from `BaseClass` |
| `where T : IInterface` | Must implement `IInterface` |

---

## Common Generic Types in .NET

| Type | Purpose |
|------|---------|
| `List<T>` | Dynamic list |
| `Dictionary<TKey, TValue>` | Key-value map |
| `HashSet<T>` | Unique elements |
| `Queue<T>`, `Stack<T>` | FIFO / LIFO |
| `Nullable<T>` | Nullable value type (`int?`) |

---

## Generic Methods

Methods can also be generic:

```csharp
public static void Swap<T>(ref T a, ref T b)
{
    T temp = a;
    a = b;
    b = temp;
}

int x = 1, y = 2;
Swap(ref x, ref y);  // x=2, y=1
```

---

## Run This Example

Currently active in `Program.cs`:

```csharp
Collections.generics<string> gen2 = new Collections.generics<string>();
gen2.Value = "Hello, Generics!";
gen2.Display();
```

---

## Previous | Next

← [08 - Collections](08-collections.md) | [10 - Delegates](10-delegates.md) →

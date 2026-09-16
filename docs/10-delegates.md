# Delegates

**Source:** `Delegates/Delegate.cs`

A **delegate** is a type-safe function pointer. It holds a reference to a method and can invoke it later or pass it as an argument.

---

## Custom Delegate

From this project:

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
```

---

## Using a Delegate

```csharp
DelegateExample d = new DelegateExample();

MyDelegate del1 = d.Method1;
MyDelegate del2 = d.Method2;

del1();  // Method1 called
del2();  // Method2 called
```

You can also assign with `+=` to create a multicast delegate:

```csharp
MyDelegate del = d.Method1;
del += d.Method2;
del();  // calls both methods
```

---

## Delegates with Parameters

```csharp
delegate int MathOperation(int a, int b);

MathOperation add = (a, b) => a + b;
MathOperation multiply = (a, b) => a * b;

Console.WriteLine(add(3, 4));       // 7
Console.WriteLine(multiply(3, 4));  // 12
```

---

## Built-in Delegate Types

.NET provides generic delegate types so you rarely need custom ones:

| Type | Signature | Example |
|------|-----------|---------|
| `Action` | `void()` | `Action greet = () => Console.WriteLine("Hi");` |
| `Action<T>` | `void(T)` | `Action<string> print = s => Console.WriteLine(s);` |
| `Func<T>` | `T()` | `Func<int> getRandom = () => new Random().Next();` |
| `Func<T, TResult>` | `TResult(T)` | `Func<int, int, int> add = (a,b) => a+b;` |
| `Predicate<T>` | `bool(T)` | `Predicate<int> isEven = n => n % 2 == 0;` |

```csharp
Action greet = () => Console.WriteLine("Hello!");
Func<int, int, int> add = (a, b) => a + b;

greet();
Console.WriteLine(add(2, 3));  // 5
```

---

## Delegates vs Direct Calls

| Approach | When to Use |
|----------|-------------|
| Direct call | One fixed method, simple flow |
| Delegate | Callbacks, events, passing behavior as data |
| Lambda | Short inline delegate without naming a method |

---

## Events (Built on Delegates)

Events use delegates for publish/subscribe patterns:

```csharp
public class Button
{
    public event Action? Clicked;

    public void Click() => Clicked?.Invoke();
}

Button btn = new Button();
btn.Clicked += () => Console.WriteLine("Button was clicked!");
btn.Click();
```

---

## Run This Example

Currently active in `Program.cs`:

```csharp
Collections.DelegateExample d = new Collections.DelegateExample();
Collections.MyDelegate del1 = d.Method1;
Collections.MyDelegate del2 = d.Method2;
del1();
del2();
```

---

## Previous | Next

← [09 - Generics](09-generics.md) | [11 - LINQ](11-linq.md) →

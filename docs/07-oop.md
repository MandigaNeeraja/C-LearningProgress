# Object-Oriented Programming (OOP)

**Sources:** `OOPs/oop.cs`, `OOPs/StudentModel.cs`, `OOPs/StudentService.cs`, `OOPs/pp.cs`

OOP organizes code around **objects** that combine **data** and **behavior**.

---

## Four Pillars of OOP

| Pillar | Description | Example in Project |
|--------|-------------|-------------------|
| **Encapsulation** | Bundle data and methods; hide internal details | `Age` property with validation |
| **Inheritance** | Derived class inherits from base class | Extend with `class GraduateStudent : Student` |
| **Polymorphism** | Same interface, different implementations | `IStudentService` → `StudentService` |
| **Abstraction** | Expose only what is necessary | Interface hides implementation |

---

## Encapsulation — Fields vs Properties

```csharp
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }

    private int age;  // field — hidden from outside

    public int Age    // property — controlled access
    {
        get { return age; }
        set
        {
            if (value > 0) age = value;
            else age = 0;
        }
    }

    public void Display()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Age: {Age}");
    }
}
```

Auto-properties (`{ get; set; }`) are shorthand when you don't need custom logic.

---

## Access Modifiers

| Modifier | Visibility |
|----------|------------|
| `public` | Anywhere |
| `private` | Same class only |
| `protected` | Same class + derived classes |
| `internal` | Same assembly (project) |
| `protected internal` | Same assembly OR derived classes |
| `private protected` | Same assembly AND derived classes |

---

## Constructors

Run when an object is created. Initialize fields and properties.

```csharp
public class Student
{
    public Student() { }

    public Student(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }
}

// Usage
Student s = new Student(1, "Alice", 20);
```

Constructors can be **overloaded** — multiple constructors with different parameters.

---

## Static vs Instance Members

| Type | Belongs To | Access |
|------|------------|--------|
| **Static** | The class itself | `ClassName.Member` |
| **Instance** | A specific object | Requires `new ClassName()` |

```csharp
Console.WriteLine(Math.PI);       // static — no object needed

Student s = new Student();        // instance — needs new
s.Display();
```

---

## Interfaces

Define a **contract** — what a class must implement, not how.

```csharp
internal interface IStudentService
{
    void Add(Student student);
    void Update(int id);
    void Delete(int id);
    void viewStudents();
    Student Findstudent(int id);
}
```

---

## Service Layer Pattern

`StudentService` implements `IStudentService` and manages a `List<Student>`:

```csharp
internal class StudentService : IStudentService
{
    private List<Student> students = new List<Student>();

    public void Add(Student student) => students.Add(student);

    public Student Findstudent(int id) => students.Find(s => s.Id == id);

    public void Delete(int id)
    {
        for (int i = 0; i < students.Count; i++)
        {
            if (students[i].Id == id)
            {
                students.RemoveAt(i);
                break;
            }
        }
    }

    public void viewStudents()
    {
        foreach (var student in students)
            student.Display();
    }

    public void Update(int id)
    {
        var student = Findstudent(id);
        if (student != null)
        {
            Console.Write("Enter name:");
            student.Name = Console.ReadLine();
            Console.Write("Enter age:");
            if (int.TryParse(Console.ReadLine(), out var age))
                student.Age = age;
        }
        else
            Console.WriteLine("Student not found");
    }
}
```

---

## Student CRUD Console App

The full menu-driven app is in `OOPs/pp.cs` (commented out). It demonstrates:

- `while` loop for menu
- `switch` for options
- Console input with `Convert.ToInt32` and `Console.ReadLine()`
- CRUD operations via `StudentService`

To enable it, uncomment the code in `pp.cs` and use it as the entry point.

---

## Inheritance Example (Extension)

Not in the project yet, but a natural next step:

```csharp
public class GraduateStudent : Student
{
    public string ThesisTopic { get; set; }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Thesis: {ThesisTopic}");
    }
}
```

---

## Previous | Next

← [06 - Methods](06-methods.md) | [08 - Collections](08-collections.md) →

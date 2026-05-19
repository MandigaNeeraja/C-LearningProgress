using OOPs.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPs.Services
{
    internal interface IStudentService {
        void Add(Student student);
        void Update(int id);
        void Delete(int id);
        void viewStudents();
        Student Findstudent(int id) ;


    }


    internal class StudentService : IStudentService
    {
        private List<Student> students = new List<Student>();
        public List<Student> Students { get => students; set => students = value; }

        public void Add(Student student)
        {
            students.Add(student);
        }
        public void viewStudents()
        {
            foreach (var student in students)
            {
                student.Display();
            }
        }
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
        public Student Findstudent(int id)
        {
            return students.Find(s => s.Id == id);
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
                {
                    student.Age = age;
                    Console.WriteLine("Student updated successfully");
                }
                else
                {
                    Console.WriteLine("Invalid age entered. Update aborted.");
                }
            }
            else
            {
                Console.WriteLine("Student not found");
            }

        }
    }






    //internal class studentManager
    //{   private List<student> students = new List<student>();
    //    public void Add(student student)
    //    {
    //        students.Add(student);
    //    }
    //    public void View()
    //    {
    //        foreach (var student in students) {
    //            student.Display();

    //        }
    //    }
    //    public void Delete(int id)
    //    {
    //        for (int i = 0; i < students.Count; i++) {
    //            if (students[i].Id == id) { 
    //                 students.RemoveAt(i);
    //            } 
    //        }
    //    }
    //    public student FindStudent(int id)
    //    {
    //        return students.Find(s => s.Id == id);
    //    }


    //}
}

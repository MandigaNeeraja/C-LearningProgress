using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPs.models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private int age;
        public int Age
        {
            get { return age; }
            set { 
            if (value>0) age = value;
            else  age = 0;}
        }


        public void Display()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Age: {Age}");
        }

    }
}

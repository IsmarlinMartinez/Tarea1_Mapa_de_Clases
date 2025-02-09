using MapaDeClase_Tarea1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MapaDeClase_Tarea1
{

    //Ismarlin Martinez Mejia//
    //2024-0229//
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
    public abstract class CommunityMember : Person
    {
        public CommunityMember(int id, string name) : base(id, name) { }

        public abstract void ShowInfo();
    }
    public class Student : CommunityMember
    {
        public string Career { get; set; }

        public Student(int id, string name, string career) : base(id, name)
        {
            Career = career;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Student: {Name}, Id: {Id} Career: {Career}");
        }
    }

    public class ExStudent : CommunityMember
    {
        public string Graduation { get; set; }

        public ExStudent(int id, string name, string graduation) : base(id, name)
        {
            Graduation = graduation;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Ex Student: {Name}, Id: {Id}, Graduation Date: {Graduation}");
        }
    }

    public abstract class Employee : CommunityMember
    {
        public double Salary { get; set; }

        public Employee(int id, string name, double salary) : base(id, name)
        {
            Salary = salary;
        }
    }

    public class Administrative : Employee
    {
        public string Area { get; set; }

        public Administrative(int id, string name, string area, double salary) : base (id, name, salary)
        {
            Area = area;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Administrative: {Name}, Id: {Id}, Area: {Area}, Salary: {Salary}");
        }
    }

    public class Teacher : Employee
    {
        public string Department { get; set; }

        public Teacher(int id, string name, string department, double salary) : base (id, name, salary)
        {
            Department = department;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Teacher: {Name}, Id: {Id}, Department: {Department}, Salary: {Salary}");
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            List<CommunityMember> members = new List<CommunityMember>
                {
                    new Student(20250215, "Camilo", "Multimedia"),
                    new ExStudent(20210314, "Marcos", "02/09/2024"),
                    new Administrative(912, "Lorenzo", "Human Resources", 65000),
                    new Teacher(56020, "Carmen", "Ciencias", 25500)
                };
            foreach (var member in members) 
            {
                member.ShowInfo();
            }

            Console.ReadKey();
    }

}

}
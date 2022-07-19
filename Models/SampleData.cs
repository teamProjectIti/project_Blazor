using System.Collections.Generic;

namespace projectBlazor.Models
{
    public class SampleData
    {

        public List<Department> Departments { get; set; } = new List<Department>();
        public List<Student> Students { get; set; } = new List<Student>();

        public SampleData()
        {
            Departments.Add(new Department() { Name = "C#", ID = 1 });
            Departments.Add(new Department() { Name = "php", ID = 2 });
            Departments.Add(new Department() { Name = "html", ID = 3 });
            Departments.Add(new Department() { Name = "css", ID = 4 });
            Departments.Add(new Department() { Name = "js", ID = 5 });
            Departments.Add(new Department() { Name = "sql", ID = 6 });
            Departments.Add(new Department() { Name = "oop", ID = 7 });
            Students.Add(new Student() { ID = 1, Name = "ehab", Department_ID = 1 });
            Students.Add(new Student() { ID = 1, Name = "bassem", Department_ID = 2 });
            Students.Add(new Student() { ID = 1, Name = "amire", Department_ID = 3 });
            Students.Add(new Student() { ID = 1, Name = "samy", Department_ID = 3 });
            Students.Add(new Student() { ID = 1, Name = "mona", Department_ID = 2 });
            Students.Add(new Student() { ID = 1, Name = "saad", Department_ID = 6 });
            Students.Add(new Student() { ID = 1, Name = "bob", Department_ID = 2 });
        }

        public List<Department> GetDepartments()
        {
            return Departments;
        }
        public List<Student> GetStudents()
        {
            return Students;
        }
    }
}

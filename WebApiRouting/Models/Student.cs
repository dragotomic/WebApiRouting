using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiRouting.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<Student> Students = new List<Student>
        {
            new Student { Id = 1, Name = "Mark" },
            new Student { Id = 2, Name = "Paul" },
            new Student { Id = 3, Name = "Eva" },
        };

        public static Dictionary<int, List<string>> Courses = new Dictionary<int, List<string>>
        {
            { 1, new List<string> { "ASP.NET", "SQL Server" } },
            { 2, new List<string> { "ASP.NET MVC", "Unit Tests" } },
            { 3, new List<string> { "C#", "WCF" } },
        };
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiRouting.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<Teacher> Teachers = new List<Teacher>
        {
            new Teacher { Id = 1, Name = "Steve" },
            new Teacher { Id = 2, Name = "Pablo" },
            new Teacher { Id = 3, Name = "Gabriela" },
        };
    }
}
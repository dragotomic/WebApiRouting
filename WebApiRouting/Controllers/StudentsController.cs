using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiRouting.Models;

namespace WebApiRouting.Controllers
{
    [RoutePrefix("api/students")]
    public class StudentsController : ApiController
    {
        [Route("")]
        public IEnumerable<Student> Get()
        {
            return Student.Students;
        }

        [Route("{id:int:min(1)}")]
        public HttpResponseMessage Get(int id)
        {
            var student = Student.Students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Student not found");
            }
            return Request.CreateResponse(HttpStatusCode.Found, student);
        }

        [Route("{name}")]
        public Student Get(string name)
        {
            return Student.Students.FirstOrDefault(s => s.Name.ToLower() == name.ToLower());
        }

        [Route("{id:int:min(0)}/courses")]
        public IEnumerable<string> GetCourses(int id)
        {
            return Student.Courses.FirstOrDefault(s => s.Key == id).Value;
        }

        [Route("~/api/teachers")]
        public IHttpActionResult GetTeachers()
        {
            return Ok(Teacher.Teachers);
        }

        [Route("~/api/teachers/{id:int:min(1)}")]
        public IHttpActionResult GetTeacherById(int id)
        {
            var teacher = Teacher.Teachers.FirstOrDefault(t => t.Id == id);
            if (teacher == null)
            {
                return Content(HttpStatusCode.NotFound, "Teacher not found"); //NotFound();
            }
            return Ok(teacher);
        }
    }
}

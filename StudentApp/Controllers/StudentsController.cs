using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentApp.Models;

namespace StudentApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        Student[] students = new Student[]
        {
            new Student{ Id = 1, Name = "Saman Kumara", School = "Mahinda College", GuardianName = "Loku Samana"},
            new Student{ Id = 2, Name = "Samantha Kumara", School = "Royal College", GuardianName = "Loku Samantha"},
        };

        [HttpGet]
        public IEnumerable<Student> getAllStudents()
        { 
            return students;
        }

        [HttpGet("{id}")]
        public ActionResult<Student> GetStudentById(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null) return NotFound();
            return Ok(student);
        }

    }
}

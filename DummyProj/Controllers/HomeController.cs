using DummyProj.Models;
using DummyProj.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace DummyProj.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            StudentTchrVM vm = new StudentTchrVM();
            vm.myStudent = GetStudent();
            vm.myTeacher = GetTeacher();
            return View(vm);
        }

        private List<Student> GetStudent()
        {
            var students = new List<Student>();
            students.Add(new Student { ID=1,Name="Hamza",Class="8",FatherName="Shakoor"});
            students.Add(new Student { ID = 2, Name = "Abbas", Class = "8", FatherName = "Ali" });
            students.Add(new Student { ID = 3, Name = "Ahsan", Class = "9", FatherName = "Ghafoor" });
            students.Add(new Student { ID = 4, Name = "Raza", Class = "10", FatherName = "Butt" });
            return students;
        }

        private Teacher GetTeacher()
        {
            Teacher teacher = new Teacher();
            teacher.ID = 1;
            teacher.Name = "Hammad Maqbool";
            teacher.Qualification = "BSCS";
            teacher.Pay = 100;
            return teacher;
        }
    }
}

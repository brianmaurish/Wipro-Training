using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        public string Index()
        {
            return "This is student index";
        }
        public string GetStudentName()
        {
            return "Student name is Brian";
        }
        public string GetStudentPhone()
        {
            return "Student phone is 9345850328";
        }
    }
}

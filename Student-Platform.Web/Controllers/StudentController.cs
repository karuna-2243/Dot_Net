using Microsoft.AspNetCore.Mvc;

namespace Student_Platform.Web.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

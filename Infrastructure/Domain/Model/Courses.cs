using Microsoft.AspNetCore.Mvc;

namespace daryljohn.midterm_.Infrastructure.Domain.Model
{
    public class Courses : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using FirstMvcExample.Models;
namespace FirstMvcExample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NextPage() { 
        List <Student> list = new List<Student>
        {
            new Student()
            {
                Id = 1,
                Name = "Ram",
                Address = "USA",
                JoinDate = "2024-04-11"
            }
        };
            return View(list);  
        }
    }
}

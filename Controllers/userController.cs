using Microsoft.AspNetCore.Mvc;

namespace eproject.Controllers
{
    public class userController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult Events()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }


        //Dashboard Work
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult AddCategory() {
            
        return View();

        }


    }
}


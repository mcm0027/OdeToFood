using Microsoft.AspNet.Mvc;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            var model = new Restaurant { Id = 1, Name = "Matt's"};

            return View(model);
        }
    }
}

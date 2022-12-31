using EntityCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EntityCore.Controllers
{
    public class HomeController : Controller
    {

        private   DataContext dataContext;
        public HomeController(DataContext context)
        {
            dataContext = context;
        }
   

        public IActionResult Index()
        {
            var product = new Product("test1","text is  for  test  data base",999.9,9);
            dataContext.Add(product);
            dataContext.SaveChanges();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

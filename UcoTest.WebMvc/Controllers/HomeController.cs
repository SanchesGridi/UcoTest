using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UcoTest.WebMvc.Models;

namespace UcoTest.WebMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<SomeTestClass> Items = new List<SomeTestClass>();
            Items.Add(new SomeTestClass() { ID = 1, Title = "Title 1", Data1 = "Data1 1", Data2 = "Data2 1", Data3 = "Data3 1", Data4 = "Data4 1", OtherTypeValue = new SomeTestClass.OtherType() { ID = 1, Title = "Ot1" } });
            Items.Add(new SomeTestClass() { ID = 2, Title = "Title 2", Data1 = "Data1 2", Data2 = "Data2 2", Data3 = "Data3 2", Data4 = "Data4 2", OtherTypeValue = new SomeTestClass.OtherType() { ID = 2, Title = "Ot2" } });
            Items.Add(new SomeTestClass() { ID = 3, Title = "Title 3", Data1 = "Data1 3", Data2 = "Data2 3", Data3 = "Data3 3", Data4 = "Data4 3", OtherTypeValue = new SomeTestClass.OtherType() { ID = 3, Title = "Ot3" } });
            Items.Add(new SomeTestClass() { ID = 4, Title = "Title 4", Data1 = "Data1 4", Data2 = "Data2 4", Data3 = "Data3 4", Data4 = "Data4 4", OtherTypeValue = new SomeTestClass.OtherType() { ID = 4, Title = "Ot4" } });
            Items.Add(new SomeTestClass() { ID = 5, Title = "Title 5", Data1 = "Data1 5", Data2 = "Data2 5", Data3 = "Data3 5", Data4 = "Data4 5", OtherTypeValue = new SomeTestClass.OtherType() { ID = 5, Title = "Ot5" } });

            return View(Items.Where(x => x.ID == 2 || x.ID == 3).ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

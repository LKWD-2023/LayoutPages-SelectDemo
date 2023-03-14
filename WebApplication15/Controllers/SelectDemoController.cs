using Microsoft.AspNetCore.Mvc;
using WebApplication15.Models;

namespace WebApplication15.Controllers
{
    public class SelectDemoController : Controller
    {
        private List<ColorOption> _colorOptions = new List<ColorOption>
        {
            new ColorOption{Id = 1, Color = "Red"},
            new ColorOption{Id = 2, Color = "Orange"},
            new ColorOption{Id = 3, Color = "Green"},
            new ColorOption{Id = 4, Color = "Blue"},
            new ColorOption{Id = 5, Color = "Shiney Yellow"},
            new ColorOption{Id = 6, Color = "Purple Too"}
        };

        public IActionResult Index()
        {
            ShowSelectViewModel vm = new ShowSelectViewModel
            {
                ColorOptions = _colorOptions
            };
            return View(vm);
        }

        [HttpPost]
        public IActionResult Post(int id)
        {
            SelectPostViewModel vm = new SelectPostViewModel
            {
                Color = _colorOptions.FirstOrDefault(c => c.Id == id).Color
            };
            return View(vm);
        }

        public IActionResult Employees()
        {
            string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=Northwnd; Integrated Security=true;";
            var db = new NorthwindDb(connectionString);
            return View(db.GetAll());
        }
    }
}

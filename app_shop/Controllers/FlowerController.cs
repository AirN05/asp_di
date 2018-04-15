using app_shop.Models;
using Microsoft.AspNetCore.Mvc;

namespace app_shop.Controllers
{
    public class FlowerController : Controller
    {
       
        // GET
        [ResponseCache(Duration = 30)]
        public IActionResult Index(int id)
        {
            var flower = FlowerDB.GetById(id);
            ViewBag.FlowerId = id;
            return View(flower);
        }
    }
}
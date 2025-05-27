using Microsoft.AspNetCore.Mvc;
using MVC_NAV.Data;
using MVC_NAV.Models;

namespace MVC_NAV.Controllers
{
    [Route("ponozky")]
    [Route("socks")]
    public class SocksController : Controller
    {
       
        public IActionResult Index()
        {
            var data = SocksDataset.GetSocks();
            return View(data);
        }

        [Route("[action]/{id}")]
        public IActionResult GetById(int id)
        {
            var data = SocksDataset.GetSocks().Where(s => s.Id == id).FirstOrDefault();
            return View(data);
        }

        [Route("[action]/min/{minPrice:int}/max/{maxPrice:int}")]
        public IActionResult SearchByPrice(int minPrice, int maxPrice)
        {           
            var data = SocksDataset.GetSocks().Where(s => s.Price >= minPrice && s.Price<=maxPrice);
            return View("Index", data);
        }


    }
}

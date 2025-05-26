using Microsoft.AspNetCore.Mvc;
using MVC_NAV.Data;

namespace MVC_NAV.Controllers
{
    public class SocksController : Controller
    {
        public IActionResult Index()
        {
            var data = SocksDataset.GetSocks();
            return View(data);
        }
    }
}

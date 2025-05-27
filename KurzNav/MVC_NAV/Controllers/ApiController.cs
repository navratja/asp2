using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_NAV.Data;
using MVC_NAV.Models;

namespace MVC_NAV.Controllers
{
    //[Route("[controller]")]
    //[ApiController]
    public class ApiController : ControllerBase
    {
        
        public Socks GetById (int id)
        {
            var data = SocksDataset.GetSocks().Where(s => s.Id == id).FirstOrDefault();
            return data;
        }
    }
}

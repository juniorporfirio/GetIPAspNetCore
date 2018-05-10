using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GetIPAspNetCore.Models;
using Microsoft.AspNetCore.Http;

namespace GetIPAspNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHttpContextAccessor contexto;

        public HomeController(IHttpContextAccessor contexto)
        {
            this.contexto = contexto;
        }
        public IActionResult Index()
        {
            var ip = this.contexto.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.IP = ip;

            return View();
        }

        public IActionResult About([FromServices]IHttpContextAccessor context)
        {
            var ip = context.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.IP = ip;

            return View();
        }

        public IActionResult Contact()
        {
           

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

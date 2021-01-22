using System.Runtime.InteropServices;
using System;
using Backend.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Backend.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeServices _service;
        public HomeController(IHomeServices service)
        {
            this._service = service;
        }
        public async Task<ActionResult> Index()
        {
            ViewBag.ListXp = await _service.ListXp();
            return View();
        }
       
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FrontEnd.Models;
using Microsoft.Extensions.Configuration;
using System.Net.Http;

namespace FrontEnd.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        //private IConfiguration Configuration;

        //public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        //{
        //    _logger = logger;
        //    Configuration = configuration;
        //}

        public async Task<IActionResult> Index()
        {
            var mergedService = "https://localhost:44381/merge";
            var serviceThreeResponseCall = await new HttpClient().GetStringAsync(mergedService);
            ViewBag.responseCall = serviceThreeResponseCall;
            return View();
        }
    }
}

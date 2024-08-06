using EventSourcing.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EventSourcing.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        List<DiaryItemModel> diaryItemModels;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            diaryItemModels = new List<DiaryItemModel>
            {
                new()
                {
                    Title = "Title 1",
                    From = new DateTime(2008,12,30)
                },
                 new()
                {
                    Title = "Title 2",
                    From = new DateTime(2018,12,30)
                }
            };
        }

        public IActionResult Index()
        {
            return View(diaryItemModels);
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

/*
 * Resources used for this project:
 * 1) https://www.codeproject.com/Articles/555855/Introduction-to-CQRS
 * 2) https://www.codeproject.com/Articles/1212100/Simple-Event-Sourcing-Demo-in-Csharp
 * 3) https://www.codeproject.com/Articles/5264244/A-Fast-and-Lightweight-Solution-for-CQRS-and-Event
 */ 
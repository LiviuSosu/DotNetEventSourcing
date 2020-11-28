using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventSourcing.CQRS.Commands;
using EventSourcing.CQRS.Reporting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetEventSourcing.Configuration;

namespace NetEventSourcing.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {    
            _logger = logger;
        }

        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        [HttpGet]
        public ActionResult Index()
        {
            return Ok(ServiceLocator.ReportDatabase.GetItems());
        }

        [HttpPost]
        public ActionResult Add(DiaryItemDto item)
        {
            ServiceLocator.CommandBus.Send(new CreateItemCommand(Guid.NewGuid(), item.Title, item.Description, -1, item.From, item.To));
            return Ok();
        }

        [HttpPost]
        [Route("/Edit")]
        public ActionResult Edit(DiaryItemDto item)
        {
            ServiceLocator.CommandBus.Send(new ChangeItemCommand(item.Id, item.Title, item.Description, item.From, item.To, item.Version));
            return Ok();
        }

        //[HttpDelete]
        //public ActionResult Delete(Guid id)
        //{
        //    var item = ServiceLocator.ReportDatabase.GetById(id);
        //    ServiceLocator.CommandBus.Send(new DeleteItemCommand(item.Id, item.Version));
        //    return Ok();
        //}
    }
}

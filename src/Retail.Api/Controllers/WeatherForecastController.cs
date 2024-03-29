//using Microsoft.AspNetCore.Mvc;
//using Retail.Domain;

//namespace RentalApi.Controllers
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class WeatherForecastController : ControllerBase
//    {
//        private static readonly string[] Summaries = new[]
//        {
//        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
//    };

//        private readonly IApiConfig _apiConfig;
//        private readonly IService _service;
//        private readonly ILogger _logger;

//        public WeatherForecastController(IApiConfig apiConfig, IService service, ILogger logger)
//        {
//            _apiConfig = apiConfig;
//            _service = service;
//            _logger = logger;
//        }

//        //private readonly ILogger<WeatherForecastController> _logger;

//        //public WeatherForecastController(ILogger<WeatherForecastController> logger, IApiConfig apiConfig)
//        //{
//        //    _logger = logger;
//        //    _apiConfig = apiConfig;
//        //}

//        //[HttpGet(Name = "GetWeatherForecast")]
//        //public IEnumerable<WeatherForecast> Get()
//        //{
//        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
//        //    {
//        //        Date = DateTime.Now.AddDays(index),
//        //        TemperatureC = Random.Shared.Next(-20, 55),
//        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
//        //    })
//        //    .ToArray();
//        //}

//        //[HttpGet]
//        //[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
//        //public async Task<IActionResult> GetConfigName()
//        //{
//        //    return Ok(_apiConfig.Name);
//        //}

//        [HttpGet]
//        [Route("GetConfigName")]
//        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
//        public string GetConfigName()
//        {
//            _logger.LogInformation("Getting Config Name");
//            return _apiConfig.Name;
//        }

//        [HttpGet]
//        [Route("GetConfigConnectionString")]
//        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
//        public string GetConfigConnectionString()
//        {
//            _logger.LogInformation("Getting Connection String");
//            return _apiConfig.ConnectionString;
//        }

//        [HttpGet]
//        [Route("DoWork")]
//        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
//        public bool DoWork([FromQuery] int number)
//        {
//            _logger.LogInformation("Doing Work");
//            return _service.DoWork(number);
//        }
//    }
//}
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace IOptionsWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TesteController : ControllerBase
    {
        private readonly ILogger<TesteController> _logger;
        private readonly ConfigTeste _config;

        public TesteController(
            ILogger<TesteController> logger, 
            IOptions<ConfigTeste> options)
        {
            _logger = logger;
            _config = options.Value;
        }

        [HttpGet]
        public IActionResult GetConfig()
        {
            return Ok(new
            {
                ApiUrl = _config.ApiUrl,
                TimeoutSegundos = _config.TimeoutSegundos
            });
        }
    }
}

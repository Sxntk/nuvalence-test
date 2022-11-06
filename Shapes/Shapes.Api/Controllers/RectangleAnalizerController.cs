using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Shapes.Model;

namespace Shapes.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RectangleAnalizerController : ControllerBase
    {

        private readonly ILogger<RectangleAnalizerController> _logger;

        public RectangleAnalizerController(ILogger<RectangleAnalizerController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "GetRectangleProperties")]
        public async Task<IActionResult> Post([FromBody] RectangleRequest inputRequest)
        {

            return Ok(inputRequest.Name);
        }
    }

    public class RectangleRequest
    {
        public Rectangle? Rectangle1 { get; set; }

        public Rectangle? Rectangle2 { get; set; }
        public string Name { get; set; }
    }
}
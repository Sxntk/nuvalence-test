using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Shapes.Model;
using Shapes.Services;

namespace Shapes.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RectangleAnalizerController : ControllerBase
    {

        private readonly ContainmentService _containmentService;

        private readonly AdjacencyService _adjacencyService;

        public RectangleAnalizerController(ContainmentService containmentService, AdjacencyService adjacencyService)
        {
            _containmentService = containmentService;
            _adjacencyService = adjacencyService;
        }

        [HttpPost(Name = "GetRectangleProperties")]
        [EnableCors("AllowAll")]
        public async Task<IActionResult> Post([FromBody] RectangleRequest inputRequest)
        {
            if (inputRequest is null || inputRequest.Rectangle1 is null || inputRequest.Rectangle2 is null)
            {
                return BadRequest($"Input cannot be null. Input: {inputRequest}, Rectangle1: {inputRequest?.Rectangle1} Rectangle2: {inputRequest?.Rectangle2}");
            }

            RectangleResponse response = new();
            response.IsContained = _containmentService.IsContained(inputRequest.Rectangle1, inputRequest.Rectangle2);
            response.AdjacencyType = _adjacencyService.IsAdjacent(inputRequest.Rectangle1, inputRequest.Rectangle2).AdjacencyType.ToString();

            return Ok(response);
        }
    }

    public class RectangleRequest
    {
        public Rectangle Rectangle1 { get; set; }

        public Rectangle Rectangle2 { get; set; }
    }

    public class RectangleResponse
    {
        public bool IsContained { get; set; }

        public string AdjacencyType { get; set; }
    }
}
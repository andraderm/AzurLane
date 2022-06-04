using AzurLaneApi.Application.Dtos.Ship;
using AzurLaneApi.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AzurLaneApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShipController : ControllerBase
    {
        private readonly IShipApplicationService _shipApplicationService;

        public ShipController(IShipApplicationService shipApplicationService)
        {
            _shipApplicationService = shipApplicationService;
        }

        [HttpGet]
        [Route("")]
        [Produces("application/json")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _shipApplicationService.GetAll();
            return Ok(result);
        }

        [HttpPost]
        [Route("")]
        [Produces("application/json")]
        public async Task<IActionResult> Insert([FromBody] CreateShipDto model)
        {
            await _shipApplicationService.Insert(model);
            return Ok();
        }

        [HttpPut]
        [Route("image")]
        [Produces("application/json")]
        public async Task<IActionResult> InsertImage([FromQuery] string id, [FromForm] IFormFile image)
        {
            await _shipApplicationService.InsertImage(id, image);
            return Ok();
        }
    }
}

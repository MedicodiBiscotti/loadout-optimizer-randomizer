using LoadoutOptimizerRandomizer.Core.Redout.Services;
using LoadoutOptimizerRandomizer.Model.Redout.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LoadoutOptimizerRandomizer.API.Redout.Controllers;

[Route("api/redout/[controller]")]
[ApiController]
public class ShipComponentController : ControllerBase
{
    private readonly IShipComponentService _shipComponentService;

    public ShipComponentController(IShipComponentService shipComponentService)
    {
        _shipComponentService = shipComponentService;
    }

    [HttpGet]
    public async Task<ActionResult<List<ShipComponent>>> GetShipComponentsAsync()
    {
        var shipComponents = await _shipComponentService.GetShipComponentsAsync();
        return Ok(shipComponents);
    }
}
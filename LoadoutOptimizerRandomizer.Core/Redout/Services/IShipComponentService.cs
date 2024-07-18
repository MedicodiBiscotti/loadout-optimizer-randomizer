using LoadoutOptimizerRandomizer.Model.Redout.Dtos;

namespace LoadoutOptimizerRandomizer.Core.Redout.Services;

public interface IShipComponentService
{
    Task<List<ShipComponentDto>> GetShipComponentsAsync();
}
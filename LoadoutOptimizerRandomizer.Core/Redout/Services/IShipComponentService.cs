using LoadoutOptimizerRandomizer.Model.Redout.Entities;

namespace LoadoutOptimizerRandomizer.Core.Redout.Services;

public interface IShipComponentService
{
    Task<List<ShipComponent>> GetShipComponentsAsync();
}
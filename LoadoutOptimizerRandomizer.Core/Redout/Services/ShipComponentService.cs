using LoadoutOptimizerRandomizer.Model.Redout.Entities;
using LoadoutOptimizerRandomizer.Repository.Redout.Repositories;

namespace LoadoutOptimizerRandomizer.Core.Redout.Services;

public class ShipComponentService : IShipComponentService
{
    private readonly IComponentRepository _componentRepository;

    public ShipComponentService(IComponentRepository componentRepository)
    {
        _componentRepository = componentRepository;
    }

    public async Task<List<ShipComponent>> GetShipComponentsAsync()
    {
        return await _componentRepository.GetAllAsync();
    }
}
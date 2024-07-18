using LoadoutOptimizerRandomizer.Model.Redout.Entities;
using LoadoutOptimizerRandomizer.Model.Redout.Enums;
using LoadoutOptimizerRandomizer.Repository.Redout.Data;

namespace LoadoutOptimizerRandomizer.Repository.Redout.Repositories;

public class InMemoryComponentRepository : IComponentRepository
{
    private readonly Dictionary<string, ShipComponent> _components = ComponentData.Components;

    public Task<List<ShipComponent>> GetAllAsync()
    {
        return Task.FromResult(_components.Values.ToList());
    }

    public Task<List<ShipComponent>> GetByTypeAsync(ComponentType type)
    {
        return Task.FromResult(_components.Values.Where(c => c.Type == type).ToList());
    }

    public Task<List<ShipComponent>> GetByClassAsync(ComponentClass @class)
    {
        return Task.FromResult(_components.Values.Where(c => c.Class == @class).ToList());
    }

    public Task<ShipComponent?> GetByShortNameAsync(string shortName)
    {
        return Task.FromResult(_components.Values.FirstOrDefault(c => c.ShortName == shortName));
    }
}
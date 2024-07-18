using LoadoutOptimizerRandomizer.Model.Redout.Entities;
using LoadoutOptimizerRandomizer.Model.Redout.Enums;

namespace LoadoutOptimizerRandomizer.Repository.Redout.Repositories;

public interface IComponentRepository
{
    Task<List<ShipComponent>> GetAllAsync();
    Task<List<ShipComponent>> GetByTypeAsync(ComponentType type);
    Task<List<ShipComponent>> GetByClassAsync(ComponentClass @class);
    Task<ShipComponent?> GetByShortNameAsync(string shortName);
}
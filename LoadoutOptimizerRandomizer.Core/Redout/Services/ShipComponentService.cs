using AutoMapper;
using LoadoutOptimizerRandomizer.Model.Redout.Dtos;
using LoadoutOptimizerRandomizer.Repository.Redout.Repositories;

namespace LoadoutOptimizerRandomizer.Core.Redout.Services;

public class ShipComponentService : IShipComponentService
{
    private readonly IComponentRepository _componentRepository;
    private readonly IMapper _mapper;

    public ShipComponentService(IComponentRepository componentRepository, IMapper mapper)
    {
        _componentRepository = componentRepository;
        _mapper = mapper;
    }

    public async Task<List<ShipComponentDto>> GetShipComponentsAsync()
    {
        var entities = await _componentRepository.GetAllAsync();
        return _mapper.Map<List<ShipComponentDto>>(entities);
    }
}
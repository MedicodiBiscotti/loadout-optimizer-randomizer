using AutoMapper;
using LoadoutOptimizerRandomizer.Model.Redout.Dtos;
using LoadoutOptimizerRandomizer.Model.Redout.Entities;

namespace LoadoutOptimizerRandomizer.Model.Redout.Mapping;

public class EntityDtoProfile : Profile
{
    public EntityDtoProfile()
    {
        CreateMap<ShipComponent, ShipComponentDto>();
    }
}
using LoadoutOptimizerRandomizer.Model.Redout.Enums;

namespace LoadoutOptimizerRandomizer.Model.Redout.Dtos;

public record ShipComponentDto(
    ComponentType Type,
    string Name,
    string ShortName,
    ComponentClass Class,
    int Power,
    Dictionary<Stat, int> Stats);
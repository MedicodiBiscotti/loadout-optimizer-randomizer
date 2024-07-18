using System.Collections;
using LoadoutOptimizerRandomizer.Model.Redout.Enums;

namespace LoadoutOptimizerRandomizer.Model.Redout.Entities;

public class ShipComponent
{
    public ComponentType Type { get; set; }
    public string Name { get; set; }
    public string ShortName { get; set; }
    public Dictionary<Stat, int> Stats { get; set; }
    public ComponentClass Class { get; set; }

    public ShipComponent(ComponentType type, string name, string shortName, Dictionary<Stat, int> stats, ComponentClass @class)
    {
        Type = type;
        Name = name;
        ShortName = shortName;
        Stats = stats;
        Class = @class;
    }
}
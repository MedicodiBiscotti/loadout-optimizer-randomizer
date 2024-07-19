using LoadoutOptimizerRandomizer.Model.Redout.Enums;

namespace LoadoutOptimizerRandomizer.Model.Redout.Entities;

public class ShipComponent
{
    public ShipComponent(ComponentType type, string name, string shortName, ComponentClass @class, int power,
        Dictionary<Stat, int> stats)
    {
        Type = type;
        Name = name;
        ShortName = shortName;
        Class = @class;
        Power = power;
        Stats = stats;
    }

    public ComponentType Type { get; set; }
    public string Name { get; set; }
    public string ShortName { get; set; }
    public ComponentClass Class { get; set; }
    public int Power { get; set; }
    public Dictionary<Stat, int> Stats { get; set; }
}
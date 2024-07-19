using LoadoutOptimizerRandomizer.Model.Redout.Entities;
using LoadoutOptimizerRandomizer.Model.Redout.Enums;

namespace LoadoutOptimizerRandomizer.Repository.Redout.Data;

public static class ComponentData
{
    public static readonly Dictionary<string, ShipComponent> Components = new()
    {
        {
            "ESA", new ShipComponent(ComponentType.Ship, "ESA-AGR", "ESA", ComponentClass.None, 185,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 4 },
                    { Stat.Thrust, 4 },
                    { Stat.Durability, 4 },
                    { Stat.Strafe, 4 },
                    { Stat.Steering, 4 },
                    { Stat.Stability, 4 }
                })
        }
    };
}
using LoadoutOptimizerRandomizer.Model.Redout.Entities;
using LoadoutOptimizerRandomizer.Model.Redout.Enums;

namespace LoadoutOptimizerRandomizer.Repository.Redout.Data;

public static class ComponentData
{
    // Short name used as key/index
    public static readonly Dictionary<string, ShipComponent> Components = new()
    {
        // Ships. Power rating can be cheesed to 184 for all using loadout bug.
        {
            "LUN", new ShipComponent(ComponentType.Ship, "Lunare", "LUN", ComponentClass.None, 184,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 5 },
                    { Stat.Thrust, 3 },
                    { Stat.Durability, 2 },
                    { Stat.Strafe, 3 },
                    { Stat.Steering, 8 },
                    { Stat.Stability, 3 }
                })
        },
        {
            "CNQ", new ShipComponent(ComponentType.Ship, "Conqueror", "CNQ", ComponentClass.None, 184,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 7 },
                    { Stat.Thrust, 3 },
                    { Stat.Durability, 4 },
                    { Stat.Strafe, 7 },
                    { Stat.Steering, 0 },
                    { Stat.Stability, 1 }
                })
        },
        {
            "HEL", new ShipComponent(ComponentType.Ship, "Helix", "HEL", ComponentClass.None, 184,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 5 },
                    { Stat.Thrust, 5 },
                    { Stat.Durability, 3 },
                    { Stat.Strafe, 2 },
                    { Stat.Steering, 3 },
                    { Stat.Stability, 4 }
                })
        },
        {
            "ASE", new ShipComponent(ComponentType.Ship, "Asera", "ASE", ComponentClass.None, 184,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 2 },
                    { Stat.Thrust, 8 },
                    { Stat.Durability, 5 },
                    { Stat.Strafe, 4 },
                    { Stat.Steering, 1 },
                    { Stat.Stability, 3 }
                })
        },
        {
            "ESA", new ShipComponent(ComponentType.Ship, "ESA-AGR", "ESA", ComponentClass.None, 184,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 4 },
                    { Stat.Thrust, 4 },
                    { Stat.Durability, 4 },
                    { Stat.Strafe, 4 },
                    { Stat.Steering, 4 },
                    { Stat.Stability, 4 }
                })
        },
        {
            "WRG", new ShipComponent(ComponentType.Ship, "WALLACE-RG", "WRG", ComponentClass.None, 184,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 4 },
                    { Stat.Thrust, 2 },
                    { Stat.Durability, 4 },
                    { Stat.Strafe, 3 },
                    { Stat.Steering, 8 },
                    { Stat.Stability, 4 }
                })
        },
        {
            "SUL", new ShipComponent(ComponentType.Ship, "Sulha", "SUL", ComponentClass.None, 184,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 8 },
                    { Stat.Thrust, 6 },
                    { Stat.Durability, 1 },
                    { Stat.Strafe, 2 },
                    { Stat.Steering, 1 },
                    { Stat.Stability, 1 }
                })
        },
        {
            "MAN", new ShipComponent(ComponentType.Ship, "Mantis", "MAN", ComponentClass.None, 184,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 4 },
                    { Stat.Thrust, 7 },
                    { Stat.Durability, 2 },
                    { Stat.Strafe, 2 },
                    { Stat.Steering, 4 },
                    { Stat.Stability, 3 }
                })
        },
        {
            "AKT", new ShipComponent(ComponentType.Ship, "AKHAL-Tech", "AKT", ComponentClass.None, 184,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 8 },
                    { Stat.Thrust, 2 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 2 },
                    { Stat.Steering, 3 },
                    { Stat.Stability, 8 }
                })
        },
        {
            "KGW", new ShipComponent(ComponentType.Ship, "Koeniggswerth", "KGW", ComponentClass.None, 184,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 2 },
                    { Stat.Thrust, 2 },
                    { Stat.Durability, 6 },
                    { Stat.Strafe, 6 },
                    { Stat.Steering, 4 },
                    { Stat.Stability, 8 }
                })
        },
        {
            "BEH", new ShipComponent(ComponentType.Ship, "Behemoth", "BEH", ComponentClass.None, 186,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 3 },
                    { Stat.Thrust, 4 },
                    { Stat.Durability, 8 },
                    { Stat.Strafe, 7 },
                    { Stat.Steering, 1 },
                    { Stat.Stability, 1 }
                })
        },
        {
            "BRN", new ShipComponent(ComponentType.Ship, "BURAN", "BRN", ComponentClass.None, 185,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 2 },
                    { Stat.Thrust, 6 },
                    { Stat.Durability, 8 },
                    { Stat.Strafe, 3 },
                    { Stat.Steering, 2 },
                    { Stat.Stability, 2 }
                })
        },

        // Propulsors
        {
            "OCT", new ShipComponent(ComponentType.Propulsor, "BASE", "OCT", ComponentClass.White, 0,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 0 },
                    { Stat.Stability, 0 }
                })
        },
        
        // Stabilizers
        {
            "MGA", new ShipComponent(ComponentType.Stabilizer, "BASE", "MGA", ComponentClass.White, 0,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 0 },
                    { Stat.Stability, 0 }
                })
        },
        
        // Rudders
        {
            "OKS", new ShipComponent(ComponentType.Rudder, "BASE", "OKS", ComponentClass.White, 0,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 0 },
                    { Stat.Stability, 0 }
                })
        },
        
        // Hulls
        {
            "QIQ", new ShipComponent(ComponentType.Hull, "BASE", "QIQ", ComponentClass.White, 0,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 0 },
                    { Stat.Stability, 0 }
                })
        },
        
        // Intercoolers
        {
            "TLC", new ShipComponent(ComponentType.Intercooler, "BASE", "TLC", ComponentClass.White, 0,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 0 },
                    { Stat.Stability, 0 }
                })
        },
        
        // Electronic Stability Controls
        {
            "NBL", new ShipComponent(ComponentType.ElectronicStabilityControl, "BASE", "NBL", ComponentClass.White, 0,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 0 },
                    { Stat.Stability, 0 }
                })
        }
    };
}
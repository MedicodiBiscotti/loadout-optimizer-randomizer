using LoadoutOptimizerRandomizer.Model.Redout.Entities;
using LoadoutOptimizerRandomizer.Model.Redout.Enums;

namespace LoadoutOptimizerRandomizer.Repository.Redout.Data;

public static class ComponentData
{
    // Short name used as key/index
    public static readonly Dictionary<string, ShipComponent> Components = new()
    {
        // Ships.
		// Power rating can be cheesed to be the same for all ships using loadout bug.
		// TODO: Add setting to set all ships to a specific power to accommodate this cheat.
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
            "CNQ", new ShipComponent(ComponentType.Ship, "Conqueror", "CNQ", ComponentClass.None, 186,
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
            "HEL", new ShipComponent(ComponentType.Ship, "Helix", "HEL", ComponentClass.None, 182,
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
            "ASE", new ShipComponent(ComponentType.Ship, "Asera", "ASE", ComponentClass.None, 185,
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
            "WRG", new ShipComponent(ComponentType.Ship, "WALLACE-RG", "WRG", ComponentClass.None, 183,
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
            "SUL", new ShipComponent(ComponentType.Ship, "Sulha", "SUL", ComponentClass.None, 185,
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
            "MAN", new ShipComponent(ComponentType.Ship, "Mantis", "MAN", ComponentClass.None, 183,
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
            "KGW", new ShipComponent(ComponentType.Ship, "Koeniggswerth", "KGW", ComponentClass.None, 186,
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
        {
            "8-TA", new ShipComponent(ComponentType.Propulsor, "8-TA", "8-TA", ComponentClass.Green, 24,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 2 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 0 },
                    { Stat.Stability, 0 }
                })
        },
        {
            "IDV1", new ShipComponent(ComponentType.Propulsor, "Draper v1", "IDV1", ComponentClass.Green, 48,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 4 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 0 },
                    { Stat.Stability, 0 }
                })
        },
        {
            "F460", new ShipComponent(ComponentType.Propulsor, "F460", "F460", ComponentClass.Green, 66,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 3 },
                    { Stat.Thrust, 3 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 0 },
                    { Stat.Stability, 0 }
                })
        },
        {
            "8-TE", new ShipComponent(ComponentType.Propulsor, "8-TE", "8-TE", ComponentClass.Yellow, 102,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 6 },
                    { Stat.Thrust, 3 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 0 },
                    { Stat.Stability, 0 }
                })
        },
        {
            "IBV1", new ShipComponent(ComponentType.Propulsor, "Breda v1", "IBV1", ComponentClass.Yellow, 106,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 8 },
                    { Stat.Thrust, 1 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 0 },
                    { Stat.Stability, 0 }
                })
        },
        {
            "IDV2", new ShipComponent(ComponentType.Propulsor, "Draper v2", "IDV2", ComponentClass.Yellow, 144,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 12 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 0 },
                    { Stat.Stability, 0 }
                })
        },
        {
            "F570", new ShipComponent(ComponentType.Propulsor, "F570", "F570", ComponentClass.Yellow, 148,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 9 },
                    { Stat.Thrust, 4 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 0 },
                    { Stat.Stability, 0 }
                })
        },
        {
            "8-TI", new ShipComponent(ComponentType.Propulsor, "8-TI", "8-TI", ComponentClass.Pink, 228,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 14 },
                    { Stat.Thrust, 6 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 0 },
                    { Stat.Stability, 0 }
                })
        },
        {
            "IBV2", new ShipComponent(ComponentType.Propulsor, "Breda v2", "IBV2", ComponentClass.Pink, 226,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 18 },
                    { Stat.Thrust, 1 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 0 },
                    { Stat.Stability, 0 }
                })
        },
        {
            "F690", new ShipComponent(ComponentType.Propulsor, "F690", "F690", ComponentClass.Pink, 224,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 12 },
                    { Stat.Thrust, 8 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 0 },
                    { Stat.Stability, 0 }
                })
        },
        {
            "PSSU", new ShipComponent(ComponentType.Propulsor, "Signature Sulha", "PSSU", ComponentClass.Purple, 237,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 20 },
                    { Stat.Thrust, 5 },
                    { Stat.Durability, -6 },
                    { Stat.Strafe, -1 },
                    { Stat.Steering, 0 },
                    { Stat.Stability, 0 }
                })
        },
        {
            "PSBU", new ShipComponent(ComponentType.Propulsor, "Signature Mantis", "PSBU", ComponentClass.Purple, 237,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 14 },
                    { Stat.Thrust, 10 },
                    { Stat.Durability, -1 },
                    { Stat.Strafe, -7 },
                    { Stat.Steering, 0 },
                    { Stat.Stability, 0 }
                })
        },
        {
            "PSLN", new ShipComponent(ComponentType.Propulsor, "Signature Lunare", "PSLN", ComponentClass.Purple, 238,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 22 },
                    { Stat.Thrust, 8 },
                    { Stat.Durability, -5 },
                    { Stat.Strafe, -6 },
                    { Stat.Steering, 0 },
                    { Stat.Stability, 0 }
                })
        },
        {
            "PSCO", new ShipComponent(ComponentType.Propulsor, "Signature Conqueror", "PSCO", ComponentClass.Purple, 237,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 22 },
                    { Stat.Thrust, 2 },
                    { Stat.Durability, -4 },
                    { Stat.Strafe, -3 },
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
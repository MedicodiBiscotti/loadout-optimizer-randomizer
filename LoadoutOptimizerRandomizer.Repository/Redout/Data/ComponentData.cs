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
        {
            "AL55", new ShipComponent(ComponentType.Stabilizer, "Alfa55", "AL55", ComponentClass.Green, 10,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 0 },
                    { Stat.Stability, 2 }
                })
        },
        {
            "BE55", new ShipComponent(ComponentType.Stabilizer, "Beta55", "BE55", ComponentClass.Green, 20,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 0 },
                    { Stat.Stability, 4 }
                })
        },
        {
            "ALTO", new ShipComponent(ComponentType.Stabilizer, "Alto", "ALTO", ComponentClass.Green, 22,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 2 },
                    { Stat.Stability, 2 }
                })
        },
        {
            "RIGL", new ShipComponent(ComponentType.Stabilizer, "Rigel", "RIGL", ComponentClass.Green, 32,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 2 },
                    { Stat.Stability, 4 }
                })
        },
        {
            "CIRR", new ShipComponent(ComponentType.Stabilizer, "Cirrus", "CIRR", ComponentClass.Yellow, 54,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 4 },
                    { Stat.Stability, 6 }
                })
        },
        {
            "BLLX", new ShipComponent(ComponentType.Stabilizer, "Bellatrix", "BLLX", ComponentClass.Yellow, 52,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 2 },
                    { Stat.Stability, 8 }
                })
        },
        {
            "GA60", new ShipComponent(ComponentType.Stabilizer, "Gamma60", "GA60", ComponentClass.Yellow, 60,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 0 },
                    { Stat.Stability, 12 }
                })
        },
        {
            "MTKA", new ShipComponent(ComponentType.Stabilizer, "Mintaka", "MTKA", ComponentClass.Yellow, 62,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 2 },
                    { Stat.Stability, 10 }
                })
        },
        {
            "CUMU", new ShipComponent(ComponentType.Stabilizer, "Cumulus", "CUMU", ComponentClass.Yellow, 66,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 6 },
                    { Stat.Stability, 6 }
                })
        },
        {
            "STRM", new ShipComponent(ComponentType.Stabilizer, "Storm", "STRM", ComponentClass.Pink, 110,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 10 },
                    { Stat.Stability, 10 }
                })
        },
        {
            "BTLG", new ShipComponent(ComponentType.Stabilizer, "Betelgeuse", "BTLG", ComponentClass.Pink, 106,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 6 },
                    { Stat.Stability, 14 }
                })
        },
        {
            "ZE70", new ShipComponent(ComponentType.Stabilizer, "Zeta70", "ZE70", ComponentClass.Pink, 102,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 2 },
                    { Stat.Stability, 18 }
                })
        },
        {
            "SSWR", new ShipComponent(ComponentType.Stabilizer, "Signature Wallace", "SSWR", ComponentClass.Purple, 121,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, -2 },
                    { Stat.Thrust, -2 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 10 },
                    { Stat.Stability, 21 }
                })
        },
        {
            "SSHE", new ShipComponent(ComponentType.Stabilizer, "Signature Helix", "SSHE", ComponentClass.Purple, 120,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, -1 },
                    { Stat.Thrust, -1 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 7 },
                    { Stat.Stability, 20 }
                })
        },
        {
            "SSES", new ShipComponent(ComponentType.Stabilizer, "Signature ESA-AGR", "SSES", ComponentClass.Purple, 122,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, -4 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 9 },
                    { Stat.Stability, 16 }
                })
        },
        {
            "SSBR", new ShipComponent(ComponentType.Stabilizer, "Signature Buran", "SSBR", ComponentClass.Purple, 118,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, -4 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 8 },
                    { Stat.Stability, 22 }
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
        {
            "CAST", new ShipComponent(ComponentType.Rudder, "Castellanus", "CAST", ComponentClass.Green, 18,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 3 },
                    { Stat.Stability, 0 }
                })
        },
        {
            "SVTX", new ShipComponent(ComponentType.Rudder, "Svelto X", "SVTX", ComponentClass.Green, 23,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 1 },
                    { Stat.Steering, 3 },
                    { Stat.Stability, 0 }
                })
        },
        {
            "LVLK", new ShipComponent(ComponentType.Rudder, "Lovelock", "LVLK", ComponentClass.Green, 29,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 1 },
                    { Stat.Steering, 4 },
                    { Stat.Stability, 0 }
                })
        },
        {
            "STRA", new ShipComponent(ComponentType.Rudder, "Stratus", "STRA", ComponentClass.Green, 30,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 5 },
                    { Stat.Stability, 0 }
                })
        },
        {
            "SVTK", new ShipComponent(ComponentType.Rudder, "Svelto K", "SVTK", ComponentClass.Yellow, 44,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 4 },
                    { Stat.Steering, 4 },
                    { Stat.Stability, 0 }
                })
        },
        {
            "DRWN", new ShipComponent(ComponentType.Rudder, "Darwin", "DRWN", ComponentClass.Yellow, 47,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 1 },
                    { Stat.Steering, 7 },
                    { Stat.Stability, 0 }
                })
        },
        {
            "NIMB", new ShipComponent(ComponentType.Rudder, "Nimbus", "NIMB", ComponentClass.Yellow, 54,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 9 },
                    { Stat.Stability, 0 }
                })
        },
        {
            "HRPR", new ShipComponent(ComponentType.Rudder, "Harper", "HRPR", ComponentClass.Yellow, 64,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 2 },
                    { Stat.Steering, 9 },
                    { Stat.Stability, 0 }
                })
        },
        {
            "TORN", new ShipComponent(ComponentType.Rudder, "Tornado", "TORN", ComponentClass.Yellow, 65,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 1 },
                    { Stat.Steering, 10 },
                    { Stat.Stability, 0 }
                })
        },
        {
            "SVLY", new ShipComponent(ComponentType.Rudder, "Svelto Y", "SVLY", ComponentClass.Pink, 111,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 9 },
                    { Stat.Steering, 11 },
                    { Stat.Stability, 0 }
                })
        },
        {
            "TSLY", new ShipComponent(ComponentType.Rudder, "Tansley", "TSLY", ComponentClass.Pink, 109,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 5 },
                    { Stat.Steering, 14 },
                    { Stat.Stability, 0 }
                })
        },
        {
            "HURR", new ShipComponent(ComponentType.Rudder, "Hurricane", "HURR", ComponentClass.Pink, 108,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 0 },
                    { Stat.Steering, 18 },
                    { Stat.Stability, 0 }
                })
        },
        {
            "RSWR", new ShipComponent(ComponentType.Rudder, "Signature Wallace", "RSWR", ComponentClass.Purple, 119,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, -6 },
                    { Stat.Strafe, 10 },
                    { Stat.Steering, 22 },
                    { Stat.Stability, -3 }
                })
        },
        {
            "RSLU", new ShipComponent(ComponentType.Rudder, "Signature Lunare", "RSLU", ComponentClass.Purple, 119,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, -3 },
                    { Stat.Strafe, 8 },
                    { Stat.Steering, 18 },
                    { Stat.Stability, -1 }
                })
        },
        {
            "RSBE", new ShipComponent(ComponentType.Rudder, "Signature Behemoth", "RSBE", ComponentClass.Purple, 122,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, -1 },
                    { Stat.Strafe, 3 },
                    { Stat.Steering, 20 },
                    { Stat.Stability, -1 }
                })
        },
        {
            "RSES", new ShipComponent(ComponentType.Rudder, "Signature ESA-AGR", "RSES", ComponentClass.Purple, 121,
                new Dictionary<Stat, int>
                {
                    { Stat.Speed, 0 },
                    { Stat.Thrust, 0 },
                    { Stat.Durability, 0 },
                    { Stat.Strafe, 10 },
                    { Stat.Steering, 16 },
                    { Stat.Stability, -5 }
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
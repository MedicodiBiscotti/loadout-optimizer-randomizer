using System.Text.Json.Serialization;

namespace LoadoutOptimizerRandomizer.Model.Redout.Enums;

[JsonConverter(typeof(JsonStringEnumConverter<ComponentType>))]
public enum ComponentType
{
    Ship,
    Propulsor,
    Stabilizer,
    Rudder,
    Hull,
    Intercooler,
    ElectronicStabilityControl
}
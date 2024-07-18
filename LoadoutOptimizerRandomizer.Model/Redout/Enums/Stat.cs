using System.Text.Json.Serialization;

namespace LoadoutOptimizerRandomizer.Model.Redout.Enums;

[JsonConverter(typeof(JsonStringEnumConverter<Stat>))]
public enum Stat
{
    Speed,
    Thrust,
    Durability,
    Strafe,
    Steering,
    Stability
}
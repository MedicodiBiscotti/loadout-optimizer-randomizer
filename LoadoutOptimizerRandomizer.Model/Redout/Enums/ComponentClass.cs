using System.Text.Json.Serialization;

namespace LoadoutOptimizerRandomizer.Model.Redout.Enums;

[JsonConverter(typeof(JsonStringEnumConverter<ComponentClass>))]
public enum ComponentClass
{
    None,
    White,
    Green,
    Yellow,
    Pink,
    Purple
}
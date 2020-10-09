using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace calculator
{
    [JsonConverter(typeof(StringEnumConverter))]    
    public enum CalculatorResult
    {
        [EnumMember(Value = "M")]
        M,
        [EnumMember(Value = "P")]
        P,
        [EnumMember(Value = "T")]
        T,
        [EnumMember(Value = "Error")]
        Error
    }

    public interface ICalculator
    {
        CalculatorResult Get_H(bool a, bool b, bool c);
        float Get_K(CalculatorResult h, float d, int e, int f);
    }
}

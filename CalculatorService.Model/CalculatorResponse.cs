using CalculatorService.Model.Interfaces;
using System.Runtime.Serialization;

namespace CalculatorService.Model
{
    [DataContract]
    public class CalculatorResponse : ICalulatorResponse
    {
        [DataMember]
        public string TextExpression { get; set; }

        [DataMember]
        public decimal Value { get; set; }
    }
}

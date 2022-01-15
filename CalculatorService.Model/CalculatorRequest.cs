using CalculatorService.Model.Interfaces;
using System.Runtime.Serialization;

namespace CalculatorService.Model
{
    [DataContract]
    public class CalculatorRequest : ICalulatorRequest
    {
        [DataMember]
        public string ValueAName { get; set; }

        [DataMember]
        public decimal ValueA { get; set; }

        [DataMember]
        public string ValueBName { get; set; }

        [DataMember]
        public decimal ValueB { get; set; }
    }
}

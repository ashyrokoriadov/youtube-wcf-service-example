using System.ServiceModel;

namespace CalculatorService.Model.Interfaces
{
    [ServiceContract]
    [ServiceKnownType(typeof(CalculatorRequest))]
    [ServiceKnownType(typeof(CalculatorResponse))]
    public interface ILoggingCalculator
    {
        [OperationContract]
        ICalulatorResponse Add(ICalulatorRequest request);

        [OperationContract]
        ICalulatorResponse Subtract(ICalulatorRequest request);
    }
}

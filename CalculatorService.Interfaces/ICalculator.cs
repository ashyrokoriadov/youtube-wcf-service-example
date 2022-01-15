using System.ServiceModel;

namespace CalculatorService.Interfaces
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        decimal Add(decimal value1, decimal value2);

        [OperationContract]
        decimal Subtract(decimal value1, decimal value2);
    }
}

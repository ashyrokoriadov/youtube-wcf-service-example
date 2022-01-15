using CalculatorService.Model;
using CalculatorService.Model.Interfaces;
using System.ServiceModel;

namespace CalculatorServiceWCF
{
    public class LoggingCalculatorService : ILoggingCalculator
    {
        public ICalulatorResponse Add(ICalulatorRequest request)
        {
            var value = request.ValueA + request.ValueB;
            var textExpression = $"{request.ValueAName} + {request.ValueBName} = {value}";
            return new CalculatorResponse()
            {
                Value = value,
                TextExpression = textExpression
            };
        }

        public ICalulatorResponse Subtract(ICalulatorRequest request)
        {
            var value = request.ValueA - request.ValueB;
            var textExpression = $"{request.ValueAName} - {request.ValueBName} = {value}";
            return new CalculatorResponse()
            {
                Value = value,
                TextExpression = textExpression
            };
        }
    }
}

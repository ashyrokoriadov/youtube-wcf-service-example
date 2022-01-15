using CalculatorService.Model.Interfaces;

namespace CalculatorServiceWCF
{
    public class CalculatorService : ICalculator
    {
        public decimal Add(decimal value1, decimal value2) => value1 + value2;

        public decimal Subtract(decimal value1, decimal value2) => value1 - value2;
    }
}

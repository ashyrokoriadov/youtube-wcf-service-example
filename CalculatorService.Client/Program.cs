using CalculatorService.Client.CalculatorServiceReference;
using CalculatorService.Client.LoggingCalculatorServiceReference;
using System;

namespace CalculatorService.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorClient calculatorClient = new CalculatorClient();
            Console.WriteLine(calculatorClient.Add(11.22M, 33.44M));
            Console.WriteLine(calculatorClient.Subtract(88.77M, 66.55M));

            LoggingCalculatorClient loggingCalculatorClient = new LoggingCalculatorClient();

            var request1 = new CalculatorRequest()
            {
                ValueA = 11.22M,
                ValueAName = "A1",
                ValueB = 33.44M,
                ValueBName = "B1"
            };
            var response1 = loggingCalculatorClient.Add(request1) as CalculatorResponse;
            Console.WriteLine($"Value: {response1.Value}; log messsage: {response1.TextExpression}");

            var request2 = new CalculatorRequest()
            {
                ValueA = 88.77M,
                ValueAName = "C1",
                ValueB = 66.55M,
                ValueBName = "D1"
            };
            var response2 = loggingCalculatorClient.Subtract(request2) as CalculatorResponse;
            Console.WriteLine($"Value: {response2.Value}; log messsage: {response2.TextExpression}");

            Console.ReadKey();
        }
    }
}

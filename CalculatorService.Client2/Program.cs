using CalculatorService.Model;
using CalculatorService.Model.Interfaces;
using System;
using System.ServiceModel;

namespace CalculatorService.Client2
{
    class Program
    {
        static void Main(string[] args)
        {
            var binding = new BasicHttpBinding();
            var endpoint = new EndpointAddress("http://localhost:8733/Design_Time_Addresses/CalculatorService/");
            using (var channelFactory = new ChannelFactory<ICalculator>(binding, endpoint))
            {
                ICalculator calculatorClient = null;

                try
                {
                    calculatorClient = channelFactory.CreateChannel();

                    Console.WriteLine(calculatorClient.Add(11.22M, 33.44M));
                    Console.WriteLine(calculatorClient.Subtract(88.77M, 66.55M));

                    ((ICommunicationObject)calculatorClient).Close();
                    channelFactory.Close();
                }
                catch
                {
                    (calculatorClient as ICommunicationObject)?.Abort();
                }
            }

            endpoint = new EndpointAddress("http://localhost:8733/Design_Time_Addresses/LoggingCalculatorService/");
            using (var channelFactory = new ChannelFactory<ILoggingCalculator>(binding, endpoint))
            {
                ILoggingCalculator loggingCalculatorClient = null;

                try
                {
                    loggingCalculatorClient = channelFactory.CreateChannel();

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


                    ((ICommunicationObject)loggingCalculatorClient).Close();
                    channelFactory.Close();
                }
                catch
                {
                    (loggingCalculatorClient as ICommunicationObject)?.Abort();
                }
            }

            Console.ReadKey();
        }
    }
}

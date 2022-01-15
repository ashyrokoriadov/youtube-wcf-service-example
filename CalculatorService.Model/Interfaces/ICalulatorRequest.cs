namespace CalculatorService.Model.Interfaces
{
    public interface ICalulatorRequest
    {
        string ValueAName { get; set; }

        decimal ValueA { get; set; }

        string ValueBName { get; set; }

        decimal ValueB { get; set; }
    }
}

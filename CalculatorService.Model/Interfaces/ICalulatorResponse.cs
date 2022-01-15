using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorService.Model.Interfaces
{
    public interface ICalulatorResponse
    {
        string TextExpression { get; set; }

        decimal Value { get; set; }
    }
}

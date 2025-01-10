using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4.Interfaces
{
    public interface ICalculatorView
    {
        event EventHandler AddEvent;
        event EventHandler SubtractEvent;
        event EventHandler MultiplyEvent;
        event EventHandler DivideEvent;
        double Value1 { get; }
        double Value2 { get; }
        double Result { set; }
    }
}


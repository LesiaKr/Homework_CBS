using System;

namespace MyCalculator
{
    class MyCalcException : Exception
    {
        public MyCalcException() { }
        public MyCalcException(string message) : base(message) { }
        public MyCalcException(string message, Exception inner) : base(message, inner) { }
    }
}

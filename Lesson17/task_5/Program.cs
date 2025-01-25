/*Завдання 5 
Створіть клас Calculator, методи якого приймають аргументи та повертають значення типу dynamic.*/
using System.Text;

namespace DynamicCalculator
{
    class Calculator
    {
        public dynamic Add(dynamic a, dynamic b)
        {
            return a + b;
        }
        public dynamic Sub(dynamic a, dynamic b)
        {
            return a - b;
        }
        public dynamic Mul(dynamic a, dynamic b)
        {
            return a * b;
        }
        public dynamic Div(dynamic a, dynamic b)
        {
            if (b == 0 && a == 0)
                throw new DivideByZeroException("Ділення на нуль неможливе.");
            return a / b;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            dynamic calculator = new Calculator();

            Console.WriteLine($"Додавання: {calculator.Add(10, 2)}");
            Console.WriteLine($"Додавання2: {calculator.Add("10", 2)}");
            Console.WriteLine($"Віднімання: {calculator.Sub(10, 2)}");
            Console.WriteLine($"Множення: {calculator.Mul(10, 2)}");
            Console.WriteLine($"Ділення: {calculator.Div(10, 0)}");
          
            Console.ReadKey();
        }
    }
}
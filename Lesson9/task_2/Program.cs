/*Завдання 2 
Створіть чотири лямбда оператора для виконання арифметичних дій: (Add – додавання, Sub – віднімання, Mul – множення, Div – поділ). Кожен лямбда оператор повинен приймати два аргументи та повертати результат обчислення. Лямбда оператор поділу повинен перевірити поділ на нуль. Написати програму, яка виконуватиме арифметичні дії, вказані користувачем. */
using System.Text;

namespace Calculator
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            
            Func<double, double, double> Add = (x, y) => x + y;
            Func<double, double, double> Sub = (x, y) => x - y;
            Func<double, double, double> Mul = (x, y) => x * y;
            Func<double, double, double> Div = (x, y) => y != 0 ? x / y : double.NaN;

            Console.Write("Введіть перше число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть друге число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть операцію (+, -, *, /): ");
            string operation = Console.ReadLine();

            double result = 0;
            switch (operation)
            {
                case "+":
                    result = Add(num1, num2);
                    break;
                case "-":
                    result = Sub(num1, num2);
                    break;
                case "*":
                    result = Mul(num1, num2);
                    break;
                case "/":
                    result = Div(num1, num2);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Помилка: поділ на нуль.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Невірна операція.");
                    return;
            }
            Console.WriteLine($"Результат: {result}");
        }
    }
}
/* Завдання 5
Створіть клас Calculator. У тілі класу створіть чотири методи для арифметичних дій: Add – додавання, Sub – віднімання, Mul – множення, Div – розподіл. Метод поділу повинен перевірити поділ на нуль, якщо перевірка не проходить, згенерувати виняток. Користувач вводить значення, над якими хоче зробити операцію та вибрати саму операцію. У разі виникнення помилок повинні викидатися винятки.*/
using System.Text;

namespace MyCalculator
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Calculator calculator = new Calculator();
           

            Console.Write("Введіть перше число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть друге число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть операцію (+, -, *, /): ");
            string operation = Console.ReadLine();

            try
            {
                double result = 0;
                switch (operation)
                {
                    case "+":
                        result = calculator.Add(num1, num2);
                        break;
                    case "-":
                        result = calculator.Sub(num1, num2);
                        break;
                    case "*":
                        result = calculator.Mul(num1, num2);
                        break;
                    case "/":
                        result = calculator.Div(num1, num2);
                        break;
                    default:
                        throw new MyCalcException("Невірна операція.");
                }
                Console.WriteLine($"Результат: {result}");
            }
            catch (Exception ex) {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }
    }
}
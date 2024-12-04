/*Завдання 6
Потрібно: Створити статичний клас Calculator, з методами виконання основних арифметичних операцій. Написати програму, яка виводить на екран основні арифметичні операції.*/
using System;
using System.Text;

namespace StaticCalculator
{
    static class Calculator
    {
        public static double Plus(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double Minus(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double Divited(double num1, double num2)
        {
            return num1 / num2;
        }
        public static double Multy(double num1, double num2)
        {
            return num1 * num2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            
            Console.WriteLine("Введіть перше число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть друге число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Опереція додавання: " + Calculator.Plus(num1, num2));
            Console.WriteLine("Опереція віднімання: " + Calculator.Minus(num1, num2));
            if (num1 == 0 || num2 == 0)
            {
                Console.WriteLine("Операція ділення на 0 не можлива!!!");
            }
            else
            {
                Console.WriteLine("Опереція ділення: " + Calculator.Divited(num1, num2));
            }
            Console.WriteLine("Опереція множення: " + Calculator.Multy(num1, num2));
        }
    }
}
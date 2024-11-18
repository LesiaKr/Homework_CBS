/*Завдання 5
Потрібно: Створити клас Printer. У тілі класу створіть метод void Print(string value), що виводить на екран значення аргументу. Реалізуйте можливість того, щоб у разі успадкування від даного класу інших класів, та виклику відповідного методу їх екземпляра, рядки, передані як аргументи методів, виводилися різними кольорами. Обов'язково використовуйте типи.*/
using System;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Printer
{
    public class PrinterGreen : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            base.Print(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
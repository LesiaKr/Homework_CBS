/*Завдання 5
Потрібно: Створити клас Printer. У тілі класу створіть метод void Print(string value), що виводить на екран значення аргументу. Реалізуйте можливість того, щоб у разі успадкування від даного класу інших класів, та виклику відповідного методу їх екземпляра, рядки, передані як аргументи методів, виводилися різними кольорами. Обов'язково використовуйте типи.*/
using System;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Printer
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Printer printer = new Printer();
            printer.Print("Колір за замовчуванням");
            PrinterGreen printerGreen = new PrinterGreen();
            printerGreen.Print("Колір зелений");
            PrinterRed printerRed = new PrinterRed();
            printerRed.Print("Колір червоний");

            Console.ReadKey();
        }
    }
}
/*Завдання 2 
Створіть статичний клас із методом void Print (string stroka, int color), який виводить на екран рядок заданим кольором. Використовуючи перелік, створіть набір кольорів, доступних користувачеві. Введення рядка та вибір кольору надайте користувачеві. */
using System;
using System.Text;

enum Color
{
    Red = 0, Green = 1, Blue = 2
}
static class PrintString
{
    public static void Print(string stroka, int color)
    {
        if (color == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(stroka);
            Console.ResetColor();
        }
        else if (color == 1) {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(stroka);
            Console.ResetColor();
        }
        else if (color == 2)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(stroka);
            Console.ResetColor();
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("Введіть рядок: ");
        string str = Console.ReadLine();
        Console.WriteLine("Введіть число бажаного кольору (0 - червоний, 1 - зелений, 2 - синій): ");
        int number = int.Parse(Console.ReadLine());
        PrintString.Print(str, number);
    }
}
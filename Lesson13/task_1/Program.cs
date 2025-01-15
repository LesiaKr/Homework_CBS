/*Завдання 1
Створіть програму, яка виводитиме на екран ланцюжки падаючих символів. Довжина кожного ланцюжка визначається випадково. Перший символ ланцюжка – білий, другий символ – світло-зелений, решта символів темно-зелені. Під час падіння ланцюжка на кожному кроці всі символи змінюють своє значення. Дійшовши до кінця, ланцюжок зникає і зверху формується новий ланцюжок. Дивіться example1.png представлений як зразок.*/

using System;
using System.Threading;

class Program
{
    static Random random = new Random();
    static object locker = new object();

    static void Main(string[] args)
    {
        Console.CursorVisible = false;
        for (int i = 0; i < 10; i++) //запуск 10 потоків
        {
            new Thread(Drop).Start();
            Thread.Sleep(random.Next(100, 500)); 
        }
    }

    static void Drop()
    {
        while (true)
        {
            int length = random.Next(3, 15); 
            int column = random.Next(0, Console.WindowWidth);

            char[] symbols = new char[length];
            for (int i = 0; i < length; i++)
            {
                symbols[i] = GetRandomChar();
            }

            for (int row = -length; row < Console.WindowHeight + length; row++)
            {
                lock (locker)
                {
                    if (row >= 0 && row < Console.WindowHeight)
                    {
                        for (int i = 0; i < length; i++)
                        {
                            int position = row - i;
                            if (position >= 0 && position < Console.WindowHeight)
                            {
                                Console.SetCursorPosition(column, position);
                                Console.ForegroundColor = GetColor(i);
                                Console.Write(symbols[i]);
                                symbols[i] = GetRandomChar();
                            }
                        }
                    }
                    if (row - length >= 0 && row - length < Console.WindowHeight)
                    {
                        Console.SetCursorPosition(column, row - length);
                        Console.Write(' ');
                    }
                    if (row >= Console.WindowHeight)
                    {
                        for (int i = 0; i < length; i++)
                        {
                            int disappearingPosition = row - Console.WindowHeight + i;
                            if (disappearingPosition < length)
                            {
                                Console.SetCursorPosition(column, Console.WindowHeight - 1 - disappearingPosition);
                                Console.Write(' ');
                            }
                        }
                    }
                }
                Thread.Sleep(100);
            }
        }
    }

    static char GetRandomChar()
    {
        return (char)random.Next(33, 126); 
    }

    static ConsoleColor GetColor(int position)
    {
        if (position == 0)
        {
            return ConsoleColor.White;
        }
        else if (position == 1)
        {
            return ConsoleColor.Green;
        }
        else
        {
            return ConsoleColor.DarkGreen;
        }
    }
}



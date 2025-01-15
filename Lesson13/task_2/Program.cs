/*Завдання 2
Розширте завдання 2 так, щоб в одному стовпці одночасно могло бути два ланцюжки символів. Дивіться example2.png, представлений як зразок.*/

using System;
using System.Threading;

class Program
{
    static Random random = new Random();
    static object locker = new object();

    static void Main(string[] args)
    {
        Console.CursorVisible = false;
        for (int i = 0; i < 10; i++)
        {
            new Thread(Drop).Start();
            Thread.Sleep(random.Next(100, 500));
        }
    }

    static void Drop()
    {
        while (true)
        {
            int length1 = random.Next(3, 15);
            int length2 = random.Next(3, 15);
            int offset = random.Next(3, 10);
            int column = random.Next(0, Console.WindowWidth);

            char[] symbols1 = new char[length1];
            char[] symbols2 = new char[length2];
            for (int i = 0; i < length1; i++)
            {
                symbols1[i] = GetRandomChar();
            }
            for (int i = 0; i < length2; i++)
            {
                symbols2[i] = GetRandomChar();
            }

            for (int row = -Math.Max(length1, length2) - offset; row < Console.WindowHeight + Math.Max(length1, length2) + offset; row++)
            {
                lock (locker)
                {
                    // Ланцюжок 1
                    if (row >= 0 && row < Console.WindowHeight)
                    {
                        for (int i = 0; i < length1; i++)
                        {
                            int position = row - i;
                            if (position >= 0 && position < Console.WindowHeight && column >= 0 && column < Console.WindowWidth)
                            {
                                Console.SetCursorPosition(column, position);
                                Console.ForegroundColor = GetColor(i);
                                Console.Write(symbols1[i]);
                                symbols1[i] = GetRandomChar();
                            }
                        }
                    }
                    if (row - length1 >= 0 && row - length1 < Console.WindowHeight)
                    {
                        int position = row - length1;
                        if (position >= 0 && position < Console.WindowHeight && column >= 0 && column < Console.WindowWidth)
                        {
                            Console.SetCursorPosition(column, position);
                            Console.Write(' ');
                        }
                    }

                    // Ланцюжок 2
                    if (row >= offset && row < Console.WindowHeight + offset)
                    {
                        for (int i = 0; i < length2; i++)
                        {
                            int position = row - offset - i;
                            if (position >= 0 && position < Console.WindowHeight && column >= 0 && column < Console.WindowWidth)
                            {
                                Console.SetCursorPosition(column, position);
                                Console.ForegroundColor = GetColor(i);
                                Console.Write(symbols2[i]);
                                symbols2[i] = GetRandomChar();
                            }
                        }
                    }
                    if (row - length2 - offset >= 0 && row - length2 - offset < Console.WindowHeight)
                    {
                        int position = row - length2 - offset;
                        if (position >= 0 && position < Console.WindowHeight && column >= 0 && column < Console.WindowWidth)
                        {
                            Console.SetCursorPosition(column, position);
                            Console.Write(' ');
                        }
                    }

                    if (row >= Console.WindowHeight)
                    {
                        // Ланцюжок 1 зникає
                        for (int i = 0; i < length1; i++)
                        {
                            int disappearingPosition = row - Console.WindowHeight + i;
                            if (disappearingPosition < length1)
                            {
                                int position = Console.WindowHeight - 1 - disappearingPosition;
                                if (position >= 0 && position < Console.WindowHeight && column >= 0 && column < Console.WindowWidth)
                                {
                                    Console.SetCursorPosition(column, position);
                                    Console.Write(' ');
                                }
                            }
                        }
                        // Ланцюжок 2 зникає
                        for (int i = 0; i < length2; i++)
                        {
                            int disappearingPosition = row - Console.WindowHeight + i - offset;
                            if (disappearingPosition < length2)
                            {
                                int position = Console.WindowHeight - 1 - disappearingPosition;
                                if (position >= 0 && position < Console.WindowHeight && column >= 0 && column < Console.WindowWidth)
                                {
                                    Console.SetCursorPosition(column, position);
                                    Console.Write(' ');
                                }
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


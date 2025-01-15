/*Завдання 4
Напишіть програму, в якій метод викликатиметься рекурсивно. Кожен новий виклик методу виконується окремому потоці.*/

using System;
using System.Threading;

namespace RecursiveThreads
{
    class Program
    {
        static void Main()
        {
            RecursiveMethod(6);
        }

        static void RecursiveMethod(int depth)
        {
            if (depth >= 15)
            {
                return;
            }
           Thread newThread = new Thread(() => RecursiveMethod(depth + 1));
            Console.WriteLine($"ID потоку {newThread.Name}: {newThread.GetHashCode()}, Count: {depth}");
            newThread.Start();
            newThread.Join(); // Чекаємо на завершення потоку
        }
    }
}

/* Завдання 2
Потрібно: Створити масив розмірністю N елементів, заповнити його довільними цілими значеннями. Вивести найбільше значення масиву, найменше значення масиву, загальну суму елементів, середнє арифметичне всіх елементів, вивести всі непарні значення.*/
using System;
using System.Text;
namespace IntArray
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("Введіть розмір масиву: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введіть {i + 1} елемент масиву: ");
                int value = Convert.ToInt32(Console.ReadLine());
                array[i] = value;
            }
            Console.WriteLine();
            Console.WriteLine($"Найбільше знвчення масиву: {array.Max()}");
            Console.WriteLine($"Найменше знвчення масиву: {array.Min()}");
            Console.WriteLine($"Суму всіх елементів: {array.Sum()}");
            Console.WriteLine($"Середнє арифметичне всіх елементів: {(double)array.Sum() / n}");
            Console.Write($"Усі непарні значення: ");
            GetOdd(array);
            Console.ReadKey();
        }
        static void GetOdd(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Console.Write($"{array[i]} ");
                }
            }
        }
    }
}
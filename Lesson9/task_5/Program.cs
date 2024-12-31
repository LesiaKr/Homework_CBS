/* Завдання 5
Створіть анонімний метод, який приймає як параметри три цілих аргументи і повертає середнє арифметичне цих аргументів.*/

using System;

namespace Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            double Average (int a, int b, int c) => (double)(a + b + c)/3;
            var result = Average(5, 25, 12);
            
            Console.WriteLine(result);
        }
    }
}
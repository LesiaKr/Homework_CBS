/*Завдання 3 
Створіть анонімний метод, який приймає як аргумент масив делегатів і повертає середнє арифметичне значення значень методів, повідомлених з делегатами в масиві. Методи, повідомлені з делегатами з масиву, повертають випадкове значення типу int. */

using System;

namespace ArithmeticDelegate
{
    public delegate int Del(int num);
   
    class Program
    {
        public static int Method1(int num)
        {
            return new Random().Next(num);
        }
        public static int Method2(int num)
        {
            return new Random().Next(num);
        }
        public static int Method3(int num)
        {
            return new Random().Next(num);
        }
        public static double Method4(Del[] array)
        {
            double sum = 0;
            int count = array.Length;
            int value;
            Console.WriteLine($"Значення: ");
            foreach (Del del in array)
            {
                value = del(10);
                sum += value;
                Console.Write(value + " ");
            }
            Console.WriteLine("\nСума: " + sum);
            return sum / count;
        }

        static void Main(string[] args)
        {
            Del del1 = new Del(Method1);
            Del del2 = new Del(Method2);
            Del del3 = new Del(Method3);

            Del[] delegatesArray = { del1, del2, del3 };
           
            double Average(Del[] delegatesArray) => Method4(delegatesArray);
            double results = Average(delegatesArray);
            Console.WriteLine($"Середнє арифметичне значення: {results}");
        }
    }
}
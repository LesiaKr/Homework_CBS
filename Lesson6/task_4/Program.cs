/*Завдання 4 
Потрібно: створити розширюючий метод для цілого масиву, який сортує елементи масиву за зростанням. */
using System;
using System.Text;

namespace ExtentionArray
{
    static class ExtentionArray
    {
        public static void ExtMethod(this int[] array)
        {
            Array.Sort(array);
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 100, 255, 3, 42 };
            arr.ExtMethod();
        }
    }
}
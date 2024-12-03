/*Завдання 6
Розширте приклад 5 ще і польським словником. Реалізуйте можливість пошуку не тільки за ключовими українським словами і словами на інших мовах.*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["книга"]);
            Console.WriteLine(dictionary["дім"]);
            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["стіл"]);
            Console.WriteLine(dictionary["олівець"]);
            Console.WriteLine(dictionary["яблуко"]);
            Console.WriteLine(dictionary["сонце"]);

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            Console.WriteLine(new string('-', 20));
            // Пошук за англійськими та польськими словами
            Console.WriteLine("Переклад за англійськими та польськими словами:");
            Console.WriteLine(dictionary["book"]); 
            Console.WriteLine(dictionary["dom"]); 
            Console.WriteLine(dictionary["pen"]); 
            Console.WriteLine(dictionary["stół"]); 
            Console.WriteLine(dictionary["ołówek"]); 
            Console.WriteLine(dictionary["apple"]); 
            Console.WriteLine(dictionary["słońce"]);

            Console.ReadKey();
        }
    }
}

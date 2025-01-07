/*Завдання 3
Створіть клас Dictionary. Реалізуйте у найпростішому наближенні можливість використання його екземпляра аналогічно екземпляру класу Dictionary із простору імен System.Collections.Generic. Мінімально необхідний інтерфейс взаємодії з екземпляром повинен включати метод додавання пар елементів, індексатор для отримання значення елемента за вказаним індексом і властивість тільки для читання для отримання загальної кількості пар елементів.*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryHome
{
    interface IDictionaryHome<TKey, TValue>
    {
        void Add(TKey key, TValue value);
        TValue this[TKey key] { get; }
        int Count { get; }
    }

    public class MyDictionary<TKey, TValue> : IDictionaryHome<TKey, TValue>
    {
        private Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>();

        public void Add(TKey key, TValue value)
        {
            dictionary.Add(key, value);
        }

        public TValue this[TKey key]
        {
            get { return dictionary[key]; }
        }

        public int Count
        {
            get { return dictionary.Count; }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();

            dictionary.Add(2021, "Nissan");
            dictionary.Add(2018, "Honda");
            dictionary.Add(2015, "BMW");
            dictionary.Add(2022, "Jeep");

            Console.WriteLine(dictionary[2021]); // Nissan

            Console.WriteLine(new string('-', 30));

            Console.WriteLine($"Загальна кількість: {dictionary.Count}");

            Console.ReadKey();
        }
    }
}


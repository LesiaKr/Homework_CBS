/*Завдання 4 
Створіть клас ArrayList. Реалізуйте у найпростішому наближенні можливість використання його екземпляра аналогічно екземпляру класу ArrayList із простору імен System.Collections. */

using System;

namespace CustomArrayList
{
    public class MyArrayList
    {
        private object[] items;
        private int count;

        public MyArrayList()
        {
            items = new object[4];
            count = 0;
        }

        public void Add(object value)
        {
            if (count == items.Length)
            {
                object[] newItems = new object[items.Length * 2];
                Array.Copy(items, newItems, items.Length);
                items = newItems;
            }
            items[count++] = value;
        }

        public bool Contains(object value)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(value))
                {
                    return true;
                }
            }
            return false;
        }
    }

    class Program
    {
        static void Main()
        {
            MyArrayList arrayList = new MyArrayList();
            arrayList.Add("Hello");
            arrayList.Add(42);
            arrayList.Add(3.14);

            Console.WriteLine($"Містить 'Hello': {arrayList.Contains("Hello")}");
            Console.WriteLine($"Містить 'Goodbye': {arrayList.Contains("Goodbye")}");
        }
    }
}


/*Завдання 3 
Створіть колекцію MyDictionary. Реалізуйте у найпростішому наближенні можливість використання її екземпляра аналогічно екземпляру класу Dictionary. Мінімально необхідний інтерфейс взаємодії з екземпляром повинен включати метод додавання елемента, індексатор для отримання значення елемента за вказаним індексом і властивість тільки для читання для отримання загальної кількості елементів. Реалізуйте можливість перебору елементів колекції у циклі наперед.*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using ElementsForDictionary;
public class MyDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
{
    private Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>();

    public void Add(TKey key, TValue value)
    {
        dictionary.Add(key, value);
    }

    public TValue this[TKey key]
    {
        get { return dictionary[key]; }
        set { dictionary[key] = value; }
    }

    public int Count
    {
        get { return dictionary.Count; }
    }

    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
    {
        return dictionary.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        MyDictionary<string, Element> myDictionary = new MyDictionary<string, Element>();
        myDictionary.Add("Математичний", new Element("Олег", 95, 2015));
        myDictionary.Add("Економічний", new Element("Назар", 75, 2012));
        myDictionary.Add("Технічний", new Element("Саша", 98, 2019));

        Console.WriteLine("Загальна кількість елементів: " + myDictionary.Count);

        Console.WriteLine($"Елемент за факультетом (ключ) \"Математичний\": Ім'я = {myDictionary["Математичний"].Name}, Бали = {myDictionary["Математичний"].Field1}, Рік = {myDictionary["Математичний"].Field2}");

        Console.WriteLine("Перебір foreach:");
        foreach (var kvp in myDictionary)
        {
            Console.WriteLine($"Факультет = {kvp.Key}, Ім'я = {kvp.Value.Name}, Бали = {kvp.Value.Field1}, Рік = {kvp.Value.Field2}");
        }
    }
}

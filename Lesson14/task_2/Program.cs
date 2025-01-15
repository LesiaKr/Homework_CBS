/* Завдання 2
Створіть колекцію MyList. Реалізуйте у найпростішому наближенні можливість використання її екземпляра аналогічно екземпляру класу List. Мінімально необхідний інтерфейс взаємодії з екземпляром повинен включати метод додавання елемента, індексатор для отримання значення елемента за вказаним індексом і властивість тільки для читання для отримання загальної кількості елементів. Реалізуйте можливість перебору елементів колекції у циклі наперед.*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using ElementsForMyList;

public class MyList : IEnumerable<Element>
{
    private List<Element> elements = new List<Element>();

    public void Add(Element element)
    {
        elements.Add(element);
    }

    public Element this[int index]
    {
        get { return elements[index]; }
    }

    public int Count
    {
        get { return elements.Count; }
    }

    public IEnumerator<Element> GetEnumerator()
    {
        return elements.GetEnumerator();
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

        MyList myList = new MyList();
        myList.Add(new Element("Олег", 95, 2015));
        myList.Add(new Element("Назар", 75, 2012));
        myList.Add(new Element("Саша", 98, 2019));

        Console.WriteLine("Загальна кількість елементів: " + myList.Count);
        Console.WriteLine($"Eлемент за індексом 2: Ім'я = {myList[2].Name}, Бали = {myList[2].Field1}, Рік = {myList[2].Field2}");
        Console.WriteLine("Перебір foreach:");
        foreach (var element in myList)
        {
            Console.WriteLine($"Ім'я = {element.Name}, Бали = {element.Field1}, Рік = {element.Field2}");
        }
    }
}

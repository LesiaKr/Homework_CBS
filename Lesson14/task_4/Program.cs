/*Завдання 4 
Створіть метод, що розширює: public static T[ ] GetArray(this IEnumerable list){…} Застосуйте розширюючий метод до екземпляра типу MyList, розробленого в домашньому завданні 2 для даного уроку. Виведіть на екран значення елементів масиву, який повернув метод GetArray(), що розширює метод.*/
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

public static class Extensions { 
    public static T[] GetArray<T>(this IEnumerable<T> list) 
    { 
        return list.ToArray(); 
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

        Element[] array = myList.GetArray(); 

        Console.WriteLine("Значення елементів масиву:"); 
        foreach (var element in array) { 
            Console.WriteLine($"Ім'я = {element.Name}, Бали = {element.Field1}, Рік = {element.Field2}"); }
    }
}

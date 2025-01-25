/*Завдання 1
Використовуючи приклад виконаного домашнього завдання 3 з 14 уроку, реалізуйте можливість підключення вашого простору імен та роботи з MyDictionary аналогічно екземпляру класу Dictionary.*/

using System.Text;
using System.Xml.Linq;
using MyDictionary;
using ElementsForDictionary;
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
/*Завдання 4
Потрібно: Створити клас Article, що містить наступні закриті поля:
• Назва товару;
• назва магазину, в якому продається товар;
• вартість товару в гривнях. 
Створити клас Store, який містить закритий масив елементів типу Article.
Забезпечити такі можливості:
• висновок інформації про товар за номером за допомогою індексу;
• висновок на екран інформації про товар, назва якого введено з клавіатури, якщо таких товарів немає, видати відповідне повідомлення.
Написати програму, виведення на екран інформацію про товар.*/
using System;
using System.Text;

namespace Article
{
    class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.Write("Пошук за назвою. Введіть назву товару: ");
            Store store = new Store();
            store.FindByName(Console.ReadLine());

            Console.Write($"Пошук за індексом. Введіть індекс товару: ");
            int i = Convert.ToInt32(Console.ReadLine());
            if (store[i] != null) 
            { 
                store[i].PrintInfo(); 
            } 
            else 
            { 
                Console.WriteLine("Товар за цим індексом відсутній."); 
            }
        }
    }
}
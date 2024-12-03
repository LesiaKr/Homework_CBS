/*Завдання 4
Потрібно: Створити клас Article, що містить наступні закриті поля:
• Назва товару;
• назва магазину, в якому продається товар;
• вартість товару в гривнях. 
Створити клас Store, який містить закритий масив елементів типу Article.
Забезпечити такі можливості:
• висновок інформації про товар за номером за допомогою індексу;
• висновок на екран інформації про товар, назва якого введено з клавіатури, якщо таких товарів немає, видати відповідне повідомлення.*/
using System;
using System.Text;

namespace Article
{
    public class Store
    {
        private Article[] articles = new Article[5] {
            new Article("ноутбук", "Comfy", 35000), 
            new Article("телевізор", "Розетка", 45000), 
            new Article("смартфон", "Фокстрот", 15000), 
            new Article("пральна", "Ельдорадо", 20000), 
            new Article("холодильник", "Comfy", 18000)
        };
        public Article this[int index]
        {
            get
            {
                if (index >= 0 && index < articles.Length) 
                { 
                    return articles[index]; 
                } 
                else 
                { 
                    Console.WriteLine("Індекс виходить за межі масиву.");
                    return null;
                }
            }
        }
        public void FindByName(string productName) 
        { 
            bool found = false; 
            foreach (var article in articles) 
            { 
                if (article != null && article.ProductName == productName) { 
                    article.PrintInfo(); 
                    found = true; 
                    break; 
                } 
            } if (!found) 
            { 
                Console.WriteLine("Товар не знайдено."); 
            } 
        }
    }
}

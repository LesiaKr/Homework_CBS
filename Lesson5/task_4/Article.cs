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
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Article
{
    public class Article
    {
        private string productName;
        private string storeName;
        private int price;
        public Article(string productName, string storeName, int price)
        {
            this.productName = productName;
            this.storeName = storeName;
            this.price = price;
        }
        public string ProductName { get { return productName; } }
        public void PrintInfo()
        {
            Console.WriteLine($"Товар: {productName}, Магазин: {storeName}, Ціна: {price} грн");
        }
    }
}

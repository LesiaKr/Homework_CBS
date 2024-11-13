/*Завдання 4 
Потрібно: Створити клас Invoice. У тілі класу створити три поля int account, string customer, string provider, які мають бути проініціалізовані один раз (при створенні екземпляра даного класу) без можливості їхньої подальшої зміни. У тілі класу створити два закриті поля string article, int quantity Створити метод розрахунку вартості замовлення з ПДВ та без ПДВ. Написати програму, яка виводить на екран суму оплати замовленого товару з ПДВ чи без ПДВ.*/
using System;
using System.Text;

namespace Invoice
{
    class Invoice
    {
        public readonly int account = 12345;
        public readonly string customer = "Natali";
        public readonly string provider = "Nazar";
        string article;
        int quantity;

        public Invoice(string article, int quantity)
        {
            this.article = article;
            this.quantity = quantity;
        } 

        public double СalculateOrder(double priceClear)
        {
            return quantity * priceClear;
        }
        public double СalculateTax(double priceClear)
        {
            double cost = СalculateOrder(priceClear);
            const double taxRate = 0.20; // 20% ПДВ
            return cost * (1 + taxRate);
        }
    }
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            
            Invoice invoice = new Invoice("Папір офісний", 5);
            Console.WriteLine($"Вартість: {invoice.СalculateOrder(1000)}грн");
            Console.WriteLine($"Вартість з ПДВ: {invoice.СalculateTax(1000)}грн");

            Console.ReadKey();
        }
    }
}
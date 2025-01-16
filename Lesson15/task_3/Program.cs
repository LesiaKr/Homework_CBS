/*Завдання 3 
Потрібно описати структуру з іменем Price, що містить такі поля:
• назва товару;
• назва магазину, де продається товар;
• вартість товару у гривнях.
Написати програму, яка виконує такі дії:
• введення з клавіатури даних до масиву, що складається з двох елементів типу Price (записи мають бути впорядковані в алфавітному порядку за назвами магазинів);
• виведення на екран інформації про товари, що продаються в магазині, назва якого введена з клавіатури (якщо такого магазину немає, вивести виняток).*/
using System.Text;

namespace Store
{
    struct Price
    {
        private string productName;
        private string storeName;
        private double productPrice;
        public Price(string productName, string storeName, double price)
        {
            this.productName = productName;
            this.storeName = storeName;
            this.productPrice = price;
        }
        public string ProductName { get => productName; set => productName = value; }
        public string StoreName { get => storeName; set => storeName = value; }
        public double ProductPrice { get => productPrice; set => productPrice = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Price[] prices = new Price[2]; 
            for (int i = 0; i < prices.Length; i++) 
            { 
                Console.WriteLine($"Введіть дані для товару {i + 1}:");
                Console.Write("Назва товару: "); 
                string productName = Console.ReadLine(); 
                Console.Write("Назва магазину: "); 
                string storeName = Console.ReadLine(); 
                Console.Write("Вартість: "); 
                double productPrice = double.Parse(Console.ReadLine());
                
                prices[i] = new Price(productName, storeName, productPrice); 
            } 
            prices = prices.OrderBy(p => p.StoreName).ToArray();

            Console.Write("Введіть назву магазину для пошуку наявних товарів: "); 
            string searchStoreName = Console.ReadLine();

            try { 
                var foundProducts = prices.Where(p => p.StoreName.Trim().ToLower() == searchStoreName.Trim().ToLower()).ToArray();
                if (foundProducts.Length == 0) { 
                    throw new Exception($"Магазин з назвою '{searchStoreName}' не знайдено."); 
                } 
                Console.WriteLine($"Товари в магазині '{searchStoreName}':"); 
                foreach (var product in foundProducts) { 
                    Console.WriteLine($"Назва товару: {product.ProductName}, Вартість: {product.ProductPrice}"); 
                } 
            } catch (Exception ex) { 
                Console.WriteLine($"Помилка: {ex.Message}"); 
            }
        }
    }
}

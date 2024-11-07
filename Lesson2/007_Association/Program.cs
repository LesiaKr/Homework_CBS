using System;
using System.Text;

// Використання техніки фабричних методів.

namespace Classes
{
    class Product
    {
        public Product()
        {
            Console.WriteLine("Створено екземпляр класу Product");
        }
    }

    class Factory
    {
        public Product FactoryMethod()
        {
            return new Product();
        }
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Factory factory = new Factory();

            Product product = factory.FactoryMethod();

            // Delay.
            Console.ReadKey();
        }
    }
}

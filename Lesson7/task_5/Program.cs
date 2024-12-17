/* Завдання 5
Створіть структуру з ім'ям – Notebook. Поля структури: модель, виробник, вартість. У структурі має бути реалізований конструктор для ініціалізації полів та метод для виведення вмісту полів на екран.*/
namespace Notebook
{
    struct Notebook
    {
        private string model;
        private string producer;
        private double price;
        public Notebook(string model, string producer, double price) { 
            this.model = model;
            this.producer = producer;
            this.price = price;
        }
        public void Show() {
            Console.WriteLine("Модель:" + model + " Виробник:" + producer + " Вартість: " + price);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("Lenovo", "China", 35500);
            notebook.Show();
        }
    }
}

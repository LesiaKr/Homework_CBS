/*Завдання 3 
Потрібно: Створити клас Book. Створити класи Title, Author та Content, кожен з яких повинен містити одне рядкове поле та метод void Show(). Реалізуйте можливість додавання до книги назви книги, імені автора та змісту. Виведіть на екран різними кольорами за допомогою методу Show() назву книги, ім'я автора та зміст.*/
using System.Reflection.Metadata;
using System.Text;
namespace Book
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.Write("Введіть назву книги: ");
            string title = Console.ReadLine();
            Console.Write("Введіть ім'я автора книги: ");
            string author = Console.ReadLine();
            Console.Write("Введіть зміст книги: ");
            string content = Console.ReadLine();

            Book book = new Book(title);

            book.Author = author;
            book.Content = content;

            book.Show();
            Console.ReadKey();
        }
    }
}
/*Завдання 2 
Потрібно: Створити клас із ім'ям Rectangle. У тілі класу створити два поля, що описують довжини сторін double side1, side2. Створити власний конструктор Rectangle(double side1, double side2), у тілі якого поля side1 і side2 ініціалізуються значеннями аргументів. Створити два методи, що обчислюють площу прямокутника - double AreaCalculator() та периметр прямокутника - double PerimeterCalculator(). Створити дві властивості double Area та double Perimeter з одним методом доступу get. Написати програму, яка приймає від користувача довжини двох сторін прямокутника і виводить на екран периметр та площу. */

using System.Text;
namespace Rectangle
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Введіть першу довжину сторони прямокутника: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть другу довжину сторони прямокутника: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine($"Площа прямокутника = {rectangle.Area}");
            Console.WriteLine($"Периметр прямокутника = {rectangle.Perimeter}");

            Console.ReadKey();
        }
    }
}
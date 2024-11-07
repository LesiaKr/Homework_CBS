/*Завдання 4 
Потрібно: Створити класи Point та Figure. Клас Point повинен містити два цілих поля і одне рядкове поле. Створити три властивості одним методом доступу get. Створити власний конструктор, у тілі якого проініціалізуйте поля значеннями аргументів. Клас Figure повинен містити конструктори, які приймають від 3 до 5 аргументів типу Point. Створити два методи: double LengthSide(Point A, Point B), що розраховує довжину сторони багатокутника; void PerimeterCalculator(), що розраховує периметр багатокутника. Написати програму, яка виводить на екран назву та периметр багатокутника.*/
using System.Text;
namespace Polygon
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            Point p1 = new Point(10, 15, "A");
            Point p2 = new Point(2, 5, "B");
            Point p3 = new Point(7, 11, "C");
            Point p4 = new Point(5, 4, "D");

            Figure figure = new Figure(p1, p2, p3, p4);
            Console.WriteLine(figure.Name);
            figure.PerimeterCalculator();
            Console.ReadKey();
        }
    }
}
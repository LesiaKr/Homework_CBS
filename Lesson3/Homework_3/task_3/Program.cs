/*Завдання 3 
Потрібно: Створити клас Vehicle. У тілі класу створіть поля: координати та параметри суден (ціна, швидкість, рік випуску). Створіть 3 похідні класи Plane, Саг і Ship. Для класу Plane має бути визначена висота та кількість пасажирів. Для класу Ship – кількість пасажирів та порт приписки. Написати програму, яка виводить на екран інформацію про кожен засіб пересування. */
using System;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Vehicle
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            
            Plane plane = new Plane(49.5033, 24.0156, 2000000, 700, 2001, 4000, 400);
            Ship ship = new Ship(34.0146, 24.0156, 1000000, 400, 2009, 500, "Odessa");
            Car car = new Car(49.5033, 24.0156, 300000, 220, 2024);
 
            Console.WriteLine("Інформація про літак:"); 
            plane.DisplayInfo(); 
            Console.WriteLine(); 
            Console.WriteLine("Інформація про автомобіль:"); 
            car.DisplayInfo(); 
            Console.WriteLine(); 
            Console.WriteLine("Інформація про корабель:"); 
            ship.DisplayInfo();
        
            Console.ReadKey();
        }
    }
}

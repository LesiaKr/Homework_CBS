/*Завдання 3 
Потрібно: Створити клас Vehicle. У тілі класу створіть поля: координати та параметри суден (ціна, швидкість, рік випуску). Створіть 3 похідні класи Plane, Саг і Ship. Для класу Plane має бути визначена висота та кількість пасажирів. Для класу Ship – кількість пасажирів та порт приписки. Написати програму, яка виводить на екран інформацію про кожен засіб пересування. */
using System;
using System.Diagnostics;
using System.Text;

namespace Vehicle
{
    class Plane : Vehicle
    {
        public double Height { get; set; }
        public int NumberPassengers { get; set; }
        
        public Plane(double latitude, double longitude, int price, int speed, int year, double height, int numberPassengers)
            :base(latitude, longitude, price, speed, year)
        {
            Height = height;
            NumberPassengers = numberPassengers;
        }
        public override void DisplayInfo() 
        { 
            base.DisplayInfo(); 
            Console.WriteLine($"Висота польоту: {Height} м"); 
            Console.WriteLine($"Кількість пасажирів: {NumberPassengers}"); 
        }
    }
}
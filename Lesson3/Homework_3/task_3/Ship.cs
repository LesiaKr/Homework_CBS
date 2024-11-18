/*Завдання 3 
Потрібно: Створити клас Vehicle. У тілі класу створіть поля: координати та параметри суден (ціна, швидкість, рік випуску). Створіть 3 похідні класи Plane, Саг і Ship. Для класу Plane має бути визначена висота та кількість пасажирів. Для класу Ship – кількість пасажирів та порт приписки. Написати програму, яка виводить на екран інформацію про кожен засіб пересування. */
using System;
using System.Diagnostics;
using System.Text;

namespace Vehicle
{
    class Ship : Vehicle
    {
        public int NumberPassengers { get; set; }
        public string NamePort { get; set; }

        public Ship(double latitude, double longitude, int price, int speed, int year, int numberPassengers, string namePort)
            : base(latitude, longitude, price, speed, year)
        {
            NumberPassengers = numberPassengers;
            NamePort = namePort;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            
            Console.WriteLine($"Кількість пасажирів: {NumberPassengers}");
            Console.WriteLine($"Порт: {NamePort}");
        }
    }
}
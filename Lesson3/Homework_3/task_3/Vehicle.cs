/*Завдання 3 
Потрібно: Створити клас Vehicle. У тілі класу створіть поля: координати та параметри суден (ціна, швидкість, рік випуску). Створіть 3 похідні класи Plane, Саг і Ship. Для класу Plane має бути визначена висота та кількість пасажирів. Для класу Ship – кількість пасажирів та порт приписки. Написати програму, яка виводить на екран інформацію про кожен засіб пересування. */
using System;
using System.Diagnostics;
using System.Text;

namespace Vehicle
{
    public class Vehicle
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Price { get; set; }
        public int Speed { get; set; }
        public int Year { get; set; }
        public Vehicle(double latitude, double longitude, int price, int speed, int year)
        {
            Latitude = latitude; 
            Longitude = longitude; 
            Price = price; 
            Speed = speed; 
            Year = year;
        }
        public virtual void DisplayInfo() 
        { 
            Console.WriteLine($"Координати: {Latitude}°N, {Longitude}°E"); 
            Console.WriteLine($"Ціна: ${Price}"); 
            Console.WriteLine($"Швидкість: {Speed} км/год"); 
            Console.WriteLine($"Рік випуску: {Year}"); 
        }
    } 
}

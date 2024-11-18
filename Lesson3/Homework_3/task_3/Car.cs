/*Завдання 3 
Потрібно: Створити клас Vehicle. У тілі класу створіть поля: координати та параметри суден (ціна, швидкість, рік випуску). Створіть 3 похідні класи Plane, Саг і Ship. Для класу Plane має бути визначена висота та кількість пасажирів. Для класу Ship – кількість пасажирів та порт приписки. Написати програму, яка виводить на екран інформацію про кожен засіб пересування. */
using System;
using System.Text;

namespace Vehicle
{
    public class Car : Vehicle
    {
        public Car(double latitude, double longitude, int price, int speed, int year) 
            : base(latitude, longitude, price, speed, year) 
        { }
        public override void DisplayInfo() 
        { 
            base.DisplayInfo(); 
        }
    }
}

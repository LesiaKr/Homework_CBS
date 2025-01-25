/*Завдання 4 
Створіть клас, який містить інформацію про дату (день, місяць, рік). За допомогою механізму перевантаження операторів визначте операцію різниці двох дат (результат у вигляді кількості днів між датами), а також операцію збільшення дати на певне кількість днів. */
using System;
using System.Text;

class Date
{
    private int day;
    private int month;
    private int year;

    public Date(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    public static int operator -(Date d1, Date d2)
    {
        DateTime date1 = new DateTime(d1.year, d1.month, d1.day);
        DateTime date2 = new DateTime(d2.year, d2.month, d2.day);
        return (date1 - date2).Days;
    }

    public static Date operator +(Date d, int days)
    {
        DateTime date = new DateTime(d.year, d.month, d.day);
        date = date.AddDays(days);
        return new Date(date.Day, date.Month, date.Year);
    }

    public override string ToString()
    {
        return string.Format("{0:D2}/{1:D2}/{2}", day, month, year);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Date date1 = new Date(18, 1, 2021);
        Date date2 = new Date(18, 7, 2025);

        int difference = date1 - date2;
        Console.WriteLine("Різниця між датами: " + difference + " днів");

        Date newDate = date2 + 30;
        Console.WriteLine("Нова дата: " + newDate);
    }
}



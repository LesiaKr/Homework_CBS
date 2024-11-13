/*Завдання 6
Потрібно: Створити клас User, що містить інформацію про користувача (логін, ім'я, прізвище, вік, дату заповнення анкети). Поле дата заповнення анкети має бути проініціалізоване лише один раз (при створенні екземпляра цього класу) без можливості його подальшої зміни. Реалізуйте виведення на екран інформації про користувача.*/
using System;
using System.Security.Principal;
using System.Text;

namespace User
{
    class User
    {
        string login;
        string firstName;
        string lastName;
        int age;
        public readonly string data;
        public User(string login, string firstName, string lastName, int age, string data)
        {
            this.login = login;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.data = data;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"User Info:");
            Console.WriteLine($"Login: {login}");
            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Date of filling: {data}");
        }
    }
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            User user = new User("My_Login", "Lesia", "Kirat", 33, "12.11.2024");
            user.PrintInfo();
        }
    }
}
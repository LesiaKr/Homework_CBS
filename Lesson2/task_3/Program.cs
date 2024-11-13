/*Завдання 3 
Потрібно створити клас Employee. У тілі класу створити користувальницький конструктор, який приймає два рядкові аргументи, та ініціалізує поля, що відповідають прізвищу та імені співробітника. Створити метод, що розраховує оклад співробітника (залежно від посади та стажу) та податковий збір. Написати програму, яка виводить на екран інформацію про співробітника (прізвище, ім'я, посада), оклад та податковий збір. */

using System;
using System.Text;

namespace Employee
{
    class Employee
    {
        public string LastName { get; }
        public string FirstName { get; }
        public string Position { get; set; }
        public int Experience { get; set; }
        public Employee(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;
        }

        public double СalculateSalary()
        {
            double salary = 0;
            double experience;
            switch (Position.ToLower())
            {
                case "junior":
                    salary = 30000;
                    break;
                case "middle":
                    salary = 80000;
                    break;
                case "senior":
                    salary = 130000;
                    break;
                default:
                    salary = 25000;
                    break;
            }
            experience = Experience * 1000;
            return salary + experience;
        }
        public double СalculateTax()
        {
            double salary = СalculateSalary();
            const double taxRate = 0.18; // 18% tax rate
            return salary * taxRate;
        }
    }
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Employee employee = new Employee("Кірат", "Андрій"); 
            employee.Position = "Middle"; 
            employee.Experience = 9;

            double tax = employee.СalculateTax();

            Console.WriteLine("Інформація про працівника:");
            Console.WriteLine($"Прізвище: {employee.LastName}");
            Console.WriteLine($"Ім'я: {employee.FirstName}");
            Console.WriteLine($"Посада: {employee.Position}");
            Console.WriteLine($"Оклад: {employee.СalculateSalary()}грн");
            Console.WriteLine($"Податок: {tax}грн");

            Console.ReadKey();
        }
    }
}
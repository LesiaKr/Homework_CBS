/* Завдання 2 
Потрібно: Описати структуру з ім'ям Train, що містить такі поля: назву пункту призначення, номер поїзда, час відправлення. Написати програму, яка виконує такі дії: введення з клавіатури даних до масиву, що складається з восьми елементів типу Train (записи мають бути впорядковані за номерами поїздів); виведення на екран інформації про поїзд, номер якого введено з клавіатури (якщо таких поїздів немає, вивести відповідне повідомлення).  */
using System;
using System.Text;

namespace Train
{
    struct Train
    {
        public string NameDestination { get; set; }
        public int TrainNumber { get; set; }
        public string DepartureTime { get; set; }

        public Train(string nameDestination, int trainNumber, string departureTime)
        {
            NameDestination = nameDestination;
            TrainNumber = trainNumber;
            DepartureTime = departureTime;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Train[] trains = new Train[2];

            // заповнення масиву
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine($"Введіть дані для поїзда {i + 1}:");

                Console.Write("Назва пункту призначення: ");
                string destination = Console.ReadLine();

                Console.Write("Номер поїзда: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Час відправлення (формат HH:mm): ");
                string time = Console.ReadLine();

                trains[i] = new Train(destination, number, time);
            }

            Array.Sort(trains, (x, y) => x.TrainNumber.CompareTo(y.TrainNumber));

            // пошук
            Console.WriteLine();
            Console.WriteLine("Дані введено!");
            Console.Write("Введіть номер поїзда для пошуку: ");
            int searchNumber = int.Parse(Console.ReadLine());

            bool found = false;
            foreach (Train train in trains)
            {
                if (train.TrainNumber == searchNumber)
                {
                    Console.WriteLine($"Поїзд №{train.TrainNumber} до {train.NameDestination} відправляється о {train.DepartureTime}.");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Поїзд з таким номером не знайдено.");
            }
        }
    }
}

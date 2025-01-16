/*Завдання 2
Потрібно описати структуру з ім'ям Worker, що містить такі поля:
• прізвище та ініціали працівника;
• назва займаної посади;
• рік надходження працювати.
Написати програму, яка виконує такі дії:
• введення з клавіатури даних до масиву, що складається з п'яти елементів типу Worker (записи мають бути впорядковані за абеткою);
• якщо значення року введено не у відповідному форматі видає виняток;
• виведення на екран прізвища працівника, стаж роботи якого перевищує введене значення.*/

using System.Globalization;
using System.Text;

namespace WorkerStruct
{
    struct Worker
    {
        public string LastName;
        public string Position;
        public DateTime YearPosition;
    }

    class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Worker[] workers = new Worker[3];

            for (int i = 0; i < workers.Length; i++)
            {
                try {
                    Console.WriteLine($"Введіть дані для працівника {i + 1}:");
                    Console.Write("Прізвище та ініціали: ");
                    workers[i].LastName = Console.ReadLine();
                    if (string.IsNullOrEmpty(workers[i].LastName))
                        throw new ArgumentException("Прізвище не може бути порожнім.");
                   
                    Console.Write("Посада: ");
                    workers[i].Position = Console.ReadLine();
                    if (string.IsNullOrEmpty(workers[i].Position))
                        throw new ArgumentException("Посада не може бути порожньою.");

                    
                    Console.Write("Рік надходження на посаду (формат день.місяць.рік): ");
                    string dateString = Console.ReadLine();
                    if (!DateTime.TryParseExact(dateString, "dd.MM.yyyy", null, DateTimeStyles.None, out DateTime employmentDate))
                    {
                        throw new FormatException("Невірний формат дати. Використовуйте формат день.місяць.рік.");
                    }
                    workers[i].YearPosition = employmentDate;
                    Console.WriteLine(new string('-', 30));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Помилка вводу: {ex.Message}");
                    i--;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Помилка формату: {ex.Message}");
                    i--;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Невідома помилка: {ex.Message}");
                }
            } 
            Array.Sort(workers, (x, y) => string.Compare(x.LastName, y.LastName));

            Console.WriteLine();
            Console.WriteLine("Дані введено!");

            int workExperience = 3;
            int currentYear = DateTime.Now.Year;

            foreach (Worker worker in workers)
            {
                int yearAsInt = worker.YearPosition.Year;
                int experience = currentYear - yearAsInt;
                if (experience >= workExperience)
                {
                    Console.WriteLine($"Працівнику {worker.LastName} призначена премія за стаж роботи більше 3 років");
                }
            }
        }
    }
}

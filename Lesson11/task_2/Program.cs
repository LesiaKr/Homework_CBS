/*Завдання 2
Створіть клас CarCollection. Реалізуйте у найпростішому наближенні можливість використання екземпляра для створення парку машин. Мінімально необхідний інтерфейс взаємодії з екземпляром повинен включати метод додавання машин з назвою машини і року її випуску, індексатор для отримання значення елемента за вказаним індексом і властивість тільки для читання для отримання загальної кількості елементів. Створіть спосіб видалення всіх машин автопарку.*/

namespace AutoPark
{
    interface ICarCollection
    {
        void AddCar(string name, int year);
        Car this[int index] { get; }
        int Count { get; }
        void Clear();
    }

    public class CarCollection : ICarCollection
    {
        private List<Car> cars = new List<Car>();
        public void AddCar(string name, int year)
        {
            cars.Add(new Car(name, year));
        }

        public Car this[int index]
        {
            get { return cars[index]; }
        }

        public int Count
        {
            get { return cars.Count; }
        }

        public void Clear()
        {
            cars.Clear();
        }
    }

    public class Car
    {
        public string Name { get; }
        public int Year { get; }

        public Car(string name, int year)
        {
            Name = name;
            Year = year;
        }
    }

    class Program
    {
        static void Main()
        {
            CarCollection carCollection = new CarCollection();
            carCollection.AddCar("Nissan", 2021);
            carCollection.AddCar("Honda", 2018);
            carCollection.AddCar("BMW", 2015);
            carCollection.AddCar("Jeep", 2022);
            carCollection.AddCar("Tesla", 2024);

            for (int i = 0; i < carCollection.Count; i++)
            {
                Console.WriteLine($"{carCollection[i].Name} - {carCollection[i].Year}");
            }

            carCollection.Clear();
            Console.WriteLine($"Кількість після видалення: {carCollection.Count}");
        }
    }
}


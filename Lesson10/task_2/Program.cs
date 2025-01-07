/*Завдання 2 
Створіть клас MyList. Реалізуйте у найпростішому наближенні можливість використання його екземпляра аналогічно 
екземпляру класу List. Мінімально необхідний інтерфейс взаємодії з екземпляром повинен включати метод додавання елемента, 
індексатор для отримання значення елемента за вказаним індексом і властивість тільки для читання для отримання загальної 
кількості елементів.*/

using System.Text;

namespace ListElements
{
    public interface IMyList
    {
        int Amount { get; }
        void Add(int item);
        int this[int index] { get; }
    }

    public class MyList : IMyList
    {
        private List<int> _items = new List<int>();

        public int Amount
        {
            get { return _items.Count; }
        }
        //public int Amount => _items.Count;

        public void Add(int item)
        {
            _items.Add(item);
        }

        public int this[int index]
        {
            get { return _items[index]; }
        }
        //public int this[int index] => _items[index];
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            MyList myList = new MyList();
            myList.Add(8);
            myList.Add(12);
            myList.Add(25);
            myList.Add(34);

            Console.WriteLine("Загальна кількість елементів: " + myList.Amount);
            Console.WriteLine("Елемент за індексом 2: " + myList[2]);

            Console.ReadKey();
        }
    }
}
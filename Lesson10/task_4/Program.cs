/*Створіть метод, що розширює: public static T[ ] GetArray(this MyList list) Застосуйте розширюючий метод до екземпляра типу MyList,
* розробленого в домашньому завданні 2 для даного уроку. Виведіть на екран значення елементів масиву, який повернув 
* метод GetArray(), що розширює метод.*/

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
    public static class MyListExtensions
    {
        public static int[] GetArray(this MyList list)
        {
            int[] array = new int[list.Amount];
            for (int i = 0; i < list.Amount; i++)
            {
                array[i] = list[i];
            }
            return array;
        }
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

            int[] array = myList.GetArray();

            Console.WriteLine("Застосування розширюючого методу. Елементи масиву:");
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}

/*Завдання 3 
Створіть клас MyClass і структуру MyStruct, які містять поля public string change. У класі Program створіть два методи: static void ClassTaker(MyClass myClass), який надає полю change екземпляра myClass значення «змінено». static void StruktTaker(MyStruct myStruct), який надає полю change екземпляра myStruct значення «змінено». Продемонструйте різницю у використанні класів та структур, створивши у методі Main() екземпляри структури та класу. Змініть значення полів екземплярів на «не змінено», а потім викличте методи ClassTaker і StruktTaker. Виведіть на екран значення полів екземплярів. Проаналізуйте отримані результати. */
namespace Taker
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.change = "не змінено";

            MyStruct myStruct = new MyStruct();
            myStruct.change = "не змінено";

            Console.WriteLine("myClass: " + myClass.change);
            Console.WriteLine("myStruct: " + myStruct.change);

            MyClass.ClassTaker(myClass);
            //MyStruct.StructTaker(myStruct); // додати ref
            MyStruct myStruct2 = new MyStruct("змінено");

            Console.WriteLine("myClass: " + myClass.change);
            Console.WriteLine("myStruct: " + myStruct2.change);

            // у структурах не можемо передати значення через посилання, тому маємо використовувати поруч з параметром ref
            // або використати користувацький конструктор у структурі для зміни значення
        }
    }
}
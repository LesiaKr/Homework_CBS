using System;
using System.Text;

namespace Classes
{
    class MyClass1
    {
        public MyClass1()
        {
            Console.WriteLine("Створено екземпляр класу MyClass1");
        }
    }

    class MyClass2
    {
        private MyClass1 myObj = null;

        // Цей метод не є фабричним.
        public void Method()
        {
            myObj = new MyClass1();
        }
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            MyClass2 my = new MyClass2();

            my.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}

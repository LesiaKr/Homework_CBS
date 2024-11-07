using System;

// Об'єкт не може приховувати (інкапсулювати) нічого від іншого об'єкта того ж класу.

namespace Classes
{
    class MyClass
    {
        MyClass my = null;

        private void Method()
        {
            Console.WriteLine("Hello");
        }

        public void CallMethod()
        {
            my = new MyClass();

            // private метод видно на екземплярі!
            my.Method();
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass my = new MyClass();
            my.CallMethod();
            //my.Method(); // Неприпустимо.

            // Delay.
            Console.ReadKey();
        }
    }
}

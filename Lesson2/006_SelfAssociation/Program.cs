using System;

// Самоасоціація (self-association).

namespace Classes
{
    class MyClass
    {
        MyClass instance;

        public MyClass()  // StackOverflowException
        {
            Console.WriteLine("Constructor MyClass");

            // Самоасоціація після першої спроби інстанціювання призводить до циклічного інстанціювання.

            instance = new MyClass();
        }
    }

    class Program
    {
        static void Main()
        {
            // Спроба інстанціювання класу MyClass.

            MyClass instance = new MyClass();

            // Delay.
            Console.ReadKey();
        }
    }
}

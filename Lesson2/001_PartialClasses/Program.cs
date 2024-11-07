using System;

// Часткові класи (Partial classes).

namespace Classes
{
    class Program
    {
        static void Main()
        {
            PartialClass instance = new PartialClass();

            instance.MethodFromPart1(); // Метод із першої частини класу PartialClass
            instance.MethodFromPart2(); // Метод із другої частини класу PartialClass.

            // Delay.
            Console.ReadKey();
        }
    }
}

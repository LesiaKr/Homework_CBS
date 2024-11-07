using System;
using System.Text;

// Часткові методи (Partial methods).

namespace Classes
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            PartialClass instance = new PartialClass();

            instance.CallPartialMethod();

            // Delay.
            Console.ReadKey();
        }
    }
}

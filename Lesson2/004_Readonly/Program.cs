using System;
using System.Text;

// readonly - поля лише для читання.

namespace Classes
{
    class Program
    {
        // Поле лише для читання(встановлюється лише конструктором)!
        public readonly string field = "hello";

        // Конструктор.
        public Program()
        {
            field = "Поле лише для читання ";

            field += "!";
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Program program = new Program();

            Console.WriteLine(program.field);

            // Помилка компіляції.
            //program.field = "Спроба запису в полі лише для читання.";

            // Delay.
            Console.ReadKey();
        }
    }
}

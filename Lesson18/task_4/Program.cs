/*Завдання 4 
Створіть власний простір імен MyNamespace з класом MyClass і підключіть його до іншої програми.*/
using System;
using System.Text;
using MyNamespace;

namespace ExternalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            MyClass myClass = new MyClass();
            Console.WriteLine("Виклик MyMethod з класу MyClass у просторі імен MyNamespace");
            myClass.MyMethod(); 

            Console.ReadLine();
        }
    }
}


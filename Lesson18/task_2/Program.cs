/*Завдання 2
Створіть клас із методом позначеним модифікатором доступу public. Доведіть, що до цього методу можна звернутися не тільки з поточного складання, але і з похідного класу зовнішнього складання.*/
using MyNamespace;
using System.Text;

namespace ExternalNamespace
{
    public class DerivedClass : MyClass
    {
        public void CallMyMethod()
        {
            MyMethod();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            DerivedClass derived = new DerivedClass();
            Console.WriteLine("Виклик MyMethod з похідного класу зовнішнього складання:");
            derived.CallMyMethod();

            Console.WriteLine( new string('-', 30));
            MyClass myClass = new MyClass();
            Console.WriteLine("Виклик MyMethod з класу поточного складання:");
            myClass.MyMethod(); 
        }
    }
}


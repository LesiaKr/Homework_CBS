/*Завдання 2 
Потрібно: Створити клас AbstractHandler. У тілі класу створити методи void Open(), void Create(), void Change(), void Save(). Створити похідні класи XMLHandler, TXTHandler, DOCHandler від базового класу AbstractHandler. Написати програму, яка виконуватиме визначення документа і для кожного формату мають бути методи відкриття, створення, редагування, збереження певного формату документа.*/

using System;
using System.Text;

namespace AbstractHandler
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введіть тип документа (XML, TXT, DOC): "); 
            string docType = Console.ReadLine(); 
            AbstractHandler instance; 
            switch (docType.ToUpper()) { 
                case "XML":
                    instance = new XMLHandler(); 
                    break; 
                case "TXT":
                    instance = new TXTHandler(); 
                    break; 
                case "DOC":
                    instance = new DOCHandler(); 
                    break; 
                default: 
                    Console.WriteLine("Невідомий формат документа"); 
                    return; 
            }
            instance.Open();
            instance.Create();
            instance.Change();
            instance.Save();
        }
    }
}
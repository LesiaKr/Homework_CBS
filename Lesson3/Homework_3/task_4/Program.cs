/*Завдання 4 
Потрібно створити клас DocumentWorker. У тілі класу створіть три методи OpenDocument(), EditDocument(), SaveDocument(). У тіло кожного з методів додайте виведення на екран відповідних рядків: "Документ відкритий", "Редагування документа у версії Про", "Збереження документа у версії Про".

Створіть похідний клас ProDocumentWorker. Перевизначте відповідні методи, при перевизначенні методів виводьте наступні рядки: "Документ відредаговано", "Документ збережено у старому форматі, збереження в інших форматах є у версії Експерт".
Створіть похідний клас ExpertDocumentWorker від базового класу ProDocumentWorker. Перевизначте відповідний спосіб. При викликі даного методу необхідно виводити на екран "Документ збережений у новому форматі".
У тілі методу Main() реалізуйте можливість прийому від користувача номер ключа доступу pro і exp. Якщо користувач не вводить ключ, він може користуватися лише безкоштовною версією (створюється екземпляр базового класу), якщо користувач ввів номери ключа доступу pro і exp, то повинен створити екземпляр відповідної версії класу, наведений до базового - DocumentWorker.*/
using System;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace DocumentWorker
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            int keyPro = 1111;
            int keyExp = 0000;
            Console.Write("Введіть номер ключа доступу pro або exp: ");
            int key = Convert.ToInt32(Console.ReadLine());

            DocumentWorker versionDocument;

            if (key == keyPro)
            {
                versionDocument = new ProDocumentWorker();
            }
            else if (key == keyExp)
            {
                versionDocument = new ExpertDocumentWorker();
            }
            else
            {
                versionDocument = new DocumentWorker();
            }

            versionDocument.OpenDocument();
            versionDocument.EditDocument();
            versionDocument.SaveDocument();
            Console.ReadKey();
        }
    }
}


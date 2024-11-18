﻿/*Завдання 4 
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
    public class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void OpenDocument()
        {
            Console.WriteLine("Документ відкритий");
        }
        public override void EditDocument()
        {
            Console.WriteLine("Документ відредаговано");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережений у новому форматі");
        }
    }
}

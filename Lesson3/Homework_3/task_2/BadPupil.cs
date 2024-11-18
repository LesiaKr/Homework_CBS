/* Завдання 2 
Потрібно: Створити клас, який представляє навчальний клас ClassRoom. Створіть клас учень Pupil. У тілі класу створіть методи void Study(), void Read(), void Write(), void Relax(). Створіть 3 похідні класу ExcelentPupil, GoodPupil, BadPupil від класу базового класу Pupil і перевизначте кожен із методів, залежно від успішності учня. Конструктор класу ClassRoom приймає аргументи типу Pupil, клас має складатися із 4 учнів. Передбачте можливість, що користувач може передати 2 або 3 аргументи. Виведіть інформацію про те, як усі учні екземпляра класу ClassRoom вміють вчитися, читати, писати, відпочивати. */
using System;

namespace ClassRoom
{
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Я не люблю вчитися!");
        }
        public override void Read()
        {
            Console.WriteLine("Я  не вмію читати!");
        }
        public override void Write()
        {
            Console.WriteLine("Я не вмію писати!");
        }
    }
}


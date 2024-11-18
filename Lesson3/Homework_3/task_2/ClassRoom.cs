/* Завдання 2 
Потрібно: Створити клас, який представляє навчальний клас ClassRoom. Створіть клас учень Pupil. У тілі класу створіть методи void Study(), void Read(), void Write(), void Relax(). Створіть 3 похідні класу ExcelentPupil, GoodPupil, BadPupil від класу базового класу Pupil і перевизначте кожен із методів, залежно від успішності учня. Конструктор класу ClassRoom приймає аргументи типу Pupil, клас має складатися із 4 учнів. Передбачте можливість, що користувач може передати 2 або 3 аргументи. Виведіть інформацію про те, як усі учні екземпляра класу ClassRoom вміють вчитися, читати, писати, відпочивати. */
using System;

namespace ClassRoom
{
    class ClassRoom
    {
        private Pupil pupil1;
        private Pupil pupil2;
        private Pupil pupil3;
        private Pupil pupil4;
        public ClassRoom(Pupil p1, Pupil p2, Pupil p3 = null, Pupil p4 = null)
        {
            this.pupil1 = p1;
            this.pupil2 = p2;
            this.pupil3 = p3 ?? new Pupil();
            this.pupil4 = p4 ?? new Pupil();
        }
        public void ShowSuccess()
        {
            Console.WriteLine($"Учень 1: ");
            pupil1.Study(); 
            pupil1.Read(); 
            pupil1.Write(); 
            pupil1.Relax();

            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Учень 2: ");
            pupil2.Study(); 
            pupil2.Read(); 
            pupil2.Write();
            pupil2.Relax();

            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Учень 3: ");
            pupil3.Study(); 
            pupil3.Read(); 
            pupil3.Write(); 
            pupil3.Relax();

            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Учень 4: ");
            pupil4.Study(); 
            pupil4.Read(); 
            pupil4.Write(); 
            pupil4.Relax();
        }
    }
}

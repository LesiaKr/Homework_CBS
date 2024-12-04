/*Завдання 3 
Розширте приклад уроку 005_Book, створивши в класі Book вкладений клас Notes, який дозволить зберігати нотатки читача.*/
using System;
using System.Text;

namespace _005_Book
{
    class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("Пошук рядка : " + str);
        }
        public class Notes
        {
            public void ShowNotes(string[] noteOut)
            {
                for (int i = 0; i < noteOut.Length; i++)
                {
                    Console.WriteLine(noteOut[i]);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Book.Notes inst = new Book.Notes();
            Console.WriteLine("Введіть нотатку 1: ");
            string note1 = Console.ReadLine();
            Console.WriteLine("Введіть нотатку 2: ");
            string note2 = Console.ReadLine();
            Console.WriteLine("Введіть нотатку 3: ");
            string note3 = Console.ReadLine();
            Console.WriteLine("Нотатки: ");
            inst.ShowNotes([note1, note2, note3]);
        }
    }
}
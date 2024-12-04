/* Завдання 2 
Потрібно: Створити статичний клас FindAndReplaceManager з методом void FindNext(string str) для пошуку за книгою з прикладу уроку 005_Book. При виклику цього методу проводиться послідовний пошук рядка в книзі. */
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
    }
    static class FindAndReplaceManager
    {
        private static Book book = new Book();
        public static void FindNext(string str)
        {
            book.FindNext(str);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FindAndReplaceManager.FindNext("добрий");
        }
    }
}

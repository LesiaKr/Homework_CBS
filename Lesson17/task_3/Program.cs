/*Завдання 3 
Використовуючи динамічні та анонімні типи даних, створіть Англо-Український словник на 10 слів та виведіть на екран його зміст. */

using System;
using System.Collections;
using System.Security.Claims;
using System.Text;

namespace EngUkrDictionary
{
    class EngUkrDict
    {
        public static IEnumerable Generator()
        {
            yield return new { Key = "table", Value = "стіл" };
            yield return new { Key = "chair", Value = "стілець" };
            yield return new { Key = "bed", Value = "ліжко" };
            yield return new { Key = "wardrobe", Value = "шафа" };
            yield return new { Key = "commode", Value = "комод" };
            yield return new { Key = "mirror", Value = "дзеркало" };
            yield return new { Key = "sofa", Value = "диван" };
            yield return new { Key = "carpet", Value = "килим" };
            yield return new { Key = "curtains", Value = "штори" };
            yield return new { Key = "tulle", Value = "тюль" };
        }
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            foreach (dynamic item in EngUkrDict.Generator())
            {
                Console.WriteLine("{0} = {1}", item.Key, item.Value);
            }
            Console.ReadKey();
        }
    }
}

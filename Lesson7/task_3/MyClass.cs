﻿/* Завдання 3 
Створіть клас MyClass і структуру MyStruct, які містять поля public string change. У класі Program створіть два методи: static void ClassTaker(MyClass myClass), який надає полю change екземпляра myClass значення «змінено». static void StruktTaker(MyStruct myStruct), який надає полю change екземпляра myStruct значення «змінено». Продемонструйте різницю у використанні класів та структур, створивши у методі Main() екземпляри структури та класу. Змініть значення полів екземплярів на «не змінено», а потім викличте методи ClassTaker і StruktTaker. Виведіть на екран значення полів екземплярів. Проаналізуйте отримані результати. */

using System.Security.Cryptography.X509Certificates;

namespace Taker
{
    class MyClass
    {
        public string change;
        public static void ClassTaker(MyClass myClass)
        {
            myClass.change = "змінено";
        }
    }
}
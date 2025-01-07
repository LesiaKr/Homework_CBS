/*Завдання 6
 У колекцію ArrayList, через виклик методу Add додайте елементи структурного та посилального типу, переберіть цю колекцію за допомогою циклу for. З якою проблемою ви зіткнулися?*/

using System;
using System.Collections;

namespace CustomArray
{
    class Program
    {
        static void Main()
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add("Hello"); // string посилального типу
            arrayList.Add(12); // int структурного типу
            arrayList.Add("world");
            arrayList.Add(3.14);

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
        }
        //Колекція ArrayList не забезпечує типову безпеку, оскільки зберігає елементи як object. Це може призвести до помилок часу виконання, коли тип елементу не відповідає очікуванням при використанні.
    }
}

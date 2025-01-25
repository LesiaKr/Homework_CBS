/*Завдання 2
Створіть клас Block із 4 полями сторін, перевизначте в ньому методи: Equals - здатний порівнювати блоки між собою, ToString - повертає інформацію про поля блоку.*/
using System.Drawing;

namespace MyBlock
{
    class Program
    {
        static void Main()
        {
            Block block1 = new Block(10, 12, 11, 15);
            Block block2 = new Block(13, 18, 11, 15);

            Console.WriteLine("block1 == block2 = {0}", block1 == block2);
            Console.WriteLine("block1 != block2 = {0}", block1 != block2);

            Console.ReadKey();
        }
    }
}
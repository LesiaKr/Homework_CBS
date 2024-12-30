/* Завдання 3
Створіть перелік, який містить посади співробітників як імена констант. Надайте кожній константі значення, що задає кількість годин, які повинен відпрацювати співробітник протягом місяця. Створіть клас Accountant з методом bool AskForBonus (Post worker, int hours), що відображатиме давати співробітнику премію. Якщо співробітник відпрацював більше годин на місяць, то йому належить премія.*/
using System.Text;

public enum Post
{
    SeniorManager = 168,
    Guard = 96,
    Manager = 176,
    Economist = 208,
    Engineer = 104
}
public class Accountant
{
    public bool AskForBonus(Post worker, int hours)
    {
        return hours > (int)worker;
    }
}
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Accountant accountant = new Accountant();
        bool isPremium = accountant.AskForBonus(Post.Guard, 100);
        if (isPremium)
        {
            Console.WriteLine("Працівнику належить премія");
        }
        else
        {
            Console.WriteLine("Працівнику не належить премія");
        }
    }
}
/*Завдання 5
Реалізуйте програму, яка прийматиме від користувача дату народження і виводити кількість днів до наступного дня народження.*/

using System.Text;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("Вкажіть дату народження у форматі (дд/мм/рррр): ");
        string input = Console.ReadLine();
        DateTime brth = DateTime.Parse(input);
        DateTime today = DateTime.Now;
        DateTime nextBirthday = new DateTime(today.Year, brth.Month, brth.Day);

        if (nextBirthday.Day < today.Day)
        {
            nextBirthday = nextBirthday.AddYears(1).AddDays(1);
        }
        else if (nextBirthday.Day == today.Day)
        {
            Console.WriteLine("З днем народження!");
            return;
        }

        //Console.WriteLine(today.Date);
        //Console.WriteLine(nextBirthday.Date);
        int left = (nextBirthday - today).Days;
        Console.WriteLine($"До вашого наступного дня народження залишилося {left} днів.");
    }
}

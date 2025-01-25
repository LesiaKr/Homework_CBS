/*Завдання 3
Створіть клас House з двома полями та властивостями. Створіть два методи Clone() та DeepClone(), які виконують поверхневе та глибоке копіювання відповідно. Реалізуйте найпростіший спосіб перевірки.*/

using System.Text;

public class Address
{
    public string Street { get; set; }
}
public class HouseDetails
{
    public int HouseArea { get; set; }
}

public class House
{
    public Address HouseAddress { get; set; }
    public HouseDetails Details { get; set; }

    public House Clone()
    {
        return (House)this.MemberwiseClone();
    }

    public House DeepClone()
    {
        return new House
        {
            HouseAddress = new Address
            {
                Street = this.HouseAddress.Street
            },
            Details = new HouseDetails
            {
                HouseArea = this.Details.HouseArea
            }
        };
    }

    public override string ToString()
    {
        return $"Вулиця: {HouseAddress.Street}, площа будинку: {Details.HouseArea}";
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        House originalHouse = new House
        {
            HouseAddress = new Address { Street = "Перемоги" },
            Details = new HouseDetails { HouseArea = 120 }
        };

        House shallowCopy = originalHouse.Clone();
        House deepCopy = originalHouse.DeepClone();

        Console.WriteLine($"Оригінал: {originalHouse}");
        Console.WriteLine($"Копія поверхнева: {shallowCopy}");
        Console.WriteLine($"Копія глибока: {deepCopy}");
        Console.WriteLine(new string('-', 30));
        
        originalHouse.HouseAddress.Street = "Львівська";
        originalHouse.Details.HouseArea = 90;

        Console.WriteLine("Після зміни оригінал: " + originalHouse);
        Console.WriteLine("Після зміни копія поверхнева: " + shallowCopy);
        Console.WriteLine("Після зміни копія глибока: " + deepCopy);
    }
}


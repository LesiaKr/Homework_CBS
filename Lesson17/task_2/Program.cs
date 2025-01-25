/*Завдання 2
Уявіть, що ви пишете програму для Автостанції і вам необхідно створити просту колекцію автомобілів з такими даними: марка автомобіля, модель, рік випуску, колір. А також другу колекцію з моделлю автомобіля, ім'ям покупця та його номером телефону. Використовуючи найпростіший запит LINQ, виведіть на екран інформацію про покупця одного з автомобілів і повну характеристику придбаної ним моделі.  */
using System;
using System.Text;

namespace AutoStations
{
    public class Auto
    {
        public string Brand {  get; set; }
        public string Model { get; set; }
        public string YearProd { get; set; }    
        public string Color { get; set; } 

    }
    public class Buyer
    {
        public string Model { get; set; }
        public string BuyerName { get; set; }
        public int PhoneNumber { get; set; }
    }
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            var auto = new List<Auto>
            {
                new Auto { Brand = "Mazda", Model = "Model 6", YearProd = "2015", Color = "white"},
                new Auto { Brand = "Tesla", Model = "Model X", YearProd = "2022", Color = "black"},
                new Auto { Brand = "BMW", Model = "Bumer", YearProd = "2019", Color = "red"}
            };
            var buyers = new List<Buyer>
            {
                new Buyer { BuyerName = "Kirov Oleg", Model = "Model X", PhoneNumber = 0987144857},
                new Buyer { BuyerName = "Maniyk Olia", Model = "Bumer", PhoneNumber = 0669144744},
                new Buyer { BuyerName = "Panchuk Lilia", Model = "Model 6", PhoneNumber = 0972354884}
            };

            var query = from car in auto
                        join buyer in buyers
                        on car.Model equals buyer.Model
                        select new
                        {
                            Buyer = buyer.BuyerName,
                            BuyerNumber = buyer.PhoneNumber,
                            ModelAuto = buyer.Model,
                            BrandAuto = car.Brand,
                            Year = car.YearProd,
                            ColorAuto = car.Color
                        };
            foreach (var elem in query)
                Console.WriteLine($"Покупець: {elem.Buyer}, Номер телефону: {elem.BuyerNumber}, Бренд: {elem.BrandAuto}, Модель: {elem.ModelAuto}, Рік випуску: {elem.Year}, Колір: {elem.ColorAuto}");
        }
    }
}
   
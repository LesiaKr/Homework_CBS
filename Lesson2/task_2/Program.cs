/*Завдання 2 
Потрібно: Створити клас Converter. У тілі класу створити користувальницький конструктор, який приймає три речові аргументи, і ініціалізує поля, що відповідають курсу 3-х основних валют, по відношенню до гривні – public Converter (double usd, double eur, double gbt). Написати програму, яка виконуватиме конвертацію з гривні в одну із зазначених валют, також програма повинна проводити конвертацію із зазначених валют у гривню. */
using System;
using System.Text;

namespace Converter
{
    class Converter
    {
        double usd, eur, gbt;

        public Converter(double usd, double eur, double gbt)
        {
            this.usd = usd;
            this.eur = eur;
            this.gbt = gbt;
        }

        public double ConvertCurrency(double amount, string currency, string operation)
        {
            switch (currency.ToLower())
            {
                case "usd":
                    return operation == "buy" ? amount / usd : amount * usd;
                case "eur":
                    return operation == "buy" ? amount / eur : amount * eur;
                case "gbt":
                    return operation == "buy" ? amount / gbt : amount * gbt;
                default:
                    Console.WriteLine("Невідома валюта");
                    return 0.0;
            }
        }  
    }
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.Write("Ви хочете купити гривні чи продати? (введіть 'sell' або 'buy'):");
            string operation = Console.ReadLine().ToLower();

            double usd, eur, gbt;

            if (operation == "buy") // Курс продажу долара, євро, фунта стерлінгів
            {
                usd = 41.65; 
                eur = 44.65; 
                gbt = 54.00; 
            }
            else if (operation == "sell") // Курс купівлі долара, євро, фунта стерлінгів
            {
                usd = 41.20; 
                eur = 44.05; 
                gbt = 52.75; 
            }
            else
            {
                Console.WriteLine("Невідома операція");
                return;
            }

            Converter converter = new Converter(usd, eur, gbt);

            Console.WriteLine("Введіть валюту для конвертації (usd, eur, gbt):"); 
            string currency = Console.ReadLine().ToLower(); 

            Console.Write("Введіть суму, яку хочете перевести: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            double convertedAmount = converter.ConvertCurrency(amount, currency, operation); 
            if (operation == "buy") { 
                Console.WriteLine($"Сума в {currency.ToUpper()}: {convertedAmount}"); 
            }
            else
            {
                Console.WriteLine($"Сума в гривнях: {convertedAmount}");
            }
            Console.ReadKey();
        }
    }
}
/*Завдання 3 
Потрібно: Створіть 2 інтерфейси IPlayable та IRecodable. У кожному з інтерфейсів створіть по 3 методи void Play() / void Pause() / void Stop() та void Record() / void Pause() / void Stop() відповідно. Створіть похідний клас Player від базових інтерфейсів IPlayable та IRecodable. Написати програму, яка виконує програвання та запис.*/
using System;
using System.Text;

namespace PlayerRecod
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            IPlayable playable = new Player();
            IRecodable recodable = new Player();
            Console.WriteLine("Програвання: ");
            playable.Play();
            playable.Pause();
            playable.Stop();

            Console.WriteLine("Запис: ");
            recodable.Record();
            recodable.Pause();
            recodable.Stop();
        }
    }
}
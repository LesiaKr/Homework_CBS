/*Завдання 3 
Потрібно: Створіть 2 інтерфейси IPlayable та IRecodable. У кожному з інтерфейсів створіть по 3 методи void Play() / void Pause() / void Stop() та void Record() / void Pause() / void Stop() відповідно. Створіть похідний клас Player від базових інтерфейсів IPlayable та IRecodable. Написати програму, яка виконує програвання та запис.*/
using System;

namespace PlayerRecod
{
    class Player : IPlayable, IRecodable
    {
        public void Play() {
            Console.WriteLine("Програю. Play");
        }
        void IPlayable.Pause() {
            Console.WriteLine("Пауза. Pause.IPlayable");
        }
        void IPlayable.Stop() {
            Console.WriteLine("Зупинити. Stop.IPlayable");
        }
        public void Record() {
            Console.WriteLine("Записую. Record");
        }
        void IRecodable.Pause() {
            Console.WriteLine("Пауза. Pause.IRecodable");
        }
        void IRecodable.Stop() {
            Console.WriteLine("Зупинити. Stop.IRecodable");
        }
    }
}
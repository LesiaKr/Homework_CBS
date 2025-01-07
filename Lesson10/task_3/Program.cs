/* Завдання 3 
Створіть проект Console Application, де реалізуйте типізований клас "Чарівний мішок". Чарівність полягає в тому, 
що подарунок сам з'являється у мішку та залежить від того, хто намагається відкрити мішок. 
Причому подарунок для однієї істоти може з'явитись лише 1 раз на день. Використовуйте обмеження типу - інтерфейс 
із властивістю, що зберігає тип істоти, яка намагається отримати подарунок із мішка.*/

namespace MagicBag
{
    public interface IIstota
    {
        string IstotaType { get; }
    }

    public class Mavka : IIstota
    {
        public string IstotaType
        {
            get { return "Mavka"; }
        }
    }

    public class Domovik : IIstota
    {
        public string IstotaType
        {
            get { return "Domovik"; }
        }
    }

    public class MagicBag<T> where T : IIstota
    {
        private Dictionary<string, DateTime> lastGiftTime = new Dictionary<string, DateTime>();

        public string GetGift(T istota)
        {
            string istotaType = istota.IstotaType;
            if (lastGiftTime.ContainsKey(istotaType) && lastGiftTime[istotaType].Date == DateTime.Today)
            {
                return $"No more gifts for {istotaType} today!";
            }
            else
            {
                lastGiftTime[istotaType] = DateTime.Now;
                return $"A magical gift appears for {istotaType}!";
            }
        }
    }

    class Program
    {
        static void Main()
        {
            MagicBag<Mavka> mavkaBag = new MagicBag<Mavka>();
            Mavka mavka = new Mavka();
            Console.WriteLine(mavkaBag.GetGift(mavka));

            MagicBag<Domovik> domovikBag = new MagicBag<Domovik>();
            Domovik domovik = new Domovik();
            Console.WriteLine(domovikBag.GetGift(domovik));

            // спробуємо знову отримати подарунок
            Console.WriteLine(mavkaBag.GetGift(mavka));
            Console.WriteLine(domovikBag.GetGift(domovik));
            Console.ReadKey();
        }
    }
}

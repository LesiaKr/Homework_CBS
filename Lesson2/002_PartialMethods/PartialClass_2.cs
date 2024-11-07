using System;

namespace Classes
{
    // Друга частина класу.
    partial class PartialClass
    {
        // Визначення часткового методу. 
        partial void PartialMethod()
        {
            Console.WriteLine("Викликаний частковий метод - PartialMethod()");
        }

        // Виклик часткового методу через метод обгортки.
        public void CallPartialMethod()
        {
            PartialMethod();

            // При виклику нереалізованого часткового методу компілятор його проігнорує
            // і помилки рівня виконання не буде. Див. 26 рядок.
            MyMethod();
        }

        #region Реалізація часткових методів інших частинах класу необов'язкова!

        //partial void MyMethod()
        //{
        //    Console.WriteLine("Реалізація часткових методів в інших частинах класу PartialClass – необов'язкова!"); ;
        //}

        #endregion

    }
}

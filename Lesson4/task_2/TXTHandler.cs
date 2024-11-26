using System;

namespace AbstractHandler
{
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Документ відкрито у TXT форматі");
        }
        public override void Create()
        {
            Console.WriteLine("Документ створено у TXT форматі");
        }
        public override void Change()
        {
            Console.WriteLine("Документ відредаговано у TXT форматі");
        }
        public override void Save()
        {
            Console.WriteLine("Документ збережено у TXT форматі");
        }
    }
}
using System;

namespace AbstractHandler
{
    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Документ відкрито у XML форматі");
        }
        public override void Create()
        {
            Console.WriteLine("Документ створено у XML форматі");
        }
        public override void Change()
        {
            Console.WriteLine("Документ відредаговано у XML форматі");
        }
        public override void Save()
        {
            Console.WriteLine("Документ збережено у XML форматі");
        }
    }
}

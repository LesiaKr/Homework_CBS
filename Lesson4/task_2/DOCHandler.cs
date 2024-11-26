using System;

namespace AbstractHandler
{
    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Документ відкрито у DOC форматі");
        }
        public override void Create()
        {
            Console.WriteLine("Документ створено у DOC форматі");
        }
        public override void Change()
        {
            Console.WriteLine("Документ відредаговано у DOC форматі");
        }
        public override void Save()
        {
            Console.WriteLine("Документ збережено у DOC форматі");
        }
    }
}

namespace Book
{
    class Content
    {
        string content;

        public string ContentText
        {
            private get
            {
                if (content != null)
                    return content;
                else
                    return "Відсутній зміст.";
            }
            set
            {
                content = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Зміст книги: " + ContentText);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
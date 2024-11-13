namespace Book
{
    class Title
    {
        string content;

        public string Content
        {
            private get
            {
                if (content != null)
                    return content;
                else
                    return "Заголовок відсутній.";
            }
            set
            {
                content = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Назва книги: " + Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
namespace Book
{
    class Author
    {
        string content;

        public string Content
        {
            private get
            {
                if (content != null)
                    return content;
                else
                    return "Автор не вказаний.";
            }
            set
            {
                content = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Автор книги: " + Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
using Book;

namespace Book
{
    class Book
    {
        Title title = null;
        Author author = null;
        Content body = null;

        void InitializeDocument()
        {
            this.title = new Title();
            this.author = new Author();
            this.body = new Content();
        }

        public Book(string title)
        {
            InitializeDocument();
            this.title.Content = title;
        }

        public void Show()
        {
            this.title.Show();
            this.author.Show();
            this.body.Show();
        }

        public string Content
        {
            set
            {
                this.body.ContentText = value;
            }
        }

        public string Author
        {
            set
            {
                this.author.Content = value;
            }
        }
    }
}

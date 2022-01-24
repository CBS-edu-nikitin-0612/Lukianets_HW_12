namespace Task2
{
    internal class Book
    {
        private Title _title;
        private Author _author;
        private Content _content;

        public string Author
        {
            set
            {
                _author.Name = value;
            }
        }

        public string Content
        {
            set
            {
                _content.Cntt = value;
            }
        }

        private void InitializeBook()
        {
            _title = new Title();
            _author = new Author();
            _content = new Content();
        }

        public Book(string title)
        {
            InitializeBook();
            _title.Ttl = title;
        }

        public void Show()
        {
            _title.Show();
            _author.Show();
            _content.Show(); // too much info, better to comment
        }
    }
}

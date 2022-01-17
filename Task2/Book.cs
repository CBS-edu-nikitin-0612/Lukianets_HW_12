using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                this._author.Name = value;
            }
        }

        public string Content
        {
            set
            {
                this._content.Cntt = value;
            }
        }

        private void InitializeBook()
        {
            this._title = new Title();
            this._author = new Author();
            this._content = new Content();
        }

        public Book(string title)
        {
            InitializeBook();
            this._title.Ttl = title;
        }

        public void Show()
        {
            this._title.Show();
            this._author.Show();
            this._content.Show(); // too much info, better to comment
        }
    }
}

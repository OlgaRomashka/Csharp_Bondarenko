using System;

namespace L04_Books
{
    public class Reader()
    {
        private string? _rememberNameBook;
        private string? _rememberAuthor;

        public void Read(Book book)
        {
            if (book.NumberPages > 1000 || book.GenreBook == Genre.Horror || book.isRead == true)
            {
                Message = "Не буду читать книгу";
            }
            else
            {
                _rememberNameBook = book.NameBook;

                _rememberAuthor = book.Author;

                Message = book.NameBook + ", " + book.Author + ", эта книга прочитана";

                book.isRead = true;
            }
        }

        public string? Message { get; private set; }
    }
}

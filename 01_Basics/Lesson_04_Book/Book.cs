using System;

namespace L04_Books
{
    public class Book
    {
        public int year;
        public bool isRead;
        public Book(string nameBook, string author, int year, Genre genreBook, int numberPages)
        {
            NameBook = nameBook;
            Author = author;
            this.year = year;
            GenreBook = genreBook;
            NumberPages = numberPages;
        }
        public string NameBook { get; }
        public string Author { get; }
        public Genre GenreBook { get; }
        public int NumberPages { get; }  
    }
}

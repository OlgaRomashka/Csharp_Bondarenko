

namespace Lesson_04_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Snomannen", "Jo Nesbo", 2018, Book.Genre.Horror, 544);
            Book book2 = new Book("It", "Stephen King", 2020, Book.Genre.Fantastic, 1182);
            Book book3 = new Book("Сhocolate", "Joanne Harris", 2016, Book.Genre.Novel, 352);

            Reader reader1 = new Reader();

            reader1.Read(book3);
           
            Console.WriteLine(reader1.Message);
        }     
    }


    public class Book
    {
        public string NameBook { get; }
        public string Author { get;}
        private int _year; 
        public Genre GenreBook { get; }
        public int NumberPages { get; }      
        public bool isRead;

        public Book(string nameBook, string author, int year, Genre genreBook, int numberPages)
        {
            NameBook = nameBook;
            Author = author;
            _year = year;
            GenreBook = genreBook;
            NumberPages = numberPages; 
        }



        public enum Genre
        {
            Detective,
            Novel,
            Fantastic,
            Horror
        }
    }
    public class Reader()
    {
        private string _rememberNameBook;
        private string _rememberAuthor;
        public string Message { get; private set; }
        public void Read(Book book)
        {
            if (book.NumberPages > 1000 || book.GenreBook == Book.Genre.Horror || book.isRead == true)
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
       
    }
}

using System;


namespace Lesson_04_2
{
   
        static void Main(string[] args)
        {
          
        }


        public class Book
        {

            string _name;
            string _Author;
            int _year;
            Genre _GenreBook;
            int _numberPages;
            bool _isRead;

        public Book(string name, string Author, int year, Genre GenreBook, int numberPages, bool isRead)
            {
            _name = name;
            _Author = Author;
            _year = year;
            _GenreBook = GenreBook; ;
            _numberPages = numberPages;
            _isRead =  isRead;

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
               string Read(Book B)
            {
                if(B._numberPages > 1000 ||  )
                {

                }
            }
        } 

        
    }


using System;

namespace L04_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book1 = new Book("Snomannen", "Jo Nesbo", 2018, Genre.Horror, 544);
            var book2 = new Book("It", "Stephen King", 2020, Genre.Fantastic, 1182);
            var book3 = new Book("Сhocolate", "Joanne Harris", 2016, Genre.Novel, 352);

            var reader = new Reader();

            reader.Read(book3);
           
            Console.WriteLine(reader.Message);

            reader.Read(book3);

            Console.WriteLine(reader.Message);
        }     
    }
 
}

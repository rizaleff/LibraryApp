using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    internal class Book
    {
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }

        public Book (string isbn, string title, string author, int publicationYear)
        {
            Isbn = isbn;
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
        }

        public Book()
        {

        }

        public void PrintBookData()
        {
            Console.WriteLine($"ISBN             : {Isbn}");
            Console.WriteLine($"Title            : {Title}");
            Console.WriteLine($"Author           : {Author}");
            Console.WriteLine($"Publication Year : {PublicationYear}");
            Console.WriteLine("-----------------------------------------");
        }
    }
}

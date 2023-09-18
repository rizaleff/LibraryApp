using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string PublicationYear { get; set; }

        public Book (string title, string author, string publicationYear)
        {
            Title = title;
            Author = author;   
            PublicationYear = publicationYear
        }

        public void PrintBookData()
        {
            Console.WriteLine($"Title            : {Title}");
            Console.WriteLine($"Author           : {Author}");
            Console.WriteLine($"Publication Year : {PublicationYear}");
            Console.WriteLine("-----------------------------------------")
        }
    }
}

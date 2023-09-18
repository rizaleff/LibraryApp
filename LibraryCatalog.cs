using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    internal class LibraryCatalog
    {
        public List<Book> books;

        public LibraryCatalog(Book book) 
        {
            books = new List<Book> ();
            books.Add (book);
        }

        public void RemoveBook(Book book)
        {

        }
        public void FindBook(string title)
        {

        }

        public void ListBook()
        {
            Console.WriteLine("============KATALOG BUKU===========");
            foreach (Book book in books) 
            {
               book.PrintBookData();
            }
        }
    }
}

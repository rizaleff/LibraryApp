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

        public LibraryCatalog() 
        {
            books = new List<Book>();
            books.Add(new Book("Biografi Saya", "Rizal Effendi", 2023));
            books.Add(new Book("Obat Malas Dosis Tinggi", "Mahmud Baharuddin", 2019));
        }
        public LibraryCatalog(Book book) 
        {
            books = new List<Book> ();
            books.Add (book);
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
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

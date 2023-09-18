using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    internal class LibraryCatalog
    {
        public List<Book> Books { get; set; }

        public ErrorHandler errorHandler;

        public LibraryCatalog()
        {

            errorHandler = new ErrorHandler();
            Books = new List<Book>();
            Books.Add(new Book("1111", "Biografi Saya", "Rizal Effendi", 2023));
            Books.Add(new Book("2222", "Obat Malas Dosis Tinggi", "Mahmud Baharuddin", 2019));
        }

        public void AddBook(Book book)
        {
            Books.Add (book);
        }
        public void RemoveBook(Book book)
        {
            Books.Remove(book);
        }
        public void FindBook(string title)
        {
            List<Book> booksFound;
            
            errorHandler.FindBookHandler(title, Books, out booksFound);

            if(errorHandler.IsError)
            {
                Console.WriteLine(errorHandler.Message);
            }
            else
            {
                Console.WriteLine("===========Pencarian Buku==========");
                PrintAllBooks(booksFound);
            };

        }

        public void ListBook()
        {
            Console.WriteLine("============KATALOG BUKU===========");
            PrintAllBooks(Books);
        }

        private void PrintAllBooks(List<Book> books)
        {
            foreach (Book book in books)
            {

                book.PrintBookData();
            }
        }
    }
}

using System.Reflection.Metadata;

namespace LibraryApp
{
    internal class LibraryApp
    {
        public static void Main(string[] args)
        {
            LibraryCatalog catalog = new LibraryCatalog();
            ErrorHandler handler = new ErrorHandler();
            Book tempBook = new Book();

            string menuChoice;
            bool isMenuActive = true;
            do
            {
                Console.Clear();
                Console.WriteLine("=================Library App================");
                Console.WriteLine("--------------------Menu--------------------");
                Console.WriteLine("1. Tambah Buku");
                Console.WriteLine("2. Cari Buku");
                Console.WriteLine("3. Katalog Buku");
                Console.WriteLine("4. Exit");

                Console.Write("Pilih Menu: ");
                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Menu Tambah Buku");
                        Console.Write("Masukkan Nomor ISBN      : ");
                        string isbn = Console.ReadLine();
                        Console.Write("Masukkan Judul           : ");
                        string title = Console.ReadLine();
                        Console.Write("Masukkan Author Buku     : ");
                        string author = Console.ReadLine();
                        Console.Write("Masukkan Tahun Publikasi : ");
                        string publicationYearString = Console.ReadLine();
                        tempBook = handler.AddBookHandler(isbn, title, author, publicationYearString, catalog.Books);
                        
                        if(tempBook.Isbn != null)
                        {
                            catalog.AddBook(tempBook);
                            Console.WriteLine("----------------------------");
                            Console.WriteLine(handler.Message);
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("----------------------------");
                            Console.WriteLine(handler.Message);
                            Console.ReadLine();
                        }

                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("-------Cari Berdasarkan Judul Buku-------");
                        Console.Write("Judul Buku: ");
                        string findTitle = Console.ReadLine();
                        catalog.FindBook(findTitle);
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Clear();
                        catalog.ListBook();
                        
                        string subMenuChoice;
                        bool isSubMenuActive = true;

                        do
                        {
                            Console.WriteLine("Pilihan ");
                            Console.WriteLine("1. Hapus Buku");
                            Console.WriteLine("2. Back");
                            Console.Write("Masukkan Pilihan: ");
                            subMenuChoice = Console.ReadLine();
                            switch (subMenuChoice)
                            {
                                case "1":
                                    Console.WriteLine("-------Cari Berdasarkan Judul Buku-------");
                                    Console.Write("Pilih Nomor ISBN buku yang akan dihapus: ");
                                    string inputIsbn = Console.ReadLine();
                                    Book deleteBook = new Book();
                                    deleteBook = handler.RemoveBookHandler(inputIsbn, catalog.Books);
                                    if(deleteBook.Isbn != null)
                                    {
                                        Console.WriteLine("----------------------------");
                                        catalog.RemoveBook(deleteBook);
                                        Console.WriteLine(handler.Message);
                                    }
                                    else
                                    {
                                        Console.WriteLine("----------------------------");
                                        Console.WriteLine(handler.Message);
                                    }
                                    break;
                                case "2":
                                    isSubMenuActive = false;
                                    break;
                                default:
                                    Console.WriteLine("Input Pilihan Tidak Valid!!");
                                    break;

                            }
                        } while (isSubMenuActive);
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Keluar dari Aplikasi");
                        isMenuActive = false;
                        break;
                    default:
                        Console.WriteLine("Menu Tidak Tersedia. Pilih menu 1-5");
                        break;
                }

            } while (isMenuActive);
        }
    }
}
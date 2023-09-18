namespace LibraryApp
{
    internal class LibraryApp
    {
        public static void Main(string[] args)
        {
            LibraryCatalog catalog = new LibraryCatalog();
            string menuChoice;
            bool isMenuActive = true;
            do
            {
                Console.Clear();
                Console.WriteLine("=================Library App================");
                Console.WriteLine("--------------------Menu--------------------");
                Console.WriteLine("1. Tambah Buku");
                Console.WriteLine("2. Hapus Buku");
                Console.WriteLine("3. Cari Buku");
                Console.WriteLine("4. Katalog Buku");
                Console.WriteLine("5. Exit");

                Console.Write("Pilih Menu: ");
                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Menu Tambah Buku");
                        Console.Read();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Hapus Buku");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Cari Buku");
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.Clear();
                        catalog.ListBook();
                        Console.ReadLine();
                        break;
                    case "5":
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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibraryApp
{
    internal class ErrorHandler
    {
        public bool IsError { get; private set; }
        public string Message { get; private set; }

        private static bool isNullOrEmptyOrWhiteSpace(string input)
        {
            return (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input));
        }

        public  bool isDuplicateISBN(string input, List<Book> books)
        {
            books = new List<Book>();

            foreach (Book book in books) 
            {
                if (book.Isbn.Equals(input))
                {
                    return true;
                }
            }
            return false;
        }

        public bool isContainDigit(string input)
        {
            return Regex.IsMatch(input, @"\d");
        }

        public bool isOnlyDigit(string input)
        {
            return Regex.IsMatch(input, @"^\d+$");
        }

        public bool CheckYear(string year)
        {
            if(year.Length == 4)
            {
                if (isOnlyDigit(year))
                {
                    return true;
                }
            }
            return false;
        }

        public Book AddBookHandler(string isbn, string title, string author, string publicationYearString, List<Book> books)
        {
            
            if (!isNullOrEmptyOrWhiteSpace(isbn) && !isNullOrEmptyOrWhiteSpace(title) 
                && !isNullOrEmptyOrWhiteSpace(author) && !isNullOrEmptyOrWhiteSpace(publicationYearString))
            {
                if (isOnlyDigit(isbn))
                {
                    if(!isDuplicateISBN(isbn, books))
                    {
                        if (!isContainDigit(author))
                        {
                            if (CheckYear(publicationYearString))
                            {
                                int year = Convert.ToInt32(publicationYearString);
                                Message = "Data Berhasil Di Masukkan";
                                return new Book(isbn, title, author, year); 
                            }
                            else
                            {
                                Message = "Input Tahun   Tidak Valid";
                            }
                        }
                        else
                        {
                            Message = "Gagal! Nama Author Hanya Boleh Terdiri Oleh Huruf!!";
                        }
                    }
                    else
                    {
                        Message = "Gagal! Nomor ISBN Sudah Ada di Sistem";
                    }
                }
                else
                {
                    Message = "Nomor ISBN Harus Berupa Angka!!";
                }
            }
            else
            {
                Message = "Input tidak valid! Semua input harus diisi!!";
            }
            return new Book();
        }
        

        public void RemoveBookHandler(Book book)
        {
            if (!isNullOrEmptyOrWhiteSpace(book.Isbn))
            {

            }
        }

        public void FindBookHandler(string inputTitle, List<Book> books, out List<Book> booksFound)
        {
            booksFound = new List<Book>();

            booksFound = books.Where(book => book.Title.Contains(inputTitle, StringComparison.OrdinalIgnoreCase)).ToList();
            
            if (booksFound.Count > 0)
            {
                IsError = false;
                Message = "Sukses";
            }
            else
            {
                IsError = true;
                Message = "Judul buku tidak ditemukan!!!";
            }
        }

    }
}

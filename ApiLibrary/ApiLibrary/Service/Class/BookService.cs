using System;
using System.Collections.Generic;
using ApiLibrary.Models;
using ApiLibrary.Repository.Interface;
using ApiLibrary.Service.Interface;

namespace ApiLibrary.Service.Class
{
    public class BookService : IBookService
    {
        private readonly IBookRepository bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public bool Update(Book book)
        {
            bookRepository.Update(book);
            return true;

        }

        public bool AddBook(Book book)
        {
            if (bookRepository.FindByCode(book.Code) == null)
            {
                bookRepository.Add(book);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Book> ListAllBooks()
        {
            return bookRepository.ListBooks();
        }
    }
}


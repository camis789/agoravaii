﻿using ApiLibrary.Models;
using System;
using System.Collections.Generic;

namespace ApiLibrary.Service.Interface
{
    public interface IBookService
    {
        bool AddBook(Book book);
        bool Update(Book book);

        List<Book> ListAllBooks();

    }
}

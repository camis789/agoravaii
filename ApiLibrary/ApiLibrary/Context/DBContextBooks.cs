﻿using System;
using ApiLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiLibrary.Context
{
    public class DbContextBooks : DbContext
    {
    public DbSet<User> Users { get; set; }
    public DbSet<Book> Books { get; set; }

        public DbContextBooks(DbContextOptions<DbContextBooks> options) : base(options)
        {

        }
    }
}


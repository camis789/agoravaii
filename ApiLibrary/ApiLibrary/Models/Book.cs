﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ApiLibrary.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Editora { get; set; }
        public string Autor { get; set; }
        public string Location { get; set; }
        public string Pages { get; set; }
        public int Code { get; set; }
        public DateTime DateCreate { get; set; }

        public Category category { get; set; }
   
    }

    public enum Category
    {
        Romance,
            Ficcao,
            Historia,
            AutoAjuda,

    }

}


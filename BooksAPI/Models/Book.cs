﻿using System;
using System.Collections.Generic;

namespace BooksAPI.Models
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int? NumberOfPage { get; set; }
        public DateTime? PublishedAt { get; set; }
    }
}

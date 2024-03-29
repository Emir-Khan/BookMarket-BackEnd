﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class BookDetailDto:IDto
    {
        public int BookId { get; set; }
        public int WriterId { get; set; }
        public int CategoryId { get; set; }
        public int PublisherId { get; set; }
        public int UnitPrice { get; set; }
        public string BookName { get; set; }
        public string WriterName { get; set; }
        public string CategoryName { get; set; }
        public string PublisherName { get; set; }
    }
}

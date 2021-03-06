﻿using System;
using static Serialization.Catalog;

namespace Serialization
{
    [Serializable]
    public class Book
    {
        public string Id { get; set; }
        public string Isbn { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public string Publisher { get; set; }
        public DateTime PublishDate { get; set; }
        public string Description { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
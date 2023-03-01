using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Publisher { get; private set; }
        public int NumberOfPages{get; private set;}
        public Book(string title, string author, string publisher, int number_of_pages)
        {
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.NumberOfPages = number_of_pages;
        }

        public override string ToString()
        {
            return this.Title + '\n' + this.Author + '\n' + this.Publisher + '\n' + this.NumberOfPages + '\n';
        }
    }
}

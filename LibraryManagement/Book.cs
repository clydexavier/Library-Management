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
        public bool IsBorrowed { get; set; }
        public DateTime Borrowed { get;  set; }  
        public int NumberOfDaysBorrowed { get; set; }
        public DateTime Returned { get;  set; }
        public Book(string title, string author, string publisher, int number_of_pages)
        {
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.Borrowed = default(DateTime);
            this.NumberOfDaysBorrowed = 0;
            this.Returned = default(DateTime);
            this.IsBorrowed = false;
            
        }

        public override string ToString()
        {
            return this.Title + '\n' + this.Author + '\n' + this.Publisher + '\n';
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Staff
    {
        public string Name { get; private set; }
        public string Email {get; private set;} 
        public string Position { get; private set;}
        public Staff(string name, string email, string position) 
        {
            this.Name = name;
            this.Email = email; 
            this.Position = position;
        }
        
        public void ArrangeBooks(Library library)
        {
            library.Books.Sort((b1, b2) => b1.Title.CompareTo(b2.Title));
        }

        public override string ToString()
        {
            return this.Name + '\n' + this.Email + '\n' + this.Position+ '\n';
        }
    }
}

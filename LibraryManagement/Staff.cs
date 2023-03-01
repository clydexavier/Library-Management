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

        public override string ToString()
        {
            return this.Name + '\n' + this.Email + '\n' + this.Position+ '\n';
        }
    }
}

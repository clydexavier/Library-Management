using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Member
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Address { get; set; }
        public int PenaltyPoints { get; set; } 

        public Member(string name, string email, string phoneNumber, string address)
        {
            this.Name = name;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            this.PenaltyPoints = 0;
        }
        public override string ToString()
        {
            return this.Name + '\n' + this.Email + '\n' + this.PhoneNumber + '\n' + this.Address + '\n';
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Library
    {
        public List<Book> Books { get; private set; }
        public List<Staff> Staffs { get; private set; }
        public List<Member> Members { get; private set; }
        public string Name {get; private set; }
        public string Address {get; private set;}
        public DateTime OpeningHours { get; private set;}
        private int MaxBookCapacity;
        private int CurrentBookCount;
        private int MaxStaffCapacity;
        private int CurrentStaffCount;
        private int MaxMemberCapacity;
        private int CurrrentMemberCount;
        public Library(string name, string address, DateTime opening_hours, int max_book_capacity, int max_staff_capacity, int max_member_capacity) 
        {
            this.Name = name;    
            this.Address = address;
            this.OpeningHours = opening_hours;
            this.MaxBookCapacity = max_book_capacity;
            this.MaxMemberCapacity = max_staff_capacity;
            this.MaxStaffCapacity = max_staff_capacity;
            this.Books= new List<Book>();
            this.Staffs = new List<Staff>();
            this.Members= new List<Member>();
            this.CurrentStaffCount= 0;
            this.CurrrentMemberCount = 0;
            this.CurrrentMemberCount = 0;
        }
        
        public bool AddBook(Book book)
        {
            if(this.CurrentBookCount < this.MaxBookCapacity)
            {
                Books.Add(book);
                return true;
            }
            return false;

        }
        public bool RemoveBook(Book book) 
        {
            if(this.CurrentBookCount > 0)
            {
                 Books.Remove(book);
                return true;
            }
            return false;
        }

        public bool AddStaff(Staff staff)
        {
            if(this.CurrentStaffCount < this.MaxStaffCapacity)
            {
                Staffs.Add(staff);
                return true;
            }
            return false;
        }

        public bool RemoveStaff(Staff staff) 
        {
            if(this.Staffs.Count > 0) 
            {
                Staffs.Remove(staff);
                return true;
            }
            return false;
        }

        public bool AddMember(Member member)
        {
            if(this.CurrrentMemberCount < this.MaxMemberCapacity) 
            {
                Members.Add(member);
                return true;
            }
            return false;
        }

        public bool RemoveMember(Member member) 
        {
            if(this.CurrrentMemberCount > 0)
            {
                Members.Remove(member); 
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return this.Name + '\n' + this.Address + '\n' + this.OpeningHours + '\n';
        }
    }
}

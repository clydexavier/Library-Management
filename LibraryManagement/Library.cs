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
        //private int CurrentBookCount;
        private int MaxStaffCapacity;
        //private int CurrentStaffCount;
        private int MaxMemberCapacity;
        //private int CurrrentMemberCount;
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
        }
        
        public bool BorrowBook(Book book, Member member, int number_of_days)
        {
            //you can borrow a book 1 - 7 days
            //you must have <= 10 penalty points to borrow 
            if (this.Members.Contains(member) && this.Books.Contains(book) && member.PenaltyPoints <= 10 && number_of_days >= 1 && number_of_days <= 7)
            {
                book.NumberOfDaysBorrowed = number_of_days;
                book.Borrowed = DateTime.Now;
                book.IsBorrowed = true;
                this.RemoveBook(book);
                return true;
            }
            return false;
        }

        public bool ReturnBook(Book book, Member member)
        {
            if(book.IsBorrowed && this.Members.Contains(member))
            {
                book.Returned = DateTime.Now;
                if(book.Borrowed.AddDays(book.NumberOfDaysBorrowed) >= book.Returned) // returned on time
                {
                    Books.Add(book);
                    book.IsBorrowed = false;
                    book.Borrowed = default(DateTime);
                    book.Returned = default(DateTime);
                    book.NumberOfDaysBorrowed = 0;
                    member.PenaltyPoints = (member.PenaltyPoints > 0) ? --member.PenaltyPoints : 0;
                    return true;
                }
                else //returned late,  add penalty points equivalent to number of days late + 1
                {
                    TimeSpan interval = book.Returned.Subtract(book.Borrowed);
                    int elapsed = (interval.Days);
                    Books.Add(book);
                    book.IsBorrowed = false;
                    book.Borrowed = default(DateTime);
                    book.Returned = default(DateTime);
                    book.NumberOfDaysBorrowed = 0;

                    member.PenaltyPoints += (elapsed + 1);
                    if(member.PenaltyPoints >= 10) 
                    {
                        Members.Remove(member); //banned lol
                    }
                    return true;
                } 
            }
            return false;
        }

        public void ArrangeBooks(Staff staff)
        {
            if(this.Staffs.Contains(staff) && this.Books.Count > 1) 
            {
                this.Books.Sort((b1, b2) => b1.Title.CompareTo(b2.Title));
            }
        }
        public bool AddBook(Book book)
        {
            if(this.Books.Count < this.MaxBookCapacity)
            {
                Books.Add(book);
                return true;
            }
            return false;
        }
        public bool RemoveBook(Book book) 
        {
            if(this.Books.Count > 0 && this.Books.Contains(book))
            {
                Books.Remove(book);
                return true;
            }
            return false;
        }
        public bool AddStaff(Staff staff)
        {
            if(this.Staffs.Count < this.MaxStaffCapacity)
            {
                Staffs.Add(staff);
                return true;
            }
            return false;
        }
        public bool RemoveStaff(Staff staff) 
        {
            if(this.Staffs.Count > 0 && this.Staffs.Contains(staff)) 
            {
                Staffs.Remove(staff);
                return true;
            }
            return false;
        }
        public bool AddMember(Member member)
        {
            if(this.Members.Count < this.MaxMemberCapacity) 
            {
                Members.Add(member);
                return true;
            }
            return false;
        }
        public bool RemoveMember(Member member) 
        {
            if(this.Members.Count > 0 && this.Members.Contains(member))
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

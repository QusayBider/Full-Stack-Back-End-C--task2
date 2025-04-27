using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taske2
{
    internal class Library
    {
        public Library() {
            Books = new List<Book>();
            Members = new List<Person>();
        }
        public Library(List<Book> books, List<Person> members)
        {
            this.Books = books;
            Members = members;
        }

        public List<Book> Books { get; set; }
        public List<Person> Members { get; set; }

        public void AddBook(Book book) { 
            Books.Add(book);
            Console.WriteLine($"Book '{book.Title}' added to the library.");
        }
        public void AddMember(Person member) { 
        
            Members.Add(member);
            Console.WriteLine($"Member '{member.Name}' added to the library.");


        }

        public Book FindBookById(int id)
        {
            return Books.Find(b => b.Id == id);
        }
        public Person FindMemberById(int id) { 
        return Members.Find(m => m.Id == id);
        }

        public void DisplayAllBooks() {
            Console.WriteLine("\nAll Books :");
            foreach (var book in Books) { 
            book.DisplayInfo();
            }
        }
        public void DisplayAllMembers() { 
        Console.WriteLine("\nAll embers:");
            foreach (var member in Members)
            {
                member.DispalyInfo();
            }
        }

    }
}

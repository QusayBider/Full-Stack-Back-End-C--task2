using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taske2
{
    internal class Member : Person
    {
        public Member(int id,string name):base(id,name)
        {
        BorrowedBooks = new List<Book>();
        }

        public List<Book> BorrowedBooks { get; private set; }
        public override void DispalyInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}");
        }

        public void BorrowBook(Book book)
        {
            if (book != null && book.IsAvailable)
            {
                BorrowedBooks.Add(book);
                book.IsAvailable = false;
                Console.WriteLine($"Book '{book.Title}' borrowed successfully.");

            }
            else
            {
                Console.WriteLine("Book is not available.");

            }
        }
            public void ReturnBook(Book book)
             {
            if (BorrowedBooks.Contains(book))
            {
                BorrowedBooks.Remove(book);
                book.IsAvailable = true;
                Console.WriteLine($"Book '{book.Title}' returned successfully.");
            }
            else
            {
                Console.WriteLine("You did not borrow this book.");
            }
             }

        public void DisplayBorrowedBooks()
        {
            Console.WriteLine($"\nBorrowed Books for {Name}:");
            if (BorrowedBooks.Count == 0)
            {
                Console.WriteLine("No books borrowed.");
            }
            else
            {
                foreach (var book in BorrowedBooks)
                {
                    Console.WriteLine($"- {book.Title} by {book.AuthorName}");
                }
            }
        }

    
    }
}

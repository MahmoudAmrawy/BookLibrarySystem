using BookLibrarySystem.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookLibrarySystem.Models
{
    internal class BookAction : IBookAction
    {
        private readonly Member member;

        public BookAction(Member member)
        {
            this.member = member;
        }
        public void BorrowBook(Library library, string title)
        {
            Book book = library.FindBook(title);

            if (book.IsAvailable && book != null)
            {
                book.IsAvailable = false;
                library.Books.Add(book);
                Console.WriteLine($"The Book Name : {book.Title} By Author: {book.Author} And Name Borrow : {member.UserName}");
            }
            else
            {
                Console.WriteLine($"Sorry The Book Name : {book.Title} Is Currently Unavailable");
            }
        }
        public void ReturnBook(Library library, string title)
        {
            Book book = library.Books.Find(x => x.Title == title);

            if (book != null)
            {
                book.IsAvailable = true;
                library.Books.Remove(book);
                Console.WriteLine($"UserName Borrow :{member.UserName} Returned Book Name {book.Title} By Author {book.Author}.");
            }
            else
            {
                Console.WriteLine($"{member.UserName} does not have \"{title}\" borrowed.");
            }
        }
    }
}

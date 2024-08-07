using BookLibrarySystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrarySystem.Models
{
    internal class Library : ILibrary
    {
        public Library()
        {
            Books = new List<Book>();
            Members = new List<Member>();
        }
        public List<Book> Books { get; set; }
        public List<Member> Members { get; set; }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void RegisterMember(Member member)
        {
            Members.Add(member);
        }

        public Book FindBook(string title)
        {
            return Books.Find(p => p.Title == title);
        }
    }
}

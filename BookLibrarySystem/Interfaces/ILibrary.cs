using BookLibrarySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrarySystem.Interfaces
{
    internal interface ILibrary
    {
        void AddBook(Book book);
        void RegisterMember(Member member);
        Book FindBook(string title);
    }
}

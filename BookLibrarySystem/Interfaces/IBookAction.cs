using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrarySystem.Models.Interfaces
{
    internal interface IBookAction
    {
        void BorrowBook(Library library, string title);
        void ReturnBook(Library library, string title);
    }
}

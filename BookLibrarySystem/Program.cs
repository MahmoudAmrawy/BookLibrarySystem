using BookLibrarySystem.Models;

namespace BookLibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Book();
            p.SetTitle("Learn With C-Sharp");
            p.SetAuthor("mahmoud amrawy");


            Library library = new Library();
            //library.AddBook(new Book("Learn With C-Sharp", "mahmoud amrawy"));
            library.AddBook(p);

            Member member = new Member();
            member.SetUsername("ahmed");

            library.RegisterMember(member);

            BookAction bookAction = new BookAction(member);

            bookAction.BorrowBook(library, p.Title);
            bookAction.ReturnBook(library, p.Title);


        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrarySystem.Models
{
    internal class Book
    {
        public Book()
        {
            
        }
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
        public string Title { get; private set; }

        public void SetTitle(string title) 
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("The Title Is Requirment");
            else
            Title = title; 
        }
        public string Author { get; set; }
        public void SetAuthor(string author)
        {
            if (string.IsNullOrWhiteSpace(author))
                throw new ArgumentException("The Author Is Requirment");
            else
                Author = author;
        }
        public bool IsAvailable { get; set; } = true;
    }
}

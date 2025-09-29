using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library
{
    public class Librarian : User
    {
        public override void DisplayRole()
        {
            Debug.WriteLine($"{Name} is a Librarian");
        }
        public void AddBook(List<Book> books, Book newBook)
        {
            books.Add(newBook);
        }
        public void RemoveBook(List<Book> books, Book bookToRemove)
        {
            books.Remove(bookToRemove);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Library
{
    public class Book : IBorrowable
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public bool IsAvailable { get; set; } = true;
        public override string ToString() => $"{Title} by {Author}";

        public override bool Equals(object? obj)
        {
            if (obj is Book other)
            {
                return Title == other.Title && Author == other.Author;
            }
            return false;
        }

        public override int GetHashCode() => (Title + Author).GetHashCode();

        public static bool operator ==(Book a, Book b) => a.Equals(b);
        public static bool operator !=(Book a, Book b) => !a.Equals(b);

        public void Borrow(User user)
        {
            if (!IsAvailable)
            {
                Debug.WriteLine($"{Title} is already borrowed.");
                return;
            }

            IsAvailable = false;
            Debug.WriteLine($"{user.Name} has borrowed {Title}.");
        }

        public void Return(User user)
        {
            IsAvailable = true;
            Debug.WriteLine($"{user.Name} has returned {Title}.");
        }

        public void Borrow()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
        public void Return()
        {
            if (IsAvailable)
            {
                IsAvailable = true;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}    

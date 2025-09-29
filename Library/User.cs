using System.Diagnostics;

namespace Library
{
    public abstract class User
    {
        public string? Name { get; set; }
        public int UserId { get; set; }
        public string? Role { get; set; }
        public abstract void DisplayRole();
    }
}

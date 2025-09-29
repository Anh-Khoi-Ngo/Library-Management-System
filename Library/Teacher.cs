using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library
{
    public class Teacher : User
    {
        public int BorrowLimit { get; set; } = 10;
        public override void DisplayRole()
        {
            Debug.WriteLine($"{Name} is a Teacher");
        }
    }
}

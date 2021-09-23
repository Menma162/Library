using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    class Books
    {
        public string name { get; set; }
        public string author { get; set; }
        public int pages { get; set; }
        
        public Books(string Name, string Author, int Pages)
        {
            Add(Name, Author, Pages);
        }

        public void Add(string Name, string Author, int Pages)
        {
            name = Name;
            author = Author;
            pages = Pages;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    class Books
    {

        public string name { get; set; } //название книги
        public string author { get; set; } //автор книги
        public int pages { get; set; } // число страниц

        
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

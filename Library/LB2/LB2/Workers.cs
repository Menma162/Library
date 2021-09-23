using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    class Workers
    {
        public string Name { get; set; }
        public string Birthday { get; set; }
        public string Post { get; set; }

        public void Add(string Name, string Birthday, string Post)
        {
            this.Name = Name;
            this.Birthday = Birthday;
            this.Post = Post;
        }

        public Workers(string Name, string Birthday, string Post)
        {
            Add(Name, Birthday, Post);
        }

    }
}

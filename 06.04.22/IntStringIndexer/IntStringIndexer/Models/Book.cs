using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntStringIndexer.Models
{
    class Book
    {
        private static int _idCounter;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime CreatedDate { get; set; }

        static Book()
        {
            _idCounter = 0;
        }

        public Book()
        {
            Id = ++_idCounter;
            CreatedDate = DateTime.Now;
        }
        public Book(string name, string author) : this()
        {
            Name = name;
            Author = author;
        }

        public override string ToString()
        {
            return $"Book name: {Name} by {Author}";
        }
    }
}

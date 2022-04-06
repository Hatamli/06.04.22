using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntStringIndexer.Models
{
    class Library
    {
        private static int _idCounter;
        private static Book[] _books;
        public Book this[int index]
        {
            get
            {
                if (index < _books.Length && index >= 0)
                {
                    return _books[index];
                }

                throw new Exception("Test Exception");
               
            }
            set
            {
                _books[index] = value;
            }
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Length { get => _books.Length; }

        static Library()
        {
            _idCounter = 0;
          
        }

        private Library()
        {
            Id = ++_idCounter;
            CreatedDate = DateTime.Now;
            _books = new Book[0];
        }

        public Library(string name)
        {
            Name = name;
        }

        public void AddBook(Book book)
        {
            Book[] newArray = BookArrayResize(_books, _books.Length - 1);
            newArray[^1] = book;
            _books = newArray;
        }
        
        private static Book[] BookArrayResize(Book[] array, int newLength)
        {
            int loopCount = 0;
            loopCount = newLength > _books.Length ? array.Length : newLength;
            Book[] books = new Book[newLength];

            for (int i = 0; i < loopCount; i++)
            {
                books[i] = array[i];
            }

            return books;
        }
    }
}

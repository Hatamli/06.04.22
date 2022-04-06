using IntStringIndexer.Models;
using System;

namespace IntStringIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Book lotr = new Book("LOTR", "J. R. Talkien");
            Book hp = new Book("HP", "J. K. Rowling");

            Library akhundov = new Library("Akhundov");

            akhundov.AddBook(lotr);
            akhundov.AddBook(hp);

            for (int i = 0; i < akhundov.Length; i++)
            {
                Console.WriteLine(akhundov[i].ToString());
            }

        }
    }
}

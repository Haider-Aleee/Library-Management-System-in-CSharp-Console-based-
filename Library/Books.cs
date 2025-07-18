using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Books
    {
        public int Id;
        public string Title;
        public string Author;
        public int ISBN;
        public string Genre;
        int TotalCopies;
        int AvailableCopies;

        public Books(int id, string title, string author, int isbn, string genre, int totalCopies, int availableCopies)
        {
            Id = id;
            Title = title;
            Author = author;
            ISBN = isbn;
            Genre = genre;
            TotalCopies = totalCopies;
            AvailableCopies = availableCopies;
        }
    }
}

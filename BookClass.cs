using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BokSystem
{
    public class BookClass
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Isbn { get; set; }

        public BookClass(string title, string author, int isbn)
        {
            Title = title;
            Author = author;
            Isbn = isbn;
        }

        public void WriteBookInfo()
        {
            Console.WriteLine($"Titel: {Title}, Författare: {Author}, ISBN-nummber: {Isbn}");
        }
    }
}

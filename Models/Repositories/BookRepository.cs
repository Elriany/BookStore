using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStores.Models.Repositories
{
    public class BookRepository : IRepository<Book>
    {
        static List<Book> books = new List<Book>() {
               new Book(){ID=1,Name="C Programming",Description="No Description"},
               new Book(){ID=2,Name="C++ Programming",Description="No Description"},
               new Book(){ID=3,Name="C# Programming",Description="No Description"},
               new Book(){ID=4,Name="Java Programming",Description="No Description"}
        };
        public void Add(Book b)
        {
            books.Add(b);
        }

        public void Delete(int id)
        {
            var book = Find(id);
            books.Remove(book);
        }

        public Book Find(int id)
        {
            var book = books.SingleOrDefault(b=>b.ID==id);
            if (book == null)
                return null;
            return book;
        }

        public IList<Book> List()
        {
            if(books.Count > 0)
                return books;
            return null;
        }

        public void Update(Book newBook,int id)
        {
            var book = Find(id);
            book.Name = newBook.Name;
            book.Description = newBook.Description;
            book.Author = newBook.Author;
        }
    }
}

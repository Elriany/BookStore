using BookStores.Models;
using BookStores.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStores.Models.Repositories
{
    public class AuthorRepository : IRepository<Author>

    {
        static List<Author> authors = new List<Author>() {
               new Author(){ID=1,FullName="Muhammad Ahmad"},
               new Author(){ID=2,FullName="Ali Hassan"},
               new Author(){ID=3,FullName="Ahmad Magdy"},
               new Author(){ID=4,FullName="Hossam Rady"}
        };

        public void Add(Author a)
        {
            authors.Add(a);
        }

        public void Delete(int id)
        {
            var author = Find(id);
            authors.Remove(author);
        }

        public Author Find(int id)
        {
            var author = authors.SingleOrDefault(a => a.ID == id);
            return author;
        }

        public IList<Author> List()
        {
            return authors;
        }

        public void Update(Author newAuthor, int id)
        {
            var author = Find(id);
            author.FullName = newAuthor.FullName;

        }
    }
}

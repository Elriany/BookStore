using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStores.Models.Repositories
{
    public interface IRepository<T>
    {
        IList<T> List();
        T Find(int id);
        void Add(T t);
        void Update(T t,int id);
        void Delete(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CodeSquirl.System
{
    public interface IRepository<T> where T : class
    {
        bool Add(T entity);
        void AddRange(IEnumerable<T> entities);
        bool Remove(T entiy);
        IList<T> GetAll();
        bool Update(T entity);
    }
}
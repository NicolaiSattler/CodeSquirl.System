using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace CodeSquirrel.System
{
    public interface IRepository<T> where T : class
    {
        bool Add(T entity);
        bool AddRange(IEnumerable<T> entities);
        bool Update(T entity);
        bool Remove(Guid uniqueID);
        T GetByID(Guid uniqueID);
        IList<T> Get();
    }
}
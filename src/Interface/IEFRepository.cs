using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CodeSquirl.System
{
    public interface IEFRepository<T> : IRepository<T> where T : class
    {
        void Remove(Func<T, bool> predecate);
        IQueryable Get(Func<T, bool> predicate);
        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken token);
    }
}



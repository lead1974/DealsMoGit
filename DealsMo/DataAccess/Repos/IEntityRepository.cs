using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using DealsMo.DataAccess.Models;

namespace DealsMo.DataAccess.Repos
{
    public interface IEntityRepository<T>:IDisposable
    {
        IQueryable<T> All { get; }
        IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProeprties);
        T Find(int id);

        void insertOrUpdate(T entity);
        void Delete(int id);
        void Save();
    }

    public interface IUserRepository<T> : IEntityRepository<User>
    {

    }
}

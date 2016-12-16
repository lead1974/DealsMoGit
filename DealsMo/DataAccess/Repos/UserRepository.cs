using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

using DealsMo.DataAccess.Models;
using DealsMo.DataAccess.Repos;
using NHibernate.Linq;

namespace DealsMo.DataAccess.Repos
{
    public class UserRepository : IUserRepository<User>
    {
        public IQueryable<User> All
        {
            get
            {
            return Database.Session.Query<User>().AsQueryable();
            }
        }

        public IQueryable<User> AllIncluding(params Expression<Func<User, object>>[] includeProeprties)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public User Find(int id)
        {
            throw new NotImplementedException();
        }

        public void insertOrUpdate(User entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}

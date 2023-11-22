using EEEE_DataAccess.Context;
using EEEE_Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EEEE_DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public T Find(Expression<Func<T, bool>> match, string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public T Find(Expression<Func<T, bool>> match, int take, int skip)
        {
            throw new NotImplementedException();
        }

        public T Find(Expression<Func<T, bool>> match, int? take, int? skip, Expression<Func<T, object>> orderBy = null, string OrderByDirection = "ASC")
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindAll(Expression<Func<T, bool>> match, string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
 
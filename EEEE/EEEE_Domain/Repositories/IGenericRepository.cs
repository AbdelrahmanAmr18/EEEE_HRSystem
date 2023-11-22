using EEEE_DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EEEE_Domain.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);
        Task<T> GetByIdAsync(int id);
        IEnumerable<T> GetAll();
        T Find(Expression<Func<T, bool>> match, string[] includes = null);
        IEnumerable<T> FindAll(Expression<Func<T, bool>> match, string[] includes = null);
        T Find(Expression<Func<T, bool>> match, int take, int skip);
        T Find(Expression<Func<T, bool>> match, int? take, int? skip,
            Expression<Func<T, object>> orderBy = null, string OrderByDirection = "ASC" );

    }

}

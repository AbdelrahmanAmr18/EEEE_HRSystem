
using EEEE_Domain.Models;
using EEEE_Domain.Repositories;
using EEEE_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EEEE_DataAccess.Context;

namespace EEEE_DataAccess.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Employee> Employees { get; }
        IGenericRepository<Company> Companies { get; }
        IGenericRepository<Branch> Branches { get; }
        IGenericRepository<Department> Departments { get; }
        IGenericRepository<Position> Positions { get; }
        IGenericRepository<Level> Levels { get; }
        IGenericRepository<ApplicationUser> Users { get; }


        int Complete();
      Task<int> CompleteAsync();

    }
}

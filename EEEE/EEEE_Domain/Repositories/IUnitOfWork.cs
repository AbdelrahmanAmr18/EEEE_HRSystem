using EEEE_Domain.Models;
using EEEE_Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        int Complete();

    }
}

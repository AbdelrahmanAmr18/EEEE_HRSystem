using EEEE_DataAccess.Context;
using EEEE_Domain.Models;
using EEEE_Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEEE_DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IGenericRepository<Employee> Employees { get; private set; }
        public IGenericRepository<Company> Companies { get; private set; }
        public IGenericRepository<Branch> Branches { get; private set; }
        public IGenericRepository<Department> Departments { get; private set; }
        public IGenericRepository<Position> Positions { get; private set; }
        public IGenericRepository<Level> Levels { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose() 
        {
            _context.Dispose();
        }

    }
}

using EEEE_DataAccess.Context;
using EEEE_Domain.Models;
using EEEE_Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Microsoft.VisualBasic;
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
        public IGenericRepository<Excuses> Excuses { get; private set; }


        public IGenericRepository<ApplicationUser> Users { get; private set; }

        //public IGenericRepository<ApplicationUser> Users { get; private set; }

        //IGenericRepository<HRsystem_DataAccess.Context.ApplicationUser> IUnitOfWork.Users => throw new NotImplementedException();

        /*IGenericRepository<HRsystem_DataAccess.Context.ApplicationUser> IUnitOfWork.Users => throw new NotImplementedException()*/

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;

            Users = new GenericRepository<ApplicationUser>(_context);
            Employees = new GenericRepository<Employee>(_context);
            Excuses= new GenericRepository<Excuses>(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }
        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();

        }
        public void Dispose()
        {
            _context.Dispose();
        }


    }
}

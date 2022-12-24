using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Entities;
using Web.Core.Interfaces;
using Web.Infrastrcture.Context;

namespace Web.Infrastrcture.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IGenericRepository<City> City  { get; private set; }

         public IGenericRepository<Degree> Degree  { get; private set; }

         public IGenericRepository<Country> Country  { get; private set; }

        public IGenericRepository<Employee> Employee { get; private set; }


        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Employee = new GenericRepository<Employee>(_context);
            City = new GenericRepository<City>(_context);
            Degree = new GenericRepository<Degree>(_context);
            Country = new GenericRepository<Country>(_context);
        }
        public void Complete()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Entities;

namespace Web.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<City> City { get; }
        IGenericRepository<Degree> Degree { get; }
        IGenericRepository<Country> Country { get; }
        IGenericRepository<Employee> Employee { get; }

        void Complete();
    }
}

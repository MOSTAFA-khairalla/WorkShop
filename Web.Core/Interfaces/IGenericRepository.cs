using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Core.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {

        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();


        Task<T> AddAsync(T entity);
        T Add(T entity);

    }
}

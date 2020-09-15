using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.Interface
{
   public interface IRepository<T> where T : class //for every table
    {
        Task<List<T>> GetAll();
        Task<T> GetById(string Id);
        Task<string> Update(T entity);
        Task<string> Create(T entity);
        Task<string> Delete(string Id);
    }
}

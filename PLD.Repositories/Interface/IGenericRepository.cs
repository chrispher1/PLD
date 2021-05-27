using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PLD.Repositories.Interface
{
    public interface IGenericRepository<T> where T: class
    {
        Task Delete(int id);
        Task Update(T entity, int id);
        Task Create(T entity);
        Task<T> GetRecordByID(Expression<Func<T,bool>> exp);      
    }
}
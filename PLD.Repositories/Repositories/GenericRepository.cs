using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PLD.DataAccess;
using PLD.Repositories.Interface;

namespace PLD.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T: class
    {
        protected readonly DMTPLDContext _context;

        public GenericRepository(DMTPLDContext context)
        {
            this._context = context;
        }
        public async Task Create(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public async Task Delete(int id)
        {
            var record = await _context.Set<T>().FindAsync(id);              
            _context.Set<T>().Remove(record);
        }

        public async Task Update(T entity,int id)
        {   
            var record = await _context.Set<T>().FindAsync(id);
            _context.Entry(record).CurrentValues.SetValues(entity);
        }
        public async Task<T> GetRecordByID(Expression<Func<T,bool>> exp)
        {            
            var record = await _context.Set<T>().Where(exp).FirstAsync();
            return record;
        }
    }
}
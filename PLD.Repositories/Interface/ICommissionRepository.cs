using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using PLD.Helper;

namespace PLD.Repositories.Interface
{
    public interface ICommissionRepository<T>: IGenericRepository<T> where T: class
    {
        Task<PagedList<T>> GetRecords(GridParams gridParams, CommissionSearchParams commissionErrorSearchParams);          
        Task MultiDelete(List<T> entity);
        Task MultiCreate(List<T> entity);
    }
}

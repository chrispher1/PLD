using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PLD.WebApi.Angular.Helper;

namespace PLD.WebApi.Angular.Repository
{
    public interface ICommissionRepository<T>
    {
        Task<PagedList<T>> GetRecords(GridParams gridParams, CommissionErrorSearchParams commissionErrorSearchParams);
        Task<T> GetRecordByID(int id);
        Task Delete(int id);
        Task MultiDelete(List<T> entity);
        Task Update(T entity);
        Task<T> Create(T entity);
    }
}

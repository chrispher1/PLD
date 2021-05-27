using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PLD.Repositories;
using PLD.Models;
using System;
using PLD.DTO;

namespace PLD.Repositories.Interface
{
    public interface IUnitOfWork<T>: IDisposable where T: DbContext
    {
        T Context {get; set;}
        ICommissionRepository<DmtCommErr> CommissionErrorRepository{ get; }
        ICommissionRepository<DmtComm> CommissionFinalRepository{ get; }
        ICommissionRepository<CommissionDTO> CommissionAllRepository{ get; }
        ICarrierRepository<T, CarrierDTO> CarrierRepository{ get; }
        IProductRepository<T, ProductDTO> ProductRepository{ get; }
        IActivityRepository<T, ActivityDTO> ActivityRepository{ get; }
        IStatusRepository<T, StatusDTO> StatusRepository{ get; }

         int SaveChanges();
         Task<int> SaveChangesAsync();
    }
}
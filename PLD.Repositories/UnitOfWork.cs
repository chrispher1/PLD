using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PLD.DataAccess;
using PLD.Repositories.Interface;
using PLD.Repositories;
using PLD.Models;
using System;
using PLD.DTO;

namespace PLD.Repositories
{
    public class UnitOfWork : IUnitOfWork<DMTPLDContext>
    {
         // Track whether Dispose has been called.
        private bool disposed = false;
        private readonly ICommissionRepository<DmtCommErr> _commissionErrorRepository;
        private readonly ICommissionRepository<DmtComm> _commissionFinalRepository;
        private readonly ICommissionRepository<CommissionDTO> _commissionAllRepository;

        private readonly ICarrierRepository<DMTPLDContext, CarrierDTO> _carrierRepository;
        private readonly IProductRepository<DMTPLDContext, ProductDTO> _productRepository;
        private readonly IActivityRepository<DMTPLDContext, ActivityDTO> _activityRepository;
        private readonly IStatusRepository<DMTPLDContext, StatusDTO> _statusRepository;

        public DMTPLDContext Context {get; set;}
        
        public ICommissionRepository<DmtCommErr> CommissionErrorRepository
        {
            get {
                return this._commissionErrorRepository;
            }
        }
        public ICommissionRepository<DmtComm> CommissionFinalRepository
        {
            get {
                return this._commissionFinalRepository;
            }
        }

        public ICommissionRepository<CommissionDTO> CommissionAllRepository
        {
            get {
                return this._commissionAllRepository;
            }
        }

       public ICarrierRepository<DMTPLDContext, CarrierDTO> CarrierRepository { 
           get {
                return this._carrierRepository;
            } 
        }
        public IProductRepository<DMTPLDContext, ProductDTO> ProductRepository { 
           get {
                return this._productRepository;
            } 
        }
        public IActivityRepository<DMTPLDContext, ActivityDTO> ActivityRepository { 
           get {
                return this._activityRepository;
            } 
        }
        public IStatusRepository<DMTPLDContext, StatusDTO> StatusRepository { 
           get {
                return this._statusRepository;
            } 
        }
        public UnitOfWork(DMTPLDContext context, 
        ICommissionRepository<DmtCommErr> commissionErrorRepository, 
        ICommissionRepository<DmtComm> commissionFinalRepository, 
        ICarrierRepository<DMTPLDContext, CarrierDTO> carrierRepository,
        IProductRepository<DMTPLDContext, ProductDTO> productRepository,
        IActivityRepository<DMTPLDContext, ActivityDTO> activityRepository,
        IStatusRepository<DMTPLDContext, StatusDTO> statusRepository,
        ICommissionRepository<CommissionDTO> commissionAllRepository
        )
        {   
            this.Context = context;
            this._commissionErrorRepository = commissionErrorRepository;
            this._commissionFinalRepository = commissionFinalRepository;
            this._carrierRepository = carrierRepository;
            this._productRepository = productRepository;
            this._activityRepository = activityRepository;
            this._statusRepository = statusRepository;
            this._commissionAllRepository = commissionAllRepository;
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }
        public int SaveChanges()
        {
           return Context.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
          return await Context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;
                if (disposing) {
                    Context.Dispose();
                }
                // Note disposing has been done.
                disposed = true;
        }

    }
}
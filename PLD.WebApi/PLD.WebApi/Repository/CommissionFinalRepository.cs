using System.Collections.Generic;
using System.Threading.Tasks;
using PLD.WebApi.Helper;
using PLD.WebApi.Models;
using PLD.WebApi.Repository;

namespace PLD.WebApi.Repository
{
    public class CommissionFinalRepository : ICommissionRepository<DmtComm>
    {
        private readonly DMTPLDContext _context;
        public CommissionFinalRepository(DMTPLDContext context)
        {
            _context = context;
        }

        public async Task<DmtComm> Create(DmtComm entity)
        {
            _context.DmtComm.Add(entity);            
            await _context.SaveChangesAsync();
            return entity;
        }

        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<DmtComm> GetRecordByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<PagedList<DmtComm>> GetRecords(GridParams gridParams, CommissionErrorSearchParams commissionErrorSearchParams)
        {
            throw new System.NotImplementedException();
        }

        public Task MultiDelete(List<DmtComm> entity)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(DmtComm entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
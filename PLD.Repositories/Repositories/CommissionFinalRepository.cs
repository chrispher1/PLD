using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PLD.Helper;
using PLD.Models;
using PLD.DataAccess;
using PLD.Repositories.Interface;
using PLD.Repositories;
using System.Linq.Expressions;
using System;

namespace PLD.Repositories
{
    public class CommissionFinalRepository : GenericRepository<DmtComm>, ICommissionRepository<DmtComm>
    {
        public CommissionFinalRepository(DMTPLDContext context): base(context) {}        
        public async Task<PagedList<DmtComm>> GetRecords(GridParams gridParams, CommissionSearchParams commissionFinalSearchParams)
        {            
            var list =  _context.DmtComm.Include( c => c.Carrier)
                .Include(p=> p.Product)
                .Include( a => a.Activity)
                .Include( s => s.StatusCode).AsQueryable();

            if (commissionFinalSearchParams.CarrId != null)
            list = list.Where(l => l.CarrId == commissionFinalSearchParams.CarrId && l.CarrId == commissionFinalSearchParams.CarrId);

            if (commissionFinalSearchParams.ProdId != null)
            list = list.Where(l => l.ProdId == commissionFinalSearchParams.ProdId);

            if (commissionFinalSearchParams.PolNum != null)
            list = list.Where( l => l.PolNum.Contains(commissionFinalSearchParams.PolNum));

            if (commissionFinalSearchParams.YrNumMin != null && commissionFinalSearchParams.YrNumMax != null)
            list = list.Where( l => l.YrNum >= commissionFinalSearchParams.YrNumMin && l.YrNum <= commissionFinalSearchParams.YrNumMax);

            if (commissionFinalSearchParams.TmCd != null)
            list = list.Where(l => l.TmCd == commissionFinalSearchParams.TmCd);

            if (commissionFinalSearchParams.ActCd != null)
            list = list.Where(l => l.ActCd == commissionFinalSearchParams.ActCd);

            if (commissionFinalSearchParams.GrsPremAmtMin != null && commissionFinalSearchParams.GrsPremAmtMax != null)
            list = list.Where( l => l.GrsPremAmt >= commissionFinalSearchParams.GrsPremAmtMin && l.GrsPremAmt <= commissionFinalSearchParams.GrsPremAmtMax);

            if (commissionFinalSearchParams.CommPremAmtMin != null && commissionFinalSearchParams.CommPremAmtMax != null)
            list = list.Where( l => l.CommPremAmt >= commissionFinalSearchParams.CommPremAmtMin && l.CommPremAmt <= commissionFinalSearchParams.CommPremAmtMax);

            if (commissionFinalSearchParams.CommRateMin != null && commissionFinalSearchParams.CommRateMax != null)
            list = list.Where( l => l.CommRt >= commissionFinalSearchParams.CommRateMin && l.CommRt <= commissionFinalSearchParams.CommRateMax);

            if (commissionFinalSearchParams.CommAmtMin != null && commissionFinalSearchParams.CommAmtMax != null)
            list = list.Where( l => l.CommAmt >= commissionFinalSearchParams.CommAmtMin && l.CommAmt <= commissionFinalSearchParams.CommAmtMax);

            if (commissionFinalSearchParams.StatCd != null)
            list = list.Where(l => l.StatCd == commissionFinalSearchParams.StatCd);            

            return await PagedList<DmtComm>.CreateAsync(list,gridParams.PageNumber,gridParams.PageSize );
       
        }

        public async Task MultiDelete(List<DmtComm> entity)
        {
            List<DmtComm> objDmtCommList = await _context.DmtComm
                        .Where( r => entity.Contains(r)).ToListAsync();
            
             _context.DmtComm.RemoveRange(objDmtCommList);    
           
        }

        public Task MultiCreate(List<DmtComm> entity)
        {
            throw new NotImplementedException();
        }
    }
}
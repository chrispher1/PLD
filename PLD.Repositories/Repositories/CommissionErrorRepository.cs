using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PLD.Models;
using Microsoft.EntityFrameworkCore;
using PLD.Helper;
using PLD.DataAccess;
using PLD.Repositories.Interface;
using PLD.Repositories;
using System.Linq.Expressions;

namespace PLD.Repositories
{
    public class CommissionErrorRepository: GenericRepository<DmtCommErr>, ICommissionRepository<DmtCommErr>
    {
        public CommissionErrorRepository(DMTPLDContext context):base(context) {}
        public async Task<PagedList<DmtCommErr>> GetRecords(GridParams gridParams, CommissionSearchParams commissionErrorSearchParams)
        {
            var list =  _context.DmtCommErr.Include( c => c.Carrier)
                .Include(p=> p.Product)
                .Include( a => a.Activity)
                .Include( s => s.StatusCode).AsQueryable();

            if (commissionErrorSearchParams.CarrId != null)
            list = list.Where(l => l.CarrId == commissionErrorSearchParams.CarrId && l.CarrId == commissionErrorSearchParams.CarrId);

            if (commissionErrorSearchParams.ProdId != null)
            list = list.Where(l => l.ProdId == commissionErrorSearchParams.ProdId);

            if (commissionErrorSearchParams.PolNum != null)
            list = list.Where( l => l.PolNum.Contains(commissionErrorSearchParams.PolNum));

            if (commissionErrorSearchParams.YrNumMin != null && commissionErrorSearchParams.YrNumMax != null)
            list = list.Where( l => l.YrNum >= commissionErrorSearchParams.YrNumMin && l.YrNum <= commissionErrorSearchParams.YrNumMax);

            if (commissionErrorSearchParams.TmCd != null)
            list = list.Where(l => l.TmCd == commissionErrorSearchParams.TmCd);

            if (commissionErrorSearchParams.ActCd != null)
            list = list.Where(l => l.ActCd == commissionErrorSearchParams.ActCd);

            if (commissionErrorSearchParams.GrsPremAmtMin != null && commissionErrorSearchParams.GrsPremAmtMax != null)
            list = list.Where( l => l.GrsPremAmt >= commissionErrorSearchParams.GrsPremAmtMin && l.GrsPremAmt <= commissionErrorSearchParams.GrsPremAmtMax);

            if (commissionErrorSearchParams.CommPremAmtMin != null && commissionErrorSearchParams.CommPremAmtMax != null)
            list = list.Where( l => l.CommPremAmt >= commissionErrorSearchParams.CommPremAmtMin && l.CommPremAmt <= commissionErrorSearchParams.CommPremAmtMax);

            if (commissionErrorSearchParams.CommRateMin != null && commissionErrorSearchParams.CommRateMax != null)
            list = list.Where( l => l.CommRt >= commissionErrorSearchParams.CommRateMin && l.CommRt <= commissionErrorSearchParams.CommRateMax);

            if (commissionErrorSearchParams.CommAmtMin != null && commissionErrorSearchParams.CommAmtMax != null)
            list = list.Where( l => l.CommAmt >= commissionErrorSearchParams.CommAmtMin && l.CommAmt <= commissionErrorSearchParams.CommAmtMax);

            if (commissionErrorSearchParams.StatCd != null)
            list = list.Where(l => l.StatCd == commissionErrorSearchParams.StatCd);

            return await PagedList<DmtCommErr>.CreateAsync(list,gridParams.PageNumber,gridParams.PageSize );
        }
        
        public async Task MultiDelete(List<DmtCommErr> commErrList)
        {
           List<DmtCommErr> objDmtCommErrList = await _context.DmtCommErr
                        .Include(c => c.DmtCommErrAgnt)
                        .Include(c => c.DmtCommErrClnt)
                        .Where( r => commErrList.Contains(r)).ToListAsync();
            
             _context.DmtCommErr.RemoveRange(objDmtCommErrList);           
        }

        public async Task Update(DmtCommErr commErr)
        {
            var record = await _context.DmtCommErr.FindAsync(commErr.CommId);
            _context.Entry(record).CurrentValues.SetValues(commErr);
        }

        public async Task MultiCreate(List<DmtCommErr> entity)
        {
            await _context.DmtCommErr.AddRangeAsync(entity); 
        }
    }
}
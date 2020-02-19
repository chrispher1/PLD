using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PLD.WebApi.Angular.Models;
using Microsoft.EntityFrameworkCore;
using PLD.WebApi.Angular.Helper;

namespace PLD.WebApi.Angular.Repository
{
    public class CommissionRepository: ICommissionRepository<DmtCommErr>
    {
        private readonly DMTPLDContext _context;
        public CommissionRepository(DMTPLDContext context)
        {
            _context = context;
        }

        public async Task<PagedList<DmtCommErr>> GetRecords(GridParams gridParams, CommissionErrorSearchParams commissionErrorSearchParams)
        {
            var list =  _context.DmtCommErr.AsQueryable();

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
            
            var list2 = from commissionError in list
                        join carrier in _context.DmtCarr 
                        on commissionError.CarrId equals carrier.CarrId into comb1
                        from temp in comb1.DefaultIfEmpty()
                        join product in _context.DmtProd
                        on commissionError.ProdId equals product.ProdId into comb2
                        from temp2 in comb2.DefaultIfEmpty()
                        join activity in _context.DmtActCd
                        on commissionError.ActCd  equals activity.ActCd into comb3
                        from temp3 in comb3.DefaultIfEmpty()
                        join status in _context.DmtStatCd
                        on commissionError.StatCd equals status.StatCd into comb4
                        from temp4 in comb4.DefaultIfEmpty()                        
                        select new DmtCommErr{ 
                                                CommId = commissionError.CommId, 
                                                CarrId = commissionError.CarrId,
                                                ProdId = commissionError.ProdId,        
                                                PolNum = commissionError.PolNum,
                                                YrNum = commissionError.YrNum,
                                                TmCd = commissionError.TmCd,
                                                ActCd = commissionError.ActCd,
                                                GrsPremAmt = commissionError.GrsPremAmt,
                                                CommPremAmt = commissionError.CommPremAmt,
                                                CommRt = commissionError.CommRt,
                                                CommAmt = commissionError.CommAmt,          
                                                StatCd = commissionError.StatCd,
                                                StatDt = commissionError.StatDt,
                                                CrtDt = commissionError.CrtDt,
                                                CrtById = commissionError.CrtById,
                                                ModDt = commissionError.ModDt,
                                                ModById = commissionError.ModById,                
                                                Carr = new DmtCarr { Name = temp.Name,
                                                                    CarrId = temp.CarrId,
                                                                    CarrCd = temp.CarrCd 
                                                                },
                                                Prod = new DmtProd { Name = temp2.Name,
                                                                    ProdId = temp2.ProdId,        
                                                                    ProdCd = temp2.ProdCd
                                                                },
                                                ActCdNavigation = new DmtActCd { ActCd = temp3.ActCd,
                                                                    DescTxt = temp3.DescTxt
                                                                },
                                                StatCdNavigation = new DmtStatCd { 
                                                    StatCd = temp4.StatCd,
                                                    DescTxt = temp4.DescTxt                                                   
                                                                }
                                                }; 
            
            return await PagedList<DmtCommErr>.CreateAsync(list2,gridParams.PageNumber,gridParams.PageSize );

            //return await PagedList<DmtCommErr>.CreateAsync(list,gridParams.PageNumber,gridParams.PageSize );
        }

        public async Task<DmtCommErr> GetRecordByID(int id)
        {
            var record = await _context.DmtCommErr.Where(r => r.CommId == id).FirstAsync();
            return record;
        }

        public async Task Delete(int id)
        {
           var record = await _context.DmtCommErr.Where(r => r.CommId == id ).FirstOrDefaultAsync();
            _context.DmtCommErr.Remove(record);
            await _context.SaveChangesAsync();
        }

        public async Task MultiDelete(List<DmtCommErr> commErrList)
        {
            _context.DmtCommErr.RemoveRange(commErrList);
            await _context.SaveChangesAsync();
        }

        public async Task Update(DmtCommErr commErr)
        {                        
            _context.Update(commErr);
            await _context.SaveChangesAsync();
        }

        public async Task<DmtCommErr> Create(DmtCommErr entity)
        {
            _context.DmtCommErr.Add(entity);            
            await _context.SaveChangesAsync();
            return entity;
        }

    }
}
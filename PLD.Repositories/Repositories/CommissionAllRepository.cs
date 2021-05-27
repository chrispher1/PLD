using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PLD.DataAccess;
using PLD.DTO;
using PLD.Helper;
using PLD.Repositories.Interface;
using AutoMapper;
using PLD.Models;

namespace PLD.Repositories
{
    public class CommissionAllRepository : ICommissionRepository<CommissionDTO>
    {
        protected readonly DMTPLDContext _context;
        protected readonly IMapper _mapper;

        public CommissionAllRepository(DMTPLDContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public Task Create(CommissionDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CommissionDTO> GetRecordByID(Expression<Func<CommissionDTO, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public async Task<PagedList<CommissionDTO>> GetRecords(GridParams gridParams, CommissionSearchParams commissionSearchParams)
        {
            /*var listCommissionError =  _context.DmtCommErr.Include( c => c.Carrier)
                .Include(p=> p.Product)
                .Include( a => a.Activity)
                .Include( s => s.StatusCode).AsQueryable();
                */
            
            var listCommissionError =  _context.DmtCommErr
                .Include( c => c.Carrier)
                .Include( p=> p.Product)
                .Include( a => a.Activity)
                .Include( s => s.StatusCode) 
                .Select( error => new DmtCommErr() {
                    CommId = error.CommId,
                    CarrId = error.CarrId,
                    ProdId = error.ProdId,
                    PolNum = error.PolNum,
                    YrNum = error.YrNum,
                    TmCd = error.TmCd,
                    ActCd = error.ActCd,
                    StatDt = error.StatDt,
                    CrtDt = error.CrtDt,
                    ModDt = error.ModDt,
                    ModById = error.ModById,
                    Carrier = error.Carrier,
                    Product = error.Product,
                    Activity = error.Activity,
                    StatusCode = error.StatusCode,
                    GrsPremAmt = error.GrsPremAmt,
                    CommPremAmt = error.CommPremAmt,
                    CommRt = error.CommRt,
                    CommAmt = error.CommAmt,
                    StatCd = error.StatCd 
                    }            
                    )
                .Union( 
                        _context.DmtComm
                                .Include( c => c.Carrier)
                                .Include( p=> p.Product)
                                .Include( a => a.Activity)
                                .Include( s => s.StatusCode) 
                .Select( final => new DmtCommErr() {
                        CommId = final.CommId,
                        CarrId = final.CarrId,
                        ProdId = final.ProdId,
                        PolNum = final.PolNum,
                        YrNum = final.YrNum,
                        TmCd = final.TmCd,
                        ActCd = final.ActCd,
                        StatDt = final.StatDt,
                        CrtDt = final.CrtDt,
                        ModDt = final.ModDt,
                        ModById = final.ModById,
                        Carrier = final.Carrier,
                        Product = final.Product,
                        Activity = final.Activity,
                        StatusCode = final.StatusCode,
                        GrsPremAmt = final.GrsPremAmt,
                        CommPremAmt = final.CommPremAmt,
                        CommRt = final.CommRt,
                        CommAmt = final.CommAmt,
                        StatCd = final.StatCd 
                        }            
                )).AsQueryable();

            if (commissionSearchParams.CarrId != null)
            listCommissionError = listCommissionError.Where(l => l.CarrId == commissionSearchParams.CarrId && l.CarrId == commissionSearchParams.CarrId);

            if (commissionSearchParams.ProdId != null)
            listCommissionError = listCommissionError.Where(l => l.ProdId == commissionSearchParams.ProdId);

            if (commissionSearchParams.PolNum != null)
            listCommissionError = listCommissionError.Where( l => l.PolNum.Contains(commissionSearchParams.PolNum));

            if (commissionSearchParams.YrNumMin != null && commissionSearchParams.YrNumMax != null)
            listCommissionError = listCommissionError.Where( l => l.YrNum >= commissionSearchParams.YrNumMin && l.YrNum <= commissionSearchParams.YrNumMax);

            if (commissionSearchParams.TmCd != null)
            listCommissionError = listCommissionError.Where(l => l.TmCd == commissionSearchParams.TmCd);

            if (commissionSearchParams.ActCd != null)
            listCommissionError = listCommissionError.Where(l => l.ActCd == commissionSearchParams.ActCd);

            if (commissionSearchParams.GrsPremAmtMin != null && commissionSearchParams.GrsPremAmtMax != null)
            listCommissionError = listCommissionError.Where( l => l.GrsPremAmt >= commissionSearchParams.GrsPremAmtMin && l.GrsPremAmt <= commissionSearchParams.GrsPremAmtMax);

            if (commissionSearchParams.CommPremAmtMin != null && commissionSearchParams.CommPremAmtMax != null)
            listCommissionError = listCommissionError.Where( l => l.CommPremAmt >= commissionSearchParams.CommPremAmtMin && l.CommPremAmt <= commissionSearchParams.CommPremAmtMax);

            if (commissionSearchParams.CommRateMin != null && commissionSearchParams.CommRateMax != null)
            listCommissionError = listCommissionError.Where( l => l.CommRt >= commissionSearchParams.CommRateMin && l.CommRt <= commissionSearchParams.CommRateMax);

            if (commissionSearchParams.CommAmtMin != null && commissionSearchParams.CommAmtMax != null)
            listCommissionError = listCommissionError.Where( l => l.CommAmt >= commissionSearchParams.CommAmtMin && l.CommAmt <= commissionSearchParams.CommAmtMax);

            if (commissionSearchParams.StatCd != null)
            listCommissionError = listCommissionError.Where(l => l.StatCd == commissionSearchParams.StatCd);

            var listCommissionCombine = this._mapper.ProjectTo<CommissionDTO>(listCommissionError);
            
            return await PagedList<CommissionDTO>.CreateAsync(listCommissionCombine, gridParams.PageNumber,gridParams.PageSize );
        }

        public Task MultiCreate(List<CommissionDTO> entity)
        {
            throw new NotImplementedException();
        }

        public Task MultiDelete(List<CommissionDTO> entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(CommissionDTO entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
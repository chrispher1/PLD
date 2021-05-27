using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PLD.Repositories;
using PLD.Models;
using AutoMapper;
using PLD.DTO;
using PLD.Helper;
using Microsoft.AspNetCore.Authorization;
using PLD.Repositories.Interface;
using PLD.DataAccess;

namespace PLD.WebApi.Controllers
{   
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CommissionController : ControllerBase
    {        
        private readonly IMapper _mapper;
        private readonly IUnitOfWork<DMTPLDContext> _unitOfWork;

        const string ErrorStatusCode = "E";

        public CommissionController(            
            IMapper mapper,
            IUnitOfWork<DMTPLDContext> unitOfWork)
        {   
            _mapper = mapper;
            this._unitOfWork = unitOfWork;
        }

        // GET api/values
        [HttpGet("error")]
        public async Task<IActionResult> GetErrorAll([FromQuery]GridParams gridParams, [FromQuery] CommissionSearchParams commissionErrorSearchParams)
        {
            var list = await this._unitOfWork.CommissionErrorRepository.GetRecords(gridParams, commissionErrorSearchParams);
            var listToReturn = _mapper.Map<IEnumerable<CommissionErrorDTO>>(list);
            Response.AddPagination(list.CurrentPage,list.PageSize,list.TotalCount,list.TotalPages);
            return Ok(listToReturn);            
        }

        [HttpGet("final")]        
        public async Task<IActionResult> GetFinalAll([FromQuery]GridParams gridParams, [FromQuery] CommissionSearchParams commissionFinalSearchParams)
        {
            var list = await this._unitOfWork.CommissionFinalRepository.GetRecords(gridParams, commissionFinalSearchParams);
            var listToReturn = _mapper.Map<IEnumerable<CommissionFinalDTO>>(list);
            Response.AddPagination(list.CurrentPage,list.PageSize,list.TotalCount,list.TotalPages);
            return Ok(listToReturn);            
        }

        [HttpGet("all")]        
        public async Task<IActionResult> GetAll([FromQuery]GridParams gridParams, [FromQuery] CommissionSearchParams commissionSearchParams)
        {
            var list = await this._unitOfWork.CommissionAllRepository.GetRecords(gridParams, commissionSearchParams);
            Response.AddPagination(list.CurrentPage,list.PageSize,list.TotalCount,list.TotalPages);
            return Ok(list);          
        }

        [HttpGet("error/getrecord/{id}")]
        public async Task<IActionResult> GetByID(int id)
        {   
            var record = await this._unitOfWork.CommissionErrorRepository.GetRecordByID( x => x.CommId == id);
            var recordToReturn = _mapper.Map<CommissionErrorDTO>(record);
            return Ok(recordToReturn);
        }
        
        [HttpPost("error/addrecord")]
        public async Task<IActionResult> AddRecord(CommissionErrorDTO commissionError)
        {
            var destinationRecord = new DmtCommErr();
            _mapper.Map(commissionError, destinationRecord);
            await this._unitOfWork.CommissionErrorRepository.Create(destinationRecord);
            await this._unitOfWork.SaveChangesAsync();
            return Ok();
        }


        // PUT api/values/update
        [HttpPut("error/updaterecord")]
        public async Task<IActionResult> SaveRecord(CommissionErrorDTO commissionError)
        {            
            var destinationRecord = await this._unitOfWork.CommissionErrorRepository.GetRecordByID(x => x.CommId == commissionError.CommId);
            _mapper.Map(commissionError, destinationRecord);
            await this._unitOfWork.CommissionErrorRepository.Update(destinationRecord, commissionError.CommId);   
            await this._unitOfWork.SaveChangesAsync(); 
            return Ok();
        }

        [HttpPost("error/processrecord")]
        public async Task<IActionResult> ProcessRecord(CommissionErrorDTO commissionError)
        {
            var destinationRecord = await this._unitOfWork.CommissionErrorRepository.GetRecordByID(x => x.CommId == commissionError.CommId);
            _mapper.Map(commissionError, destinationRecord);
            await this._unitOfWork.CommissionErrorRepository.Update(destinationRecord, commissionError.CommId);    
            // Make a copy on the final table
            var finalCommissionDestinationRecord = _mapper.Map<DmtComm>(destinationRecord);
            await this._unitOfWork.CommissionFinalRepository.Create(finalCommissionDestinationRecord);

            // Delete the record in Commission Error table
            await this._unitOfWork.CommissionErrorRepository.Delete(commissionError.CommId);            
            await this._unitOfWork.SaveChangesAsync(); 

            return Ok();
        }

        [HttpPost("final/revalidaterecord")]
        public async Task<IActionResult> RevalidateRecord(CommissionFinalDTO commission)
        {
            var destinationRecord = await this._unitOfWork.CommissionFinalRepository.GetRecordByID(x => x.CommId == commission.CommId);
            _mapper.Map(commission, destinationRecord);
            destinationRecord.StatCd = ErrorStatusCode;
            await this._unitOfWork.CommissionFinalRepository.Update(destinationRecord, commission.CommId);    
            // Make a copy on the error table
            var errorNewCommissionDestinationRecord = _mapper.Map<DmtCommErr>(destinationRecord);
                        
            errorNewCommissionDestinationRecord.CommId = 0;
            await this._unitOfWork.CommissionErrorRepository.Create(errorNewCommissionDestinationRecord);

            // Delete the record in Commission Final table
            await this._unitOfWork.CommissionFinalRepository.Delete(commission.CommId);            
            await this._unitOfWork.SaveChangesAsync(); 

            return Ok();
        }

        [HttpPost("final/revalidatemultirecord")]
        public async Task<IActionResult> MultiRevalidate(int[] commissionIdList)
        {   
            List<DmtComm> commissionList = new List<DmtComm>();
            List<DmtCommErr> errorCommissionList = new List<DmtCommErr>();

            foreach( int commId in commissionIdList) {
                DmtComm record = await this._unitOfWork.CommissionFinalRepository.GetRecordByID(x => x.CommId == commId);
                commissionList.Add(record);
            }

            foreach( DmtComm objCommission in commissionList) {
                // Make a copy on the error table
                var errorNewCommissionDestinationRecord = _mapper.Map<DmtCommErr>(objCommission);
                errorNewCommissionDestinationRecord.CommId = 0;
                errorNewCommissionDestinationRecord.StatCd = ErrorStatusCode;

                errorCommissionList.Add(errorNewCommissionDestinationRecord);
            }
            
                await this._unitOfWork.CommissionErrorRepository.MultiCreate(errorCommissionList);
                await this._unitOfWork.CommissionFinalRepository.MultiDelete(commissionList);
                await _unitOfWork.SaveChangesAsync();
            return Ok();            
        }

        // DELETE api/values/5
        [HttpDelete("error/deleterecord/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await this._unitOfWork.CommissionErrorRepository.Delete(id);
            await this._unitOfWork.SaveChangesAsync(); 
            return Ok();
        }        
        
        [HttpPut("error/deletemultirecord")]
        public async Task<IActionResult> MultiDelete(int[] commissionIdList)
        {   
            List<DmtCommErr> commissionErrorList = new List<DmtCommErr>();
            foreach( int commId in commissionIdList) {
                DmtCommErr record = await this._unitOfWork.CommissionErrorRepository.GetRecordByID(x => x.CommId == commId);
                commissionErrorList.Add(record);
            }
            
                await this._unitOfWork.CommissionErrorRepository.MultiDelete(commissionErrorList);
                await _unitOfWork.SaveChangesAsync();
            return Ok();            
        }

        [HttpGet("final/getrecord/{id}")]
        public async Task<IActionResult> GetFinalByID(int id)
        {   
            // to do, to change the implementation
            var record = await this._unitOfWork.CommissionFinalRepository.GetRecordByID(x => x.CommId == id);
            var recordToReturn = _mapper.Map<CommissionFinalDTO>(record);
            return Ok(recordToReturn);
        }

        // PUT api/values/update
        [HttpPut("final/updaterecord")]
        public async Task<IActionResult> SaveFinalRecord(CommissionFinalDTO commission)
        {            
            var destinationRecord = await this._unitOfWork.CommissionFinalRepository.GetRecordByID(x => x.CommId == commission.CommId);
            _mapper.Map(commission, destinationRecord);
            await this._unitOfWork.CommissionFinalRepository.Update(destinationRecord, commission.CommId);   
            await this._unitOfWork.SaveChangesAsync(); 
            return Ok();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PLD.WebApi.Repository;
using PLD.WebApi.Models;
using AutoMapper;
using PLD.WebApi.DTO;
using PLD.WebApi.Helper;
using Microsoft.AspNetCore.Authorization;

namespace PLD.WebApi.Controllers
{   
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CommissionErrorController : ControllerBase
    {
        private readonly ICommissionRepository<DmtCommErr> _repository;
        private readonly ICommissionRepository<DmtComm> _finalRepository;
        private readonly IMapper _mapper;
        public CommissionErrorController(ICommissionRepository<DmtCommErr> repository, 
            ICommissionRepository<DmtComm> finalRepository,
            IMapper mapper)
        {
            _repository = repository;
            _finalRepository = finalRepository;
            _mapper = mapper;
        }

        
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery]GridParams gridParams, [FromQuery] CommissionErrorSearchParams commissionErrorSearchParams)
        {
            var list = await _repository.GetRecords(gridParams, commissionErrorSearchParams);
            var listToReturn = _mapper.Map<IEnumerable<CommissionErrorDTO>>(list);
            Response.AddPagination(list.CurrentPage,list.PageSize,list.TotalCount,list.TotalPages);
            return Ok(listToReturn);            
        }

        [HttpGet("getrecord/{id}")]
        public async Task<IActionResult> GetByID(int id)
        {   
            var record = await _repository.GetRecordByID(id);
            var recordToReturn = _mapper.Map<CommissionErrorDTO>(record);
            return Ok(recordToReturn);
        }
        
        [HttpPost("addrecord")]
        public async Task<IActionResult> AddRecord(CommissionErrorDTO commissionError)
        {
            var destinationRecord = new DmtCommErr();
            _mapper.Map(commissionError, destinationRecord);
            var record = _mapper.Map<CommissionErrorDTO> (await _repository.Create(destinationRecord));
            return Ok();
        }


        // PUT api/values/update
        [HttpPut("updaterecord")]
        public async Task<IActionResult> SaveRecord(CommissionErrorDTO commissionError)
        {            
            var destinationRecord = await _repository.GetRecordByID(commissionError.CommId);
            _mapper.Map(commissionError, destinationRecord);

            // Check status if processed
            // if processed then save to final table and delete in error table
            // else update the error table

            

            await _repository.Update(destinationRecord);    

            var finalRecord = _mapper.Map<DmtComm>(destinationRecord);
            await _finalRepository.Create(finalRecord);

            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("deleterecord/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.Delete(id);
            return Ok();
        }        
        
        [HttpPost("deletemultirecord")]
        public async Task<IActionResult> MultiDelete(CommissionErrorDTORootObject rootObject)
        {   
            var destinationRecordList = _mapper.Map<List<CommissionErrorDTO>,List<DmtCommErr>>(rootObject.CommissionErrorList);
            await _repository.MultiDelete(destinationRecordList);            
            return Ok();
        }
    }
}

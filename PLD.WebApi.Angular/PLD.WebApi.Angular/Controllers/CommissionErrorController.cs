using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PLD.WebApi.Angular.Repository;
using PLD.WebApi.Angular.Models;
using AutoMapper;
using PLD.WebApi.Angular.DTO;
using PLD.WebApi.Angular.Helper;
using Microsoft.AspNetCore.Authorization;

namespace PLD.WebApi.Angular.Controllers
{   
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CommissionErrorController : ControllerBase
    {
        private readonly ICommissionRepository<DmtCommErr> _repository;
        private readonly IMapper _mapper;
        public CommissionErrorController(ICommissionRepository<DmtCommErr> repository, IMapper mapper)
        {
            _repository = repository;
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
        public async Task<ActionResult<CommissionErrorDTO>> GetByID(int id)
        {   
            var record = await _repository.GetRecordByID(id);
            var recordToReturn = _mapper.Map<CommissionErrorDTO>(record);
            return Ok(recordToReturn);
        }

        
        [HttpPost("addrecord")]
        public async Task<ActionResult<CommissionErrorDTO>> AddRecord(CommissionErrorDTO commissionError)
        {
            var destinationRecord = new DmtCommErr();
            _mapper.Map(commissionError, destinationRecord);
            var record = _mapper.Map<CommissionErrorDTO> (await _repository.Create(destinationRecord));
            return Ok(record);
        }


        // PUT api/values/update
        [HttpPut("updaterecord")]
        public async Task<ActionResult> SaveRecord(CommissionErrorDTO commissionError)
        {            
            var destinationRecord = await _repository.GetRecordByID(commissionError.CommId);
            _mapper.Map(commissionError, destinationRecord);
            await _repository.Update(destinationRecord);    
            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("deleterecord/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _repository.Delete(id);
            return Ok();
        }
        
        [HttpDelete("deletemultirecord")]
        public async Task<ActionResult> MultiDelete(List<CommissionErrorDTO> commissionErrorList)
        {            
            var destinationRecordList = _mapper.Map<List<CommissionErrorDTO>,List<DmtCommErr>>(commissionErrorList);
            await _repository.MultiDelete(destinationRecordList);            
            return Ok();
        }
    }
}

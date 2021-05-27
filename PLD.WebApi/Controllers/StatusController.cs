using Microsoft.AspNetCore.Mvc;
using PLD.Repositories;
using AutoMapper;
using PLD.DTO;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using PLD.Repositories.Interface;
using PLD.DataAccess;

namespace PLD.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StatusController : ControllerBase
    {
        private readonly IUnitOfWork<DMTPLDContext> _unitOfWork;
        public StatusController(
            IUnitOfWork<DMTPLDContext> unitOfWork)
        {
           this._unitOfWork = unitOfWork;   
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var listToReturn = await _unitOfWork.StatusRepository.GetRecords();            
            return Ok(listToReturn);
        }

        [HttpGet("forCommissionForm/{filter}")]
        public async Task<IActionResult> GetStatus(string filter)
        {   
            var listToReturn = await _unitOfWork.StatusRepository.GetRecords(filter);            
            return Ok(listToReturn);
        }
    }
}
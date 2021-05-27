using Microsoft.AspNetCore.Mvc; 
using PLD.Repositories;
using AutoMapper;
using PLD.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using PLD.Repositories.Interface;
using PLD.DataAccess;

namespace PLD.WebApi.Controllers
{
    [Route("api/[controller]")]     
    [ApiController]
    [Authorize]
    public class CarrierController : ControllerBase
    {
        private readonly IUnitOfWork<DMTPLDContext> _unitOfWork;        
        public CarrierController(
            IUnitOfWork<DMTPLDContext> unitOfWork)
        {
            this._unitOfWork = unitOfWork;            
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var listToReturn = await _unitOfWork.CarrierRepository.GetRecords();            
            return Ok(listToReturn);
        }
    }
}
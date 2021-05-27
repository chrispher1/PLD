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
    public class ProductController : ControllerBase
    {
        private readonly IUnitOfWork<DMTPLDContext> _unitOfWork;        
        public ProductController(
            IUnitOfWork<DMTPLDContext> unitOfWork)
        {
            this._unitOfWork = unitOfWork;            
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var listToReturn = await this._unitOfWork.ProductRepository.GetRecords();
            return Ok(listToReturn);
        }
    }
}
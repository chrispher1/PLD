using Microsoft.AspNetCore.Mvc; 
using PLD.WebApi.Repository;
using AutoMapper;
using PLD.WebApi.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace PLD.WebApi.Controllers
{
    [Route("api/[controller]")]     
    [ApiController]
    [Authorize]
    public class CarrierController : ControllerBase
    {
        private readonly CarrierRepository _repository;
        private readonly IMapper _mapper;
        public CarrierController(CarrierRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var list = await _repository.GetRecords();
            var listToReturn = _mapper.Map<IEnumerable<CarrierDTO>>(list);

            return Ok(listToReturn);
        }
    }
}
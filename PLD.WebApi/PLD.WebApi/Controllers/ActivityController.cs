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
    public class ActivityController : ControllerBase
    {
        private readonly ActivityRepository _repository;
        private readonly IMapper _mapper;
        public ActivityController(ActivityRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var listToReturn = await _repository.GetRecords();
            return Ok(listToReturn);
        }
    }
}
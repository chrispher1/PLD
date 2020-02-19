using Microsoft.AspNetCore.Mvc; 
using PLD.WebApi.Angular.Repository;
using AutoMapper;
using PLD.WebApi.Angular.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace PLD.WebApi.Angular.Controllers
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
        public async Task<ActionResult> GetAll()
        {
            var list = await _repository.GetRecords();
            var listToReturn = _mapper.Map<IEnumerable<ActivityDTO>>(list);

            return Ok(listToReturn);
        }
    }
}
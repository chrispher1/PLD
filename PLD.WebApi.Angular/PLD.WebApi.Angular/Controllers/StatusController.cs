using Microsoft.AspNetCore.Mvc;
using PLD.WebApi.Angular.Repository;
using AutoMapper;
using PLD.WebApi.Angular.DTO;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace PLD.WebApi.Angular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StatusController : ControllerBase
    {
        private readonly StatusRepository _repository;
        private readonly IMapper _mapper;
        public StatusController(StatusRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var list = await _repository.GetRecords();
            var listToReturn = _mapper.Map<IEnumerable<StatusDTO>>(list);

            return Ok(listToReturn);
        }
    }
}
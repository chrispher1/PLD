using Microsoft.AspNetCore.Mvc;
using PLD.WebApi.Repository;
using AutoMapper;
using PLD.WebApi.DTO;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace PLD.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductController : ControllerBase
    {
        private readonly ProductRepository _repository;

        private readonly IMapper _mapper;
        public ProductController(ProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var list = await _repository.GetRecords();
            var listToReturn = _mapper.Map<IEnumerable<ProductDTO>>(list);

            return Ok(listToReturn);
        }
    }
}
using PLD.WebApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PLD.WebApi.DTO;

namespace PLD.WebApi.Repository
{
    public class ProductRepository
    {
        private readonly DMTPLDContext _context;
        public ProductRepository(DMTPLDContext context)
        {    
            _context = context;
        }

        public async Task<List<ProductDTO>> GetRecords()
        {
            var list = await _context.DmtProd.Select( o => new ProductDTO
            {   ProdId = o.ProdId,
                ProdCd = o.ProdCd,
                Name = o.Name
            }
            ).ToListAsync();            

            return list;
        }
    }
}
using PLD.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PLD.DTO;
using PLD.DataAccess;
using PLD.Repositories.Interface;

namespace PLD.Repositories
{
    public class ProductRepository: IProductRepository<DMTPLDContext,ProductDTO>
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
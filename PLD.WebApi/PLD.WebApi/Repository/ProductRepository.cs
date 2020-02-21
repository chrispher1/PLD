using PLD.WebApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace PLD.WebApi.Repository
{
    public class ProductRepository
    {
        private readonly DMTPLDContext _context;
        public ProductRepository(DMTPLDContext context)
        {    
            _context = context;
        }

        public async Task<List<DmtProd>> GetRecords()
        {
            var list = await _context.DmtProd.ToListAsync();            
            return list;
        }
    }
}
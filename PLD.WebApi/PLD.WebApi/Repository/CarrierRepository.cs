using PLD.WebApi.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PLD.WebApi.Repository
{
    public class CarrierRepository
    {
        private readonly DMTPLDContext _context;
        public CarrierRepository(DMTPLDContext context)
        {
            _context = context;
        }
        public async Task<List<DmtCarr>> GetRecords()
        {
            var list = await _context.DmtCarr.ToListAsync();
            return list;
        }

    }
}